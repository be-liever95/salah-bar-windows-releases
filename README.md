# Salah Bar for Windows

Prayer times in the Windows notification area: a live countdown to the next prayer,
reminders before each prayer, the adhan, a screen-edge flash before prayer time, the
Qibla, the Hijri date, and an ayah or dua — in English, Türkçe and العربية.

The Windows version of [Salah Bar for Mac](https://github.com/be-liever95/salah-bar).

## Download

**[Download the latest version](https://github.com/be-liever95/salah-bar-windows-releases/releases/latest)**

- Most PCs: `SalahBar.Windows-win-x64-Setup.exe`
- Windows on Arm (Snapdragon, Surface Pro X …): `SalahBar.Windows-win-arm64-Setup.exe`

Windows 11 is required. The installer isn't code-signed yet, so Windows SmartScreen may
say it "protected your PC": choose **More info → Run anyway**. Salah Bar installs for your
user only (no administrator rights), adds a Start menu entry, and updates itself.

Salah Bar will also be in the Microsoft Store, with widgets for the Widgets board.

## Features

- Countdown in the notification area; panel with today's times, Hijri date, Qibla and an ayah or dua
- Prayer times calculated on your PC: Diyanet (matching the official tables), Umm al-Qura,
  ISNA, MWL, Egypt and 18 more; automatic method by country
- Reminders 10, 5 and 0 minutes before each prayer, with a Silence button
- The adhan at prayer time, with fade-in, trimming, your own recordings and an online library of 169 adhans
- Stays quiet during calls, while the camera is on, in Do not disturb and in full-screen presentations
- A green glow around the screen edges a few minutes before each prayer
- A desktop widget (Small, Medium, Large)
- English, Turkish and Arabic, with a right-to-left layout in Arabic

## Uninstall

Settings → Apps → Installed apps → Salah Bar → Uninstall. Your settings stay in
`%LOCALAPPDATA%\SalahBar`; delete that folder to remove them too.

## Privacy

Salah Bar has no accounts, ads or analytics. See [PRIVACY.md](PRIVACY.md).

## License

Salah Bar is free to download and use, but all rights are reserved (see [LICENSE](LICENSE)).
The prayer-time engine is LGPL-3.0: its source is in [third-party/](third-party/) and in
each release. See [THIRD_PARTY_NOTICES.md](THIRD_PARTY_NOTICES.md).

[Support Salah Bar](https://buymeacoffee.com/be_liever95)
