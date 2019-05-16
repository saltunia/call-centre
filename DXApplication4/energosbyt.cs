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

namespace DXApplication4
{
    public partial class energosbyt : DevExpress.XtraEditors.XtraForm
    {
        public energosbyt()
        {
            InitializeComponent();
        }

        private void energosbyt_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'call_centerDataSet1.otkl_succes1' table. You can move, or remove it, as needed.
          
            textEdit3.Text = Globals.clishet;
            textEdit4.Text = Globals.ctp;
            textEdit5.Text = Globals.cfio;
            textEdit6.Text = Globals.cadress1;
            textEdit7.Text = Globals.cadress2.Replace(" ", "");
            textEdit8.Text = Globals.cdebet.ToString();
            textEdit9.Text = Globals.cpenya.ToString();
            textEdit12.Text = Globals.czavnom;
            textEdit13.Text = Globals.tip_shetchika;
            this.otkl_succes1TableAdapter.FillByZavnomer(this.call_centerDataSet1.otkl_succes1, Globals.czavnom);
            if (otkl_succes1BindingSource.Count > 0)
            {
                textEdit11.Text = (string)((DataRowView)(otkl_succes1BindingSource.Current)).Row["timeout"];
                textEdit2.Text = Convert.ToString((DateTime)((DataRowView)(otkl_succes1BindingSource.Current)).Row["data_vkl"]);
            }
            else { 
            textEdit2.Text = "";
            textEdit11.Text = "";}
            textEdit10.Text = Globals.cakt.ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DateTime? data_otkl = DateTime.Now;
            try
            {
                this.queriesTableAdapter1.energosbyt(Globals.idUser, Globals.clishet, Globals.cfio, Globals.ctp, Globals.cadress1, Globals.cadress2, textEdit1.Text, memoEdit1.Text, null, data_otkl, Globals.craion);
                this.Close();
            }
            catch { MessageBox.Show("Заявка не оформлена"); }
        }
    }
}