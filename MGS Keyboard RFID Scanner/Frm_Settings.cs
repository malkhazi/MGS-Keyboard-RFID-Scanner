using MGS_Keyboard_RFID_Scanner.Properties;
using Microsoft.Win32;
using System;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;


namespace MGS_Keyboard_RFID_Scanner
{
    public partial class Frm_Settings : Form
    {
        private string[] myPorts;
        private int crPort = -1;
        private string InTxt = "";
        private string FPortName = "";
        private int Tmr2_tik = 0;

        public Frm_Settings()
        {
            InitializeComponent();
        }

        private void Frm_Settings_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.AppIcon;
            this.Chk_AutStart.Checked = GV.ReadAtStartup(Application.ProductName, Application.ExecutablePath);
            Upd_Coms();

            foreach (string crt1 in Enum.GetNames(typeof(Parity)))
            {
                this.ParityCombo.Items.Add(crt1);
            }
            this.DataBitsCombo.Items.Add("5");
            this.DataBitsCombo.Items.Add("6");
            this.DataBitsCombo.Items.Add("7");
            this.DataBitsCombo.Items.Add("8");
            foreach (string crt1 in Enum.GetNames(typeof(StopBits)))
            {
                this.StopBitsCombo.Items.Add(crt1);
            }
            foreach (string crt1 in Enum.GetNames(typeof(Handshake)))
            {
                this.HandshakeCombo.Items.Add(crt1);
            }

            this.Chk_LogSave.Checked = bool.Parse(GV.My_Get_Setting("Flg_LogSave", "false"));

            string prt_nm1 = GV.My_Get_Setting("PortName", "");
            if (prt_nm1.Trim().Length > 0)
            {
                this.Cmb_ports.Text = prt_nm1;
            }
            this.Chk_RTS.Checked = bool.Parse(GV.My_Get_Setting("chk_RTS", "false"));
            this.Chk_DTR.Checked = bool.Parse(GV.My_Get_Setting("chk_DTR", "false"));

            this.StopBitsCombo.Text = GV.My_Get_Setting("StopBits", "One");
            this.DataBitsCombo.Text = GV.My_Get_Setting("DataBits", "8");
            this.ParityCombo.Text = GV.My_Get_Setting("Parity", "None");
            this.HandshakeCombo.Text = GV.My_Get_Setting("Handshake", "NONE");
            this.Cmb_BaudRate.Text = GV.My_Get_Setting("BaudRate", "9600");

            this.Tb_FirstChar.Text = GV.My_Get_Setting("FirstChar", "0x13");
            this.Tb_LastChar.Text = GV.My_Get_Setting("LastChar", "0x14");

            this.Tb_CheckRs232Interval.Text = (int)(int.Parse(GV.My_Get_Setting("CheckRs232Interval", "10000")) / 1000) + "";
            this.Tb_ReCheckRs232Count.Text = GV.My_Get_Setting("ReCheckRs232Count", "3");
            this.Tb_ReCheckRs232Interval.Text = (int)(int.Parse(GV.My_Get_Setting("ReCheckRs232Interval", "5000")) / 1000) + "";
            this.Tb_Rs232Delay.Text = GV.My_Get_Setting("Rs232Delay", "500");
        }

        private void Bt_shenaxva_Click(object sender, EventArgs e)
        {
            GV.My_Save_Setting("PortName", this.Cmb_ports.Text.Trim());
            GV.My_Save_Setting("StopBits", this.StopBitsCombo.Text.Trim());
            GV.My_Save_Setting("DataBits", this.DataBitsCombo.Text.Trim());
            GV.My_Save_Setting("Parity", this.ParityCombo.Text.Trim());
            GV.My_Save_Setting("Handshake", this.HandshakeCombo.Text.Trim());
            GV.My_Save_Setting("BaudRate", this.Cmb_BaudRate.Text.Trim());

            GV.My_Save_Setting("chk_RTS", this.Chk_RTS.Checked.ToString());
            GV.My_Save_Setting("chk_DTR", this.Chk_DTR.Checked.ToString());

            GV.My_Save_Setting("FirstChar", this.Tb_FirstChar.Text.Trim());
            GV.My_Save_Setting("LastChar", this.Tb_LastChar.Text.Trim());

            GV.My_Save_Setting("Flg_LogSave", this.Chk_LogSave.Checked.ToString());


            GV.My_Save_Setting("CheckRs232Interval", int.Parse(this.Tb_CheckRs232Interval.Text) * 1000 + "");
            GV.My_Save_Setting("ReCheckRs232Count", int.Parse(this.Tb_ReCheckRs232Count.Text) + "");
            GV.My_Save_Setting("ReCheckRs232Interval", int.Parse(this.Tb_ReCheckRs232Interval.Text) * 1000 + "");
            GV.My_Save_Setting("Rs232Delay", int.Parse(this.Tb_Rs232Delay.Text) + "");




            if (this.Chk_AutStart.Checked)
            {
                RunAtStartup(Application.ProductName, Application.ExecutablePath);
            }
            else
            {
                RemoveValue(Application.ProductName);
            }
            this.DialogResult = DialogResult.OK;
        }

