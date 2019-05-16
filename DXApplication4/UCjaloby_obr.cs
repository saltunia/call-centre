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
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;

namespace DXApplication4
{
    public partial class UCjaloby_obr : DevExpress.XtraEditors.XtraUserControl
    {
        public UCjaloby_obr()
        {
            InitializeComponent();
        }

        private void UCjaloby_obr_Load(object sender, EventArgs e)
        {
            if (Globals.access == 10)
            { simpleButton1.Enabled = false; simpleButton2.Enabled = false; contextMenuStrip1.Visible = false; simpleButton4.Enabled = false; simpleButton3.Enabled = false; simpleButton6.Enabled = false; }
            if (Globals.idUser == 92 || Globals.idUser == 93 || Globals.idUser == 96)
            { ответНеУстраиваетToolStripMenuItem.Visible = true;
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;
            }
            else { ответНеУстраиваетToolStripMenuItem.Visible = false; }
            if (Globals.idUser == 96)
            {
                this.users_programmTableAdapter.Fill(call_centerDataSet1.users_programm);
                this.sprRaionovTableAdapter.Fill(call_centerDataSet1.sprRaionov);
                this.jalobyTableAdapter1.FillByRES(call_centerDataSet1.Jaloby);
            }
            else { 
            this.users_programmTableAdapter.Fill(call_centerDataSet1.users_programm);
            this.sprRaionovTableAdapter.Fill(call_centerDataSet1.sprRaionov);
            this.jalobyTableAdapter1.FillByUser(call_centerDataSet1.Jaloby,Globals.idUser);}
            
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (Globals.idUser == 96)
            { this.jalobyTableAdapter1.FillByRES(call_centerDataSet1.Jaloby ); }
            else
            { 
            this.jalobyTableAdapter1.FillByUser(call_centerDataSet1.Jaloby, Globals.idUser);}
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            jalobyBindingSource1.AddNew();
            Globals.addnew = "insert_new";
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (Globals.addnew == "insert_new")
                {

                    var rowHandle = advBandedGridView1.FocusedRowHandle;
                   if (advBandedGridView1.GetRowCellValue(rowHandle, "komu_slujba").ToString()=="" ||
                     advBandedGridView1.GetRowCellValue(rowHandle, "raion").ToString()=="" ||
                     advBandedGridView1.GetRowCellValue(rowHandle, "FIO").ToString()=="" ||
                     advBandedGridView1.GetRowCellValue(rowHandle, "tel").ToString()=="" ||
                    advBandedGridView1.GetRowCellValue(rowHandle, "Prichina").ToString()=="" ||
                    advBandedGridView1.GetRowCellValue(rowHandle, "komu_slujba").ToString()=="" )
                    {
                       MessageBox.Show("Введите все данные!!!");

                    }
                    else
                    {
                        Globals.jraion = (string)advBandedGridView1.GetRowCellValue(rowHandle, "raion");
                        Globals.jvopros = (string)advBandedGridView1.GetRowCellValue(rowHandle, "komu_slujba");
                        Globals.jprichina = (string)advBandedGridView1.GetRowCellValue(rowHandle, "Prichina");
                        Globals.jkontakty = (string)advBandedGridView1.GetRowCellValue(rowHandle, "tel");
                        Globals.jadres = (string)advBandedGridView1.GetRowCellValue(rowHandle, "Adres");
                        Globals.jfio = (string)advBandedGridView1.GetRowCellValue(rowHandle, "FIO");
                       // Globals.jid = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                        this.jalobyTableAdapter1.InsertQuery(Globals.jraion, Globals.jfio,DateTime.Now.ToString(),Globals.jadres,Globals.jkontakty,Globals.jprichina,Globals.idUser,Globals.jvopros);
                    MessageBox.Show("Данные успешно сохранены");
                   }
                }
                else
                {
                    var rowHandle = advBandedGridView1.FocusedRowHandle;
                    Globals.jraion = (string)advBandedGridView1.GetRowCellValue(rowHandle, "raion");
                    Globals.jvopros = (string)advBandedGridView1.GetRowCellValue(rowHandle, "komu_slujba");
                    Globals.jprichina = (string)advBandedGridView1.GetRowCellValue(rowHandle, "Prichina");
                    Globals.jkontakty = (string)advBandedGridView1.GetRowCellValue(rowHandle, "tel");
                    Globals.jadres = (string)advBandedGridView1.GetRowCellValue(rowHandle, "Adres");
                    Globals.jfio = (string)advBandedGridView1.GetRowCellValue(rowHandle, "FIO");
                    Globals.jid = (int)advBandedGridView1.GetRowCellValue(rowHandle, "id");
                    this.jalobyTableAdapter1.UpdateQuery(Globals.jraion, Globals.jfio, DateTime.Now.ToString(), Globals.jadres,Globals.jkontakty,Globals.jprichina,Globals.idUser,Globals.jvopros,Globals.jid);
                }
                

                this.jalobyTableAdapter1.FillByUser(call_centerDataSet1.Jaloby, Globals.idUser);
            }
            catch { MessageBox.Show("Данные не сохранены"); }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (Globals.idUser == 96)
            { this.jalobyTableAdapter1.FillByRES(call_centerDataSet1.Jaloby); }
            else
            { 
            this.jalobyTableAdapter1.FillByAll(call_centerDataSet1.Jaloby);}
        }

