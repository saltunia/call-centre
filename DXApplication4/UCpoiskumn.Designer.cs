namespace DXApplication4
{
    partial class UCpoiskumn
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.poiskumnBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.call_centerDataSet = new DXApplication4.call_centerDataSet();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colnch = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colfio = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coladdress1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coladdress2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldata_otkl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colstatus = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.coltp = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldebet = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpenya = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colakt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colzavNomer = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colraion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldata_vkl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.poisk_umnTableAdapter = new DXApplication4.call_centerDataSetTableAdapters.poisk_umnTableAdapter();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poiskumnBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.poiskumnBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 158);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gridControl1.Size = new System.Drawing.Size(850, 402);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // poiskumnBindingSource
            // 
            this.poiskumnBindingSource.DataMember = "poisk_umn";
            this.poiskumnBindingSource.DataSource = this.call_centerDataSet;
            // 
            // call_centerDataSet
            // 
            this.call_centerDataSet.DataSetName = "call_centerDataSet";
            this.call_centerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colnch,
            this.colfio,
            this.coladdress1,
            this.colstatus,
            this.coladdress2,
            this.coldata_otkl,
            this.coldata_vkl,
            this.coldebet,
            this.colpenya,
            this.colakt,
            this.coltp,
            this.colzavNomer,
            this.colraion});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsBehavior.ReadOnly = true;
            this.advBandedGridView1.OptionsView.ShowFooter = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Отключенные абоненты";
            this.gridBand1.Columns.Add(this.colnch);
            this.gridBand1.Columns.Add(this.colfio);
            this.gridBand1.Columns.Add(this.coladdress1);
            this.gridBand1.Columns.Add(this.coladdress2);
            this.gridBand1.Columns.Add(this.coldata_otkl);
            this.gridBand1.Columns.Add(this.colstatus);
            this.gridBand1.Columns.Add(this.coltp);
            this.gridBand1.Columns.Add(this.coldebet);
            this.gridBand1.Columns.Add(this.colpenya);
            this.gridBand1.Columns.Add(this.colakt);
            this.gridBand1.Columns.Add(this.colzavNomer);
            this.gridBand1.Columns.Add(this.colraion);
            this.gridBand1.Columns.Add(this.coldata_vkl);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1429;
            // 
            // colnch
            // 
            this.colnch.Caption = "Лиц.счет";
            this.colnch.FieldName = "nch";
            this.colnch.Name = "colnch";
            this.colnch.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colnch.Visible = true;
            this.colnch.Width = 81;
            // 
            // colfio
            // 
            this.colfio.Caption = "Ф.И.О.";
            this.colfio.FieldName = "fio";
            this.colfio.Name = "colfio";
            this.colfio.Visible = true;
            this.colfio.Width = 153;
            // 
            // coladdress1
            // 
            this.coladdress1.Caption = "Адрес";
            this.coladdress1.FieldName = "address1";
            this.coladdress1.Name = "coladdress1";
            this.coladdress1.Visible = true;
            this.coladdress1.Width = 164;
            // 
            // coladdress2
            // 
            this.coladdress2.Caption = "Дом/кв";
            this.coladdress2.FieldName = "address2";
            this.coladdress2.Name = "coladdress2";
            this.coladdress2.Visible = true;
            this.coladdress2.Width = 78;
            // 
            // coldata_otkl
            // 
            this.coldata_otkl.Caption = "Дата/время откл.";
            this.coldata_otkl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldata_otkl.FieldName = "data_otkl";
            this.coldata_otkl.Name = "coldata_otkl";
            this.coldata_otkl.Visible = true;
            this.coldata_otkl.Width = 173;
            // 
            // colstatus
            // 
            this.colstatus.Caption = "Отключен";
            this.colstatus.ColumnEdit = this.repositoryItemCheckEdit1;
            this.colstatus.FieldName = "status";
            this.colstatus.Name = "colstatus";
            this.colstatus.Width = 71;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // coltp
            // 
            this.coltp.Caption = "ТП";
            this.coltp.FieldName = "tp";
            this.coltp.Name = "coltp";
            this.coltp.Visible = true;
            this.coltp.Width = 69;
            // 
            // coldebet
            // 
            this.coldebet.Caption = "Задолжность(сом)";
            this.coldebet.FieldName = "debet";
            this.coldebet.Name = "coldebet";
            this.coldebet.Visible = true;
            this.coldebet.Width = 120;
            // 
            // colpenya
            // 
            this.colpenya.Caption = "Пеня(сом)";
            this.colpenya.FieldName = "penya";
            this.colpenya.Name = "colpenya";
            this.colpenya.Visible = true;
            this.colpenya.Width = 97;
            // 
            // colakt
            // 
            this.colakt.Caption = "Акт(сом)";
            this.colakt.FieldName = "akt";
            this.colakt.Name = "colakt";
            this.colakt.Visible = true;
            this.colakt.Width = 97;
            // 
            // colzavNomer
            // 
            this.colzavNomer.Caption = "Зав. номер счетчика";
            this.colzavNomer.FieldName = "zavNomer";
            this.colzavNomer.Name = "colzavNomer";
            this.colzavNomer.Visible = true;
            this.colzavNomer.Width = 165;
            // 
            // colraion
            // 
            this.colraion.FieldName = "raion";
            this.colraion.Name = "colraion";
            // 
            // coldata_vkl
            // 
            this.coldata_vkl.Caption = "Дата/время последнего вкл.";
            this.coldata_vkl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldata_vkl.FieldName = "data_vkl";
            this.coldata_vkl.Name = "coldata_vkl";
            this.coldata_vkl.Visible = true;
            this.coldata_vkl.Width = 232;
            // 
            // poisk_umnTableAdapter
            // 
            this.poisk_umnTableAdapter.ClearBeforeFill = true;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(228, 83);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Поиск";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(76, 85);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.textEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.textEdit1.Size = new System.Drawing.Size(137, 20);
            this.textEdit1.TabIndex = 2;
            this.textEdit1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEdit1_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(79, 29);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(119, 39);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "  Введите лиц.счет или\r\n заводской №счетчика\r\n         или номер ТП";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelControl2.Location = new System.Drawing.Point(241, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(334, 23);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "По вашему запросу ничего найдено!!!";
            // 
            // UCpoiskumn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.gridControl1);
            this.Name = "UCpoiskumn";
            this.Size = new System.Drawing.Size(856, 563);
            this.Load += new System.EventHandler(this.UCpoiskumn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poiskumnBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource poiskumnBindingSource;
        private call_centerDataSet call_centerDataSet;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnch;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfio;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coladdress1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coladdress2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltp;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldebet;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpenya;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colzavNomer;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colraion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colakt;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colstatus;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldata_otkl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldata_vkl;
        private call_centerDataSetTableAdapters.poisk_umnTableAdapter poisk_umnTableAdapter;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
    }
}
