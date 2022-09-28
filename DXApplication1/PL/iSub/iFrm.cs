using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PL.iSub
{
    public partial class iFrm : DevExpress.XtraEditors.XtraForm
    {
        #region Codes
        public virtual void LoadData()
        {
        }
        #endregion Codes
        public iFrm()
        {
            InitializeComponent();
        }

        private void iFrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}