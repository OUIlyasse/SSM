using DAL.Db;
using PL.iSub;
using System;
using System.Linq;

namespace PL.Sub
{
    public partial class frmAEntrepots : iFormList
    {
        #region Variables
        sysSalesEntities db = new sysSalesEntities();
        #endregion Variables
        #region Override
        public override void getData()
        {
            gcEntrepots.DataSource = db.Select_Branche();
        }
        public override void OpenForm()
        {
            frmAEntrepotsAjouter frm = new frmAEntrepotsAjouter(this);
            frm.Text = "Ajouter un entrepôt";
            frm.ShowDialog();
        }
        #endregion Override
        public frmAEntrepots()
        {
            InitializeComponent();
        }

        private void gvEntrepots_DoubleClick(object sender, System.EventArgs e)
        {
            if (gvEntrepots.RowCount > 0)
            {
                var row = gvEntrepots.FocusedRowHandle;
                string name = gvEntrepots.GetRowCellValue(row, "bran_Nom").ToString();
                Branche br = db.Select_Branche_By_Name(name).FirstOrDefault();
                frmAEntrepotsAjouter frm = new frmAEntrepotsAjouter(this, br.bran_Code, br.bran_Nom, br.bran_Adresse, br.bran_Ville, br.bran_Pays, br.bran_Tele, br.bran_Mobile, (DateTime)br.bran_Date_Creation, br.Entreprise_Info.entr_Nom, br.bran_Note);
                frm.Text = "Modifier cet entôpot";
                frm.ShowDialog();
            }
        }
    }
}