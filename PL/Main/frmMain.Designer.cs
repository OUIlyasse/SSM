namespace PL.Main
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnSocietes = new DevExpress.XtraBars.BarButtonItem();
            this.txtMsg = new DevExpress.XtraBars.BarHeaderItem();
            this.txtTime = new DevExpress.XtraBars.BarHeaderItem();
            this.txtDate = new DevExpress.XtraBars.BarHeaderItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btnParametre = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogOut = new DevExpress.XtraBars.BarButtonItem();
            this.txtUser = new DevExpress.XtraBars.BarHeaderItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mdi_Manager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdi_Manager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnSocietes,
            this.txtMsg,
            this.txtTime,
            this.txtDate,
            this.barSubItem1,
            this.btnParametre,
            this.btnLogOut,
            this.txtUser});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barSubItem1);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(998, 207);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnSocietes
            // 
            this.btnSocietes.Caption = "Sociétés";
            this.btnSocietes.Id = 1;
            this.btnSocietes.ImageOptions.Image = global::PL.Properties.Resources.icons8_company_32px;
            this.btnSocietes.Name = "btnSocietes";
            this.btnSocietes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSocietes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSocietes_ItemClick);
            // 
            // txtMsg
            // 
            this.txtMsg.Caption = "---";
            this.txtMsg.Id = 2;
            this.txtMsg.Name = "txtMsg";
            // 
            // txtTime
            // 
            this.txtTime.Caption = "---";
            this.txtTime.Id = 3;
            this.txtTime.Name = "txtTime";
            // 
            // txtDate
            // 
            this.txtDate.Caption = "---";
            this.txtDate.Id = 4;
            this.txtDate.Name = "txtDate";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Compte";
            this.barSubItem1.Id = 5;
            this.barSubItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.Image")));
            this.barSubItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barSubItem1.ImageOptions.LargeImage")));
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnParametre),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnLogOut)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // btnParametre
            // 
            this.btnParametre.Caption = "Paramètre";
            this.btnParametre.Id = 6;
            this.btnParametre.Name = "btnParametre";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Caption = "Déconnection";
            this.btnLogOut.Id = 7;
            this.btnLogOut.Name = "btnLogOut";
            // 
            // txtUser
            // 
            this.txtUser.Appearance.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Appearance.Options.UseFont = true;
            this.txtUser.Caption = "user";
            this.txtUser.Id = 8;
            this.txtUser.Name = "txtUser";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.KeyTip = "P";
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Paramètres";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSocietes, "S");
            this.ribbonPageGroup1.KeyTip = "0";
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.txtUser);
            this.ribbonStatusBar.ItemLinks.Add(this.txtMsg);
            this.ribbonStatusBar.ItemLinks.Add(this.txtDate);
            this.ribbonStatusBar.ItemLinks.Add(this.txtTime);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(998, 31);
            // 
            // mdi_Manager
            // 
            this.mdi_Manager.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdi_Manager.AppearancePage.HeaderActive.Options.UseFont = true;
            this.mdi_Manager.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.mdi_Manager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.mdi_Manager.MdiParent = this;
            this.mdi_Manager.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InActiveTabPageHeader;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 599);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdi_Manager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnSocietes;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdi_Manager;
        private DevExpress.XtraBars.BarHeaderItem txtMsg;
        private DevExpress.XtraBars.BarHeaderItem txtTime;
        private DevExpress.XtraBars.BarHeaderItem txtDate;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem btnParametre;
        private DevExpress.XtraBars.BarButtonItem btnLogOut;
        private DevExpress.XtraBars.BarHeaderItem txtUser;
    }
}