using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGS_Keyboard_RFID_Scanner
{
    static class GV
    {
        public static int AG_RfidID = 0;
        public static bool Flg_LogSave;
        public static string Flg_Encoding;
        public static byte[] Bt_Check = Encoding.ASCII.GetBytes("<chek>");
        public static char? RfidFirstChar = (char)19;
        public static char? RfidLastChar = (char)20;

        public static bool ReadAtStartup(string ApplicationName, string ApplicationPath)
        {
            RegistryKey CU = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
            CU.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if ((string)CU.GetValue(ApplicationName, "") == ApplicationPath.ToString().Trim())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string My_Get_Setting(string myKey, string mValue)
        {
            return My_Get_Setting("", "", myKey, mValue);
        }

        public static string My_Get_Setting(string mgankof, string myKey, string mValue)
        {
            return My_Get_Setting("", mgankof, myKey, mValue);
        }

        public static string My_Get_Setting(string mseqcia, string mgankof, string myKey, string mValue)
        {
            string rez22;
            if (mseqcia.Length == 0)
            {
                mseqcia = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            }
            if (mgankof.Length == 0)
            {
                mgankof = "Setting";
            }
            try
            {
                string txt1 = "SOFTWARE" + char.ConvertFromUtf32(92) + "MGS" + char.ConvertFromUtf32(92) + mseqcia + char.ConvertFromUtf32(92) + mgankof;
                Microsoft.Win32.RegistryKey CU = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(txt1);
                CU.OpenSubKey(txt1, true);
                rez22 = (string)CU.GetValue(myKey, mValue);
            }
            catch (Exception ex)
            {
                rez22 = ex.Message;
            }
            return rez22;
        }

        public static string My_Save_Setting(string myKey, string mValue)
        {
            return My_Save_Setting("", "", myKey, mValue);
        }

        public static string My_Save_Setting(string mgankof, string myKey, string mValue)
        {
            return My_Save_Setting("", mgankof, myKey, mValue);
        }

        public static string My_Save_Setting(string mseqcia, string mgankof, string myKey, string mValue)
        {
            string rez22;
            if (mseqcia.Length == 0)
            {
                mseqcia = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            }
            if (mgankof.Length == 0)
            {
                mgankof = "Setting";
            }
            try
            {
                string txt1 = "SOFTWARE" + char.ConvertFromUtf32(92) + "MGS" + char.ConvertFromUtf32(92) + mseqcia + char.ConvertFromUtf32(92) + mgankof;
                Microsoft.Win32.RegistryKey CU = Microsoft.Win32.Registry.CurrentUser.CreateSubKey(txt1);
                CU.OpenSubKey(txt1, true);
                CU.SetValue(myKey, mValue);
                rez22 = mValue;
            }
            catch (Exception ex)
            {
                rez22 = ex.Message;
            }
            return rez22;
        }

        public static char[] Chk_Sum(string sak_txt1, int codir_typi1)
        {
            byte[] bts1;
            if (codir_typi1 == 1)
            {
                bts1 = Encoding.ASCII.GetBytes(sak_txt1);
            }
            else if (codir_typi1 == 2)
            {
                bts1 = Encoding.UTF8.GetBytes(sak_txt1);
            }
            else
            {
                bts1 = Encoding.Unicode.GetBytes(sak_txt1);
            }
            byte checksum = 0;
            foreach (byte crnt2 in bts1)
                checksum += crnt2;
            byte[] rez = new byte[1];
            rez[0] = checksum;
            return BitConverter.ToString(rez).ToCharArray();
        }

        public static byte Chk_SumB(byte[] bt_arr1)
        {
            byte clc_sum = 0;
            foreach (byte cr_bt1 in bt_arr1)
            {
                clc_sum += cr_bt1;
            }
            return clc_sum;
        }
    }
}
