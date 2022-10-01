namespace PL.Sub
{
    partial class frmPSociete
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
            this.gcSos = new DevExpress.XtraGrid.GridControl();
            this.gvSos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gcNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcSos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSos)).BeginInit();
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
            this.groupControl1.Location = new System.Drawing.Point(12, 72);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(972, 237);
            this.groupControl1.TabIndex = 1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcSos);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 28);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(968, 207);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gcSos
            // 
            this.gcSos.Location = new System.Drawing.Point(12, 12);
            this.gcSos.MainView = this.gvSos;
            this.gcSos.Name = "gcSos";
            this.gcSos.Size = new System.Drawing.Size(944, 183);
            this.gcSos.TabIndex = 4;
            this.gcSos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSos});
            // 
            // gvSos
            // 
            this.gvSos.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSos.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcNom,
            this.gcAdresse,
            this.gcVille,
            this.gcPays});
            this.gvSos.GridControl = this.gcSos;
            this.gvSos.Name = "gvSos";
            this.gvSos.OptionsBehavior.Editable = false;
            this.gvSos.DoubleClick += new System.EventHandler(this.gvSos_DoubleClick);
            // 
            // gcNom
            // 
            this.gcNom.Caption = "Nom de la sociétés";
            this.gcNom.FieldName = "entr_Nom";
            this.gcNom.MinWidth = 25;
            this.gcNom.Name = "gcNom";
            this.gcNom.Visible = true;
            this.gcNom.VisibleIndex = 0;
            this.gcNom.Width = 94;
            // 
            // gcAdresse
            // 
            this.gcAdresse.Caption = "Adresse de la sociétés";
            this.gcAdresse.FieldName = "entr_Adresse";
            this.gcAdresse.MinWidth = 25;
            this.gcAdresse.Name = "gcAdresse";
            this.gcAdresse.Visible = true;
            this.gcAdresse.VisibleIndex = 1;
            this.gcAdresse.Width = 94;
            // 
            // gcVille
            // 
            this.gcVille.Caption = "Ville de la sociétés";
            this.gcVille.FieldName = "entr_Ville";
            this.gcVille.MinWidth = 25;
            this.gcVille.Name = "gcVille";
            this.gcVille.Visible = true;
            this.gcVille.VisibleIndex = 2;
            this.gcVille.Width = 94;
            // 
            // gcPays
            // 
            this.gcPays.Caption = "Pays de la sociétés";
            this.gcPays.FieldName = "entr_Pays";
            this.gcPays.MinWidth = 25;
            this.gcPays.Name = "gcPays";
            this.gcPays.Visible = true;
            this.gcPays.VisibleIndex = 3;
            this.gcPays.Width = 94;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(968, 207);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcSos;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(948, 187);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // frmPSociete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 321);
            this.Controls.Add(this.groupControl1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmPSociete";
            this.Text = "Sociétés";
            this.Controls.SetChildIndex(this.groupControl1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcSos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSos;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcNom;
        private DevExpress.XtraGrid.Columns.GridColumn gcAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn gcVille;
        private DevExpress.XtraGrid.Columns.GridColumn gcPays;
        public DevExpress.XtraGrid.GridControl gcSos;
    }
}