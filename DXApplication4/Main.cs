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
    public partial class Main : DevExpress.XtraEditors.XtraForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void tileItem2_ItemDoubleClick(object sender, TileItemEventArgs e)
        {
            
             
        }

        private void tileItem2_ItemClick(object sender, TileItemEventArgs e)
        { 
            Form d =new Form1();
             d.Show();

        }

        private void tileControl1_Click(object sender, EventArgs e)
        {

        }

        private void tileItem5_ItemClick(object sender, TileItemEventArgs e)
        {
           
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Globals.access == 10)
            {
                this.Text = "Вы вошли как: " + Globals.nameUser;

            }
            if (Globals.access == 32)
            {
                this.Text = "Вы вошли как: " + Globals.nameUser;
                tileItem8.Enabled = false;

            }

            if (Globals.access == 16)
            {
                this.Text = "Вы вошли как: " + Globals.nameUser;

            }
            if (Globals.access == 1)
            {
                this.Text = "Вы вошли как: " + Globals.nameUser;

            }
            if (Globals.access == 24)
            {
                this.Text = "Вы вошли как: " + Globals.nameUser;


            }
            if (Globals.access == 48)
            {
                this.Text = "Вы вошли как: " + Globals.nameUser;
                tileItem4.Enabled = true;

            }
            if (Globals.access == 33)
            {
                this.Text = "Вы вошли как: " + Globals.nameUser;
                tileItem1.Enabled=false;
                    tileItem2.Enabled=false;
                    tileItem4.Enabled=false;
                        tileItem5.Enabled=false;
                        tileItem6.Enabled = false;
                        

            }
            if (Globals.access == 14)
            {
                this.Text = "Вы вошли как: " + Globals.nameUser;
tileItem2.Visible=false;
    tileItem4.Visible=false;
    tileItem5.Visible=false;
    tileItem6.Visible = false;

            }
        }

        private void tileItem1_ItemClick(object sender, TileItemEventArgs e)
        {
            Form d = new jaloby();
            d.Show();
        }

        private void tileItem6_ItemClick(object sender, TileItemEventArgs e)
        {
            Form d = new Otchet();
            d.Show();
        }

        private void tileItem8_ItemClick(object sender, TileItemEventArgs e)
        {
            Form d = new Sbyt();
            d.Show();
        }

      
    }
}