using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using PL.Sub;
using DevExpress.XtraEditors;

namespace PL.Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Codes
        public void OpenForm(XtraForm _Form)
        {
            if (!isFormActivated(_Form))
            {
                _Form.MdiParent = this;
                _Form.Show();
            }
        }
        private bool isFormActivated(XtraForm _Form)
        {
            bool isOpen = false;
            if (MdiChildren.Count() > 0)
            {
                foreach (var item in MdiChildren)
                {
                    if (_Form.Name == item.Name)
                    {
                        mdi_Manager.Pages[item].MdiChild.Activate();
                        isOpen = true;
                    }
                }
            }
            return isOpen;
        }
        #endregion Codes
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnSocietes_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmPSociete frm = new frmPSociete();
            OpenForm(frm);
        }
    }
}