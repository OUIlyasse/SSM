using System;

namespace PL.iSub
{
    public partial class iFormList : DevExpress.XtraEditors.XtraForm
    {
        #region Codes
        public virtual void OpenForm()
        {
        }
        public virtual void getData()
        {
        }
        #endregion Codes
        public iFormList()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            OpenForm();
        }

        private void iFormList_Activated(object sender, EventArgs e)
        {
            getData();
        }
    }
}