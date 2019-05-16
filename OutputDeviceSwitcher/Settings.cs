﻿using System;
using System.IO;
using Newtonsoft.Json;

namespace OutputDeviceSwitcher {
    public class Settings {
        public string VoicemeeterVersion { get; set; }
        public string DefaultVoicemeeterOutputDevice { get; set; }
        public string DefaultNonVoicemeeterOutputDevice { get; set; }

        public bool NotShowMinimizeMessage { get; set; }
    }
}