# Privacy

*Last updated: 31 October 2026*

Salah Bar for Windows doesn't collect, store or send any personal data to its developer. It has
no accounts, ads, tracking or analytics. Your settings, location and prayer log stay on your PC,
unless you choose to sync them through your own Google Drive or a file in your own cloud drive.
The one other exception, off until you turn it on, is the weather: then your location, rounded to
about 10 km, goes to Open-Meteo (see below).

- **Location.** When you allow it, Salah Bar asks Windows (its location service) for your
  approximate location to calculate prayer times and the Qibla where you are. The location stays
  on your PC: it is matched to a city name using a list that ships with the app, and is never
  sent anywhere (except, rounded, to Open-Meteo if you turn on the weather), nor written to the
  sync file.
- **Settings and logs** (your settings, saved cities, prayer log, Ramadan log, Khatma progress,
  where you stopped in each surah, downloaded adhans and recitations) are saved on your PC, in
  `%LOCALAPPDATA%\SalahBar`.
- **Sync (only if you turn it on).** In Settings → Sync you choose a file in a cloud drive you
  already use (OneDrive, Google Drive, Dropbox or any folder your PC syncs). Salah Bar then writes
  your settings, prayer log, Ramadan log, Khatma progress and Quran places to that file, with this
  PC's name (as Windows shows in Settings → System → About) so your other devices can show where
  the data came from, and reads what your other devices wrote there. The file goes only where you
  put it: Salah Bar has no server and sends it nowhere else, and the developer never sees it. Your
  cloud drive's own privacy policy applies to the file. "Stop Syncing" takes this PC's data out
  of the file.
- **Sync with Google Drive (only if you sign in).** In Settings → Sync you can instead click *Sign in
  with Google*. Google's page opens in your browser and Salah Bar asks for one permission only, to
  keep its own file in your Google Drive's hidden app folder (the `drive.appdata` scope): it can't
  see, open or change any of your other files in Drive. It keeps the same sync file there, `Salah
  Bar sync.json`, sending it straight from your PC to your own Google Drive over HTTPS; there is no
  Salah Bar server in between, and the developer never sees the file or your account. The sign-in
  token is kept on your PC in `%LOCALAPPDATA%\SalahBar`, protected with Windows' data protection for
  your user account, with your account's email address to show it. Google's privacy policy applies
  to your Google account and Drive. *Sign Out* takes this PC's data out of the file and stops syncing
  here; *Remove my data from Drive* deletes the file from your Drive (every device's data in it) and
  takes Salah Bar's access away. You can also remove Salah Bar's access at any time from your Google
  Account (Security → Third-party apps), and Drive → Settings → Manage apps lets you delete its
  hidden data. Salah Bar's use of information received from Google APIs adheres to the
  [Google API Services User Data Policy](https://developers.google.com/terms/api-services-user-data-policy),
  including the Limited Use requirements: it only reads and writes its own sync file in your Drive,
  to sync your devices, and never uses it for anything else or passes it to anyone.
- **Widgets.** The widgets on the Windows Widgets board and the desktop show prayer times,
  the Qibla and the Ramadan countdown. They are drawn from your PC's data by Windows' widget
  host; nothing is sent to the internet for them.
- **Updates.** The direct-download version checks GitHub for a new release and downloads it. The
  Microsoft Store version is updated by the Microsoft Store, under Microsoft's privacy statement.
- **Microphone and camera.** "Stay quiet during calls" checks whether another app is using the
  microphone or camera (the same information Windows shows in its privacy indicator). Salah
  Bar never uses the microphone or camera itself.

## What goes over the internet

Salah Bar connects only to the services below, and only for the feature named. Apart from Google
Drive, if you sign in to sync with it, none of them receives your name, your settings or an account,
and only Open-Meteo (with the weather on) and Google Maps (when you open *Mosques*) receive a location;
like any web request, each sees your PC's IP address.

| Service | When | What it receives |
|---|---|---|
| **Open-Meteo** (api.open-meteo.com) | Only with *Show the weather* on (Settings → Appearance): when you turn it on, then at most every 30 minutes while the app runs | Your location rounded to 0.1° (about 10 km), to get the current weather there; nothing else is sent with it |
| **mp3quran.net** | When you use the Quran window: the list of reciters (at most once a week), the surahs you play or download, and ayah timings for Hifz | Requests for those files |
| **EveryAyah.com** | Hifz with recitations it serves ayah by ayah | Requests for those ayahs' files |
| **hisnmuslim.com** | When you listen to a dua, or download the recordings | A request for that dua's recording |
| **IslamHouse.com** | When you listen to a dua read by a reciter whose files it serves | A request for the reciter's file that holds that dua |
| **archive.org** (the Internet Archive) | When you listen to a dua read by a reciter whose files it serves | A request for the reciter's file that holds that dua |
| **Wikimedia Commons** (upload.wikimedia.org) | Only when you play a name in the 99 Names (or a name-of-the-day card) or download the names for offline use | Requests for the recordings you play or download |
| **Your mosque's website** (the link you give) or **islamic.app** (api.islamic.app) | Only with *Iqama times from your mosque* on (Settings → Iqama): when you save the link, when you click *Refresh now*, and once a week | A request for the iqama timetable at that link (or that islamic.app mosque); nothing is sent with it |
| **android.quran.com** | When you open the list of Quran translations and tafsirs, or download one | Requests for that list and those editions |
| **files.quran.app** | When you use a printed Mushaf style (Madani, Shamarly, IndoPak): its page images | Requests for those page images |
| **GitHub** (github.com and the addresses it redirects downloads to) | Updates to the direct-download version; and when you choose or preview an adhan from the online library | A request for the update feed and files, or for that adhan's file |
| **Google Maps** (in your browser) | Only when you click *Mosques* beside the Qibla in the panel | Your city's position, in the link that opens the map of the mosques around it (Google's privacy policy applies) |
| **Google** (accounts.google.com in your browser, oauth2.googleapis.com, www.googleapis.com) | Only with *Sync with Google Drive*: when you sign in, when the sign-in is renewed, at each sync, and when you sign out or remove your data | Your Google sign-in, and the sync file read from and written to your Drive's hidden app folder (Google's privacy policy applies) |
| **Microsoft Store** | Update checks of the Store version, made by the Store | Handled by Windows and the Store, not by Salah Bar |

**The weather** (off until you turn it on, on each PC). The sky behind the next prayer and in the
widgets is worked out on your PC from the prayer times. If you turn on *Show the weather* (Settings →
Appearance), Salah Bar first says what it will send, then asks Open-Meteo (open-meteo.com) for the
current weather at your city's location rounded to 0.1° (about 10 km), at most every 30 minutes while
the app runs, with no account, key, cookie or identifier. The answer (clouds, rain, snow…) stays on
your PC and is shared with its widgets. Turning the switch off stops the requests and forgets the last
answer. Open-Meteo's terms and privacy policy apply to the request; its weather data is CC BY 4.0.

Links you click (such as Tanzil.net for the Quran text's source, or the Buy Me a Coffee support
page) open in your browser.

## Children

Salah Bar collects no data from anyone, including children.

## Changes

If this policy changes, the new version will be published on this page with a new date.

## Contact

Questions: open an issue in this repository.
