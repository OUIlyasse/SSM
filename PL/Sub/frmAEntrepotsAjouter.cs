using DAL.Db;
using DevExpress.XtraEditors;
using PL.iSub;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Sub
{
    public partial class frmAEntrepotsAjouter : iForm
    {
        #region Variables
        sysSalesEntities db = new sysSalesEntities();
        frmAEntrepots aEntrepots;
        #endregion Variables

        #region Code
        public string getCode()
        {
            return string.Format("{0}{1}{2}{3}{4}", Properties.Settings.Default.codeEntropot.ToString(), iTools.getDateNow().ToString("dd"), iTools.getDateNow().ToString("MM"), iTools.getDateNow().ToString("yyyy"), Convert.ToInt32(getMax()));
        }
        public string getMax()
        {
            return db.MaxID_Branche().SingleOrDefault().ToString();
        }
        public void newRecord()
        {
            txtNom.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtVille.Text = string.Empty;
            cmbxPays.SelectedIndex = -1;
            txtTele.Text = string.Empty;
            txtFix.Text = string.Empty;
            dtDate.Text = string.Empty;
            cmbxSociete.SelectedIndex = -1;
            txtNote.Text = string.Empty;
            txtNom.Focus();
            lblCode.Visible = false;
            labelControl1.Visible = false;
        }
        public void getData()
        {
            aEntrepots.gcEntrepots.DataSource = db.Select_Branche();
        }
        public void fillCombo()
        {
            cmbxSociete.data
        }
        #endregion Code

        #region Override
        public override void verifyButtons(XtraForm f, string txt)
        {
            base.verifyButtons(this, "Ajouter un entrepôt");
        }
        public override void Insert_Data()
        {
            if (vpText.Validate())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Insert_Branche(
                            getCode(), txtNom.Text.ToUpper(), txtAdresse.Text.ToUpper(), txtVille.Text.ToUpper(), cmbxPays.Text.ToUpper(), txtTele.Text, txtFix.Text, (DateTime)dtDate.EditValue, true, txtNote.Text, db.Select_Entreprise_Info_By_Name(cmbxSociete.Text).ToString()
                            );
                        db.SaveChanges();
                        transaction.Commit();
                        iTools.msgBox("votre Entrôpot est bien ajoutée", "Sucées", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newRecord();
                        getData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        iTools.msgBox(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public override void Update_Data()
        {
            if (vpText.Validate())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Update_Branche(
                            lblCode.Text, txtNom.Text.ToUpper(), txtAdresse.Text.ToUpper(), txtVille.Text.ToUpper(), cmbxPays.Text.ToUpper(), txtTele.Text, txtFix.Text, (DateTime)dtDate.EditValue, true, txtNote.Text, db.Select_Entreprise_Info_By_Name(cmbxSociete.Text).ToString()
                            );
                        db.SaveChanges();
                        transaction.Commit();
                        iTools.msgBox("Votre Entrôpot est bien modifiée", "Sucées", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        iTools.msgBox(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public override void Delete_Data()
        {
            DialogResult re = iTools.msgBox("Voulez-vous supprimer cet entôpot", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Delete_Branche(lblCode.Text);
                        db.SaveChanges();
                        transaction.Commit();
                        iTools.msgBox("votre entôpot est bien supprimée", "Sucées", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newRecord();
                        Text = "Ajouter un entôpot";
                        verifyButtons(this, "Ajouter un entôpot");
                        getData();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        iTools.msgBox(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        #endregion Override
        public frmAEntrepotsAjouter(frmAEntrepots frm)
        {
            InitializeComponent();
            aEntrepots = frm;
        }
        public frmAEntrepotsAjouter(frmAEntrepots frm, string code, string Nom, string Adresse, string Ville, string Pays, string Tele, string Fix, DateTime dateCreation, string Entreprise, string Note)
        {
            InitializeComponent();
            aEntrepots = frm;
            lblCode.Text = code;
            txtNom.Text = Nom;
            txtAdresse.Text = Adresse;
            txtVille.Text = Ville;
            cmbxPays.Text = Pays;
            txtTele.Text = Tele;
            txtFix.Text = Fix;
            dtDate.EditValue = dateCreation;
            cmbxSociete.Text = Entreprise;
            txtNote.Text = Note;
        }

        private void frmAEntrepotsAjouter_Load(object sender, EventArgs e)
        {
            if (Text == "Ajouter un entrepôt")
            {
                newRecord();
            }
            else
            {
                lblCode.Visible = true;
                labelControl1.Visible = true;
            }
        }
    }
}