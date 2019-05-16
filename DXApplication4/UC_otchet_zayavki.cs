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
using DevExpress.XtraReports.UI;

namespace DXApplication4
{
    public partial class UC_otchet_zayavki : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_otchet_zayavki()
        {
            InitializeComponent();
        }

        private void commandBarItem34_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void snapControl1_Click(object sender, EventArgs e)
        {

        }

        private void UC_otchet_zayavki_Load(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //DevExpress.XtraReports.Parameters.Parameter par = new DevExpress.XtraReports.Parameters.Parameter();
            //this.Parameters.Add(par);
            //par.Value = Globals.sdata;
            //DevExpress.XtraReports.Parameters.Parameter par1 = new DevExpress.XtraReports.Parameters.Parameter();
            //this.Parameters.Add(par1);
            //par1.Value = Globals.podata;
            //
            //DevExpress.XtraReports.Parameters.Parameter par = report.Parameters[0];
            //par.Value = Convert.ToDateTime(dateEdit1.Text);
            //report.Parameters[0] = par;
            //DevExpress.XtraReports.Parameters.Parameter par2 = report.Parameters[1];
            //par2.Value = Convert.ToDateTime(dateEdit2.Text);
            //report.Parameters[1] = par2;
            //report.Parameters.Add(par);
            //report.Parameters.Add(par1);
            
        }

        private void jalobyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.jalobyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.call_centerDataSet1);

        }
    }
}
