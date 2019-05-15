﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OutputDeviceSwitcher {
    public partial class MainWindow : Form {
        private readonly Settings _settings;
        private const string ControllerExePath = @"EndPointController.exe";
        private readonly List<string> _voicemeeterOutputDevices = new List<string>();
        private static readonly Dictionary<int, string> OutputDevices = new Dictionary<int, string>();

        public MainWindow() {
            if (!File.Exists(@"settings.json"))
                using (var w = File.AppendText(@"settings.json"))
                    w.WriteLine(@"{}");

            _settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(@"settings.json"));
            InitializeComponent();
        }

        private void MainWindow_Resize(object sender, EventArgs e) {
            switch (WindowState) {
                case FormWindowState.Minimized:
                    mainNotifyIcon.Visible = true;
                    if (!_settings.NotShowMinimizeMessage) mainNotifyIcon.ShowBalloonTip(500);
                    Hide();
                    break;
                case FormWindowState.Normal:
                    mainNotifyIcon.Visible = false;
                    break;
                case FormWindowState.Maximized:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void UpdateOptions(object sender, EventArgs e) {
            _settings.VoicemeeterVersion =
                voicemeeterVersionComboBox.Items[voicemeeterVersionComboBox.SelectedIndex].ToString();
            if (defaultVoicemeeterOutputDevice.SelectedIndex != -1) _settings.DefaultVoicemeeterOutputDevice = defaultVoicemeeterOutputDevice.Items[defaultVoicemeeterOutputDevice.SelectedIndex].ToString();
            if (defaultNonVoicemeeterOutputDevice.SelectedIndex != -1) _settings.DefaultNonVoicemeeterOutputDevice = defaultNonVoicemeeterOutputDevice.Items[defaultNonVoicemeeterOutputDevice.SelectedIndex].ToString();
            _settings.NotShowMinimizeMessage = !minimizeMessage.Checked;
            File.WriteAllText(@"settings.json", JsonConvert.SerializeObject(_settings));
        }

        private void MainWindow_Load(object sender, EventArgs e) {
            minimizeMessage.Checked = !_settings.NotShowMinimizeMessage;
            voicemeeterVersionComboBox.SelectedIndex =
                voicemeeterVersionComboBox.FindStringExact(_settings.VoicemeeterVersion);
            
            UpdateNonVoiceMeeterOutputDevice_Click(sender, e);
            UpdateVoicemeeterVersionDeviceInputs();
            defaultVoicemeeterOutputDevice.SelectedIndex =
                defaultVoicemeeterOutputDevice.FindStringExact(_settings.DefaultVoicemeeterOutputDevice);
            defaultNonVoicemeeterOutputDevice.SelectedIndex =
                defaultNonVoicemeeterOutputDevice.FindStringExact(_settings.DefaultNonVoicemeeterOutputDevice);

            var processlist = Process.GetProcesses();
            Process voicemeeterProcess = null;
            foreach (var process in processlist)
                if (process.ProcessName.ToLower().StartsWith(@"voicemeeter"))
                    voicemeeterProcess = process;
            CheckVoicemeeterProcessRunning(100, voicemeeterProcess, defaultNonVoicemeeterOutputDevice, defaultVoicemeeterOutputDevice);
        }

        private void VoicemeeterVersionComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateVoicemeeterVersionDeviceInputs();
            UpdateOptions(sender, e);
        }

        private void UpdateVoicemeeterVersionDeviceInputs() {
            // Change the dropdown for the Voicemeeter output devices depending on which version of Voicemeeter was selected
            _voicemeeterOutputDevices.Clear();
            defaultVoicemeeterOutputDevice.Items.Clear();
            switch (voicemeeterVersionComboBox.Items[voicemeeterVersionComboBox.SelectedIndex]) {
                case @"Voicemeeter":
                    _voicemeeterOutputDevices.Add(@"VoiceMeeter Input");
                    break;
                case @"Voicemeeter Banana":
                    _voicemeeterOutputDevices.Add(@"VoiceMeeter Input");
                    _voicemeeterOutputDevices.Add(@"VoiceMeeter Aux Input");
                    break;
                case @"Voicemeeter Potato":
                    _voicemeeterOutputDevices.Add(@"VoiceMeeter Input");
                    _voicemeeterOutputDevices.Add(@"VoiceMeeter Aux Input");
                    _voicemeeterOutputDevices.Add(@"VoiceMeeter VAIO3 Input");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            _voicemeeterOutputDevices.ForEach(device => defaultVoicemeeterOutputDevice.Items.Add(device));
        }

        private void UpdateNonVoiceMeeterOutputDevice_Click(object sender, EventArgs e) {
            if (System.IO.File.Exists(ControllerExePath)) {
                var p = new Process {
                    StartInfo = {
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        CreateNoWindow = true,
                        FileName = ControllerExePath,
                        Arguments = @"-f ""%d:%s"""
                    }
                };
                p.Start();
                defaultNonVoicemeeterOutputDevice.Items.Clear();
                OutputDevices.Clear();
                while (!p.StandardOutput.EndOfStream) {
                    var line = p.StandardOutput.ReadLine();
                    if (line == null) continue;
                    var splitLine = line.Split(':');
                    var outputDevice = splitLine[1];
                    OutputDevices.Add(int.Parse(splitLine[0]), outputDevice);
                    var skipLine = false;
                    _voicemeeterOutputDevices.ForEach(device => {
                        if (outputDevice.StartsWith(device)) {
                            skipLine = true;
                        }
                    });
                    if (!skipLine) defaultNonVoicemeeterOutputDevice.Items.Add(outputDevice);
                }

                p.WaitForExit();
            } else {
                MessageBox.Show(@"Error: Could not find EndPointController.exe",
                    Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private static async void CheckVoicemeeterProcessRunning(int interval, Process voicemeeterProcess, ComboBox nonVoicemeeterOutputDevice, ComboBox defaultVoiceMeeterOutputDevice) {
            var lastState = voicemeeterProcess == null ? 0 : Process.GetProcessesByName(voicemeeterProcess.ProcessName).Length;
            while (true) {
                var newState = voicemeeterProcess == null ? 0 : Process.GetProcessesByName(voicemeeterProcess.ProcessName).Length;
                if (newState != lastState) {
                    if (newState == 0)
                        ChangeToNonVoicemeeterOutputDevice(nonVoicemeeterOutputDevice);
                    else
                        ChangeToVoicemeeterOutputDevice(defaultVoiceMeeterOutputDevice);
                }

                lastState = newState;
                await Task.Delay(interval);
            }
        }

        private static void ChangeToNonVoicemeeterOutputDevice(ComboBox nonVoicemeeterOutputDevice) {
            var id = -1;
            foreach (var outputDevice in OutputDevices)
                if (nonVoicemeeterOutputDevice != null && outputDevice.Value.Equals(nonVoicemeeterOutputDevice.Items[nonVoicemeeterOutputDevice.SelectedIndex]))
                    id = outputDevice.Key;

            var p = new Process {
                StartInfo = {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    FileName = ControllerExePath,
                    Arguments = id.ToString(CultureInfo.InvariantCulture)
                }
            };
            p.Start();
        }

        private static void ChangeToVoicemeeterOutputDevice(ComboBox defaultVoiceMeeterOutputDevice) {
            var id = -1;

            foreach (var outputDevice in OutputDevices) {
                var trimOutputDevice = outputDevice.Value.Split('(')[outputDevice.Value.Split('(').Length - 1];
                if (defaultVoiceMeeterOutputDevice != null && outputDevice.Value.Replace($@" ({trimOutputDevice}", @"").Equals(defaultVoiceMeeterOutputDevice.Items[defaultVoiceMeeterOutputDevice.SelectedIndex]))
                    id = outputDevice.Key;
            }

            var p = new Process {
                StartInfo = {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    FileName = ControllerExePath,
                    Arguments = id.ToString(CultureInfo.InvariantCulture)
                }
            };
            p.Start();
        }

        private void MainNotifyIcon_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) RestoreWindow();
        }

        private void NotifyMenuOpen_Click(object sender, EventArgs e) {
            RestoreWindow();
        }

        private void RestoreWindow() {
            Show();
            WindowState = FormWindowState.Normal;
        }
    }
}