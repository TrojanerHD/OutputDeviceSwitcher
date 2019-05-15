namespace OutputDeviceSwitcher
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.mainNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.voicemeeterVersionDescription = new System.Windows.Forms.TextBox();
            this.voicemeeterVersionComboBox = new System.Windows.Forms.ComboBox();
            this.defaultVoicemeeterOutputDescription = new System.Windows.Forms.TextBox();
            this.defaultVoicemeeterOutputDevice = new System.Windows.Forms.ComboBox();
            this.defaultNonVoicemeeterOutputDeviceDescription = new System.Windows.Forms.TextBox();
            this.defaultNonVoicemeeterOutputDevice = new System.Windows.Forms.ComboBox();
            this.updateNonVoiceMeeterOutputDevice = new System.Windows.Forms.Button();
            this.notifyMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyMenuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.notfifyMenuSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.notifyMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizeMessage = new System.Windows.Forms.CheckBox();
            this.notifyMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainNotifyIcon
            // 
            this.mainNotifyIcon.BalloonTipText = "It is still active";
            this.mainNotifyIcon.BalloonTipTitle = "OutputDeviceSwitcher is now minimized";
            this.mainNotifyIcon.ContextMenuStrip = this.notifyMenuStrip;
            this.mainNotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("mainNotifyIcon.Icon")));
            this.mainNotifyIcon.Text = "OutputDeviceSwitcher";
            this.mainNotifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MainNotifyIcon_MouseClick);
            // 
            // voicemeeterVersionDescription
            // 
            this.voicemeeterVersionDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.voicemeeterVersionDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voicemeeterVersionDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.voicemeeterVersionDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.voicemeeterVersionDescription.Location = new System.Drawing.Point(12, 12);
            this.voicemeeterVersionDescription.Name = "voicemeeterVersionDescription";
            this.voicemeeterVersionDescription.ReadOnly = true;
            this.voicemeeterVersionDescription.Size = new System.Drawing.Size(194, 20);
            this.voicemeeterVersionDescription.TabIndex = 0;
            this.voicemeeterVersionDescription.TabStop = false;
            this.voicemeeterVersionDescription.Text = "Used Voicemeeter version";
            // 
            // voicemeeterVersionComboBox
            // 
            this.voicemeeterVersionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.voicemeeterVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voicemeeterVersionComboBox.ForeColor = System.Drawing.SystemColors.Control;
            this.voicemeeterVersionComboBox.FormattingEnabled = true;
            this.voicemeeterVersionComboBox.Items.AddRange(new object[] {
            "Voicemeeter",
            "Voicemeeter Banana",
            "Voicemeeter Potato"});
            this.voicemeeterVersionComboBox.Location = new System.Drawing.Point(226, 12);
            this.voicemeeterVersionComboBox.Name = "voicemeeterVersionComboBox";
            this.voicemeeterVersionComboBox.Size = new System.Drawing.Size(263, 21);
            this.voicemeeterVersionComboBox.TabIndex = 2;
            this.voicemeeterVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.VoicemeeterVersionComboBox_SelectedIndexChanged);
            // 
            // defaultVoicemeeterOutputDescription
            // 
            this.defaultVoicemeeterOutputDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.defaultVoicemeeterOutputDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultVoicemeeterOutputDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.defaultVoicemeeterOutputDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.defaultVoicemeeterOutputDescription.Location = new System.Drawing.Point(12, 38);
            this.defaultVoicemeeterOutputDescription.Name = "defaultVoicemeeterOutputDescription";
            this.defaultVoicemeeterOutputDescription.ReadOnly = true;
            this.defaultVoicemeeterOutputDescription.Size = new System.Drawing.Size(194, 20);
            this.defaultVoicemeeterOutputDescription.TabIndex = 3;
            this.defaultVoicemeeterOutputDescription.TabStop = false;
            this.defaultVoicemeeterOutputDescription.Text = "Default Voicemeeter output device";
            // 
            // defaultVoicemeeterOutputDevice
            // 
            this.defaultVoicemeeterOutputDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.defaultVoicemeeterOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultVoicemeeterOutputDevice.ForeColor = System.Drawing.SystemColors.Control;
            this.defaultVoicemeeterOutputDevice.FormattingEnabled = true;
            this.defaultVoicemeeterOutputDevice.Location = new System.Drawing.Point(226, 38);
            this.defaultVoicemeeterOutputDevice.Name = "defaultVoicemeeterOutputDevice";
            this.defaultVoicemeeterOutputDevice.Size = new System.Drawing.Size(263, 21);
            this.defaultVoicemeeterOutputDevice.TabIndex = 4;
            this.defaultVoicemeeterOutputDevice.SelectedIndexChanged += new System.EventHandler(this.UpdateOptions);
            // 
            // defaultNonVoicemeeterOutputDeviceDescription
            // 
            this.defaultNonVoicemeeterOutputDeviceDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.defaultNonVoicemeeterOutputDeviceDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultNonVoicemeeterOutputDeviceDescription.Cursor = System.Windows.Forms.Cursors.Default;
            this.defaultNonVoicemeeterOutputDeviceDescription.ForeColor = System.Drawing.SystemColors.Control;
            this.defaultNonVoicemeeterOutputDeviceDescription.Location = new System.Drawing.Point(12, 64);
            this.defaultNonVoicemeeterOutputDeviceDescription.Name = "defaultNonVoicemeeterOutputDeviceDescription";
            this.defaultNonVoicemeeterOutputDeviceDescription.ReadOnly = true;
            this.defaultNonVoicemeeterOutputDeviceDescription.Size = new System.Drawing.Size(194, 20);
            this.defaultNonVoicemeeterOutputDeviceDescription.TabIndex = 5;
            this.defaultNonVoicemeeterOutputDeviceDescription.TabStop = false;
            this.defaultNonVoicemeeterOutputDeviceDescription.Text = "Default non-Voicemeeter output device";
            // 
            // defaultNonVoicemeeterOutputDevice
            // 
            this.defaultNonVoicemeeterOutputDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.defaultNonVoicemeeterOutputDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.defaultNonVoicemeeterOutputDevice.ForeColor = System.Drawing.SystemColors.Control;
            this.defaultNonVoicemeeterOutputDevice.FormattingEnabled = true;
            this.defaultNonVoicemeeterOutputDevice.Location = new System.Drawing.Point(226, 64);
            this.defaultNonVoicemeeterOutputDevice.Name = "defaultNonVoicemeeterOutputDevice";
            this.defaultNonVoicemeeterOutputDevice.Size = new System.Drawing.Size(263, 21);
            this.defaultNonVoicemeeterOutputDevice.TabIndex = 6;
            this.defaultNonVoicemeeterOutputDevice.SelectedIndexChanged += new System.EventHandler(this.UpdateOptions);
            // 
            // updateNonVoiceMeeterOutputDevice
            // 
            this.updateNonVoiceMeeterOutputDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.updateNonVoiceMeeterOutputDevice.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateNonVoiceMeeterOutputDevice.Location = new System.Drawing.Point(495, 64);
            this.updateNonVoiceMeeterOutputDevice.Name = "updateNonVoiceMeeterOutputDevice";
            this.updateNonVoiceMeeterOutputDevice.Size = new System.Drawing.Size(75, 21);
            this.updateNonVoiceMeeterOutputDevice.TabIndex = 7;
            this.updateNonVoiceMeeterOutputDevice.Text = "Update";
            this.updateNonVoiceMeeterOutputDevice.UseVisualStyleBackColor = true;
            this.updateNonVoiceMeeterOutputDevice.Click += new System.EventHandler(this.UpdateNonVoiceMeeterOutputDevice_Click);
            // 
            // notifyMenuStrip
            // 
            this.notifyMenuStrip.BackColor = System.Drawing.Color.White;
            this.notifyMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notifyMenuOpen,
            this.notfifyMenuSeparator,
            this.notifyMenuExit});
            this.notifyMenuStrip.Name = "notifyMenuStrip";
            this.notifyMenuStrip.Size = new System.Drawing.Size(105, 54);
            // 
            // notifyMenuOpen
            // 
            this.notifyMenuOpen.BackColor = System.Drawing.Color.White;
            this.notifyMenuOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.notifyMenuOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notifyMenuOpen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notifyMenuOpen.Name = "notifyMenuOpen";
            this.notifyMenuOpen.Size = new System.Drawing.Size(104, 22);
            this.notifyMenuOpen.Text = "Open";
            this.notifyMenuOpen.ToolTipText = "Opens the OutputDeviceSwitcher";
            this.notifyMenuOpen.Click += new System.EventHandler(this.NotifyMenuOpen_Click);
            // 
            // notfifyMenuSeparator
            // 
            this.notfifyMenuSeparator.ForeColor = System.Drawing.SystemColors.Control;
            this.notfifyMenuSeparator.Name = "notfifyMenuSeparator";
            this.notfifyMenuSeparator.Size = new System.Drawing.Size(101, 6);
            // 
            // notifyMenuExit
            // 
            this.notifyMenuExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.notifyMenuExit.Name = "notifyMenuExit";
            this.notifyMenuExit.Size = new System.Drawing.Size(104, 22);
            this.notifyMenuExit.Text = "Exit";
            // 
            // minimizeMessage
            // 
            this.minimizeMessage.AutoSize = true;
            this.minimizeMessage.Checked = true;
            this.minimizeMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.minimizeMessage.Location = new System.Drawing.Point(12, 90);
            this.minimizeMessage.Name = "minimizeMessage";
            this.minimizeMessage.Size = new System.Drawing.Size(155, 17);
            this.minimizeMessage.TabIndex = 9;
            this.minimizeMessage.Text = "Show message on minimize";
            this.minimizeMessage.UseVisualStyleBackColor = true;
            this.minimizeMessage.Click += new System.EventHandler(this.UpdateOptions);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(581, 116);
            this.Controls.Add(this.minimizeMessage);
            this.Controls.Add(this.updateNonVoiceMeeterOutputDevice);
            this.Controls.Add(this.defaultNonVoicemeeterOutputDevice);
            this.Controls.Add(this.defaultNonVoicemeeterOutputDeviceDescription);
            this.Controls.Add(this.defaultVoicemeeterOutputDevice);
            this.Controls.Add(this.defaultVoicemeeterOutputDescription);
            this.Controls.Add(this.voicemeeterVersionComboBox);
            this.Controls.Add(this.voicemeeterVersionDescription);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Output Device Switcher";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.notifyMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon mainNotifyIcon;
        private System.Windows.Forms.TextBox voicemeeterVersionDescription;
        private System.Windows.Forms.ComboBox voicemeeterVersionComboBox;
        private System.Windows.Forms.TextBox defaultVoicemeeterOutputDescription;
        private System.Windows.Forms.ComboBox defaultVoicemeeterOutputDevice;
        private System.Windows.Forms.TextBox defaultNonVoicemeeterOutputDeviceDescription;
        private System.Windows.Forms.ComboBox defaultNonVoicemeeterOutputDevice;
        private System.Windows.Forms.Button updateNonVoiceMeeterOutputDevice;
        private System.Windows.Forms.ContextMenuStrip notifyMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuOpen;
        private System.Windows.Forms.ToolStripSeparator notfifyMenuSeparator;
        private System.Windows.Forms.ToolStripMenuItem notifyMenuExit;
        private System.Windows.Forms.CheckBox minimizeMessage;
    }
}

