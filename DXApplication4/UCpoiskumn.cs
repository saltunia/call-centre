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
    public partial class UCpoiskumn : DevExpress.XtraEditors.XtraUserControl
    {
        public UCpoiskumn()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.poisk_umnTableAdapter.Fill(this.call_centerDataSet.poisk_umn, textEdit1.Text);
            textEdit1.Text = "";
            if (poiskumnBindingSource.Count < 1)
            {
                //this.labelControl2.Text = "По вашему запросу ничего не найдено";
                this.labelControl2.Visible = true;

            }
            else { this.labelControl2.Visible = false; }
            return;
        }

        private void UCpoiskumn_Load(object sender, EventArgs e)
        {
            this.labelControl2.Visible = false;
        }

        private void textEdit1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(null, null);
            }
        }
    }
}
