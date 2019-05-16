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
using System.Data.SqlClient;

namespace DXApplication4
{
    public partial class zayavka_nulltp : DevExpress.XtraEditors.XtraForm
    {
        public zayavka_nulltp(UCzayavka sd)
        {
            InitializeComponent();
            sh = sd;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        UCzayavka sh;
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
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
                DateTime s = DateTime.Today;
                DateTime d = DateTime.Today.AddHours(23.0).AddMinutes(59.0);
                if (textEdit7.Text == "")
                {
                    str1 = "";
                }
                else
                {
                    str1 = textEdit7.Text.Replace(" ", "");
                }
                #region
                if (textEdit4.Text == "0")
                {

                    queriesTableAdapter3.zayavkanulltp(Globals.idUser, Globals.clishet, Globals.cfio, textEdit4.Text, Globals.cadress1, str1, tel, note, 0, DateTime.Now, null, null, Globals.craion);
                    this.Close();
                    sh.UCzayavka_Load(sender, e);
                }
                else
                {
                    this.callcpoisk6TableAdapter.Fill(this.call_centerDataSet.callcpoisk6, textEdit4.Text);
                    
                        if (callcpoisk6BindingSource.Count < 1)
                        {

                            this.callcpoisk4TableAdapter.Fill(this.call_centerDataSet.callcpoisk4, textEdit4.Text);


                        }
                        else
                        {


                            return;
                        }

                        this.callcpoisk35TableAdapter.Fill(this.call_centerDataSet.callcpoisk35, textEdit4.Text);

                        if (callcpoisk35BindingSource.Count > 0)
                        {
                            string dt_vkl;
                            if (((DataRowView)(callcpoisk35BindingSource.Current)).Row["date_vkl"].ToString() == "")
                            { dt_vkl = null; }
                            else
                            {
                                dt_vkl = Convert.ToString((DateTime)((DataRowView)(callcpoisk35BindingSource.Current)).Row["date_vkl"]);
                            }
                            string ps = (string)((DataRowView)(callcpoisk35BindingSource.Current)).Row["nazvanie_podstansii"];
                            string dt_otkl = Convert.ToString((DateTime)((DataRowView)(callcpoisk35BindingSource.Current)).Row["date_otkl"]);
                            string prichina = (string)((DataRowView)(callcpoisk35BindingSource.Current)).Row["prihina"];
                            MessageBox.Show("Отключена подстанция: " + ps + "\n" + "Дата/время откл: " + dt_otkl + "\n" + "Дата/время вкл: " + dt_vkl + "\n" + "Причина откл: " + prichina);
                            return;


                        }


                        bool ee;
                        this.abontpTableAdapter.Fill(this.call_centerDataSet.abontp, textEdit4.Text);
                        if ((bool)((DataRowView)(abontpBindingSource.Current)).Row["abon"] == false)
                        { ee = false; }
                        ee = (bool)((DataRowView)(abontpBindingSource.Current)).Row["abon"];
                        if (abontpBindingSource.Count > 0 && ee == false)
                        {
                            if (callcpoisk4BindingSource.Count == 0)
                            {
                                this.queriesTableAdapter3.tp_proverka(textEdit4.Text, Globals.craion);
                                this.queriesTableAdapter3.callcaddzayavka(Globals.idUser, Globals.clishet, Globals.cfio, textEdit4.Text, Globals.cadress1, str1, tel, note, null, data_otkl, str0 + "(" + str1 + ")", Globals.craion);
                                this.Close();
                                sh.UCzayavka_Load(sender, e);
                            }
                            else
                            {
                                try
                                {


                                    queriesTableAdapter3.updzayavka(Globals.idUser, Globals.clishet, Globals.cfio, textEdit4.Text, Globals.cadress1, str1, null, null, null, data_otkl, s, d);
                                }
                                catch { MessageBox.Show("Вы нам уже звонили!!!"); }
                            }



                        }
                        else
                        {


                            //MessageBox.Show("ТП абонентский, заявка отправлена в энергосбыт(стол заявок)");
                            //kryptonTextBox1.Text = "";
                            try
                            {

                                this.queriesTableAdapter3.proverka(Globals.clishet, s, d);
                                MessageBox.Show("Вы нам уже звонили!!!");
                                textEdit4.Text = "";


                            }
                            // TODO: данная строка кода позволяет загрузить данные в таблицу "call_centerDataSet.call_c". При необходимости она может быть перемещена или удалена.
                            catch
                            {
                                textEdit4.Text = "";
                                //Form f = new energosbyt();
                                //f.Show();
                            }
                            return;
                        }
                    }
                #endregion
                
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
        }

        private void zayavka_nulltp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'call_centerDataSet1.otkl_succes1' table. You can move, or remove it, as needed.
          
            textEdit3.Text = Globals.clishet;
            textEdit4.Text = Globals.ctp;
            textEdit5.Text = Globals.cfio;
            textEdit6.Text = Globals.cadress1;
            textEdit7.Text = Globals.cadress2;
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
            textEdit11.Text = ""; }
            textEdit10.Text = Globals.cakt.ToString();
        }
    }
}