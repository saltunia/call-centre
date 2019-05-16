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
    public partial class UCbyt : DevExpress.XtraEditors.XtraUserControl
    {
        public UCbyt()
        {
            InitializeComponent();
          
        }

        private void UCbyt_Load(object sender, EventArgs e)
        {
            sprRaionovTableAdapter.Fill(this.call_centerDataSet1.sprRaionov);
            if (Globals.access == 16 || Globals.access == 10)
            {
                this.abonTableAdapter.Fill(this.call_centerDataSet1.abon);
            }
            else { this.abonTableAdapter.FillBy(this.call_centerDataSet1.abon, Globals.tDivision1); }
        }

        private void abonBindingSource_CurrentChanged(object sender, EventArgs e)
        {
           
        }
       
        private void advBandedGridView1_DoubleClick(object sender, EventArgs e)
        {
            Globals.select_taby();
            Globals.select_taby1();
            Globals.setFocus1();
           
        }

        private void UCbyt_DoubleClick(object sender, EventArgs e)
        {
            advBandedGridView1_DoubleClick(sender, e);
        }

        private void abonBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            Globals.abonshet = (string)((DataRowView)(abonBindingSource.Current)).Row["nch"];
        }

        
    }
}