        private void RunAtStartup(string ApplicationName, string ApplicationPath)
        {
            RegistryKey CU = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            CU.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            CU.SetValue(ApplicationName, ApplicationPath);
        }

        private void RemoveValue(string ApplicationName)
        {
            RegistryKey CU = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            CU.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            CU.DeleteValue(ApplicationName, false);
        }

        private void Bt_upd1_Click(object sender, EventArgs e)
        {
            Upd_Coms();
        }

        private void Upd_Coms()
        {
            string prt_name = this.Cmb_ports.Text.Trim().Length > 0 ? this.Cmb_ports.Text.Trim() : "";
            this.Cmb_ports.Items.Clear();
            myPorts = System.IO.Ports.SerialPort.GetPortNames();
            this.Cmb_ports.Items.AddRange(myPorts);
            if (prt_name.Length > 0)
            {
                foreach (string portname in myPorts)
                {
                    if (portname.Trim() == prt_name)
                    {
                        this.Cmb_ports.Text = portname.Trim();
                        break;
                    }
                }
            }
        }



        private void Bt_shemowmeba_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.Cmb_ports.SelectedIndex >= 0)
                {
                    MySerialPort.PortName = this.Cmb_ports.Text.Trim();
                    MySerialPort.BaudRate = int.Parse(this.Cmb_BaudRate.Text);
                    MySerialPort.DataBits = int.Parse(this.DataBitsCombo.Text);
                    MySerialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.StopBitsCombo.Text, true);
                    MySerialPort.Parity = (Parity)Enum.Parse(typeof(Parity), this.ParityCombo.Text, true);
                    MySerialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), this.HandshakeCombo.Text, true);
                    try
                    {
                        MySerialPort.Open();
                        InTxt = "";
                        Tmr2_tik = 0;
                        this.Timer2.Enabled = true;
                        MySerialPort.Write(GV.Bt_Check, 0, GV.Bt_Check.Length);
                    }
                    catch (Exception Ex1)
                    {
                        MessageBox.Show(Ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Indicate the port name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Bt_AutoFind_Click(object sender, EventArgs e)
        {
            FPortName = "";
            try
            {
                Upd_Coms();
                MySerialPort.BaudRate = int.Parse(this.Cmb_BaudRate.Text);
                MySerialPort.DataBits = int.Parse(this.DataBitsCombo.Text);
                MySerialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), this.StopBitsCombo.Text, true);
                MySerialPort.Parity = (Parity)Enum.Parse(typeof(Parity), this.ParityCombo.Text, true);
                MySerialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), this.HandshakeCombo.Text, true);
                this.Bt_AutoFind.Enabled = false;
                if (myPorts.Length > 0)
                {
                    crPort = 0;
                    MySerialPort.PortName = myPorts[crPort];
                    this.Bt_AutoFind.Text = MySerialPort.PortName;
                    try
                    {
                        MySerialPort.Open();
                        InTxt = "";
                        MySerialPort.Write(GV.Bt_Check, 0, GV.Bt_Check.Length);
                    }
                    catch (Exception)
                    {
                    }
                    this.Timer1.Enabled = true;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (MySerialPort.IsOpen)
                MySerialPort.Close();
            if (FPortName.Length > 0)
            {
                this.Cmb_ports.Text = FPortName;
                this.Timer1.Enabled = false;
                this.Bt_AutoFind.Enabled = true;
                this.Bt_AutoFind.Text = "Auto Find";
                return;
            }
            if (crPort < 0)
                return;
            if (crPort >= myPorts.Length - 1)
            {
                this.Timer1.Enabled = false;
                this.Bt_AutoFind.Enabled = true;
                this.Bt_AutoFind.Text = "Auto Find";
                return;
            }
            crPort++;
            MySerialPort.PortName = myPorts[crPort];
            try
            {
                MySerialPort.Open();
                this.Bt_AutoFind.Text = MySerialPort.PortName;
                InTxt = "";
                MySerialPort.Write(GV.Bt_Check, 0, GV.Bt_Check.Length);
            }
            catch (Exception)
            {
            }
        }

        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int PacketSize = MySerialPort.BytesToRead;
            if (PacketSize > 0)
            {
                byte[] c_Buffer = new byte[PacketSize];
                MySerialPort.Read(c_Buffer, 0, PacketSize);
                InTxt += Encoding.ASCII.GetString(c_Buffer);
                if (InTxt.Trim() == "<I_AmRFIDScanner>")
                {
                    FPortName = ((SerialPort)sender).PortName;
                }
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (Tmr2_tik > 20)
            {
                Timer2.Enabled = false;
                if (MySerialPort.IsOpen)
                    MySerialPort.Close();
                MessageBox.Show("The port is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (FPortName.Length > 0)
                {
                    Timer2.Enabled = false;
                    MessageBox.Show("connection successful.", "it's okay", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MySerialPort.Close();
                }
            }

        }

    }
}
