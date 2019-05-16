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
    public partial class addzayavka : DevExpress.XtraEditors.XtraForm
    {
        public addzayavka(UCzayavka xc)
        {
            InitializeComponent();
            Bo = xc;
        }

        private void addzayavka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'call_centerDataSet1.otkl_succes1' table. You can move, or remove it, as needed.
          
            textEdit3.Text = Globals.clishet;
            textEdit4.Text = Globals.ctp;
            textEdit5.Text = Globals.cfio;
            textEdit6.Text = Globals.cadress1;
            textEdit7.Text = Globals.cadress2;
            textEdit12.Text = Globals.czavnom;
            textEdit13.Text = Globals.tip_shetchika;
            textEdit8.Text = Globals.cdebet.ToString();
            textEdit9.Text = Globals.cpenya.ToString(); 
            this.otkl_succes1TableAdapter.FillByZavnomer(this.call_centerDataSet1.otkl_succes1,Globals.czavnom);
            if(otkl_succes1BindingSource.Count>0)
            { textEdit11.Text = (string)((DataRowView)(otkl_succes1BindingSource.Current)).Row["timeout"];
            textEdit2.Text = Convert.ToString((DateTime)((DataRowView)(otkl_succes1BindingSource.Current)).Row["data_vkl"]);
            }
            else { 
            textEdit2.Text = "";
            textEdit11.Text = "";}
            textEdit10.Text = Globals.cakt.ToString();
            int raion = Globals.craion;
        }

        UCzayavka Bo;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string tel;
            string note;
            if (memoEdit1.Text == "")
            { note = null; }
            else { note = memoEdit1.Text; }

            if (textEdit1.Text == "")
            { tel = null; }
            else { tel = textEdit1.Text; }
            DateTime? data_otkl = DateTime.Now;
            string str0 = Globals.cadress1.Replace(" ", "");
            string str1;
            if (textEdit7.Text == "")
            {
                str1 = "";
            }
            else
            {
                str1 = textEdit7.Text.Replace(" ", "");
            }
            try
            {
                this.queriesTableAdapter2.tp_proverka(textEdit4.Text,Globals.craion);
                this.queriesTableAdapter2.callcaddzayavka(Globals.idUser, Globals.clishet, Globals.cfio, textEdit4.Text, Globals.cadress1, Globals.cadress2, tel, note, null, data_otkl, str0 + "(" + str1 + ")",Globals.craion);
                this.Close();
                Bo.UCzayavka_Load(sender, e);
            }
            catch
            {
                MessageBox.Show("Этот ТП отсутсвует в классификаторе обратитесь к инженеру по расчетам потерь !!!");
                this.Close();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}