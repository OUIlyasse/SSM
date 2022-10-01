using DAL.Db;
using DevExpress.XtraEditors;
using PL.iSub;
using System;
using System.Linq;
using System.Windows.Forms;
using Tools;

namespace PL.Sub
{
    public partial class frmPSocieteAjouter : iForm
    {
        #region Variables
        sysSalesEntities db = new sysSalesEntities();
        string pathLogo = string.Empty;
        frmPSociete pSociete;
        string code;
        #endregion Variables

        #region Code
        public string getCode()
        {
            return string.Format("{0}{1}{2}{3}{4}", Properties.Settings.Default.codeSosiete.ToString(), iTools.getDateNow().ToString("dd"), iTools.getDateNow().ToString("MM"), iTools.getDateNow().ToString("yyyy"), Convert.ToInt32(getMax()));
        }
        public string getMax()
        {
            return db.MaxID_Entreprise_Info().SingleOrDefault().ToString();
        }
        public void newRecord()
        {
            txtEntreprise.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtVille.Text = string.Empty;
            txtCodePostale.Text = string.Empty;
            cmbxPays.Text = string.Empty;
            txtTele.Text = string.Empty;
            txtFix.Text = string.Empty;
            txtWhatsapp.Text = string.Empty;
            txtFax.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNote.Text = string.Empty;
            pathLogo = string.Empty;
            txtEntreprise.Focus();
        }
        public void getData()
        {
            pSociete.gcSos.DataSource = db.Select_Entreprise_Info();
        }
        #endregion Code

        #region Override
        public override void verifyButtons(XtraForm f, string txt)
        {
            base.verifyButtons(this, "Ajouter une Sosiètè");
        }
        public override void Insert_Data()
        {
            if (string.IsNullOrEmpty(pathLogo))
            {
                iTools.msgBox("Veuillé insère un logo de votre Société", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (vpText.Validate())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Insert_Entreprise_Info(
                            getCode(), txtEntreprise.Text.ToUpper(), txtAdresse.Text.ToUpper(), txtVille.Text.ToUpper(), cmbxPays.Text.ToUpper(),
                            txtCodePostale.Text, txtTele.Text, txtFix.Text, txtEmail.Text, txtWhatsapp.Text, txtFax.Text, true, iTools.ReadFile(pathLogo), txtNote.Text
                            );
                        db.SaveChanges();
                        transaction.Commit();
                        iTools.msgBox("votre société est bien ajoutée", "Sucées", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (string.IsNullOrEmpty(pathLogo))
            {
                iTools.msgBox("Insérez le logo de votre entreprise.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (vpText.Validate())
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Update_Entreprise_Info(
                            code, txtEntreprise.Text.ToUpper(), txtAdresse.Text.ToUpper(), txtVille.Text.ToUpper(), cmbxPays.Text.ToUpper(),
                            txtCodePostale.Text, txtTele.Text, txtFix.Text, txtEmail.Text, txtWhatsapp.Text, txtFax.Text, true, null, txtNote.Text
                            );
                        db.SaveChanges();
                        transaction.Commit();
                        iTools.msgBox("Votre société est bien modifiée", "Sucées", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DialogResult re = iTools.msgBox("Voulez-vous supprimer cette socièté", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                using (var transaction = db.Database.BeginTransaction())
                {
                    try
                    {
                        db.Delete_Entreprise_Info(code, false);
                        db.SaveChanges();
                        transaction.Commit();
                        iTools.msgBox("votre société est bien supprimée", "Sucées", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        newRecord();
                        Text = "Ajouter une Sosiètè";
                        verifyButtons(this, "Ajouter une Sosiètè");
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
        public frmPSocieteAjouter(frmPSociete frm)
        {
            InitializeComponent();
            pSociete = frm;
        }
        public frmPSocieteAjouter(frmPSociete frm, string code, string Entreprise, string Adresse, string Ville, string CodePostale, string Pays, string Tele, string Fix, string Whatsapp, string Fax, string Email, string Note)
        {
            InitializeComponent();
            pSociete = frm;
            this.code = code;
            txtEntreprise.Text = Entreprise;
            txtAdresse.Text = Adresse;
            txtVille.Text = Ville;
            txtCodePostale.Text = CodePostale;
            cmbxPays.Text = Pays;
            txtTele.Text = Tele;
            txtFix.Text = Fix;
            txtWhatsapp.Text = Whatsapp;
            txtFax.Text = Fax;
            txtEmail.Text = Email;
            txtNote.Text = Note;
            pathLogo = string.Empty;
        }
        private void lnkLogo_Click(object sender, EventArgs e)
        {
            ofd.Filter = "Images|*.jpg;*.jpeg;*.png";
            ofd.Title = "Insérer une image";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pathLogo = ofd.FileName;
            }
            else
            {
                return;
            }
        }

        private void frmPSocieteAjouter_Load(object sender, EventArgs e)
        {
            if (Text == "Ajouter une Sosiètè")
            {
                newRecord();
            }
        }
    }
}