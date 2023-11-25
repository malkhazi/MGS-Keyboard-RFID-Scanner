namespace MGS_Keyboard_RFID_Scanner
{
    partial class Frm_Settings
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
            this.gb_Rs232 = new System.Windows.Forms.GroupBox();
            this.Bt_AutoFind = new System.Windows.Forms.Button();
            this.Chk_DTR = new System.Windows.Forms.CheckBox();
            this.Chk_RTS = new System.Windows.Forms.CheckBox();
            this.Bt_upd1 = new System.Windows.Forms.Button();
            this.Bt_Test = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.HandshakeCombo = new System.Windows.Forms.ComboBox();
            this.StopBitsCombo = new System.Windows.Forms.ComboBox();
            this.DataBitsCombo = new System.Windows.Forms.ComboBox();
            this.ParityCombo = new System.Windows.Forms.ComboBox();
            this.Cmb_BaudRate = new System.Windows.Forms.ComboBox();
            this.Cmb_ports = new System.Windows.Forms.ComboBox();
            this.Chk_AutStart = new System.Windows.Forms.CheckBox();
            this.Bt_Save = new System.Windows.Forms.Button();
            this.Chk_LogSave = new System.Windows.Forms.CheckBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.MySerialPort = new System.IO.Ports.SerialPort(this.components);
            this.Timer2 = new System.Windows.Forms.Timer(this.components);
            this.Tb_FirstChar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_LastChar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tb_CheckRs232Interval = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Tb_ReCheckRs232Count = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Tb_ReCheckRs232Interval = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Tb_Rs232Delay = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.gb_Rs232.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Rs232
            // 
            this.gb_Rs232.Controls.Add(this.Bt_AutoFind);
            this.gb_Rs232.Controls.Add(this.Chk_DTR);
            this.gb_Rs232.Controls.Add(this.Chk_RTS);
            this.gb_Rs232.Controls.Add(this.Bt_upd1);
            this.gb_Rs232.Controls.Add(this.Bt_Test);
            this.gb_Rs232.Controls.Add(this.Label5);
            this.gb_Rs232.Controls.Add(this.Label6);
            this.gb_Rs232.Controls.Add(this.Label7);
            this.gb_Rs232.Controls.Add(this.Label8);
            this.gb_Rs232.Controls.Add(this.Label9);
            this.gb_Rs232.Controls.Add(this.Label10);
            this.gb_Rs232.Controls.Add(this.HandshakeCombo);
            this.gb_Rs232.Controls.Add(this.StopBitsCombo);
            this.gb_Rs232.Controls.Add(this.DataBitsCombo);
            this.gb_Rs232.Controls.Add(this.ParityCombo);
            this.gb_Rs232.Controls.Add(this.Cmb_BaudRate);
            this.gb_Rs232.Controls.Add(this.Cmb_ports);
            this.gb_Rs232.Location = new System.Drawing.Point(68, 12);
            this.gb_Rs232.Name = "gb_Rs232";
            this.gb_Rs232.Size = new System.Drawing.Size(274, 242);
            this.gb_Rs232.TabIndex = 0;
            this.gb_Rs232.TabStop = false;
            this.gb_Rs232.Text = "RS232";
            // 
            // Bt_AutoFind
            // 
            this.Bt_AutoFind.Location = new System.Drawing.Point(20, 204);
            this.Bt_AutoFind.Name = "Bt_AutoFind";
            this.Bt_AutoFind.Size = new System.Drawing.Size(109, 23);
            this.Bt_AutoFind.TabIndex = 31;
            this.Bt_AutoFind.Text = "Auto Find";
            this.Bt_AutoFind.UseVisualStyleBackColor = true;
            this.Bt_AutoFind.Click += new System.EventHandler(this.Bt_AutoFind_Click);
            // 
            // Chk_DTR
            // 
            this.Chk_DTR.AutoSize = true;
            this.Chk_DTR.Location = new System.Drawing.Point(171, 181);
            this.Chk_DTR.Name = "Chk_DTR";
            this.Chk_DTR.Size = new System.Drawing.Size(49, 17);
            this.Chk_DTR.TabIndex = 8;
            this.Chk_DTR.Text = "DTR";
            this.Chk_DTR.UseVisualStyleBackColor = true;
            // 
            // Chk_RTS
            // 
            this.Chk_RTS.AutoSize = true;
            this.Chk_RTS.Location = new System.Drawing.Point(114, 181);
            this.Chk_RTS.Name = "Chk_RTS";
            this.Chk_RTS.Size = new System.Drawing.Size(48, 17);
            this.Chk_RTS.TabIndex = 7;
            this.Chk_RTS.Text = "RTS";
            this.Chk_RTS.UseVisualStyleBackColor = true;
            // 
            // Bt_upd1
            // 
            this.Bt_upd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Bt_upd1.Image = global::MGS_Keyboard_RFID_Scanner.Properties.Resources.arrow_refresh;
            this.Bt_upd1.Location = new System.Drawing.Point(5, 11);
            this.Bt_upd1.Name = "Bt_upd1";
            this.Bt_upd1.Size = new System.Drawing.Size(23, 23);
            this.Bt_upd1.TabIndex = 12;
            this.Bt_upd1.UseVisualStyleBackColor = true;
            this.Bt_upd1.Click += new System.EventHandler(this.Bt_upd1_Click);
            // 
            // Bt_Test
            // 
            this.Bt_Test.Location = new System.Drawing.Point(151, 204);
            this.Bt_Test.Name = "Bt_Test";
            this.Bt_Test.Size = new System.Drawing.Size(75, 23);
            this.Bt_Test.TabIndex = 9;
            this.Bt_Test.Text = "Test";
            this.Bt_Test.UseVisualStyleBackColor = true;
            this.Bt_Test.Click += new System.EventHandler(this.Bt_shemowmeba_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(33, 42);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(58, 13);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "BaudRate:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(62, 15);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(29, 13);
            this.Label6.TabIndex = 10;
            this.Label6.Text = "Port:";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(26, 150);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(65, 13);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Handshake:";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(39, 123);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(52, 13);
            this.Label8.TabIndex = 7;
            this.Label8.Text = "Stop Bits:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(38, 96);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(53, 13);
            this.Label9.TabIndex = 8;
            this.Label9.Text = "Data Bits:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(55, 69);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(36, 13);
            this.Label10.TabIndex = 9;
            this.Label10.Text = "Parity:";
            // 
            // HandshakeCombo
            // 
            this.HandshakeCombo.FormattingEnabled = true;
            this.HandshakeCombo.Location = new System.Drawing.Point(97, 147);
            this.HandshakeCombo.Name = "HandshakeCombo";
            this.HandshakeCombo.Size = new System.Drawing.Size(146, 21);
            this.HandshakeCombo.TabIndex = 5;
            // 
            // StopBitsCombo
            // 
            this.StopBitsCombo.FormattingEnabled = true;
            this.StopBitsCombo.Location = new System.Drawing.Point(97, 120);
            this.StopBitsCombo.Name = "StopBitsCombo";
            this.StopBitsCombo.Size = new System.Drawing.Size(146, 21);
            this.StopBitsCombo.TabIndex = 4;
            // 
            // DataBitsCombo
            // 
            this.DataBitsCombo.FormattingEnabled = true;
            this.DataBitsCombo.Location = new System.Drawing.Point(97, 93);
            this.DataBitsCombo.Name = "DataBitsCombo";
            this.DataBitsCombo.Size = new System.Drawing.Size(146, 21);
            this.DataBitsCombo.TabIndex = 3;
            // 
            // ParityCombo
            // 
            this.ParityCombo.FormattingEnabled = true;
            this.ParityCombo.Location = new System.Drawing.Point(97, 66);
            this.ParityCombo.Name = "ParityCombo";
            this.ParityCombo.Size = new System.Drawing.Size(146, 21);
            this.ParityCombo.TabIndex = 2;
            // 
            // Cmb_BaudRate
            // 
            this.Cmb_BaudRate.FormattingEnabled = true;
            this.Cmb_BaudRate.Items.AddRange(new object[] {
            "75",
            "100",
            "134",
            "150",
            "300",
            "600",
            "1200",
            "1800",
            "2400",
            "4800",
            "7200",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000"});
            this.Cmb_BaudRate.Location = new System.Drawing.Point(97, 38);
            this.Cmb_BaudRate.Name = "Cmb_BaudRate";
            this.Cmb_BaudRate.Size = new System.Drawing.Size(146, 21);
            this.Cmb_BaudRate.TabIndex = 1;
            // 
            // Cmb_ports
            // 
            this.Cmb_ports.FormattingEnabled = true;
            this.Cmb_ports.Location = new System.Drawing.Point(97, 11);
            this.Cmb_ports.Name = "Cmb_ports";
            this.Cmb_ports.Size = new System.Drawing.Size(146, 21);
            this.Cmb_ports.TabIndex = 0;
            // 
            // Chk_AutStart
            // 
            this.Chk_AutStart.AutoSize = true;
            this.Chk_AutStart.Location = new System.Drawing.Point(255, 442);
            this.Chk_AutStart.Name = "Chk_AutStart";
            this.Chk_AutStart.Size = new System.Drawing.Size(73, 17);
            this.Chk_AutStart.TabIndex = 1;
            this.Chk_AutStart.Text = "Auto Start";
            this.Chk_AutStart.UseVisualStyleBackColor = true;
            // 
            // Bt_Save
            // 
            this.Bt_Save.Location = new System.Drawing.Point(182, 478);
            this.Bt_Save.Name = "Bt_Save";
            this.Bt_Save.Size = new System.Drawing.Size(75, 23);
            this.Bt_Save.TabIndex = 3;
            this.Bt_Save.Text = "Save";
            this.Bt_Save.UseVisualStyleBackColor = true;
            this.Bt_Save.Click += new System.EventHandler(this.Bt_shenaxva_Click);
            // 
            // Chk_LogSave
            // 
            this.Chk_LogSave.AutoSize = true;
            this.Chk_LogSave.Location = new System.Drawing.Point(110, 442);
            this.Chk_LogSave.Name = "Chk_LogSave";
            this.Chk_LogSave.Size = new System.Drawing.Size(106, 17);
            this.Chk_LogSave.TabIndex = 2;
            this.Chk_LogSave.Text = "Log View / Save";
            this.Chk_LogSave.UseVisualStyleBackColor = true;
            // 
            // Timer1
            // 
            this.Timer1.Interval = 500;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MySerialPort
            // 
            this.MySerialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.MySerialPort_DataReceived);
            // 
            // Timer2
            // 
            this.Timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Tb_FirstChar
            // 
            this.Tb_FirstChar.Location = new System.Drawing.Point(126, 270);
            this.Tb_FirstChar.Name = "Tb_FirstChar";
            this.Tb_FirstChar.Size = new System.Drawing.Size(58, 20);
            this.Tb_FirstChar.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "First char:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Last char:";
            // 
            // Tb_LastChar
            // 
            this.Tb_LastChar.Location = new System.Drawing.Point(277, 270);
            this.Tb_LastChar.Name = "Tb_LastChar";
            this.Tb_LastChar.Size = new System.Drawing.Size(58, 20);
            this.Tb_LastChar.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "* For special characters use the prefix 0x and Hex character code";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // Tb_CheckRs232Interval
            // 
            this.Tb_CheckRs232Interval.Location = new System.Drawing.Point(236, 328);
            this.Tb_CheckRs232Interval.Name = "Tb_CheckRs232Interval";
            this.Tb_CheckRs232Interval.Size = new System.Drawing.Size(58, 20);
            this.Tb_CheckRs232Interval.TabIndex = 4;
            this.Tb_CheckRs232Interval.Text = "0";
            this.Tb_CheckRs232Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Check RFID connection after";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(300, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "seconds";
            // 
            // Tb_ReCheckRs232Count
            // 
            this.Tb_ReCheckRs232Count.Location = new System.Drawing.Point(236, 354);
            this.Tb_ReCheckRs232Count.Name = "Tb_ReCheckRs232Count";
            this.Tb_ReCheckRs232Count.Size = new System.Drawing.Size(58, 20);
            this.Tb_ReCheckRs232Count.TabIndex = 4;
            this.Tb_ReCheckRs232Count.Text = "0";
            this.Tb_ReCheckRs232Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 357);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Number of failed connection attempts:";
            // 
            // Tb_ReCheckRs232Interval
            // 
            this.Tb_ReCheckRs232Interval.Location = new System.Drawing.Point(236, 380);
            this.Tb_ReCheckRs232Interval.Name = "Tb_ReCheckRs232Interval";
            this.Tb_ReCheckRs232Interval.Size = new System.Drawing.Size(58, 20);
            this.Tb_ReCheckRs232Interval.TabIndex = 4;
            this.Tb_ReCheckRs232Interval.Text = "0";
            this.Tb_ReCheckRs232Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "If the connection fails, try again after";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(300, 383);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "seconds";
            // 
            // Tb_Rs232Delay
            // 
            this.Tb_Rs232Delay.Location = new System.Drawing.Point(236, 406);
            this.Tb_Rs232Delay.Name = "Tb_Rs232Delay";
            this.Tb_Rs232Delay.Size = new System.Drawing.Size(58, 20);
            this.Tb_Rs232Delay.TabIndex = 4;
            this.Tb_Rs232Delay.Text = "0";
            this.Tb_Rs232Delay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(107, 409);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 13);
            this.label15.TabIndex = 5;
            this.label15.Text = "RS232 response timeout";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(300, 409);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 5;
            this.label16.Text = "milliseconds";
            // 
            // Frm_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 517);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_LastChar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_ReCheckRs232Count);
            this.Controls.Add(this.Tb_Rs232Delay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_ReCheckRs232Interval);
            this.Controls.Add(this.Tb_CheckRs232Interval);
            this.Controls.Add(this.Tb_FirstChar);
            this.Controls.Add(this.Chk_LogSave);
            this.Controls.Add(this.Bt_Save);
            this.Controls.Add(this.Chk_AutStart);
            this.Controls.Add(this.gb_Rs232);
            this.Name = "Frm_Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Frm_Settings_Load);
            this.gb_Rs232.ResumeLayout(false);
            this.gb_Rs232.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox gb_Rs232;
        internal System.Windows.Forms.Button Bt_upd1;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.ComboBox HandshakeCombo;
        internal System.Windows.Forms.ComboBox StopBitsCombo;
        internal System.Windows.Forms.ComboBox DataBitsCombo;
        internal System.Windows.Forms.ComboBox ParityCombo;
        internal System.Windows.Forms.ComboBox Cmb_BaudRate;
        internal System.Windows.Forms.ComboBox Cmb_ports;
        internal System.Windows.Forms.CheckBox Chk_AutStart;
        internal System.Windows.Forms.Button Bt_Save;
        internal System.Windows.Forms.CheckBox Chk_LogSave;
        internal System.Windows.Forms.Button Bt_AutoFind;
        internal System.Windows.Forms.CheckBox Chk_DTR;
        internal System.Windows.Forms.CheckBox Chk_RTS;
        internal System.Windows.Forms.Button Bt_Test;
        private System.Windows.Forms.Timer Timer1;
        private System.IO.Ports.SerialPort MySerialPort;
        private System.Windows.Forms.Timer Timer2;
        private System.Windows.Forms.TextBox Tb_FirstChar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_LastChar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Tb_CheckRs232Interval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Tb_ReCheckRs232Count;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Tb_ReCheckRs232Interval;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Tb_Rs232Delay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}