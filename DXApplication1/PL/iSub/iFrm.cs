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
        public virtual void Add_Data()
        {
        }
        public virtual void Update_Data()
        {
        }
        public virtual void Delete_Data()
        {
        }
        public virtual void Titre(string txt)
        {
            lblTitre.Text = txt;
        }
        #endregion Codes
        public iFrm()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Add_Data();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Update_Data();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_Data();
        }

        private void iFrm_Load(object sender, EventArgs e)
        {
            Titre("");
        }
    }
}