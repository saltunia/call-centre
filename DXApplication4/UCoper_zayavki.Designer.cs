namespace DXApplication4
{
    partial class UCoper_zayavki
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
            this.operatorszayavkaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.call_centerDataSet = new DXApplication4.call_centerDataSet();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colabon_shet = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colFIO = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colulisa = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldom = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coltel = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colid_operator = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.coltp = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldata_otkl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnote = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldata_vkl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colvid_otkl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colfioUser = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.operators_zayavkaTableAdapter = new DXApplication4.call_centerDataSetTableAdapters.operators_zayavkaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorszayavkaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.operatorszayavkaBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(953, 529);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // operatorszayavkaBindingSource
            // 
            this.operatorszayavkaBindingSource.DataMember = "operators_zayavka";
            this.operatorszayavkaBindingSource.DataSource = this.call_centerDataSet;
            // 
            // call_centerDataSet
            // 
            this.call_centerDataSet.DataSetName = "call_centerDataSet";
            this.call_centerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.advBandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.colabon_shet,
            this.colFIO,
            this.colulisa,
            this.coldom,
            this.coltel,
            this.coltp,
            this.coldata_otkl,
            this.colnote,
            this.colvid_otkl,
            this.coldata_vkl,
            this.colfioUser,
            this.colid_operator});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsBehavior.Editable = false;
            this.advBandedGridView1.OptionsBehavior.ReadOnly = true;
            this.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.advBandedGridView1.OptionsView.ShowAutoFilterRow = true;
            this.advBandedGridView1.OptionsView.ShowFooter = true;
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView1.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.advBandedGridView1_RowStyle);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Данные об абоненте ";
            this.gridBand1.Columns.Add(this.colabon_shet);
            this.gridBand1.Columns.Add(this.colFIO);
            this.gridBand1.Columns.Add(this.colulisa);
            this.gridBand1.Columns.Add(this.coldom);
            this.gridBand1.Columns.Add(this.coltel);
            this.gridBand1.Columns.Add(this.colid_operator);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 576;
            // 
            // colabon_shet
            // 
            this.colabon_shet.Caption = "Лиц.счет";
            this.colabon_shet.FieldName = "abon_shet";
            this.colabon_shet.Name = "colabon_shet";
            this.colabon_shet.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colabon_shet.Visible = true;
            this.colabon_shet.Width = 89;
            // 
            // colFIO
            // 
            this.colFIO.Caption = "Ф.И.О.";
            this.colFIO.FieldName = "FIO";
            this.colFIO.Name = "colFIO";
            this.colFIO.Visible = true;
            this.colFIO.Width = 146;
            // 
            // colulisa
            // 
            this.colulisa.Caption = "Улица";
            this.colulisa.FieldName = "ulisa";
            this.colulisa.Name = "colulisa";
            this.colulisa.Visible = true;
            this.colulisa.Width = 181;
            // 
            // coldom
            // 
            this.coldom.Caption = "Дом/кв";
            this.coldom.FieldName = "dom";
            this.coldom.Name = "coldom";
            this.coldom.Visible = true;
            this.coldom.Width = 69;
            // 
            // coltel
            // 
            this.coltel.Caption = "Телефон";
            this.coltel.FieldName = "tel";
            this.coltel.Name = "coltel";
            this.coltel.Visible = true;
            this.coltel.Width = 91;
            // 
            // colid_operator
            // 
            this.colid_operator.FieldName = "id_operator";
            this.colid_operator.Name = "colid_operator";
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Данные о причине звонка";
            this.gridBand2.Columns.Add(this.coltp);
            this.gridBand2.Columns.Add(this.coldata_otkl);
            this.gridBand2.Columns.Add(this.colnote);
            this.gridBand2.Columns.Add(this.coldata_vkl);
            this.gridBand2.Columns.Add(this.colvid_otkl);
            this.gridBand2.Columns.Add(this.colfioUser);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1000;
            // 
            // coltp
            // 
            this.coltp.Caption = "ТП";
            this.coltp.FieldName = "tp";
            this.coltp.Name = "coltp";
            this.coltp.Visible = true;
            this.coltp.Width = 85;
            // 
            // coldata_otkl
            // 
            this.coldata_otkl.Caption = "Дата/время откл.";
            this.coldata_otkl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldata_otkl.FieldName = "data_otkl";
            this.coldata_otkl.Name = "coldata_otkl";
            this.coldata_otkl.Visible = true;
            this.coldata_otkl.Width = 144;
            // 
            // colnote
            // 
            this.colnote.Caption = "Примечание";
            this.colnote.FieldName = "note";
            this.colnote.Name = "colnote";
            this.colnote.Visible = true;
            this.colnote.Width = 294;
            // 
            // coldata_vkl
            // 
            this.coldata_vkl.Caption = "Дата/время вкл.";
            this.coldata_vkl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldata_vkl.FieldName = "data_vkl";
            this.coldata_vkl.Name = "coldata_vkl";
            this.coldata_vkl.Visible = true;
            this.coldata_vkl.Width = 115;
            // 
            // colvid_otkl
            // 
            this.colvid_otkl.Caption = "Вид откл.";
            this.colvid_otkl.FieldName = "vid_otkl";
            this.colvid_otkl.Name = "colvid_otkl";
            this.colvid_otkl.Visible = true;
            this.colvid_otkl.Width = 137;
            // 
            // colfioUser
            // 
            this.colfioUser.Caption = "Оператор принявший заявку";
            this.colfioUser.FieldName = "fioUser";
            this.colfioUser.Name = "colfioUser";
            this.colfioUser.Visible = true;
            this.colfioUser.Width = 225;
            // 
            // operators_zayavkaTableAdapter
            // 
            this.operators_zayavkaTableAdapter.ClearBeforeFill = true;
            // 
            // UCoper_zayavki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "UCoper_zayavki";
            this.Size = new System.Drawing.Size(956, 532);
            this.Load += new System.EventHandler(this.UCoper_zayavki_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operatorszayavkaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource operatorszayavkaBindingSource;
        private call_centerDataSet call_centerDataSet;
        private call_centerDataSetTableAdapters.operators_zayavkaTableAdapter operators_zayavkaTableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colabon_shet;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colFIO;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colulisa;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldom;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltel;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colid_operator;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coltp;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldata_otkl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnote;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldata_vkl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colvid_otkl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfioUser;
    }
}
