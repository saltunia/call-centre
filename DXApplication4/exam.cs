using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DXApplication4
{
    public partial class exam : DevExpress.XtraEditors.XtraForm
    {
        public exam()
        {
            InitializeComponent();
        }

        private void exam_Load(object sender, EventArgs e)
        {
            DateTime s = DateTime.Today;
            DateTime d = DateTime.Today.AddHours(23.0).AddMinutes(59.0);
            // TODO: This line of code loads data into the 'call_centerDataSet1.call_c' table. You can move, or remove it, as needed.
            this.call_cTableAdapter.FillBy1(this.call_centerDataSet1.call_c,s,d);

        }
    }
}