namespace DXApplication4
{
    partial class UCbyt
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
            this.abonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.call_centerDataSet1 = new DXApplication4.call_centerDataSet1();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.colid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnch = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colfio = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coladdress1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coladdress2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coltp = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colzavNomer = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colccounter2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.column = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colidMarka = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colraion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldebet = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpenya = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colakt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcarea2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcarea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.abonTableAdapter = new DXApplication4.call_centerDataSet1TableAdapters.abonTableAdapter();
            this.tableAdapterManager = new DXApplication4.call_centerDataSet1TableAdapters.TableAdapterManager();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sprRaionovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprRaionovTableAdapter = new DXApplication4.call_centerDataSet1TableAdapters.sprRaionovTableAdapter();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprRaionovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.abonBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gridControl1.Size = new System.Drawing.Size(847, 470);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // abonBindingSource
            // 
            this.abonBindingSource.DataMember = "abon";
            this.abonBindingSource.DataSource = this.call_centerDataSet1;
            this.abonBindingSource.CurrentItemChanged += new System.EventHandler(this.abonBindingSource_CurrentItemChanged);
            // 
            // call_centerDataSet1
            // 
            this.call_centerDataSet1.DataSetName = "call_centerDataSet1";
            this.call_centerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colid,
            this.colnch,
            this.colfio,
            this.coladdress1,
            this.coladdress2,
            this.coltp,
            this.coldebet,
            this.colpenya,
            this.colzavNomer,
            this.colccounter2,
            this.colidMarka,
            this.colraion,
            this.colakt,
            this.colcarea2,
            this.column,
            this.colcarea});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.advBandedGridView1.OptionsView.ShowFooter = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView1.DoubleClick += new System.EventHandler(this.advBandedGridView1_DoubleClick);
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Width = 64;
            // 
            // colnch
            // 
            this.colnch.Caption = "Лиц.счет";
            this.colnch.FieldName = "nch";
            this.colnch.Name = "colnch";
            this.colnch.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colnch.Visible = true;
            this.colnch.Width = 114;
            // 
            // colfio
            // 
            this.colfio.Caption = "Ф.И.О.";
            this.colfio.FieldName = "fio";
            this.colfio.Name = "colfio";
            this.colfio.Visible = true;
            this.colfio.Width = 213;
            // 
            // coladdress1
            // 
            this.coladdress1.Caption = "Улица";
            this.coladdress1.FieldName = "address1";
            this.coladdress1.Name = "coladdress1";
            this.coladdress1.Visible = true;
            this.coladdress1.Width = 197;
            // 
            // coladdress2
            // 
            this.coladdress2.Caption = "Дом";
            this.coladdress2.FieldName = "address2";
            this.coladdress2.Name = "coladdress2";
            this.coladdress2.Visible = true;
            this.coladdress2.Width = 129;
            // 
            // coltp
            // 
            this.coltp.Caption = "ТП";
            this.coltp.FieldName = "tp";
            this.coltp.Name = "coltp";
            this.coltp.Visible = true;
            this.coltp.Width = 78;
            // 
            // colzavNomer
            // 
            this.colzavNomer.Caption = "Заводской номер";
            this.colzavNomer.FieldName = "zavNomer";
            this.colzavNomer.Name = "colzavNomer";
            this.colzavNomer.Visible = true;
            this.colzavNomer.Width = 127;
            // 
            // colccounter2
            // 
            this.colccounter2.Caption = "Тип";
            this.colccounter2.FieldName = "ccounter2";
            this.colccounter2.Name = "colccounter2";
            this.colccounter2.Visible = true;
            // 
            // column
            // 
            this.column.Caption = "Умный счетчик(>0)";
            this.column.FieldName = "umn";
            this.column.Name = "column";
            this.column.Visible = true;
            // 
            // colidMarka
            // 
            this.colidMarka.FieldName = "idMarka";
            this.colidMarka.Name = "colidMarka";
            this.colidMarka.Width = 64;
            // 
            // colraion
            // 
            this.colraion.Caption = "Район";
            this.colraion.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colraion.FieldName = "raion";
            this.colraion.Name = "colraion";
            this.colraion.Visible = true;
            this.colraion.Width = 59;
            // 
            // coldebet
            // 
            this.coldebet.Caption = "Задолжность(сом)";
            this.coldebet.FieldName = "debet";
            this.coldebet.Name = "coldebet";
            this.coldebet.Visible = true;
            this.coldebet.Width = 99;
            // 
            // colpenya
            // 
            this.colpenya.Caption = "Пеня(сом)";
            this.colpenya.FieldName = "penya";
            this.colpenya.Name = "colpenya";
            this.colpenya.Visible = true;
            this.colpenya.Width = 99;
            // 
            // colakt
            // 
            this.colakt.Caption = "Акт(сом)";
            this.colakt.FieldName = "akt";
            this.colakt.Name = "colakt";
            this.colakt.Visible = true;
            this.colakt.Width = 102;
            // 
            // colcarea2
            // 
            this.colcarea2.Caption = "Маршрут";
            this.colcarea2.FieldName = "carea2";
            this.colcarea2.Name = "colcarea2";
            this.colcarea2.Visible = true;
            // 
            // colcarea
            // 
            this.colcarea.Caption = "Участок";
            this.colcarea.FieldName = "carea";
            this.colcarea.Name = "colcarea";
            this.colcarea.Visible = true;
            // 
            // abonTableAdapter
            // 
            this.abonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.b6TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.call_spotTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.Dispetcher_bTableAdapter = null;
            this.tableAdapterManager.Dispetcher_gTableAdapter = null;
            this.tableAdapterManager.Dispetcher_mTableAdapter = null;
            this.tableAdapterManager.idMarkaTableAdapter = null;
            this.tableAdapterManager.operators_zayavkaTableAdapter = null;
            this.tableAdapterManager.otklTableAdapter = null;
            this.tableAdapterManager.Potreb_pervoi_katTableAdapter = null;
            this.tableAdapterManager.potreb_ps_vlTableAdapter = null;
            this.tableAdapterManager.potreb_tpTableAdapter = null;
            this.tableAdapterManager.prom_abonTableAdapter = null;
            this.tableAdapterManager.spr_pov_elTableAdapter = null;
            this.tableAdapterManager.spr_prihina_psTableAdapter = null;
            this.tableAdapterManager.spr_remontTableAdapter = null;
            this.tableAdapterManager.spr_uchastokTableAdapter = null;
            this.tableAdapterManager.spr_vid_otklTableAdapter = null;
            this.tableAdapterManager.sprDoljnosteiTableAdapter = null;
            this.tableAdapterManager.sprNapryajTableAdapter = null;
            this.tableAdapterManager.sprPodstansii_35TableAdapter = null;
            this.tableAdapterManager.sprPoVidamPovrElementovDetalnoTableAdapter = null;
            this.tableAdapterManager.sprPoVidamPovrElementovTableAdapter = null;
            this.tableAdapterManager.sprPrichinOtklDetalnoTableAdapter = null;
            this.tableAdapterManager.sprPrichinOtklTableAdapter = null;
            this.tableAdapterManager.sprRabotTableAdapter = null;
            this.tableAdapterManager.sprRaionovTableAdapter = null;
            this.tableAdapterManager.sprSlujbaTableAdapter = null;
            this.tableAdapterManager.sprStatusTableAdapter = null;
            this.tableAdapterManager.sprTPTableAdapter = null;
            this.tableAdapterManager.sprVidOtklTableAdapter = null;
            this.tableAdapterManager.sprVL6_101TableAdapter = null;
            this.tableAdapterManager.sprVL6_10TableAdapter = null;
            this.tableAdapterManager.Srec_putTableAdapter = null;
            this.tableAdapterManager.tp_bTableAdapter = null;
            this.tableAdapterManager.TP_otklTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = DXApplication4.call_centerDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.users_programmTableAdapter = null;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("nazvanie", "Название")});
            this.repositoryItemLookUpEdit1.DataSource = this.sprRaionovBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "nazvanie";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.NullText = "";
            this.repositoryItemLookUpEdit1.ValueMember = "id";
            // 
            // sprRaionovBindingSource
            // 
            this.sprRaionovBindingSource.DataMember = "sprRaionov";
            this.sprRaionovBindingSource.DataSource = this.call_centerDataSet1;
            // 
            // sprRaionovTableAdapter
            // 
            this.sprRaionovTableAdapter.ClearBeforeFill = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Данные об абоненте";
            this.gridBand1.Columns.Add(this.colraion);
            this.gridBand1.Columns.Add(this.colid);
            this.gridBand1.Columns.Add(this.colnch);
            this.gridBand1.Columns.Add(this.colfio);
            this.gridBand1.Columns.Add(this.coladdress1);
            this.gridBand1.Columns.Add(this.coladdress2);
            this.gridBand1.Columns.Add(this.coltp);
            this.gridBand1.Columns.Add(this.colzavNomer);
            this.gridBand1.Columns.Add(this.colccounter2);
            this.gridBand1.Columns.Add(this.column);
            this.gridBand1.Columns.Add(this.colidMarka);
            this.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1067;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Данные об оплатах";
            this.gridBand2.Columns.Add(this.coldebet);
            this.gridBand2.Columns.Add(this.colpenya);
            this.gridBand2.Columns.Add(this.colakt);
            this.gridBand2.Columns.Add(this.colcarea2);
            this.gridBand2.Columns.Add(this.colcarea);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 450;
            // 
            // UCbyt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "UCbyt";
            this.Size = new System.Drawing.Size(853, 473);
            this.Load += new System.EventHandler(this.UCbyt_Load);
            this.DoubleClick += new System.EventHandler(this.UCbyt_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprRaionovBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnch;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfio;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coladdress1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coladdress2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltp;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colzavNomer;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colidMarka;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colraion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldebet;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpenya;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colakt;
        private System.Windows.Forms.BindingSource abonBindingSource;
        private call_centerDataSet1 call_centerDataSet1;
        private call_centerDataSet1TableAdapters.abonTableAdapter abonTableAdapter;
        private call_centerDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colccounter2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn column;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcarea2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcarea;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource sprRaionovBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private call_centerDataSet1TableAdapters.sprRaionovTableAdapter sprRaionovTableAdapter;
    }
}