        private void advBandedGridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["vypolnen"])) != "")
                {
                    e.Appearance.BackColor = Color.YellowGreen;
                    e.Appearance.ForeColor = Color.Black;
                }
                if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["vypolnen"])) != "" && (View.GetRowCellDisplayText(e.RowHandle, View.Columns["otmena"])) == "1")
                {
                    e.Appearance.BackColor = Color.FromArgb(0xFF, 0x99, 0x99);
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["vypolnen"])) != "" && (View.GetRowCellDisplayText(e.RowHandle, View.Columns["ot_kogo"])) != "")
                    {
                        e.Appearance.BackColor = Color.FromArgb(0x66, 0xFF, 0xFF);
                        e.Appearance.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            if (Globals.idUser == 96) { this.jalobyTableAdapter1.FillByResNull(call_centerDataSet1.Jaloby); }
            else { 
            this.jalobyTableAdapter1.FillByNetotv(call_centerDataSet1.Jaloby);}
            
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (Globals.idUser == 96)
            {
                dateEdit2.Text = "";
                dateEdit1.Text = "";

                this.jalobyTableAdapter1.FillByRES(call_centerDataSet1.Jaloby);
            }
            else { 
            dateEdit2.Text = "";
                dateEdit1.Text="";
            
            this.jalobyTableAdapter1.FillByUser(call_centerDataSet1.Jaloby, Globals.idUser);}
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if(Globals.idUser==96)
            {
                DateTime s = Convert.ToDateTime(dateEdit1.Text);
                DateTime d = Convert.ToDateTime(dateEdit2.Text);
                this.jalobyTableAdapter1.FillByRESdate(call_centerDataSet1.Jaloby, s, d);
            }
            else { 
            DateTime s = Convert.ToDateTime(dateEdit1.Text);
            DateTime d = Convert.ToDateTime(dateEdit2.Text);
            this.jalobyTableAdapter1.FillByDate(call_centerDataSet1.Jaloby,s,d);}
           
           
        }

        private void advBandedGridView1_RowCellClick(object sender, RowCellClickEventArgs e)
        {
          
           
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (Globals.idUser == 96)
            {
                ToolStripItem l = e.ClickedItem;
                if (l.Name == "ответНеУстраиваетToolStripMenuItem")
                {
                    this.jalobyTableAdapter1.UpdateOtmena(Globals.nameUser, Globals.jid);
                    this.jalobyTableAdapter1.FillByRES(call_centerDataSet1.Jaloby);

                }
            }
            else { 
            ToolStripItem l = e.ClickedItem;
            if (l.Name == "ответНеУстраиваетToolStripMenuItem")
            {
                this.jalobyTableAdapter1.UpdateOtmena(Globals.nameUser,Globals.jid );
                this.jalobyTableAdapter1.FillByAll(call_centerDataSet1.Jaloby);
               
            }
            }
        }

        private void jalobyBindingSource1_CurrentChanged(object sender, EventArgs e)
        {
 try { 
 Globals.jid =  (int)((DataRowView)jalobyBindingSource1.Current).Row["id"];
 }
            catch { }
        }

        private void advBandedGridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
          
            //simpleButton2_Click(sender, e);
        }

        private void ответНеУстраиваетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.jalobyTableAdapter1.UpdateOtmena(Globals.nameUser, Globals.jid);
            this.jalobyTableAdapter1.FillByAll(call_centerDataSet1.Jaloby);
        }

        private void ShowGridPreview(GridControl grid)
        {
            // Check whether the GridControl can be previewed.
            if (!grid.IsPrintingAvailable)
            {
                MessageBox.Show("The 'DevExpress.XtraPrinting' library is not found", "Error");
                return;
            }

            // Open the Preview window.
            grid.ShowPrintPreview();
        }
        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            ShowGridPreview(jalobyGridControl);
        }
      

        
    }
}
