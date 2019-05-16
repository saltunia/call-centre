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
    public partial class updzayavka : DevExpress.XtraEditors.XtraForm
    {
        public updzayavka(UCzayavka jj)
        {
            InitializeComponent();
            gh = jj;
        }

        private void updzayavka_Load(object sender, EventArgs e)
        {
            textEdit1.Text = Globals.uptel;
            textEdit3.Text = Globals.uplishet;
            textEdit4.Text = Globals.uptp;
            textEdit5.Text = Globals.upfio;
            textEdit6.Text = Globals.upadress1;
            textEdit7.Text = Globals.upadress2.Replace(" ", "");
            memoEdit1.Text = Globals.upnote;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        UCzayavka gh;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string ulisa;
            string tp;
            string dom;
            string tel;
            string note;

            if (textEdit4.Text == "")
            { tp = null; }
            else { tp = textEdit4.Text; }

            if (textEdit6.Text == "")
            { ulisa = null; }
            else { ulisa = textEdit6.Text; }

            if (textEdit7.Text == "")
            { dom = null; }
            else { dom = textEdit7.Text; }

            if (textEdit1.Text == "")
            { tel = null; }
            else { tel = textEdit1.Text; }

            if (memoEdit1.Text == "")
            { note = null; }
            else { note = memoEdit1.Text; }
            try
            {
                this.queriesTableAdapter1.tp_proverka(textEdit4.Text);
                queriesTableAdapter1.updzayavkaoperators(Globals.idUser, Globals.uplishet, Globals.upfio, tp, ulisa, dom, tel, note, Globals.updataotkl, Globals.uptp);
                this.Close();
                gh.UCzayavka_Load(sender, e);
               }
            catch
            {
                MessageBox.Show("Этот ТП отсутсвует в классификаторе обратитесь к инженеру по расчетам потерь !!!");
                this.Close();
            }
            
        }

    }
}