using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace DXApplication4
{
    public partial class UCplanotkl : DevExpress.XtraEditors.XtraUserControl
    {
        public UCplanotkl()
        {
            InitializeComponent();
        }

        private void UCplanotkl_Load(object sender, EventArgs e)
        {
            DateTime s = DateTime.Today;
            DateTime d = DateTime.Today.AddDays(7);
            this.otkl_vlTableAdapter.Fill(this.call_centerDataSet.otkl_vl, s, d);
            this.plan04TableAdapter.Fill(this.call_centerDataSet.Plan04, s, d);

        }

        private void advBandedGridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"])) == "")
                {
                    e.Appearance.BackColor = Color.Pink;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    DateTime d = DateTime.Now;
                    DateTime s = Convert.ToDateTime(View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"]));
                    if (s > d)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.YellowGreen;
                        e.Appearance.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void advBandedGridView1_RowStyle(object sender, RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"])) == "")
                {
                    e.Appearance.BackColor = Color.Pink;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    DateTime d = DateTime.Now;
                    DateTime s = Convert.ToDateTime(View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"]));
                    if (s > d)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.YellowGreen;
                        e.Appearance.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
