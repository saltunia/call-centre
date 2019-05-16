using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace DXApplication4
{
    public partial class Otchet : DevExpress.XtraEditors.XtraForm
    {
        public Otchet()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
           
        }

        
        private void Otchet_Load(object sender, EventArgs e)
        {
        
        }

        private void windowsUIButtonPanel1_ButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel tt = sender as DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel;


            if (tt.Buttons[1].Properties.Checked == true)
            {
                tt.Buttons[1].Properties.Checked = false;
                tt.Buttons[0].Properties.Checked = false;
                tt.Buttons[2].Properties.Checked = false;
                tt.Buttons[3].Properties.Checked = false;
                tt.Buttons[4].Properties.Checked = false;
                tt.Buttons[5].Properties.Checked = false;
                tt.Buttons[6].Properties.Checked = false;
                tt.Buttons[7].Properties.Checked = false;
                XtraReport1 report = new XtraReport1();
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();

            }
            if (tt.Buttons[0].Properties.Checked == true)
            {
                tt.Buttons[1].Properties.Checked = false;
                tt.Buttons[0].Properties.Checked = false;
                tt.Buttons[2].Properties.Checked = false;
                tt.Buttons[3].Properties.Checked = false;
                tt.Buttons[4].Properties.Checked = false;
                tt.Buttons[5].Properties.Checked = false;
                tt.Buttons[6].Properties.Checked = false;
                tt.Buttons[7].Properties.Checked = false;
                XtraReport2 report = new XtraReport2();
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();

            }
            if (tt.Buttons[2].Properties.Checked == true)
            {
                tt.Buttons[1].Properties.Checked = false;
                tt.Buttons[0].Properties.Checked = false;
                tt.Buttons[2].Properties.Checked = false;
                tt.Buttons[3].Properties.Checked = false;
                tt.Buttons[4].Properties.Checked = false;
                tt.Buttons[5].Properties.Checked = false;
                tt.Buttons[6].Properties.Checked = false;
                tt.Buttons[7].Properties.Checked = false;
                XtraReport3 report = new XtraReport3();
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();

            }
            if (tt.Buttons[3].Properties.Checked == true)
            {
                tt.Buttons[1].Properties.Checked = false;
                tt.Buttons[0].Properties.Checked = false;
                tt.Buttons[2].Properties.Checked = false;
                tt.Buttons[3].Properties.Checked = false;
                tt.Buttons[4].Properties.Checked = false;
                tt.Buttons[5].Properties.Checked = false;
                tt.Buttons[6].Properties.Checked = false;
                tt.Buttons[7].Properties.Checked = false;
                XtraReport4 report = new XtraReport4();
                ReportPrintTool printTool = new ReportPrintTool(report);
                printTool.ShowPreviewDialog();

            }
        }
    }
}