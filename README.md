# Salah Bar for Windows

Prayer times in the Windows notification area: a live countdown to the next prayer,
reminders before each prayer, the adhan, a screen-edge flash before prayer time, the
Qibla, the Hijri date, and an ayah or dua — in English, Türkçe and العربية.

The Windows version of [Salah Bar for Mac](https://github.com/be-liever95/salah-bar).

## Download

**[Get it from the Microsoft Store](https://apps.microsoft.com/detail/9PNM4R0HP3QN)** (recommended):
signed by Microsoft, updated by the Store, and with Salah Bar's widgets on the Widgets board
(Win+W). Or from a terminal: `winget install 9PNM4R0HP3QN -s msstore`.

Or **[download the installer](https://github.com/be-liever95/salah-bar-windows-releases/releases/latest)**:

- Most PCs: `SalahBar.Windows-win-x64-Setup.exe`
- Windows on Arm (Snapdragon, Surface Pro X …): `SalahBar.Windows-win-arm64-Setup.exe`

The installer isn't code-signed, so Windows SmartScreen may say it "protected your PC":
choose **More info → Run anyway**. It installs for your user only (no administrator rights),
adds a Start menu entry, and updates itself.

Windows 11 is required. Use one version, not both: they would each play the adhan.

## Features

- Countdown in the notification area; panel with today's times, Hijri date, Qibla and an ayah or dua
- Prayer times calculated on your PC: Diyanet (matching the official tables), Umm al-Qura,
  ISNA, MWL, Egypt and 18 more; automatic method by country
- Reminders 10, 5 and 0 minutes before each prayer, with a Silence button
- The adhan at prayer time, with fade-in, trimming, your own recordings and an online library of 169 adhans
- A Quran player: 242 reciters, streaming or downloaded for offline listening; it pauses for the adhan
- Stays quiet during calls, while the camera is on, in Do not disturb and in full-screen presentations
- A green glow around the screen edges a few minutes before each prayer
- An optional floating countdown, since the taskbar can't show text
- A desktop widget (Small, Medium, Large), and Widgets-board widgets in the Store version
- English, Turkish and Arabic, with a right-to-left layout in Arabic

## Uninstall

Settings → Apps → Installed apps → Salah Bar → Uninstall. Your settings stay in
`%LOCALAPPDATA%\SalahBar`; delete that folder to remove them too.

## Privacy

Salah Bar has no accounts, ads or analytics. See [PRIVACY.md](PRIVACY.md).

## License

Salah Bar is free to download and use, but all rights are reserved (see [LICENSE](LICENSE)).
Versions 1.0.0 and 1.0.1 included an LGPL-3.0 prayer-time engine; its source is in
[third-party/](third-party/). See [THIRD_PARTY_NOTICES.md](THIRD_PARTY_NOTICES.md).

[Support Salah Bar](https://buymeacoffee.com/be_liever95)
