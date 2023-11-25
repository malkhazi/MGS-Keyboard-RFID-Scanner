namespace MGS_Keyboard_RFID_Scanner
{
    partial class Form1
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
            this.Bt_LogFolder = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TSB_RS232 = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Tsb_Sound = new System.Windows.Forms.ToolStripButton();
            this.Tsm_Mute = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_Settings = new System.Windows.Forms.ToolStripButton();
            this.TSB_info = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.TSB_exit = new System.Windows.Forms.ToolStripButton();
            this.Bt_Clear = new System.Windows.Forms.Button();
            this.Rtb_Log = new System.Windows.Forms.RichTextBox();
            this.MySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.TmrSend = new System.Windows.Forms.Timer(this.components);
            this.TmrCheck = new System.Windows.Forms.Timer(this.components);
            this.MyNotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.Cm_Notify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TmpStart = new System.Windows.Forms.Timer(this.components);
            this.TmrBeep = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.ToolStrip1.SuspendLayout();
            this.Cm_Notify.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bt_LogFolder
            // 
            this.Bt_LogFolder.Location = new System.Drawing.Point(12, 60);
            this.Bt_LogFolder.Name = "Bt_LogFolder";
            this.Bt_LogFolder.Size = new System.Drawing.Size(115, 23);
            this.Bt_LogFolder.TabIndex = 0;
            this.Bt_LogFolder.Text = "Open Log Folder";
            this.Bt_LogFolder.UseVisualStyleBackColor = true;
            this.Bt_LogFolder.Click += new System.EventHandler(this.Bt_LogFolder_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ToolStrip1);
            this.splitContainer1.Panel1.Controls.Add(this.Bt_Clear);
            this.splitContainer1.Panel1.Controls.Add(this.Bt_LogFolder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Rtb_Log);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 275;
            this.splitContainer1.TabIndex = 1;
            // 
            // ToolStrip1
            // 
            this.ToolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSB_RS232,
            this.ToolStripSeparator1,
            this.Tsb_Sound,
            this.Tsm_Mute,
            this.ToolStripSeparator2,
            this.TSB_Settings,
            this.TSB_info,
            this.toolStripSeparator3,
            this.TSB_exit});
            this.ToolStrip1.Location = new System.Drawing.Point(0, 0);
            this.ToolStrip1.Name = "ToolStrip1";
            this.ToolStrip1.Size = new System.Drawing.Size(275, 39);
            this.ToolStrip1.TabIndex = 3;
            this.ToolStrip1.Text = "ToolStrip1";
            // 
            // TSB_RS232
            // 
            this.TSB_RS232.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_RS232.Image = global::MGS_Keyboard_RFID_Scanner.Properties.Resources.disconnect;
            this.TSB_RS232.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_RS232.Name = "TSB_RS232";
            this.TSB_RS232.Size = new System.Drawing.Size(36, 36);
            this.TSB_RS232.Tag = "0";
            this.TSB_RS232.ToolTipText = "RS232 Connection";
            this.TSB_RS232.Click += new System.EventHandler(this.TSB_RS232_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // Tsb_Sound
            // 
            this.Tsb_Sound.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsb_Sound.Image = global::MGS_Keyboard_RFID_Scanner.Properties.Resources.volume;
            this.Tsb_Sound.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Sound.Name = "Tsb_Sound";
            this.Tsb_Sound.Size = new System.Drawing.Size(36, 36);
            this.Tsb_Sound.Text = "Beep";
            this.Tsb_Sound.Click += new System.EventHandler(this.Tsb_Sound_Click);
            // 
            // Tsm_Mute
            // 
            this.Tsm_Mute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Tsm_Mute.Image = global::MGS_Keyboard_RFID_Scanner.Properties.Resources.volume1;
            this.Tsm_Mute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsm_Mute.Name = "Tsm_Mute";
            this.Tsm_Mute.Size = new System.Drawing.Size(36, 36);
            this.Tsm_Mute.Text = "Mute";
            this.Tsm_Mute.Click += new System.EventHandler(this.Tsm_Mute_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // TSB_Settings
            // 
            this.TSB_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_Settings.Image = global::MGS_Keyboard_RFID_Scanner.Properties.Resources.config_tool_icon_light_gray;
            this.TSB_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_Settings.Name = "TSB_Settings";
            this.TSB_Settings.Size = new System.Drawing.Size(36, 36);
            this.TSB_Settings.ToolTipText = "Settings";
            this.TSB_Settings.Click += new System.EventHandler(this.TSB_params_Click);
            // 
            // TSB_info
            // 
            this.TSB_info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_info.Image = global::MGS_Keyboard_RFID_Scanner.Properties.Resources.MBL_about;
            this.TSB_info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_info.Name = "TSB_info";
            this.TSB_info.Size = new System.Drawing.Size(36, 36);
            this.TSB_info.ToolTipText = "Info";
            this.TSB_info.Click += new System.EventHandler(this.TSB_info_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // TSB_exit
            // 
            this.TSB_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSB_exit.Image = global::MGS_Keyboard_RFID_Scanner.Properties.Resources.Exit;
            this.TSB_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSB_exit.Name = "TSB_exit";
            this.TSB_exit.Size = new System.Drawing.Size(36, 36);
            this.TSB_exit.Text = "გამოსვლა";
            this.TSB_exit.ToolTipText = "Exit";
            this.TSB_exit.Click += new System.EventHandler(this.TSB_exit_Click);
            // 
            // Bt_Clear
            // 
            this.Bt_Clear.Location = new System.Drawing.Point(200, 60);
            this.Bt_Clear.Name = "Bt_Clear";
            this.Bt_Clear.Size = new System.Drawing.Size(63, 23);
            this.Bt_Clear.TabIndex = 1;
            this.Bt_Clear.Text = "Clear";
            this.Bt_Clear.UseVisualStyleBackColor = true;
            this.Bt_Clear.Click += new System.EventHandler(this.Bt_Clear_Click);
            // 
            // Rtb_Log
            // 
            this.Rtb_Log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rtb_Log.Location = new System.Drawing.Point(0, 0);
            this.Rtb_Log.Name = "Rtb_Log";
            this.Rtb_Log.Size = new System.Drawing.Size(521, 450);
            this.Rtb_Log.TabIndex = 0;
            this.Rtb_Log.Text = "";
            // 
            // MySerialPort
            // 
            this.MySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.MySerialPort_DataReceived);
            // 
            // TmrSend
            // 
            this.TmrSend.Enabled = true;
            this.TmrSend.Interval = 300;
            this.TmrSend.Tick += new System.EventHandler(this.TmrSend_Tick);
            // 
            // TmrCheck
            // 
            this.TmrCheck.Interval = 300;
            this.TmrCheck.Tick += new System.EventHandler(this.TmrCheck_Tick);
            // 
            // MyNotifyIcon
            // 
            this.MyNotifyIcon.BalloonTipTitle = "MGS Keyboard RFID Scanner";
            this.MyNotifyIcon.ContextMenuStrip = this.Cm_Notify;
            this.MyNotifyIcon.Text = "MGS Keyboard RFID Scanner";
            this.MyNotifyIcon.Visible = true;
            this.MyNotifyIcon.BalloonTipClicked += new System.EventHandler(this.MyNotifyIcon_BalloonTipClicked);
            this.MyNotifyIcon.DoubleClick += new System.EventHandler(this.MyNotifyIcon_DoubleClick);
            // 
            // Cm_Notify
            // 
            this.Cm_Notify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.Cm_Notify.Name = "Cm_Notify";
            this.Cm_Notify.Size = new System.Drawing.Size(107, 48);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Image = global::MGS_Keyboard_RFID_Scanner.Properties.Resources.application_side_tree;
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.ResizeToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::MGS_Keyboard_RFID_Scanner.Properties.Resources.Exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // TmpStart
            // 
            this.TmpStart.Tick += new System.EventHandler(this.TmpStart_Tick);
            // 
            // TmrBeep
            // 
            this.TmrBeep.Interval = 10000;
            this.TmrBeep.Tick += new System.EventHandler(this.TmrBeep_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "MGS Keyboard RFID Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ToolStrip1.ResumeLayout(false);
            this.ToolStrip1.PerformLayout();
            this.Cm_Notify.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Bt_LogFolder;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Bt_Clear;
        private System.Windows.Forms.RichTextBox Rtb_Log;
        internal System.Windows.Forms.ToolStrip ToolStrip1;
        internal System.Windows.Forms.ToolStripButton TSB_Settings;
        internal System.Windows.Forms.ToolStripButton TSB_RS232;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripButton TSB_info;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        internal System.Windows.Forms.ToolStripButton TSB_exit;
        private System.IO.Ports.SerialPort MySerialPort;
        private System.Windows.Forms.Timer TmrSend;
        private System.Windows.Forms.Timer TmrCheck;
        private System.Windows.Forms.NotifyIcon MyNotifyIcon;
        private System.Windows.Forms.ContextMenuStrip Cm_Notify;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer TmpStart;
        private System.Windows.Forms.Timer TmrBeep;
        private System.Windows.Forms.ToolStripButton Tsb_Sound;
        private System.Windows.Forms.ToolStripButton Tsm_Mute;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

