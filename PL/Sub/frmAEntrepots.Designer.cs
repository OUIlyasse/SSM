namespace PL.Sub
{
    partial class frmAEntrepots
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gcEntrepots = new DevExpress.XtraGrid.GridControl();
            this.gvEntrepots = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTele = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEntrepots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntrepots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(12, 80);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(988, 237);
            this.groupControl1.TabIndex = 2;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcEntrepots);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 28);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(984, 207);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcEntrepots
            // 
            this.gcEntrepots.Location = new System.Drawing.Point(12, 12);
            this.gcEntrepots.MainView = this.gvEntrepots;
            this.gcEntrepots.Name = "gcEntrepots";
            this.gcEntrepots.Size = new System.Drawing.Size(960, 183);
            this.gcEntrepots.TabIndex = 4;
            this.gcEntrepots.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvEntrepots});
            // 
            // gvEntrepots
            // 
            this.gvEntrepots.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvEntrepots.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvEntrepots.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcCode,
            this.gcNom,
            this.gcAdresse,
            this.gcVille,
            this.gcTele});
            this.gvEntrepots.GridControl = this.gcEntrepots;
            this.gvEntrepots.Name = "gvEntrepots";
            this.gvEntrepots.OptionsBehavior.Editable = false;
            this.gvEntrepots.DoubleClick += new System.EventHandler(this.gvEntrepots_DoubleClick);
            // 
            // gcCode
            // 
            this.gcCode.Caption = "Code Entrepôt";
            this.gcCode.FieldName = "bran_Code";
            this.gcCode.MinWidth = 25;
            this.gcCode.Name = "gcCode";
            this.gcCode.Visible = true;
            this.gcCode.VisibleIndex = 0;
            this.gcCode.Width = 94;
            // 
            // gcNom
            // 
            this.gcNom.Caption = "Nom d\'Entrepôt";
            this.gcNom.FieldName = "bran_Nom";
            this.gcNom.MinWidth = 25;
            this.gcNom.Name = "gcNom";
            this.gcNom.Visible = true;
            this.gcNom.VisibleIndex = 1;
            this.gcNom.Width = 94;
            // 
            // gcAdresse
            // 
            this.gcAdresse.Caption = "Adresse d\' Entrepôt";
            this.gcAdresse.FieldName = "bran_Adresse";
            this.gcAdresse.MinWidth = 25;
            this.gcAdresse.Name = "gcAdresse";
            this.gcAdresse.Visible = true;
            this.gcAdresse.VisibleIndex = 2;
            this.gcAdresse.Width = 94;
            // 
            // gcVille
            // 
            this.gcVille.Caption = "Ville d\' Entrôpot";
            this.gcVille.FieldName = "bran_Ville";
            this.gcVille.MinWidth = 25;
            this.gcVille.Name = "gcVille";
            this.gcVille.Visible = true;
            this.gcVille.VisibleIndex = 3;
            this.gcVille.Width = 94;
            // 
            // gcTele
            // 
            this.gcTele.Caption = "Numéro du téléphone";
            this.gcTele.FieldName = "bran_Tele";
            this.gcTele.MinWidth = 25;
            this.gcTele.Name = "gcTele";
            this.gcTele.Visible = true;
            this.gcTele.VisibleIndex = 4;
            this.gcTele.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(984, 207);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcEntrepots;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(964, 187);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmAEntrepots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 329);
            this.Controls.Add(this.groupControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmAEntrepots";
            this.Text = "Entrepôts";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEntrepots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvEntrepots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        public DevExpress.XtraGrid.GridControl gcEntrepots;
        private DevExpress.XtraGrid.Views.Grid.GridView gvEntrepots;
        private DevExpress.XtraGrid.Columns.GridColumn gcNom;
        private DevExpress.XtraGrid.Columns.GridColumn gcAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn gcVille;
        private DevExpress.XtraGrid.Columns.GridColumn gcTele;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcCode;
    }
}