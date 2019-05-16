using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication4
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }







        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Вы вошли как: " + Globals.nameUser;
            // TODO: This line of code loads data into the 'call_centerDataSet.call_c' table. You can move, or remove it, as needed.
            this.call_cTableAdapter.Fill(this.call_centerDataSet.call_c);
            DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel tt = sender as DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel;
            //this.prom_abonTableAdapter.FillAll(this.call_centerDataSet.prom_abon);
            // this.abonTableAdapter.FillAll(this.call_centerDataSet.abon);
            Globals.select_taby1 = seltab;
            Globals.select_taby3 = seltab;
        }

        private void windowsUIButtonPanel1_ButtonChecked(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel tt = sender as DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel;


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


                if (transitionManager1.IsTransaction)
                {
                    transitionManager1.EndTransition();
                }

                transitionManager1.StartTransition(xtraTabPage1);
                try
                {
                    xtraTabPage1.PageVisible = true;
                    xtraTabPage2.PageVisible = false;
                    xtraTabPage3.PageVisible = false;
                    xtraTabPage4.PageVisible = false;
                    xtraTabPage5.PageVisible = false;
                    xtraTabPage6.PageVisible = false;
                    xtraTabPage7.PageVisible = false;
                    xtraTabPage8.PageVisible = false;
                    xtraTabControl1.SelectedTabPage = xtraTabPage1;



                }
                finally
                {
                    transitionManager1.EndTransition();
                }
            }
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


                if (transitionManager1.IsTransaction)
                {
                    transitionManager1.EndTransition();
                }

                transitionManager1.StartTransition(xtraTabPage2);
                try
                {
                    xtraTabPage2.PageVisible = true;
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage3.PageVisible = false;
                    xtraTabPage4.PageVisible = false;
                    xtraTabPage5.PageVisible = false;
                    xtraTabPage6.PageVisible = false;
                    xtraTabPage7.PageVisible = false;
                    xtraTabPage8.PageVisible = false;
                    xtraTabControl1.SelectedTabPage = xtraTabPage2;



                }
                finally
                {
                    transitionManager1.EndTransition();
                }
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


                if (transitionManager1.IsTransaction)
                {
                    transitionManager1.EndTransition();
                }

                transitionManager1.StartTransition(xtraTabPage3);
                try
                {
                    xtraTabPage3.PageVisible = true;
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage2.PageVisible = false;
                    xtraTabPage4.PageVisible = false;
                    xtraTabPage5.PageVisible = false;
                    xtraTabPage6.PageVisible = false;
                    xtraTabPage7.PageVisible = false;
                    xtraTabPage8.PageVisible = false;
                    xtraTabControl1.SelectedTabPage = xtraTabPage3;



                }
                finally
                {
                    transitionManager1.EndTransition();
                }
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


                if (transitionManager1.IsTransaction)
                {
                    transitionManager1.EndTransition();
                }

                transitionManager1.StartTransition(xtraTabPage4);
                try
                {
                    xtraTabPage4.PageVisible = true;
                    xtraTabPage2.PageVisible = false;
                    xtraTabPage3.PageVisible = false;
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage5.PageVisible = false;
                    xtraTabPage6.PageVisible = false;
                    xtraTabPage7.PageVisible = false;
                    xtraTabPage8.PageVisible = false;
                    xtraTabControl1.SelectedTabPage = xtraTabPage4;
                    xtraTabPage4.Text ="Заявки:"+Globals.nameUser;



                }
                finally
                {
                    transitionManager1.EndTransition();
                }
            }
            if (tt.Buttons[4].Properties.Checked == true)
            {
                tt.Buttons[1].Properties.Checked = false;
                tt.Buttons[0].Properties.Checked = false;
                tt.Buttons[2].Properties.Checked = false;
                tt.Buttons[3].Properties.Checked = false;
                tt.Buttons[4].Properties.Checked = false;
                tt.Buttons[5].Properties.Checked = false;
                tt.Buttons[6].Properties.Checked = false;
                tt.Buttons[7].Properties.Checked = false;


                if (transitionManager1.IsTransaction)
                {
                    transitionManager1.EndTransition();
                }

                transitionManager1.StartTransition(xtraTabPage5);
                try
                {
                    xtraTabPage5.PageVisible = true;
                    xtraTabPage2.PageVisible = false;
                    xtraTabPage3.PageVisible = false;
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage4.PageVisible = false;
                    xtraTabPage6.PageVisible = false;
                    xtraTabPage7.PageVisible = false;
                    xtraTabPage8.PageVisible = false;
                    xtraTabControl1.SelectedTabPage = xtraTabPage5;
                  



                }
                finally
                {
                    transitionManager1.EndTransition();
                }
            }
            if (tt.Buttons[5].Properties.Checked == true)
            {
                tt.Buttons[1].Properties.Checked = false;
                tt.Buttons[0].Properties.Checked = false;
                tt.Buttons[2].Properties.Checked = false;
                tt.Buttons[3].Properties.Checked = false;
                tt.Buttons[4].Properties.Checked = false;
                tt.Buttons[5].Properties.Checked = false;
                tt.Buttons[6].Properties.Checked = false;
                tt.Buttons[7].Properties.Checked = false;


                if (transitionManager1.IsTransaction)
                {
                    transitionManager1.EndTransition();
                }

                transitionManager1.StartTransition(xtraTabPage6);
                try
                {
                    xtraTabPage6.PageVisible = true;
                    xtraTabPage2.PageVisible = false;
                    xtraTabPage3.PageVisible = false;
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage4.PageVisible = false;
                    xtraTabPage5.PageVisible = false;
                    xtraTabPage7.PageVisible = false;
                    xtraTabPage8.PageVisible = false;
                    xtraTabControl1.SelectedTabPage = xtraTabPage6;




                }
                finally
                {
                    transitionManager1.EndTransition();
                }
            }
            if (tt.Buttons[6].Properties.Checked == true)
            {
                tt.Buttons[1].Properties.Checked = false;
                tt.Buttons[0].Properties.Checked = false;
                tt.Buttons[2].Properties.Checked = false;
                tt.Buttons[3].Properties.Checked = false;
                tt.Buttons[4].Properties.Checked = false;
                tt.Buttons[5].Properties.Checked = false;
                tt.Buttons[6].Properties.Checked = false;
                tt.Buttons[7].Properties.Checked = false;


                if (transitionManager1.IsTransaction)
                {
                    transitionManager1.EndTransition();
                }

                transitionManager1.StartTransition(xtraTabPage7);
                try
                {
                    xtraTabPage7.PageVisible = true;
                    xtraTabPage2.PageVisible = false;
                    xtraTabPage3.PageVisible = false;
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage4.PageVisible = false;
                    xtraTabPage5.PageVisible = false;
                    xtraTabPage6.PageVisible = false;
                    xtraTabPage8.PageVisible = false;
                    xtraTabControl1.SelectedTabPage = xtraTabPage7;




                }
                finally
                {
                    transitionManager1.EndTransition();
                }
            }
            if (tt.Buttons[7].Properties.Checked == true)
            {
                tt.Buttons[1].Properties.Checked = false;
                tt.Buttons[0].Properties.Checked = false;
                tt.Buttons[2].Properties.Checked = false;
                tt.Buttons[3].Properties.Checked = false;
                tt.Buttons[4].Properties.Checked = false;
                tt.Buttons[5].Properties.Checked = false;
                tt.Buttons[6].Properties.Checked = false;
                tt.Buttons[7].Properties.Checked = false;


                if (transitionManager1.IsTransaction)
                {
                    transitionManager1.EndTransition();
                }

                transitionManager1.StartTransition(xtraTabPage8);
                try
                {
                    xtraTabPage8.PageVisible = true;
                    xtraTabPage2.PageVisible = false;
                    xtraTabPage3.PageVisible = false;
                    xtraTabPage1.PageVisible = false;
                    xtraTabPage4.PageVisible = false;
                    xtraTabPage5.PageVisible = false;
                    xtraTabPage6.PageVisible = false;
                    xtraTabPage7.PageVisible = false;
                    xtraTabControl1.SelectedTabPage = xtraTabPage8;




                }
                finally
                {
                    transitionManager1.EndTransition();
                }
            }
        }

        private void uCzayavka1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void seltab()
        {
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabPage1.PageVisible = true;
            xtraTabPage2.PageVisible = false;
            xtraTabPage3.PageVisible = false;
            xtraTabPage4.PageVisible = false;
            xtraTabPage5.PageVisible = false;
            xtraTabPage6.PageVisible = false;
            xtraTabPage7.PageVisible = false;
            xtraTabPage8.PageVisible = false;





        }

    }
}