// SolarModel.cs: a C# port of the PrayTimes.js astronomical algorithm.
// Copyright (c) 2007-2011 PrayTimes.org; Swift and C# ports (c) 2026 Mumin Muhammedoglu.
// This file is licensed under the GNU Lesser General Public License v3.0
// (https://www.gnu.org/licenses/lgpl-3.0.html), unlike the rest of Salah Bar.
// See THIRD_PARTY_NOTICES.md. Ported from salah-bar's SolarModel.swift.

namespace Salah.Solar;

/// <summary>Where the sun's position is evaluated.</summary>
public enum SolarEvaluation
{
    /// <summary>Near each prayer's approximate time (one iteration), as PrayTimes and Aladhan do.</summary>
    PerPrayer,

    /// <summary>
    /// Once, at 0h UT of the date, for every prayer. Matches the official Diyanet tables
    /// far better than <see cref="PerPrayer"/> (~95% exact vs ~35% for Maghrib and Isha).
    /// </summary>
    DailyAtMidnightUT,
}

/// <summary>Raw times in fractional hours after 0h UT of the civil date. NaN when undefined.</summary>
public struct SolarRawTimes
{
    public double Fajr;
    public double Sunrise;
    public double Dhuhr;
    public double Asr;
    public double Sunset;
    public double Maghrib;
    public double Isha;
}

