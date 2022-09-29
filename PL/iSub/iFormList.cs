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
    public partial class iFormList : DevExpress.XtraEditors.XtraForm
    {
        #region Codes
        public virtual void OpenForm()
        {
        }
        public virtual void getData()
        {
        }
        #endregion Codes
        public iFormList()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            OpenForm();
        }

        private void iFormList_Load(object sender, EventArgs e)
        {
            getData();
        }
    }
}