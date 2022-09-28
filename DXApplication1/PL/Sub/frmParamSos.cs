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
using DAL.Db;
using PL.iSub;
using PL.Main;

namespace PL.Sub
{
    public partial class frmParamSos : iFrmList
    {
        #region Variables
        private sysSalesEntities db = new sysSalesEntities();
        frmMain f;
        #endregion Variables

        #region Override
        public override void LoadData()
        {
            gcSocietes.DataSource = db.Select_Entreprise_Info();
        }
        public override void OpenForm(XtraForm formulaire, Panel panel)
        {
            frmParamSosNew frm = new frmParamSosNew();
            frm.ShowDialog();
        }
        public override void Titre(string txt)
        {
            base.Titre(Text);
        }
        #endregion Override

        public frmParamSos(frmMain main)
        {
            InitializeComponent();
            f = main;
        }

        private void frmParamSos_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}