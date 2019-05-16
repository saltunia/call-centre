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
    public partial class UCpredr : DevExpress.XtraEditors.XtraUserControl
    {
        public UCpredr()
        {
            InitializeComponent();
        }

        private void UCpredr_Load(object sender, EventArgs e)
        {
            this.вЛ6_10TableAdapter.Fill(this.call_centerDataSet._ВЛ6_10);
        }
    }
}
