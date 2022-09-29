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
using PL.iSub;
using DAL.Db;

namespace PL.Sub
{
    public partial class frmPSociete : iFormList
    {
        #region Variables
        sysSalesEntities db = new sysSalesEntities();
        #endregion Variables
        #region Override
        public override void getData()
        {
            gcSos.DataSource = db.Select_Entreprise_Info();
        }
        public override void OpenForm()
        {
            frmPSocieteAjouter frm = new frmPSocieteAjouter();
            frm.ShowDialog();
        }
        #endregion Override
        public frmPSociete()
        {
            InitializeComponent();
        }
    }
}