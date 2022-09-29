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
    }
}