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
using DXApplication4.Properties;

namespace DXApplication4
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.users_programmTableAdapter.FillByLogin(this.call_centerDataSet1.users_programm, textEdit1.Text.Trim(), textEdit2.Text.Trim());

            if (call_centerDataSet1 != null && call_centerDataSet1.users_programm.Count > 0)
            {
                Settings.Default.UserNowName = textEdit1.Text;
                Settings.Default.UserNow = (int)((DataRowView)BSUsers.Current).Row["id"];
                Globals.idUser = (int)((DataRowView)BSUsers.Current).Row["id"];
                Globals.nameUser = (string)((DataRowView)BSUsers.Current).Row["fioUser"];
                Globals.tDivision1 = (int)((DataRowView)BSUsers.Current).Row["slujba"];
                
                Globals.access = (int)((DataRowView)BSUsers.Current).Row["access"];
                Globals.zavis = (int)((DataRowView)BSUsers.Current).Row["zavis"];
                Settings.Default.Save();   
                //Form f = new Main();
                //f.ShowDialog();
                Close();
                Dispose();
                



            }
            else
            {
                textEdit1.SelectAll();
                textEdit2.Text = "";
                textEdit1.Focus();
                pictureBox1.Visible = false;
                labelControl3.Visible = true;
                return;
            }
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            textEdit1.Text = Settings.Default.UserNowName;
            labelControl3.Visible = false;
        try { this.users_programmTableAdapter.Fill(this.call_centerDataSet1.users_programm); }
        catch
        {
            MessageBox.Show("Не подключен к БД");
        }
            
           
        }

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton1_Click(null, null);
            }
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}