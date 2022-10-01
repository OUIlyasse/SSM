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
using Tools;

namespace PL.Sub
{
    public partial class frmPSocieteAjouter : iForm
    {
        #region Variables
        sysSalesEntities db = new sysSalesEntities();
        #endregion Variables

        #region Code
        public string getCode()
        {
            return string.Format("{0}{1:0000}{2}{3}", Properties.Settings.Default.codeSosiete, Convert.ToInt32(getMax()), iTools.getDateNow().ToString("dd"), iTools.getDateNow().ToString("MM"));
        }
        public string getMax()
        {
            return db.MaxID_Entreprise_Info().ToString();
        }
        #endregion Code

        #region Override
        public override void verifyButtons(XtraForm f, string txt)
        {
            base.verifyButtons(this, "Ajouter une Sosiètè");
        }
        public override void Insert_Data()
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.Insert_Entreprise_Info(
                        getCode(), txtEntreprise.Text.ToUpper(), txtAdresse.Text.ToUpper(), txtVille.Text.ToUpper(), cmbxPays.Text.ToUpper(),
                        txtCodePostale.Text, txtTele.Text, txtFix.Text, txtEmail.Text, txtWhatsapp.Text, txtFax.Text, true, null, txtNote.Text
                        );
                    db.SaveChanges();
                    transaction.Commit();
                    iTools.msgBox("votre société est bien ajoutée", "Sucées", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    iTools.msgBox(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion Override
        public frmPSocieteAjouter()
        {
            InitializeComponent();
        }
    }
}