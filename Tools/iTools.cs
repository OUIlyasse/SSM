using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static void OpenForm(XtraForm formulaire, Panel panelContenant)
        {
            //panelContenant.Controls.Clear();
            formulaire.FormBorderStyle = FormBorderStyle.None;
            formulaire.Dock = DockStyle.Fill;
            formulaire.TopLevel = false;
            panelContenant.Controls.Add(formulaire);
            formulaire.Visible = true;
        }
    }
}