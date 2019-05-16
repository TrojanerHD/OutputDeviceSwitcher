# OutputDeviceSwitcher
Changes the sound output device when Voicemeeter is opened/closed.  
Note: This program was only tested on Windows and may not work on other operating systems.
## Getting Started
### Prerequesites
+ Any version of [Voicemeeter](https://www.vb-audio.com/Voicemeeter/)

Note: This program was only tested with Voicemeeter Potato. If you encounter problems with another version of Voicemeeter feel free to create an [issue](https://github.com/TrojanerHD/OutputDeviceSwitcher/issues).
### Installing
Go to the [releases-page](https://github.com/TrojanerHD/OutputDeviceSwitcher/releases) and download the newest release. Place the `.exe` file into a folder and execute it.

Important note: Since the program needs the [AudioEndpointConnector](https://github.com/DanStevens/AudioEndPointController) in order to work it will ask at the first execute if it should download it. If an error occurs, check your internet connection and run the program again. If the error still occurs you can download the AudioSwitcher manually [here](https://github.com/DanStevens/AudioEndPointController/raw/master/Release/EndPointController.exe). After you downloaded it, place the file into the same folder as the `OutputDeviceSwitcher.exe` file.
# Built With
+ [AudioEndpointConnector](https://github.com/DanStevens/AudioEndPointController) - A Windows command-line program which is used to get the sound output devices of the computer and change the default.

# Authors
+ Trojaner - *Initial work* - [TrojanerHD](https://github.com/TrojanerHD)

See also the list of [contributors](https://github.com/TrojanerHD/contributors) who participated in this project.

# Acknowledgments
+ Thanks to [marcjoha](https://github.com/marcjoha)'s [AudioSwitcher](https://github.com/marcjoha/AudioSwitcher), from whom I copied a bit of code and who showed me the AudioEndPointController.
