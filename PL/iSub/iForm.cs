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
    }
}