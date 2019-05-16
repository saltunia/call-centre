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

namespace DXApplication4
{
    public partial class UCprom : DevExpress.XtraEditors.XtraUserControl
    {
        public UCprom()
        {
            InitializeComponent();
        }

       
       

        private void UCprom_Load(object sender, EventArgs e)
        {
            sprRaionovTableAdapter.Fill(this.call_centerDataSet1.sprRaionov);
            if (Globals.access == 16 || Globals.access ==10 )
            {
                this.prom_abonTableAdapter.FillByAll(this.call_centerDataSet1.prom_abon);
                int t=prom_abonBindingSource.Count;
            }
            else {
                this.prom_abonTableAdapter.FillBy(this.call_centerDataSet1.prom_abon,Globals.tDivision1);
            }
        }

        private void advBandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            Globals.select_taby2();
            Globals.select_taby3();
        }

        private void prom_abonGridControl_DoubleClick(object sender, EventArgs e)
        {
            advBandedGridView1_DoubleClick(sender,e);
        }

        private void prom_abonBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }

        private void prom_abonBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
             Globals.abonshet = (string)((DataRowView)(prom_abonBindingSource.Current)).Row["nch"];
             Globals.raion_prom= (int)((DataRowView)(prom_abonBindingSource.Current)).Row["raion"];
        }
    }
}
