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
using Tools;

namespace PL.iSub
{
    public partial class iFrmList : DevExpress.XtraEditors.XtraForm
    {
        #region Variables
        XtraForm form;
        Panel pnl;
        #endregion Variables
        #region Codes
        public virtual void LoadData()
        {
        }
        public virtual void OpenForm(XtraForm formulaire, Panel panel)
        {
            formulaire.ShowDialog();
        }
        public virtual void Titre(string txt)
        {
            lblTitre.Text = txt;
        }
        #endregion Codes
        public iFrmList()
        {
            InitializeComponent();
        }

        private void iFrm_Load(object sender, EventArgs e)
        {
            LoadData();
            Titre("");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            iTools.OpenForm(form, pnl);
        }
    }
}