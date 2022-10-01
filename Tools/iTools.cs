using DevExpress.XtraEditors;
using System;
using System.IO;
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
        public static DialogResult msgBox(string msg)
        {
            return XtraMessageBox.Show(msg);
        }
        public static DialogResult msgBox(string msg, string title)
        {
            return XtraMessageBox.Show(msg, title, MessageBoxButtons.OK);
        }
        public static DialogResult msgBox(string msg, string title, MessageBoxButtons button)
        {
            return XtraMessageBox.Show(msg, title, button);
        }
        public static DialogResult msgBox(string msg, string title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            return XtraMessageBox.Show(msg, title, button, icon);
        }
        public static byte[] ReadFile(string sPath)
        {
            byte[] data = null;
            try
            {
                FileInfo fInfo = new FileInfo(sPath);
                long numBytes = fInfo.Length;
                FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fStream);
                data = br.ReadBytes((int)numBytes);
            }
            catch (Exception ex)
            {
                msgBox(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return data;
        }
    }
}