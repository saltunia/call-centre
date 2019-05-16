using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace DXApplication4
{
    public partial class Sbyt : DevExpress.XtraEditors.XtraForm
    {
        public Sbyt()
        {
            InitializeComponent();
        }

        private void Sbyt_Load(object sender, EventArgs e)
        {
            this.users_programmTableAdapter.Fill(call_centerDataSet1.users_programm);
            this.sprRaionovTableAdapter.Fill(call_centerDataSet1.sprRaionov);
            if (Globals.tDivision1 == 19)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Свердловский)"); }
            if (Globals.tDivision1 == 18)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Октябрьский)"); }
            if (Globals.tDivision1 == 17)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Ленинский)"); }
            if (Globals.tDivision1 == 16)
            { jalobyTableAdapter1.FillByNull1(call_centerDataSet1.Jaloby, "БЭС(Первомайский)", "БЭС(Кастромская)"); }
             if (Globals.tDivision1 == 4)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Аламединский)"); }
             if (Globals.tDivision1 == 25)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Ленинский)"); }
             if (Globals.tDivision1 == 24)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Лебединовский)"); }
             if (Globals.tDivision1 == 26)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Воронцовский)"); }
             if (Globals.tDivision1 == 10)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "Сокулукский"); }
        }

        private void simpleButton9_Click(object sender, EventArgs e)
        {
            if (Globals.tDivision1 == 19)
            { jalobyTableAdapter1.FillByRaion(call_centerDataSet1.Jaloby, "БЭС(Свердловский)"); }
            if (Globals.tDivision1 == 18)
            { jalobyTableAdapter1.FillByRaion(call_centerDataSet1.Jaloby, "БЭС(Октябрьский)"); }
            if (Globals.tDivision1 == 17)
            { jalobyTableAdapter1.FillByRaion(call_centerDataSet1.Jaloby, "БЭС(Ленинский)"); }
            if (Globals.tDivision1 == 16)
            { jalobyTableAdapter1.FillByRaion1(call_centerDataSet1.Jaloby, "БЭС(Первомайский)", "БЭС(Кастромская)"); }
            if (Globals.tDivision1 == 4)
            { jalobyTableAdapter1.FillByRaion(call_centerDataSet1.Jaloby, "АРЭС(Аламединский)"); }
            if (Globals.tDivision1 == 10)
            { jalobyTableAdapter1.FillByRaion(call_centerDataSet1.Jaloby, "Сокулукский"); }
            if (Globals.tDivision1 == 25)
            { jalobyTableAdapter1.FillByRaion(call_centerDataSet1.Jaloby, "АРЭС(Ленинский)"); }
            if (Globals.tDivision1 == 24)
            { jalobyTableAdapter1.FillByRaion(call_centerDataSet1.Jaloby, "АРЭС(Лебединовский)"); }
            if (Globals.tDivision1 == 26)
            { jalobyTableAdapter1.FillByRaion(call_centerDataSet1.Jaloby, "АРЭС(Воронцовский)"); }
        }

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (Globals.tDivision1 == 19)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Свердловский)"); }
            if (Globals.tDivision1 == 18)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Октябрьский)"); }
            if (Globals.tDivision1 == 17)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Ленинский)"); }
            if (Globals.tDivision1 == 16)
            { jalobyTableAdapter1.FillByNull1(call_centerDataSet1.Jaloby, "БЭС(Первомайский)", "БЭС(Кастромская)"); }
            if (Globals.tDivision1 == 4)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Аламединский)"); }
            if (Globals.tDivision1 == 10)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "Сокулукский"); }
            if (Globals.tDivision1 == 25)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Ленинский)"); }
            if (Globals.tDivision1 == 24)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Лебединовский)"); }
            if (Globals.tDivision1 == 26)
            { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Воронцовский)"); }
            
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            DateTime s = Convert.ToDateTime(dateEdit1.Text);
            DateTime d = Convert.ToDateTime(dateEdit2.Text);
            if (Globals.tDivision1 == 19)
            { jalobyTableAdapter1.FillByRDate(call_centerDataSet1.Jaloby, "БЭС(Свердловский)", s, d); }
            if (Globals.tDivision1 == 18)
            { jalobyTableAdapter1.FillByRDate(call_centerDataSet1.Jaloby, "БЭС(Октябрьский)", s, d); }
            if (Globals.tDivision1 == 17)
            { jalobyTableAdapter1.FillByRDate(call_centerDataSet1.Jaloby, "БЭС(Ленинский)", s, d); }
            if (Globals.tDivision1 == 16)
            { jalobyTableAdapter1.FillByRDate1(call_centerDataSet1.Jaloby, "БЭС(Первомайский)", "БЭС(Кастромская)", s, d); }
            if (Globals.tDivision1 == 4)
            { jalobyTableAdapter1.FillByRDate(call_centerDataSet1.Jaloby, "АРЭС(Аламединский)", s, d); }
            if (Globals.tDivision1 == 10)
            { jalobyTableAdapter1.FillByRDate(call_centerDataSet1.Jaloby, "Сокулукский", s, d); }
            if (Globals.tDivision1 == 25)
            { jalobyTableAdapter1.FillByRDate(call_centerDataSet1.Jaloby, "АРЭС(Ленинский)", s, d); }
            if (Globals.tDivision1 == 24)
            { jalobyTableAdapter1.FillByRDate(call_centerDataSet1.Jaloby, "АРЭС(Лебединовский)", s, d); }
            if (Globals.tDivision1 == 26)
            { jalobyTableAdapter1.FillByRDate(call_centerDataSet1.Jaloby, "АРЭС(Воронцовский)", s, d); }
        }

        private void advBandedGridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["vypolnen"])) != "")
                {
                    e.Appearance.BackColor = Color.YellowGreen;
                    e.Appearance.ForeColor = Color.Black;
                }
                if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["vypolnen"])) != "" && (View.GetRowCellDisplayText(e.RowHandle, View.Columns["otmena"])) == "1")
                {
                    e.Appearance.BackColor = Color.FromArgb(0xFF, 0x99, 0x99);
                    e.Appearance.ForeColor = Color.Black;
                }
            }
        }

        private void advBandedGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            simpleButton11_Click(sender, e);
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {
            try
            {
                var rowHandle = advBandedGridView1.FocusedRowHandle;
                Globals.jid = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                string otvet = (string)advBandedGridView1.GetRowCellValue(rowHandle, "vypolnen");
                jalobyTableAdapter1.UpdateOtvet(otvet, Globals.nameUser,Globals.jid);
                if (Globals.tDivision1 == 19)
                { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Свердловский)"); }
                if (Globals.tDivision1 == 18)
                { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Октябрьский)"); }
                if (Globals.tDivision1 == 17)
                { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Ленинский)"); }
                if (Globals.tDivision1 == 16)
                { jalobyTableAdapter1.FillByNull1(call_centerDataSet1.Jaloby, "БЭС(Первомайский)", "БЭС(Кастромская)"); }
                if (Globals.tDivision1 == 4)
                { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Аламединский)"); }
                if (Globals.tDivision1 == 10)
                { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "Сокулукский"); }
                if (Globals.tDivision1 == 25)
                { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Ленинский)"); }
                if (Globals.tDivision1 == 24)
                { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Лебединовский)"); }
                if (Globals.tDivision1 == 26)
                { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Воронцовский)"); }
                MessageBox.Show("Данные успешно сохранены");
            }

            catch {  }

        }

        private void jalobyBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
            try { 
                Globals.jid = (int)((DataRowView)(jalobyBindingSource1.Current)).Row["id"]; }
            catch { }
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             ToolStripItem l = e.ClickedItem;

             if (l.Name == "toolStripMenuItem1")
             {
                 jalobyTableAdapter1.UpdateRaion("БЭС(Первомайский)", Globals.jid);
             }
             if (l.Name == "toolStripMenuItem2")
             { jalobyTableAdapter1.UpdateRaion("БЭС(Октябрьский)", Globals.jid); }
             if (l.Name == "toolStripMenuItem3")
             { jalobyTableAdapter1.UpdateRaion("БЭС(Ленинский)", Globals.jid); }
             if (l.Name == "toolStripMenuItem4")
             { jalobyTableAdapter1.UpdateRaion("БЭС(Свердловский)", Globals.jid); }
             if (l.Name == "ToolStripMenuItem5")
             { jalobyTableAdapter1.UpdateRES( Globals.jid); }
             if (Globals.tDivision1 == 19)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Свердловский)"); }
             if (Globals.tDivision1 == 18)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Октябрьский)"); }
             if (Globals.tDivision1 == 17)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "БЭС(Ленинский)"); }
             if (Globals.tDivision1 == 16)
             { jalobyTableAdapter1.FillByNull1(call_centerDataSet1.Jaloby, "БЭС(Первомайский)", "БЭС(Кастромская)"); }
             if (Globals.tDivision1 == 4)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Аламединский)"); }
             if (Globals.tDivision1 == 10)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "Сокулукский"); }
             if (Globals.tDivision1 == 25)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Ленинский)"); }
             if (Globals.tDivision1 == 24)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Лебединовский)"); }
             if (Globals.tDivision1 == 26)
             { jalobyTableAdapter1.FillByNull(call_centerDataSet1.Jaloby, "АРЭС(Воронцовский)"); }
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }
        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ShowGridPreview(jalobyGridControl);
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        
    }
}