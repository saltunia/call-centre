namespace DXApplication4
{
    partial class UCprom
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
            this.prom_abonGridControl = new DevExpress.XtraGrid.GridControl();
            this.prom_abonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.call_centerDataSet1 = new DXApplication4.call_centerDataSet1();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.colid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnch = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colfio = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coladdress1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coladdress2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coltp = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldebet = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpenya = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colzavNomer = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colidMarka = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colraion = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colkod_potreb = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colpotrebitel = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colkod_abon = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colabonent = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coln_category = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.prom_abonTableAdapter = new DXApplication4.call_centerDataSet1TableAdapters.prom_abonTableAdapter();
            this.tableAdapterManager = new DXApplication4.call_centerDataSet1TableAdapters.TableAdapterManager();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.sprRaionovBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sprRaionovTableAdapter = new DXApplication4.call_centerDataSet1TableAdapters.sprRaionovTableAdapter();
            this.colcarea = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colcarea2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.column = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.prom_abonGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prom_abonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprRaionovBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // prom_abonGridControl
            // 
            this.prom_abonGridControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.prom_abonGridControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.prom_abonGridControl.DataSource = this.prom_abonBindingSource;
            this.prom_abonGridControl.Location = new System.Drawing.Point(0, 3);
            this.prom_abonGridControl.MainView = this.advBandedGridView1;
            this.prom_abonGridControl.Name = "prom_abonGridControl";
            this.prom_abonGridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.prom_abonGridControl.Size = new System.Drawing.Size(933, 557);
            this.prom_abonGridControl.TabIndex = 2;
            this.prom_abonGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            this.prom_abonGridControl.DoubleClick += new System.EventHandler(this.prom_abonGridControl_DoubleClick);
            // 
            // prom_abonBindingSource
            // 
            this.prom_abonBindingSource.DataMember = "prom_abon";
            this.prom_abonBindingSource.DataSource = this.call_centerDataSet1;
            this.prom_abonBindingSource.CurrentItemChanged += new System.EventHandler(this.prom_abonBindingSource_CurrentItemChanged);
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
            this.gridBand2,
            this.gridBand3});
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
            this.colidMarka,
            this.colraion,
            this.colkod_potreb,
            this.colpotrebitel,
            this.colkod_abon,
            this.colabonent,
            this.coln_category,
            this.colcarea,
            this.colcarea2,
            this.column});
            this.advBandedGridView1.GridControl = this.prom_abonGridControl;
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
            // 
            // colnch
            // 
            this.colnch.Caption = "№точки учета";
            this.colnch.FieldName = "nch";
            this.colnch.Name = "colnch";
            this.colnch.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colnch.Visible = true;
            this.colnch.Width = 111;
            // 
            // colfio
            // 
            this.colfio.Caption = "Точка учета";
            this.colfio.FieldName = "fio";
            this.colfio.Name = "colfio";
            this.colfio.Visible = true;
            this.colfio.Width = 245;
            // 
            // coladdress1
            // 
            this.coladdress1.Caption = "Адрес";
            this.coladdress1.FieldName = "address1";
            this.coladdress1.Name = "coladdress1";
            this.coladdress1.Visible = true;
            this.coladdress1.Width = 210;
            // 
            // coladdress2
            // 
            this.coladdress2.FieldName = "address2";
            this.coladdress2.Name = "coladdress2";
            // 
            // coltp
            // 
            this.coltp.Caption = "ТП";
            this.coltp.FieldName = "tp";
            this.coltp.Name = "coltp";
            this.coltp.Visible = true;
            this.coltp.Width = 94;
            // 
            // coldebet
            // 
            this.coldebet.Caption = "Задолжность(сом)";
            this.coldebet.FieldName = "debet";
            this.coldebet.Name = "coldebet";
            this.coldebet.Visible = true;
            this.coldebet.Width = 141;
            // 
            // colpenya
            // 
            this.colpenya.Caption = "Пеня(сом)";
            this.colpenya.FieldName = "penya";
            this.colpenya.Name = "colpenya";
            this.colpenya.Visible = true;
            this.colpenya.Width = 97;
            // 
            // colzavNomer
            // 
            this.colzavNomer.Caption = "Зав.ном.счетчика";
            this.colzavNomer.FieldName = "zavNomer";
            this.colzavNomer.Name = "colzavNomer";
            this.colzavNomer.Visible = true;
            this.colzavNomer.Width = 170;
            // 
            // colidMarka
            // 
            this.colidMarka.FieldName = "idMarka";
            this.colidMarka.Name = "colidMarka";
            // 
            // colraion
            // 
            this.colraion.Caption = "Район";
            this.colraion.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colraion.FieldName = "raion";
            this.colraion.Name = "colraion";
            this.colraion.Visible = true;
            // 
            // colkod_potreb
            // 
            this.colkod_potreb.Caption = "Код потребителя";
            this.colkod_potreb.FieldName = "kod_potreb";
            this.colkod_potreb.Name = "colkod_potreb";
            this.colkod_potreb.Visible = true;
            this.colkod_potreb.Width = 124;
            // 
            // colpotrebitel
            // 
            this.colpotrebitel.Caption = "Потребитель";
            this.colpotrebitel.FieldName = "potrebitel";
            this.colpotrebitel.Name = "colpotrebitel";
            this.colpotrebitel.Visible = true;
            this.colpotrebitel.Width = 251;
            // 
            // colkod_abon
            // 
            this.colkod_abon.Caption = "Код абонента";
            this.colkod_abon.FieldName = "kod_abon";
            this.colkod_abon.Name = "colkod_abon";
            this.colkod_abon.Visible = true;
            this.colkod_abon.Width = 116;
            // 
            // colabonent
            // 
            this.colabonent.Caption = "Абонент";
            this.colabonent.FieldName = "abonent";
            this.colabonent.Name = "colabonent";
            this.colabonent.Visible = true;
            this.colabonent.Width = 250;
            // 
            // coln_category
            // 
            this.coln_category.Caption = "Категория";
            this.coln_category.FieldName = "n_category";
            this.coln_category.Name = "coln_category";
            this.coln_category.Visible = true;
            this.coln_category.Width = 84;
            // 
            // prom_abonTableAdapter
            // 
            this.prom_abonTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.b6TableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.call_spotTableAdapter = null;
            this.tableAdapterManager.Dispetcher_bTableAdapter = null;
            this.tableAdapterManager.Dispetcher_gTableAdapter = null;
            this.tableAdapterManager.Dispetcher_mTableAdapter = null;
            this.tableAdapterManager.idMarkaTableAdapter = null;
            this.tableAdapterManager.operators_zayavkaTableAdapter = null;
            this.tableAdapterManager.otklTableAdapter = null;
            this.tableAdapterManager.Potreb_pervoi_katTableAdapter = null;
            this.tableAdapterManager.potreb_ps_vlTableAdapter = null;
            this.tableAdapterManager.potreb_tpTableAdapter = null;
            this.tableAdapterManager.prom_abonTableAdapter = this.prom_abonTableAdapter;
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
            // colcarea
            // 
            this.colcarea.Caption = "Участок";
            this.colcarea.FieldName = "carea";
            this.colcarea.Name = "colcarea";
            this.colcarea.Visible = true;
            // 
            // colcarea2
            // 
            this.colcarea2.Caption = "Маршрут";
            this.colcarea2.FieldName = "carea2";
            this.colcarea2.Name = "colcarea2";
            this.colcarea2.Visible = true;
            // 
            // column
            // 
            this.column.Caption = "Тип счетчика(>0)";
            this.column.FieldName = "umn";
            this.column.Name = "column";
            this.column.Visible = true;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Данные точки учета";
            this.gridBand1.Columns.Add(this.colid);
            this.gridBand1.Columns.Add(this.colnch);
            this.gridBand1.Columns.Add(this.colfio);
            this.gridBand1.Columns.Add(this.coladdress1);
            this.gridBand1.Columns.Add(this.coladdress2);
            this.gridBand1.Columns.Add(this.coltp);
            this.gridBand1.Columns.Add(this.coldebet);
            this.gridBand1.Columns.Add(this.colpenya);
            this.gridBand1.Columns.Add(this.colzavNomer);
            this.gridBand1.Columns.Add(this.colidMarka);
            this.gridBand1.Columns.Add(this.column);
            this.gridBand1.Columns.Add(this.colraion);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1218;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Данные о потребителях";
            this.gridBand2.Columns.Add(this.colkod_potreb);
            this.gridBand2.Columns.Add(this.colpotrebitel);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 375;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "Данные об абонентах";
            this.gridBand3.Columns.Add(this.colkod_abon);
            this.gridBand3.Columns.Add(this.colabonent);
            this.gridBand3.Columns.Add(this.coln_category);
            this.gridBand3.Columns.Add(this.colcarea);
            this.gridBand3.Columns.Add(this.colcarea2);
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.VisibleIndex = 2;
            this.gridBand3.Width = 600;
            // 
            // UCprom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.prom_abonGridControl);
            this.Name = "UCprom";
            this.Size = new System.Drawing.Size(938, 560);
            this.Load += new System.EventHandler(this.UCprom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prom_abonGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prom_abonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sprRaionovBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl prom_abonGridControl;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnch;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfio;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coladdress1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coladdress2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltp;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldebet;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpenya;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colzavNomer;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colidMarka;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colraion;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colkod_potreb;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colpotrebitel;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colkod_abon;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colabonent;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coln_category;
        private System.Windows.Forms.BindingSource prom_abonBindingSource;
        private call_centerDataSet1TableAdapters.prom_abonTableAdapter prom_abonTableAdapter;
        private call_centerDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private call_centerDataSet1 call_centerDataSet1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn column;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource sprRaionovBindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcarea;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colcarea2;
        private call_centerDataSet1TableAdapters.sprRaionovTableAdapter sprRaionovTableAdapter;
    }
}
