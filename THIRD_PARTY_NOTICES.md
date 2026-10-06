# Third-party notices

Salah Bar for Windows is "all rights reserved" (see [LICENSE](LICENSE)), except
for the components below, which keep their own licenses and owners.

## Prayer-time calculation
Since 1.1.0 Salah Bar computes the sun's position with its own code, written
from the U.S. Naval Observatory's public-domain "Approximate Solar
Coordinates" (https://aa.usno.navy.mil/faq/sun_approx).

Versions 1.0.0 and 1.0.1 instead used `Salah.Solar.dll`, a C# port of the
astronomical algorithm of **PrayTimes.js**, Copyright (c) 2007–2011
PrayTimes.org (Hamid Zarrabi-Zadeh). As a derived work it is licensed under
the **GNU Lesser General Public License v3.0**
(https://www.gnu.org/licenses/lgpl-3.0.html), and its source stays published in
`third-party/SolarModel-1.0.0-1.0.1.cs` (with `LICENSE.LGPL` and `LICENSE.GPL`) in
the releases repo for those versions.

## NodaTime
Copyright The Noda Time Authors. Apache License 2.0:
https://github.com/nodatime/nodatime/blob/main/LICENSE.txt
Includes the IANA time zone database (public domain).

## GeoNames (city list)
`data/cities.tsv.gz` is derived from GeoNames (https://www.geonames.org), cities
with 15,000+ people, licensed under **Creative Commons Attribution 4.0**
(https://creativecommons.org/licenses/by/4.0/). Built by `tools/gen-cities.py`.

## H.NotifyIcon
Copyright (c) havendv and contributors. MIT License:
https://github.com/HavenDV/H.NotifyIcon/blob/master/LICENSE.md

## NAudio
Copyright (c) Mark Heath and contributors. MIT License:
https://github.com/naudio/NAudio/blob/master/license.txt

## Windows App SDK / WinUI
Copyright (c) Microsoft Corporation. MIT License:
https://github.com/microsoft/WindowsAppSDK/blob/main/LICENSE

## The Quran text
The Arabic of the Quranic quotes is from the **Tanzil Quran Text** (quran-simple),
Copyright (c) 2007–2026 Tanzil Project, https://tanzil.net, used verbatim under
its terms of use.

## Translations
English quotes use **Sahih International**; Turkish quotes use the **Diyanet
İşleri Başkanlığı** translation. These belong to their publishers.

## Quran recitations
The Quran player streams (and, on request, downloads) recitations from
**mp3quran.net**, https://mp3quran.net, using its public API. The reciters
list bundled with the app comes from the same API. mp3quran.net's policy
(https://www.mp3quran.net/eng/privacy, "Copyrights") states: "All rights are
available to everyone, and we allow any visitor or developer to copy any
material or use any link on the websites". The recordings belong to their
reciters and producers and are not covered by Salah Bar's license.

## Adhan recordings
The adhan recordings, bundled and in the online library, belong to their reciters
and producers and are not covered by Salah Bar's license.

## Official prayer-time data
Test data in `shared/fixtures/` comes from Diyanet İşleri Başkanlığı
(namazvakitleri.diyanet.gov.tr) and Aladhan (aladhan.com), and is used only to
test accuracy.
