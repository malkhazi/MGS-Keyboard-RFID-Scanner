using MGS_Keyboard_RFID_Scanner.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace MGS_Keyboard_RFID_Scanner
{
    public partial class Form1 : Form
    {
        private readonly string[] Sp_Smb = { "NUL", "SOH", "STX", "ETX", "EOT", "ENQ", "ACK", "BEL", "BS", "TAB", "LF", "VT",
            "FF", "CR", "SO", "SI", "DLE", "DC1", "DC2", "DC3", "DC4", "NAK", "SYN", "ETB", "CAN", "EM", "SUB", "ESC",
            "FS", "CS", "RS", "US", "Sp" };
        private DateTime OldTextDatetime = DateTime.Now;
        private DateTime CheckDelayRs232Datetime = DateTime.Now;
        private DateTime ReCheckRs232Datetime = DateTime.Now;
        private int CheckRs232Interval = 10000;
        private int ReCheckRs232Interval = 500;
        private int ReCheckRs232Index = 0;
        private int ReCheckRs232Count = 3;
        private bool CheckConnect = false;
        private bool CheckDelay = true;
        private int Rs232Delay = 500;
        private string InText = "";
        private bool RfidError = false;
        List<RFIDitems> rFIDitems = new List<RFIDitems>();
        private bool cflg_Exit = false;
        private bool cflg_mute = false;

        private delegate void SetTextCallbackByte(SerialPort sender, string txt_Data, byte[] byte_Data, Inf_Type in_out);

        enum Inf_Type
        {
            IN,
            Out,
            Error,
            Info
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = Resources.AppIcon;
            this.MyNotifyIcon.Icon = Resources.AppIcon;
            string t1 = "345734756>";
            string txt_pack = t1.Substring(0, t1.IndexOf('>'));
            bool isNumeric = int.TryParse("123", out int n);
            Init_My();
            TmpStart.Enabled = true;
        }

        private void Bt_LogFolder_Click(object sender, EventArgs e)
        {
            string dir_nm = string.Format("{0}Log\\", AppDomain.CurrentDomain.BaseDirectory);
            if (!Directory.Exists(Path.GetDirectoryName(dir_nm)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dir_nm));
            }
            Process.Start("explorer.exe", (char)(34) + System.Windows.Forms.Application.StartupPath + @"\Log" + (char)(34));
        }

        private void Bt_Clear_Click(object sender, EventArgs e)
        {
            Sv_txt_file(this.Rtb_Log);
        }

        private void Sv_txt_file(RichTextBox p_txt2)
        {
            if (p_txt2.Text.Trim().Length > 0)
            {
                string fl_nm33 = string.Format("{0}Log\\Log_{1}.txt", AppDomain.CurrentDomain.BaseDirectory, DateTime.Now.ToString("yyyyMMddHHmmssfff"));
                if (!Directory.Exists(Path.GetDirectoryName(fl_nm33)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fl_nm33));
                }
                System.IO.File.WriteAllText(fl_nm33, p_txt2.Text);
                p_txt2.Text = "";
            }
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 aboutBox1 = new AboutBox1();
            aboutBox1.ShowDialog();
            aboutBox1.Dispose();
        }

        private void TSB_params_Click(object sender, EventArgs e)
        {
            this.TmrCheck.Enabled = false;
            Frm_Settings f_1 = new Frm_Settings();
            if (MySerialPort.IsOpen)
                MySerialPort.Close();
            if (f_1.ShowDialog() == DialogResult.OK)
            {
                Init_My();
                this.Close();
            }
            f_1.Dispose();
            Init_port();
        }

        private void Init_My()
        {
            Init_My(true);
        }
        private void Init_My(bool par1)
        {
            if (GV.My_Get_Setting("PortName", "").Trim().Length > 0)
            {
                string frst_ChStr = GV.My_Get_Setting("FirstChar", "0x13").Trim();
                char? ch_frst = null;
                if (frst_ChStr.Length > 2)
                {
                    if (frst_ChStr.Substring(0, 2).ToLower() == "0x")
                    {
                        frst_ChStr = frst_ChStr.Substring(2);
                        ch_frst = System.Convert.ToChar(System.Convert.ToUInt32(frst_ChStr, 16));
                    }
                    else
                    {
                        MessageBox.Show("The first character is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (frst_ChStr.Length == 1)
                {
                    ch_frst = char.Parse(frst_ChStr);
                }
                GV.RfidFirstChar = ch_frst;

                string lst_ChStr = GV.My_Get_Setting("LastChar", "0x14").Trim();
                char? ch_Lst = null;
                if (lst_ChStr.Length > 2)
                {
                    if (lst_ChStr.Substring(0, 2).ToLower() == "0x")
                    {
                        lst_ChStr = lst_ChStr.Substring(2);
                        ch_Lst = System.Convert.ToChar(System.Convert.ToUInt32(lst_ChStr, 16));
                    }
                    else
                    {
                        MessageBox.Show("The Last character is incorrect!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (lst_ChStr.Length == 1)
                {
                    ch_Lst = char.Parse(lst_ChStr);
                }
                GV.RfidLastChar = ch_Lst;

                CheckRs232Interval = (int)(int.Parse(GV.My_Get_Setting("CheckRs232Interval", "10000")) / 1000);
                ReCheckRs232Count = int.Parse(GV.My_Get_Setting("ReCheckRs232Count", "3"));
                ReCheckRs232Interval = (int)(int.Parse(GV.My_Get_Setting("ReCheckRs232Interval", "5000")) / 1000);
                Rs232Delay = int.Parse(GV.My_Get_Setting("Rs232Delay", "500"));

                Init_port();
            }
            else
            {
                if (par1)
                {
                    this.TmrCheck.Enabled = false;
                    Frm_Settings f_1 = new Frm_Settings();
                    if (MySerialPort.IsOpen)
                        MySerialPort.Close();
                    if (f_1.ShowDialog() == DialogResult.OK)
                    {
                        Init_My(false);
                    }
                    else
                    {
                        this.Close();
                        return;
                    }
                    f_1.Dispose();
                    Init_port();
                }
            }
        }

        private void Init_port()
        {
            string prt_nm1 = GV.My_Get_Setting("PortName", "");
            if (prt_nm1.Trim().Length > 0)
            {
                if (MySerialPort.IsOpen)
                {
                    MySerialPort.Close();
                }

                MySerialPort.PortName = prt_nm1;

                MySerialPort.RtsEnable = bool.Parse(GV.My_Get_Setting("chk_RTS", "false"));
                MySerialPort.DtrEnable = bool.Parse(GV.My_Get_Setting("chk_Dtr", "false"));

                GV.Flg_LogSave = bool.Parse(GV.My_Get_Setting("Flg_LogSave", "false"));

                GV.Flg_Encoding = GV.My_Get_Setting("Flg_Encoding", "");

                MySerialPort.BaudRate = int.Parse(GV.My_Get_Setting("BaudRate", "9600"));
                MySerialPort.DataBits = int.Parse(GV.My_Get_Setting("DataBits", "8"));
                MySerialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), GV.My_Get_Setting("StopBits", "1"));
                MySerialPort.Parity = (Parity)Enum.Parse(typeof(Parity), GV.My_Get_Setting("Parity", "NONE"));
                MySerialPort.Handshake = (Handshake)Enum.Parse(typeof(Handshake), GV.My_Get_Setting("Handshake", "NONE"));

                try
                {
                    MySerialPort.Open();
                    if (!bool.Parse(GV.My_Get_Setting("PortOpen", "true")))
                    {
                        MySerialPort.Close();
                        this.TSB_RS232.Image = Resources.disconnect;
                    }
                    else
                    {
                        this.TSB_RS232.Image = Resources.connect;
                        this.TmrCheck.Enabled = true;
                        RfidError = false;
                        MyNotifyIcon.BalloonTipText = "";
                        this.TmrBeep.Enabled = false;
                    }
                }
                catch (Exception Ex)
                {
                    this.TSB_RS232.Image = Resources.disconnect;
                    MessageBox.Show(Ex.Message + "\r\n" + Ex.StackTrace, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void Snd_arr_srl(SerialPort cr_srl, string snd_txt)
        {
            byte[] snd_bt;
            snd_bt = Encoding.ASCII.GetBytes(snd_txt);
            cr_srl.Write(snd_bt, 0, snd_bt.Length);
            Text_View(cr_srl, snd_bt, Inf_Type.Out);
        }

        private void TSB_RS232_Click(object sender, EventArgs e)
        {
            if (MySerialPort.IsOpen)
            {
                MySerialPort.Close();
                this.TSB_RS232.Image = Resources.disconnect;
                GV.My_Save_Setting("PortOpen", "false");
            }
            else
            {
                try
                {
                    MySerialPort.Open();
                    this.TSB_RS232.Image = Resources.connect;
                    GV.My_Save_Setting("PortOpen", "true");
                    ReCheckRs232Index = 0;
                    RfidError = false;
                    MyNotifyIcon.BalloonTipText = "";
                    this.TmrBeep.Enabled = false;
                }
                catch (Exception Ex1)
                {
                    MessageBox.Show(Ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void TSB_info_Click(object sender, EventArgs e)
        {
            Frm_Settings frm1 = new Frm_Settings();
            frm1.ShowDialog();
            frm1.Dispose();
        }

        private void TSB_exit_Click(object sender, EventArgs e)
        {
            cflg_Exit = true;
            this.Close();
        }
        private void My_New_line()
        {
            if (this.Rtb_Log.Lines.Count() > 0)
            {
                if (this.Rtb_Log.Lines[this.Rtb_Log.Lines.Count() - 1].Length > 0)
                {
                    this.Rtb_Log.Text += "\r\n";
                }
            }
            else
            {
                if (this.Rtb_Log.Text.Length > 0)
                {
                    this.Rtb_Log.Text += "\r\n";
                }
            }
        }

        private void Text_View(SerialPort sender, string txt_Data, byte[] byte_Data, Inf_Type in_out)
        {
            bool txt_sh8 = false;
            if (sender != null)
            {
                txt_sh8 = GV.Flg_LogSave;
            }
            if (in_out == Inf_Type.Info || in_out == Inf_Type.Error || txt_sh8)
            {
                try
                {
                    if (this.Rtb_Log.InvokeRequired)
                    {
                        SetTextCallbackByte d = new SetTextCallbackByte(Text_View);
                        this.Invoke(d, new object[] { sender, txt_Data, byte_Data, in_out });
                    }
                    else
                    {
                        if (this.Rtb_Log.Lines.Count() > 100)
                        {
                            Sv_txt_file(this.Rtb_Log);
                        }
                        string txt_cr1 = "";
                        if (in_out == Inf_Type.Info || in_out == Inf_Type.Error)
                        {
                            My_New_line();
                            this.Rtb_Log.Text += DateTime.Now.ToString("HH:mm:ss.fff") + "\t" + in_out.ToString() + "\t" + txt_Data + "\r\n";
                            return;
                        }
                        string dm_txt1 = "";
                        dm_txt1 += DateTime.Now.ToString("HH:mm:ss.fff") + "\t";

                        if (in_out == Inf_Type.IN)
                        {
                            dm_txt1 += "=>\t";
                        }
                        else if (in_out == Inf_Type.Out)
                        {
                            dm_txt1 += "<=\t";
                        }
                        else if (in_out == Inf_Type.Error)
                        {
                            dm_txt1 += "Er\t";
                        }
                        else
                        {
                            dm_txt1 += "==\t";
                        }

                        if (byte_Data != null)
                        {
                            txt_cr1 = Encoding.ASCII.GetString(byte_Data);
                            for (int i = 0; i < 33; i++)
                            {
                                txt_cr1 = txt_cr1.Replace(System.Convert.ToChar(i).ToString(), string.Format("<{0}>", Sp_Smb[i]));
                            }
                        }
                        else
                        {
                            for (int i = 0; i < byte_Data.Length; i++)
                            {
                                int cr_bt1 = byte_Data[i];
                                if (cr_bt1 < 33)
                                {
                                    txt_cr1 += string.Format("<{0}>", Sp_Smb[cr_bt1]);
                                }
                                else if (cr_bt1 > 126)
                                {
                                    txt_cr1 += string.Format("<0x{0}>", cr_bt1.ToString("X"));
                                }
                                else
                                {
                                    txt_cr1 += ((char)byte_Data[i]).ToString();
                                }
                            }
                        }
                        Boolean flg_NewLine = false;
                        if (txt_cr1.IndexOf(">") >= 0)
                        {
                            flg_NewLine = true;
                        }
                        if ((DateTime.Now - OldTextDatetime).TotalSeconds > 20)
                        {
                            flg_NewLine = true;
                        }
                        //int a11 = this.Rtb_Log.Lines[this.Rtb_Log.Lines.Length - 1].Trim().Length;
                        if (this.Rtb_Log.Lines.Length == 0 || this.Rtb_Log.Lines[this.Rtb_Log.Lines.Length - 1].Trim().Length == 0)
                        {
                            this.Rtb_Log.Text += dm_txt1;
                        }
                        this.Rtb_Log.Text += txt_cr1;
                        if (flg_NewLine)
                        {
                            My_New_line();
                        }
                    }
                }
                catch (Exception Ex1)
                {
                    Text_View(sender, Ex1.Message + "\r\n" + Ex1.StackTrace, Inf_Type.Error);
                }
            }
            OldTextDatetime = DateTime.Now;
        }

        private void Text_View(SerialPort sender, string txt_Data, Inf_Type in_out)
        {
            if (txt_Data.Length > 0)
            {
                Text_View(sender, txt_Data, null, in_out);
            }
        }

        private void Text_View(SerialPort sender, byte[] byte_Data, Inf_Type in_out)
        {
            if (byte_Data.Length > 0)
            {
                Text_View(sender, null, byte_Data, in_out);
            }
        }

        private void MySerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int PacketSize = MySerialPort.BytesToRead;
            if (PacketSize > 0)
            {
                byte[] c_Buffer = new byte[PacketSize];
                MySerialPort.Read(c_Buffer, 0, PacketSize);
                Text_View((SerialPort)sender, c_Buffer, Inf_Type.IN);
                if ((DateTime.Now - OldTextDatetime).TotalMilliseconds > Rs232Delay)
                {
                    InText = "";
                }
                InText += Encoding.ASCII.GetString(c_Buffer);
                string[] packets = InText.Split('<');
                for (int i = 0; i < packets.Length; i++)
                {
                    if (packets[i].Contains('>'))
                    {
                        if (packets[i].Trim() == "I_AmRFIDScanner>")
                        {
                            CheckConnect = true;
                        }
                        else
                        {
                            string txt_pack = packets[i].Substring(0, packets[i].IndexOf('>'));
                            long n1;
                            if (long.TryParse(txt_pack, out n1))
                            {
                                GV.AG_RfidID++;
                                rFIDitems.Add(new RFIDitems() { Id = GV.AG_RfidID, RFIDText = n1 });
                            }
                            packets[i] = "";
                        }
                        packets[i] = "";
                    }
                }
                if (packets[packets.Length - 1].Length > 0)
                {
                    InText = "<" + packets[packets.Length - 1];
                }
                else
                {
                    InText = "";
                }
            }

        }

        private void TmrSend_Tick(object sender, EventArgs e)
        {
            if (rFIDitems.Count > 0)
            {
                SendKeys.Send(GV.RfidFirstChar + rFIDitems[0].RFIDText.ToString() + GV.RfidLastChar);
                rFIDitems.Remove(new RFIDitems() { Id = rFIDitems[0].Id, RFIDText = rFIDitems[0].RFIDText });
            }
        }

        private void TmrCheck_Tick(object sender, EventArgs e)
        {
            if (CheckConnect)
            {
                CheckDelayRs232Datetime = DateTime.Now;
                CheckConnect = false;
                ReCheckRs232Index = 0;
                CheckDelay = true;
                return;
            }
            else if (CheckDelay)
            {
                if ((DateTime.Now - CheckDelayRs232Datetime).TotalMilliseconds > CheckRs232Interval)
                {
                    CheckDelay = false;
                    CheckDelayRs232Datetime = DateTime.Now;
                    ReCheckRs232Datetime = DateTime.Now;
                    MySerialPort.Write(GV.Bt_Check, 0, GV.Bt_Check.Length);
                }
            }
            else
            {
                if (ReCheckRs232Index <= ReCheckRs232Count)
                {
                    if ((DateTime.Now - ReCheckRs232Datetime).TotalMilliseconds > ReCheckRs232Interval && bool.Parse(GV.My_Get_Setting("PortOpen", "true")))
                    {
                        if (MySerialPort.IsOpen)
                            MySerialPort.Close();
                        try
                        {
                            MySerialPort.Open();
                            RfidError = false;
                            MyNotifyIcon.BalloonTipText = "";
                            this.TmrBeep.Enabled = false;
                            this.TSB_RS232.Image = Resources.connect;
                        }
                        catch (Exception)
                        {
                            this.TSB_RS232.Image = Resources.disconnect;
                        }
                        ReCheckRs232Index++;
                        ReCheckRs232Datetime = DateTime.Now;
                    }
                }
                else
                {
                    if (!RfidError)
                    {
                        RfidError = true;
                        MyNotifyIcon.BalloonTipText = "RFID device is not responding";
                        MyNotifyIcon.BalloonTipIcon = ToolTipIcon.Error;
                        MyNotifyIcon.ShowBalloonTip(30000);
                        Text_View(null, "RFID device is not responding", null, Inf_Type.Error);
                        this.TmrBeep.Enabled = true;
                    }
                }
                if ((DateTime.Now - CheckDelayRs232Datetime).TotalMilliseconds > CheckRs232Interval)
                {
                    CheckDelayRs232Datetime = DateTime.Now;
                    MySerialPort.Write(GV.Bt_Check, 0, GV.Bt_Check.Length);
                }
            }
        }

        private void ResizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            MyNotifyIcon.Visible = false;
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cflg_Exit = true;
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cflg_Exit)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MyNotifyIcon.Visible = true;
                this.Visible = false;
            }
        }

        private void MyNotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            MyNotifyIcon.Visible = false;
        }

        private void TmpStart_Tick(object sender, EventArgs e)
        {
            this.TmpStart.Enabled = false;
            if (!System.Diagnostics.Debugger.IsAttached)
            {
                MyNotifyIcon.Visible = true;
                this.Visible = false;
            }
        }

        private void MyNotifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            MyNotifyIcon.Visible = false;
        }

        private void TmrBeep_Tick(object sender, EventArgs e)
        {
            if (!cflg_mute)
            {
                System.Media.SystemSounds.Hand.Play();
            }
        }

        private void Tsb_Sound_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
        }

        private void Tsm_Mute_Click(object sender, EventArgs e)
        {
            if (cflg_mute)
            {
                cflg_mute = false;
                this.Tsm_Mute.Image = Resources.volume1;
            }
            else
            {
                cflg_mute = true;
                this.Tsm_Mute.Image = Resources.volume_mute1;
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                MyNotifyIcon.Visible = true;
                this.Visible = false;
            }
        }
    }
}
