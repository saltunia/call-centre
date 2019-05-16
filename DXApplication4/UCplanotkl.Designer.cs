namespace DXApplication4
{
    partial class UCplanotkl
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
            this.otklvlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.call_centerDataSet = new DXApplication4.call_centerDataSet();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colvid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colname_tp = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnazvanie_podstansii = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldata_otkl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnazvanie_zavis = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldata_vkl = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnazv_fidera = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colfioUser = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnazvanie_slujby = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.otkl_vlTableAdapter = new DXApplication4.call_centerDataSetTableAdapters.otkl_vlTableAdapter();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.plan04BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.advBandedGridView2 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.colvid1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colname_tp1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldata_otkl1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colremont = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coldata_vkl1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.coladres = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colfioUser1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.colnazvanie_slujby1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.plan04TableAdapter = new DXApplication4.call_centerDataSetTableAdapters.Plan04TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.otklvlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan04BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.otklvlBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(816, 325);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // otklvlBindingSource
            // 
            this.otklvlBindingSource.DataMember = "otkl_vl";
            this.otklvlBindingSource.DataSource = this.call_centerDataSet;
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
            this.colnazvanie_podstansii,
            this.colnazv_fidera,
            this.coldata_otkl,
            this.coldata_vkl,
            this.colname_tp,
            this.colfioUser,
            this.colnazvanie_zavis,
            this.colvid,
            this.colnazvanie_slujby});
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
            this.gridBand1.Caption = "Плановые отключения по ВЛ 6-10 кВ";
            this.gridBand1.Columns.Add(this.colvid);
            this.gridBand1.Columns.Add(this.colname_tp);
            this.gridBand1.Columns.Add(this.colnazvanie_podstansii);
            this.gridBand1.Columns.Add(this.coldata_otkl);
            this.gridBand1.Columns.Add(this.colnazvanie_zavis);
            this.gridBand1.Columns.Add(this.coldata_vkl);
            this.gridBand1.Columns.Add(this.colnazv_fidera);
            this.gridBand1.Columns.Add(this.colfioUser);
            this.gridBand1.Columns.Add(this.colnazvanie_slujby);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1300;
            // 
            // colvid
            // 
            this.colvid.Caption = "Вид отключения";
            this.colvid.FieldName = "vid";
            this.colvid.Name = "colvid";
            this.colvid.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colvid.Visible = true;
            this.colvid.Width = 155;
            // 
            // colname_tp
            // 
            this.colname_tp.Caption = "Название ТП";
            this.colname_tp.FieldName = "name_tp";
            this.colname_tp.Name = "colname_tp";
            this.colname_tp.Visible = true;
            this.colname_tp.Width = 104;
            // 
            // colnazvanie_podstansii
            // 
            this.colnazvanie_podstansii.FieldName = "nazvanie_podstansii";
            this.colnazvanie_podstansii.Name = "colnazvanie_podstansii";
            this.colnazvanie_podstansii.Width = 111;
            // 
            // coldata_otkl
            // 
            this.coldata_otkl.Caption = "Дата/время откл.";
            this.coldata_otkl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldata_otkl.FieldName = "data_otkl";
            this.coldata_otkl.Name = "coldata_otkl";
            this.coldata_otkl.Visible = true;
            this.coldata_otkl.Width = 214;
            // 
            // colnazvanie_zavis
            // 
            this.colnazvanie_zavis.Caption = "Причина";
            this.colnazvanie_zavis.FieldName = "nazvanie_zavis";
            this.colnazvanie_zavis.Name = "colnazvanie_zavis";
            this.colnazvanie_zavis.Visible = true;
            this.colnazvanie_zavis.Width = 180;
            // 
            // coldata_vkl
            // 
            this.coldata_vkl.Caption = "Дата/время вкл.";
            this.coldata_vkl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldata_vkl.FieldName = "data_vkl";
            this.coldata_vkl.Name = "coldata_vkl";
            this.coldata_vkl.Visible = true;
            this.coldata_vkl.Width = 254;
            // 
            // colnazv_fidera
            // 
            this.colnazv_fidera.FieldName = "nazv_fidera";
            this.colnazv_fidera.Name = "colnazv_fidera";
            this.colnazv_fidera.Width = 111;
            // 
            // colfioUser
            // 
            this.colfioUser.Caption = "Ф.И.О.(вводившего)";
            this.colfioUser.FieldName = "fioUser";
            this.colfioUser.Name = "colfioUser";
            this.colfioUser.Visible = true;
            this.colfioUser.Width = 291;
            // 
            // colnazvanie_slujby
            // 
            this.colnazvanie_slujby.Caption = "РЭС";
            this.colnazvanie_slujby.FieldName = "nazvanie_slujby";
            this.colnazvanie_slujby.Name = "colnazvanie_slujby";
            this.colnazvanie_slujby.Visible = true;
            this.colnazvanie_slujby.Width = 102;
            // 
            // otkl_vlTableAdapter
            // 
            this.otkl_vlTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl2.DataSource = this.plan04BindingSource;
            this.gridControl2.Location = new System.Drawing.Point(3, 191);
            this.gridControl2.MainView = this.advBandedGridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(810, 327);
            this.gridControl2.TabIndex = 1;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView2});
            // 
            // plan04BindingSource
            // 
            this.plan04BindingSource.DataMember = "Plan04";
            this.plan04BindingSource.DataSource = this.call_centerDataSet;
            // 
            // advBandedGridView2
            // 
            this.advBandedGridView2.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2});
            this.advBandedGridView2.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.coldata_otkl1,
            this.coldata_vkl1,
            this.coladres,
            this.colname_tp1,
            this.colvid1,
            this.colfioUser1,
            this.colremont,
            this.colnazvanie_slujby1});
            this.advBandedGridView2.GridControl = this.gridControl2;
            this.advBandedGridView2.Name = "advBandedGridView2";
            this.advBandedGridView2.OptionsBehavior.Editable = false;
            this.advBandedGridView2.OptionsBehavior.ReadOnly = true;
            this.advBandedGridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.advBandedGridView2.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.advBandedGridView2.OptionsView.ShowAutoFilterRow = true;
            this.advBandedGridView2.OptionsView.ShowFooter = true;
            this.advBandedGridView2.OptionsView.ShowGroupPanel = false;
            this.advBandedGridView2.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.advBandedGridView2_RowStyle);
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Плановые отключения по ВЛ 0,4 кВ";
            this.gridBand2.Columns.Add(this.colvid1);
            this.gridBand2.Columns.Add(this.colname_tp1);
            this.gridBand2.Columns.Add(this.coldata_otkl1);
            this.gridBand2.Columns.Add(this.colremont);
            this.gridBand2.Columns.Add(this.coldata_vkl1);
            this.gridBand2.Columns.Add(this.coladres);
            this.gridBand2.Columns.Add(this.colfioUser1);
            this.gridBand2.Columns.Add(this.colnazvanie_slujby1);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 0;
            this.gridBand2.Width = 1138;
            // 
            // colvid1
            // 
            this.colvid1.Caption = "Вид отключения";
            this.colvid1.FieldName = "vid";
            this.colvid1.Name = "colvid1";
            this.colvid1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colvid1.Visible = true;
            this.colvid1.Width = 147;
            // 
            // colname_tp1
            // 
            this.colname_tp1.Caption = "Название ТП";
            this.colname_tp1.FieldName = "name_tp";
            this.colname_tp1.Name = "colname_tp1";
            this.colname_tp1.Visible = true;
            this.colname_tp1.Width = 107;
            // 
            // coldata_otkl1
            // 
            this.coldata_otkl1.Caption = "Дата/время откл.";
            this.coldata_otkl1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldata_otkl1.FieldName = "data_otkl";
            this.coldata_otkl1.Name = "coldata_otkl1";
            this.coldata_otkl1.Visible = true;
            this.coldata_otkl1.Width = 226;
            // 
            // colremont
            // 
            this.colremont.Caption = "Причина";
            this.colremont.FieldName = "remont";
            this.colremont.Name = "colremont";
            this.colremont.Visible = true;
            this.colremont.Width = 181;
            // 
            // coldata_vkl1
            // 
            this.coldata_vkl1.Caption = "Дата/время вкл.";
            this.coldata_vkl1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldata_vkl1.FieldName = "data_vkl";
            this.coldata_vkl1.Name = "coldata_vkl1";
            this.coldata_vkl1.Visible = true;
            this.coldata_vkl1.Width = 187;
            // 
            // coladres
            // 
            this.coladres.FieldName = "adres";
            this.coladres.Name = "coladres";
            this.coladres.Width = 162;
            // 
            // colfioUser1
            // 
            this.colfioUser1.Caption = "Ф.И.О.(вводившего)";
            this.colfioUser1.FieldName = "fioUser";
            this.colfioUser1.Name = "colfioUser1";
            this.colfioUser1.Visible = true;
            this.colfioUser1.Width = 162;
            // 
            // colnazvanie_slujby1
            // 
            this.colnazvanie_slujby1.Caption = "РЭС";
            this.colnazvanie_slujby1.FieldName = "nazvanie_slujby";
            this.colnazvanie_slujby1.Name = "colnazvanie_slujby1";
            this.colnazvanie_slujby1.Visible = true;
            this.colnazvanie_slujby1.Width = 128;
            // 
            // plan04TableAdapter
            // 
            this.plan04TableAdapter.ClearBeforeFill = true;
            // 
            // UCplanotkl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl2);
            this.Controls.Add(this.gridControl1);
            this.Name = "UCplanotkl";
            this.Size = new System.Drawing.Size(816, 521);
            this.Load += new System.EventHandler(this.UCplanotkl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.otklvlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plan04BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource otklvlBindingSource;
        private call_centerDataSet call_centerDataSet;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colvid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colname_tp;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnazvanie_podstansii;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldata_otkl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnazvanie_zavis;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldata_vkl;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnazv_fidera;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfioUser;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnazvanie_slujby;
        private call_centerDataSetTableAdapters.otkl_vlTableAdapter otkl_vlTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private System.Windows.Forms.BindingSource plan04BindingSource;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colvid1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colname_tp1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldata_otkl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colremont;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coldata_vkl1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn coladres;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colfioUser1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn colnazvanie_slujby1;
        private call_centerDataSetTableAdapters.Plan04TableAdapter plan04TableAdapter;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
    }
}
