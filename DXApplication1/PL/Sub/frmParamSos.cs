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

namespace PL.Sub
{
    public partial class frmParamSos : iFrm
    {
        #region Variables
        private sysSalesEntities db = new sysSalesEntities();
        #endregion Variables

        #region Override
        public override void LoadData()
        {
            gcSocietes.DataSource = db.Select_Entreprise_Info();
        }
        #endregion Override

        public frmParamSos()
        {
            InitializeComponent();
        }

        private void frmParamSos_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}