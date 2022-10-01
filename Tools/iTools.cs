using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace Tools
{
    public class iTools
    {
        public static string getDate()
        {
            DateTime dt = DateTime.Now;
            return dt.ToString("dd/MM/yyyy");
        }
        public static DateTime getDateNow()
        {
            return DateTime.Now;
        }
        public static void msgBox(string msg)
        {
            XtraMessageBox.Show(msg);
        }
        public static void msgBox(string msg, string title)
        {
            XtraMessageBox.Show(msg, title, MessageBoxButtons.OK);
        }
        public static void msgBox(string msg, string title, MessageBoxButtons button)
        {
            XtraMessageBox.Show(msg, title, button);
        }
        public static void msgBox(string msg, string title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            XtraMessageBox.Show(msg, title, button, icon);
        }
    }
}