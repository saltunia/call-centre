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
    public partial class UCoper_zayavki : DevExpress.XtraEditors.XtraUserControl
    {
        public UCoper_zayavki()
        {
            InitializeComponent();
        }

        private void UCoper_zayavki_Load(object sender, EventArgs e)
        {
           
             this.operators_zayavkaTableAdapter.Fill(this.call_centerDataSet.operators_zayavka, Globals.idUser);
        }

        private void advBandedGridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
 GridView View = sender as GridView;
 if (e.RowHandle >= 0)
 {
     if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"])) != "")
     {
         e.Appearance.BackColor = Color.YellowGreen;
         e.Appearance.ForeColor = Color.Black;
     }
 }
        }
    }
}
