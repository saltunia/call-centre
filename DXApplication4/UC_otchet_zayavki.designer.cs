namespace DXApplication4
{
    partial class UC_otchet_zayavki
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
            this.call_centerDataSet1 = new DXApplication4.call_centerDataSet1();
            this.jalobyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jalobyTableAdapter = new DXApplication4.call_centerDataSet1TableAdapters.JalobyTableAdapter();
            this.tableAdapterManager = new DXApplication4.call_centerDataSet1TableAdapters.TableAdapterManager();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colraion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_prin_jalob = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrichina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkomu_slujba = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colvypolnen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colotv_liso = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jalobyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // call_centerDataSet1
            // 
            this.call_centerDataSet1.DataSetName = "call_centerDataSet1";
            this.call_centerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jalobyBindingSource
            // 
            this.jalobyBindingSource.DataMember = "Jaloby";
            this.jalobyBindingSource.DataSource = this.call_centerDataSet1;
            // 
            // jalobyTableAdapter
            // 
            this.jalobyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
           // this.tableAdapterManager.abonTableAdapter = null;
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
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.jalobyBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(3, 67);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(886, 396);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colid,
            this.colraion,
            this.colFIO,
            this.coldata_prin_jalob,
            this.colAdres,
            this.coltel,
            this.colPrichina,
            this.coluser_id,
            this.colkomu_slujba,
            this.colvypolnen,
            this.colotv_liso});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colid
            // 
            this.colid.FieldName = "id";
            this.colid.Name = "colid";
            this.colid.OptionsColumn.ReadOnly = true;
            this.colid.Visible = true;
            this.colid.VisibleIndex = 0;
            // 
            // colraion
            // 
            this.colraion.FieldName = "raion";
            this.colraion.Name = "colraion";
            this.colraion.Visible = true;
            this.colraion.VisibleIndex = 1;
            // 
            // colFIO
            // 
            this.colFIO.FieldName = "FIO";
            this.colFIO.Name = "colFIO";
            this.colFIO.Visible = true;
            this.colFIO.VisibleIndex = 2;
            // 
            // coldata_prin_jalob
            // 
            this.coldata_prin_jalob.FieldName = "data_prin_jalob";
            this.coldata_prin_jalob.Name = "coldata_prin_jalob";
            this.coldata_prin_jalob.Visible = true;
            this.coldata_prin_jalob.VisibleIndex = 3;
            // 
            // colAdres
            // 
            this.colAdres.FieldName = "Adres";
            this.colAdres.Name = "colAdres";
            this.colAdres.Visible = true;
            this.colAdres.VisibleIndex = 4;
            // 
            // coltel
            // 
            this.coltel.FieldName = "tel";
            this.coltel.Name = "coltel";
            this.coltel.Visible = true;
            this.coltel.VisibleIndex = 5;
            // 
            // colPrichina
            // 
            this.colPrichina.FieldName = "Prichina";
            this.colPrichina.Name = "colPrichina";
            this.colPrichina.Visible = true;
            this.colPrichina.VisibleIndex = 6;
            // 
            // coluser_id
            // 
            this.coluser_id.FieldName = "user_id";
            this.coluser_id.Name = "coluser_id";
            this.coluser_id.Visible = true;
            this.coluser_id.VisibleIndex = 7;
            // 
            // colkomu_slujba
            // 
            this.colkomu_slujba.FieldName = "komu_slujba";
            this.colkomu_slujba.Name = "colkomu_slujba";
            this.colkomu_slujba.Visible = true;
            this.colkomu_slujba.VisibleIndex = 8;
            // 
            // colvypolnen
            // 
            this.colvypolnen.FieldName = "vypolnen";
            this.colvypolnen.Name = "colvypolnen";
            this.colvypolnen.Visible = true;
            this.colvypolnen.VisibleIndex = 9;
            // 
            // colotv_liso
            // 
            this.colotv_liso.FieldName = "otv_liso";
            this.colotv_liso.Name = "colotv_liso";
            this.colotv_liso.Visible = true;
            this.colotv_liso.VisibleIndex = 10;
            // 
            // UC_otchet_zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "UC_otchet_zayavki";
            this.Size = new System.Drawing.Size(892, 466);
            this.Load += new System.EventHandler(this.UC_otchet_zayavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jalobyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private call_centerDataSet1 call_centerDataSet1;
        private System.Windows.Forms.BindingSource jalobyBindingSource;
        private call_centerDataSet1TableAdapters.JalobyTableAdapter jalobyTableAdapter;
        private call_centerDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colid;
        private DevExpress.XtraGrid.Columns.GridColumn colraion;
        private DevExpress.XtraGrid.Columns.GridColumn colFIO;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_prin_jalob;
        private DevExpress.XtraGrid.Columns.GridColumn colAdres;
        private DevExpress.XtraGrid.Columns.GridColumn coltel;
        private DevExpress.XtraGrid.Columns.GridColumn colPrichina;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_id;
        private DevExpress.XtraGrid.Columns.GridColumn colkomu_slujba;
        private DevExpress.XtraGrid.Columns.GridColumn colvypolnen;
        private DevExpress.XtraGrid.Columns.GridColumn colotv_liso;

    }
}