/// <summary>Low-precision solar position and prayer-time geometry (PrayTimes.js).</summary>
public readonly struct SolarModel
{
    /// <summary>Sun altitude at sunrise/sunset: refraction plus the sun's semi-diameter.</summary>
    public const double RiseSetAngle = 0.833;

    public double Latitude { get; }
    public double Longitude { get; }
    public SolarEvaluation Evaluation { get; }

    /// <summary>Julian date of 0h UT on the civil date.</summary>
    public double JulianDay { get; }

    public SolarModel(int year, int month, int day, double latitude, double longitude, SolarEvaluation evaluation)
    {
        Latitude = latitude;
        Longitude = longitude;
        Evaluation = evaluation;
        JulianDay = Julian(year, month, day);
    }

    /// <summary>
    /// Times in hours after 0h UT. A null Maghrib angle means sunset; a null Isha angle
    /// means the caller derives Isha from an interval (Isha is NaN).
    /// </summary>
    public SolarRawTimes Times(double fajrAngle, double? maghribAngle, double? ishaAngle, double asrShadowFactor,
                               bool angleBasedHighLatitude)
    {
        // PrayTimes' initial guesses (local mean time).
        double fajr = SunAngleTime(fajrAngle, 5, counterClockwise: true);
        double sunrise = SunAngleTime(RiseSetAngle, 6, counterClockwise: true);
        double dhuhr = MidDay(12);
        double asr = AsrTime(asrShadowFactor, 13);
        double sunset = SunAngleTime(RiseSetAngle, 18, counterClockwise: false);
        double maghrib = maghribAngle is double ma ? SunAngleTime(ma, 18, counterClockwise: false) : sunset;
        double isha = ishaAngle is double ia ? SunAngleTime(ia, 18, counterClockwise: false) : double.NaN;

        // Local mean time → UT.
        double shift = -Longitude / 15;
        var raw = new SolarRawTimes
        {
            Fajr = fajr + shift, Sunrise = sunrise + shift, Dhuhr = dhuhr + shift, Asr = asr + shift,
            Sunset = sunset + shift, Maghrib = maghrib + shift, Isha = isha + shift,
        };

        if (angleBasedHighLatitude)
        {
            // PrayTimes "AngleBased": cap Fajr/Isha at angle/60 of the night.
            double night = TimeDifference(raw.Sunset, raw.Sunrise);
            raw.Fajr = AdjustHighLatitude(raw.Fajr, raw.Sunrise, fajrAngle, night, counterClockwise: true);
            if (ishaAngle is double ia2)
                raw.Isha = AdjustHighLatitude(raw.Isha, raw.Sunset, ia2, night, counterClockwise: false);
            if (maghribAngle is double ma2)
                raw.Maghrib = AdjustHighLatitude(raw.Maghrib, raw.Sunset, ma2, night, counterClockwise: false);
        }
        return raw;
    }

    // Geometry

    private static double AdjustHighLatitude(double time, double baseTime, double angle, double night, bool counterClockwise)
    {
        double portion = angle / 60 * night;
        double difference = counterClockwise ? TimeDifference(time, baseTime) : TimeDifference(baseTime, time);
        if (double.IsNaN(time) || difference > portion)
            return baseTime + (counterClockwise ? -portion : portion);
        return time;
    }

    /// <summary>Sun position for an approximate local time in hours.</summary>
    private (double Declination, double Equation) Sun(double hours) => Evaluation switch
    {
        // PrayTimes: jDate = julian − lng/(15·24), then + time/24.
        SolarEvaluation.PerPrayer => SunPosition(JulianDay - Longitude / (15 * 24) + hours / 24),
        _ => SunPosition(JulianDay),
    };

    private double MidDay(double hours) => FixHour(12 - Sun(hours).Equation);

    private double SunAngleTime(double angle, double hours, bool counterClockwise)
    {
        double declination = Sun(hours).Declination;
        double noon = MidDay(hours);
        double cosine = (-DSin(angle) - DSin(declination) * DSin(Latitude)) / (DCos(declination) * DCos(Latitude));
        if (!(cosine >= -1 && cosine <= 1)) return double.NaN;
        double t = DArcCos(cosine) / 15;
        return noon + (counterClockwise ? -t : t);
    }

    private double AsrTime(double factor, double hours)
    {
        double declination = Sun(hours).Declination;
        double angle = -DArcCot(factor + DTan(Math.Abs(Latitude - declination)));
        return SunAngleTime(angle, hours, counterClockwise: false);
    }

    // Astronomy (PrayTimes.js)

    public static double Julian(int year, int month, int day)
    {
        double y = year, m = month;
        if (m <= 2)
        {
            y -= 1;
            m += 12;
        }
        double a = Math.Floor(y / 100);
        double b = 2 - a + Math.Floor(a / 4);
        return Math.Floor(365.25 * (y + 4716)) + Math.Floor(30.6001 * (m + 1)) + day + b - 1524.5;
    }

    public static (double Declination, double Equation) SunPosition(double jd)
    {
        double d = jd - 2451545.0;
        double g = FixAngle(357.529 + 0.98560028 * d);
        double q = FixAngle(280.459 + 0.98564736 * d);
        double l = FixAngle(q + 1.915 * DSin(g) + 0.020 * DSin(2 * g));
        double e = 23.439 - 0.00000036 * d;
        double ra = DArcTan2(DCos(e) * DSin(l), DCos(l)) / 15;
        double equation = q / 15 - FixHour(ra);
        double declination = DArcSin(DSin(e) * DSin(l));
        return (declination, equation);
    }

    public static double TimeDifference(double from, double to) => FixHour(to - from);

    public static double FixAngle(double a) => Fix(a, 360);
    public static double FixHour(double h) => Fix(h, 24);

    private static double Fix(double a, double b)
    {
        double r = a - b * Math.Floor(a / b);
        return r < 0 ? r + b : r;
    }

    private static double DSin(double d) => Math.Sin(d * Math.PI / 180);
    private static double DCos(double d) => Math.Cos(d * Math.PI / 180);
    private static double DTan(double d) => Math.Tan(d * Math.PI / 180);
    private static double DArcSin(double x) => Math.Asin(x) * 180 / Math.PI;
    private static double DArcCos(double x) => Math.Acos(x) * 180 / Math.PI;
    private static double DArcTan2(double y, double x) => Math.Atan2(y, x) * 180 / Math.PI;
    private static double DArcCot(double x) => Math.Atan(1 / x) * 180 / Math.PI;
}
