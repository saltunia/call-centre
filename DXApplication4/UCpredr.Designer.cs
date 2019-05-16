namespace DXApplication4
{
    partial class UCpredr
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
            this.вЛ610BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.call_centerDataSet = new DXApplication4.call_centerDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colnazvanie_podstansii = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnazv_fidera = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_otkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coldata_vkl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname_tp = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnomer_tel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkategory = new DevExpress.XtraGrid.Columns.GridColumn();
            this.вЛ6_10TableAdapter = new DXApplication4.call_centerDataSetTableAdapters.ВЛ6_10TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вЛ610BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.DataSource = this.вЛ610BindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1005, 526);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // вЛ610BindingSource
            // 
            this.вЛ610BindingSource.DataMember = "ВЛ6-10";
            this.вЛ610BindingSource.DataSource = this.call_centerDataSet;
            // 
            // call_centerDataSet
            // 
            this.call_centerDataSet.DataSetName = "call_centerDataSet";
            this.call_centerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colnazvanie_podstansii,
            this.colnazv_fidera,
            this.coldata_otkl,
            this.coldata_vkl,
            this.colname_tp,
            this.colname,
            this.colnomer_tel,
            this.colkategory});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colnazvanie_podstansii
            // 
            this.colnazvanie_podstansii.Caption = "Подстанция";
            this.colnazvanie_podstansii.FieldName = "nazvanie_podstansii";
            this.colnazvanie_podstansii.Name = "colnazvanie_podstansii";
            this.colnazvanie_podstansii.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count)});
            this.colnazvanie_podstansii.Visible = true;
            this.colnazvanie_podstansii.VisibleIndex = 0;
            this.colnazvanie_podstansii.Width = 147;
            // 
            // colnazv_fidera
            // 
            this.colnazv_fidera.Caption = "Фидер";
            this.colnazv_fidera.FieldName = "nazv_fidera";
            this.colnazv_fidera.Name = "colnazv_fidera";
            this.colnazv_fidera.Visible = true;
            this.colnazv_fidera.VisibleIndex = 1;
            this.colnazv_fidera.Width = 155;
            // 
            // coldata_otkl
            // 
            this.coldata_otkl.Caption = "Дата/время откл.";
            this.coldata_otkl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldata_otkl.FieldName = "data_otkl";
            this.coldata_otkl.Name = "coldata_otkl";
            this.coldata_otkl.Visible = true;
            this.coldata_otkl.VisibleIndex = 2;
            this.coldata_otkl.Width = 109;
            // 
            // coldata_vkl
            // 
            this.coldata_vkl.Caption = "Дата/время вкл.";
            this.coldata_vkl.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.coldata_vkl.FieldName = "data_vkl";
            this.coldata_vkl.Name = "coldata_vkl";
            this.coldata_vkl.Visible = true;
            this.coldata_vkl.VisibleIndex = 3;
            this.coldata_vkl.Width = 109;
            // 
            // colname_tp
            // 
            this.colname_tp.Caption = "Название ТП";
            this.colname_tp.FieldName = "name_tp";
            this.colname_tp.Name = "colname_tp";
            this.colname_tp.Visible = true;
            this.colname_tp.VisibleIndex = 4;
            this.colname_tp.Width = 109;
            // 
            // colname
            // 
            this.colname.Caption = "Абонент";
            this.colname.FieldName = "name";
            this.colname.Name = "colname";
            this.colname.Visible = true;
            this.colname.VisibleIndex = 5;
            this.colname.Width = 139;
            // 
            // colnomer_tel
            // 
            this.colnomer_tel.Caption = "Телефон";
            this.colnomer_tel.FieldName = "nomer_tel";
            this.colnomer_tel.Name = "colnomer_tel";
            this.colnomer_tel.Visible = true;
            this.colnomer_tel.VisibleIndex = 6;
            this.colnomer_tel.Width = 94;
            // 
            // colkategory
            // 
            this.colkategory.Caption = "Категория";
            this.colkategory.FieldName = "kategory";
            this.colkategory.Name = "colkategory";
            this.colkategory.Visible = true;
            this.colkategory.VisibleIndex = 7;
            this.colkategory.Width = 107;
            // 
            // вЛ6_10TableAdapter
            // 
            this.вЛ6_10TableAdapter.ClearBeforeFill = true;
            // 
            // UCpredr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Name = "UCpredr";
            this.Size = new System.Drawing.Size(1008, 526);
            this.Load += new System.EventHandler(this.UCpredr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.вЛ610BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource вЛ610BindingSource;
        private call_centerDataSet call_centerDataSet;
        private DevExpress.XtraGrid.Columns.GridColumn colnazvanie_podstansii;
        private DevExpress.XtraGrid.Columns.GridColumn colnazv_fidera;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_otkl;
        private DevExpress.XtraGrid.Columns.GridColumn coldata_vkl;
        private DevExpress.XtraGrid.Columns.GridColumn colname_tp;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colnomer_tel;
        private DevExpress.XtraGrid.Columns.GridColumn colkategory;
        private call_centerDataSetTableAdapters.ВЛ6_10TableAdapter вЛ6_10TableAdapter;
    }
}
