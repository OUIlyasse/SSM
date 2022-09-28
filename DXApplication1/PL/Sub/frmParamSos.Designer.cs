namespace PL.Sub
{
    partial class frmParamSos
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gcSocietes = new DevExpress.XtraGrid.GridControl();
            this.gvSocietes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.gcNom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcAdresse = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcVille = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcPays = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSocietes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSocietes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(851, 86);
            this.groupControl1.TabIndex = 4;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gcSocietes);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 86);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(851, 573);
            this.layoutControl1.TabIndex = 5;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(851, 573);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // gcSocietes
            // 
            this.gcSocietes.Location = new System.Drawing.Point(12, 12);
            this.gcSocietes.MainView = this.gvSocietes;
            this.gcSocietes.Name = "gcSocietes";
            this.gcSocietes.Size = new System.Drawing.Size(827, 549);
            this.gcSocietes.TabIndex = 4;
            this.gcSocietes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvSocietes});
            // 
            // gvSocietes
            // 
            this.gvSocietes.Appearance.HeaderPanel.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvSocietes.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvSocietes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gcNom,
            this.gcAdresse,
            this.gcVille,
            this.gcPays});
            this.gvSocietes.GridControl = this.gcSocietes;
            this.gvSocietes.Name = "gvSocietes";
            this.gvSocietes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gvSocietes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gcSocietes;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(831, 553);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // gcNom
            // 
            this.gcNom.Caption = "Nom de la Société";
            this.gcNom.FieldName = "entr_Nom";
            this.gcNom.Name = "gcNom";
            this.gcNom.Visible = true;
            this.gcNom.VisibleIndex = 0;
            // 
            // gcAdresse
            // 
            this.gcAdresse.Caption = "Adresse de la Société";
            this.gcAdresse.FieldName = "entr_Adresse";
            this.gcAdresse.Name = "gcAdresse";
            this.gcAdresse.Visible = true;
            this.gcAdresse.VisibleIndex = 1;
            // 
            // gcVille
            // 
            this.gcVille.Caption = "Ville de la Société";
            this.gcVille.FieldName = "entr_Ville";
            this.gcVille.Name = "gcVille";
            this.gcVille.Visible = true;
            this.gcVille.VisibleIndex = 2;
            // 
            // gcPays
            // 
            this.gcPays.Caption = "Pays de la Société";
            this.gcPays.FieldName = "entr_Pays";
            this.gcPays.Name = "gcPays";
            this.gcPays.Visible = true;
            this.gcPays.VisibleIndex = 3;
            // 
            // frmParamSos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 659);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.groupControl1);
            this.MinimumSize = new System.Drawing.Size(869, 706);
            this.Name = "frmParamSos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sociétés";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcSocietes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSocietes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gcSocietes;
        private DevExpress.XtraGrid.Views.Grid.GridView gvSocietes;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn gcNom;
        private DevExpress.XtraGrid.Columns.GridColumn gcAdresse;
        private DevExpress.XtraGrid.Columns.GridColumn gcVille;
        private DevExpress.XtraGrid.Columns.GridColumn gcPays;
    }
}