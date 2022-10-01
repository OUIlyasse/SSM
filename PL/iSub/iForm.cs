using DevExpress.XtraEditors;

namespace PL.iSub
{
    public partial class iForm : DevExpress.XtraEditors.XtraForm
    {
        #region Codes
        public virtual void Insert_Data()
        {
        }
        public virtual void Update_Data()
        {
        }
        public virtual void Delete_Data()
        {
        }
        public virtual void verifyButtons(XtraForm f, string txt)
        {
            if (f.Text == txt)
            {
                btnAdd.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }
        #endregion Codes
        public iForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            Insert_Data();
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            Update_Data();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            Delete_Data();
        }

        private void iForm_Load(object sender, System.EventArgs e)
        {
            verifyButtons(new XtraForm(), "");
        }
    }
}