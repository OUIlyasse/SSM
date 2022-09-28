using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tools;
using PL.Sub;

namespace PL.Main
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
            txtDate.Caption = iTools.getDate();
        }

        private void btnAfficheFactureAvoir_Click(object sender, EventArgs e)
        {
        }

        private void btnVCFA_Click(object sender, EventArgs e)
        {
        }

        private void btnCHitoriqueRembour_Click(object sender, EventArgs e)
        {
        }

        private void btnParamSos_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            frmParamSos frm = new frmParamSos(this);
            iTools.OpenForm(frm, pnlMain);
        }
    }
}