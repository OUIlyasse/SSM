using DAL.Db;
using PL.iSub;
using System.Linq;

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
            frmPSocieteAjouter frm = new frmPSocieteAjouter(this);
            frm.Text = "Ajouter une Sosiètè";
            frm.ShowDialog();
        }
        #endregion Override
        public frmPSociete()
        {
            InitializeComponent();
        }

        private void gvSos_DoubleClick(object sender, System.EventArgs e)
        {
            if (gvSos.RowCount > 0)
            {
                var row = gvSos.FocusedRowHandle;
                string name = gvSos.GetRowCellValue(row, "entr_Nom").ToString();
                Entreprise_Info ei = db.Select_Entreprise_Info_By_Name(name).FirstOrDefault();
                frmPSocieteAjouter frm = new frmPSocieteAjouter(this, ei.entr_Code, ei.entr_Nom, ei.entr_Adresse, ei.entr_Ville, ei.entr_Code_Postal, ei.entr_Pays, ei.entr_Tele1, ei.entr_Tele2, ei.entr_Whatsapp, ei.entr_Fax, ei.entr_Email, ei.entr_Note);
                frm.Text = "Modifier la Sociètè";
                frm.ShowDialog();
            }
        }
    }
}