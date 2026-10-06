# Third-party notices

Salah Bar for Windows is "all rights reserved" (see [LICENSE](LICENSE)), except
for the components below, which keep their own licenses and owners.

## PrayTimes.js (prayer-time calculation)
Copyright (c) 2007–2011 PrayTimes.org (Hamid Zarrabi-Zadeh).
`src/Salah.Solar/SolarModel.cs` is a C# port of its astronomical algorithm (via
the Mac app's `SolarModel.swift`) and, as a derived work, is licensed under the
**GNU Lesser General Public License v3.0** ([LICENSE.LGPL](src/Salah.Solar/LICENSE.LGPL),
with the GPL-3.0 text it refers to in [LICENSE.GPL](src/Salah.Solar/LICENSE.GPL)).
It is built as its own assembly, `Salah.Solar.dll`, so it can be replaced; its
source is published with each release.

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

## Adhan recordings
The adhan recordings, bundled and in the online library, belong to their reciters
and producers and are not covered by Salah Bar's license.

## Official prayer-time data
Test data in `shared/fixtures/` comes from Diyanet İşleri Başkanlığı
(namazvakitleri.diyanet.gov.tr) and Aladhan (aladhan.com), and is used only to
test accuracy.
