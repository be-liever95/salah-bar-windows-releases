# Privacy

*Last updated: 30 October 2026*

Salah Bar for Windows doesn't collect, store or send any personal data to its developer. It has
no accounts, ads, tracking or analytics. Your settings, location and prayer log stay on your PC,
unless you choose to sync them through a file in your own cloud drive.

- **Location.** When you allow it, Salah Bar asks Windows (its location service) for your
  approximate location to calculate prayer times and the Qibla where you are. The location stays
  on your PC: it is matched to a city name using a list that ships with the app, and is never
  sent anywhere, nor written to the sync file.
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
- **Widgets.** The widgets on the Windows Widgets board and the desktop show prayer times,
  the Qibla and the Ramadan countdown. They are drawn from your PC's data by Windows' widget
  host; nothing is sent to the internet for them.
- **Updates.** The direct-download version checks GitHub for a new release and downloads it. The
  Microsoft Store version is updated by the Microsoft Store, under Microsoft's privacy statement.
- **Microphone and camera.** "Stay quiet during calls" checks whether another app is using the
  microphone or camera (the same information Windows shows in its privacy indicator). Salah
  Bar never uses the microphone or camera itself.

## What goes over the internet

Salah Bar connects only to the services below, and only for the feature named. None of them
receives your name, your settings, your location or an account; like any web request, each sees
your PC's IP address.

| Service | When | What it receives |
|---|---|---|
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
| **Microsoft Store** | Update checks of the Store version, made by the Store | Handled by Windows and the Store, not by Salah Bar |

Links you click (such as Tanzil.net for the Quran text's source, or the Buy Me a Coffee support
page) open in your browser.

## Children

Salah Bar collects no data from anyone, including children.

## Changes

If this policy changes, the new version will be published on this page with a new date.

## Contact

Questions: open an issue in this repository.
