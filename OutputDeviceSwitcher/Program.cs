using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutputDeviceSwitcher {
    internal static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main() {
            const string controllerExePath = @"EndPointController.exe";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (File.Exists(controllerExePath)) {
                Application.Run(new MainWindow());
                return;
            }

            var result = MessageBox.Show(
                @"You have to download the EndPointController which changes your output device (if you click cancel the program will close)",
                @"Download EndPointController", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK) return;
            try {
                var wc = new WebClient();
                wc.DownloadFile(
                    new Uri(
                        @"https://github.com/DanStevens/AudioEndPointController/raw/master/Release/EndPointController.exe"),
                    controllerExePath);
                Application.Run(new MainWindow());
            } catch (Exception e) {
                MessageBox.Show(e.Message, @"An error occured");
            }
        }
    }
}