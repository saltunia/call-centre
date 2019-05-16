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

namespace DXApplication4
{
    public partial class UCzayavka : DevExpress.XtraEditors.XtraUserControl
    { 
        public UCzayavka()
        {
            InitializeComponent();
        }

        public void UCzayavka_Load(object sender, EventArgs e)
        {
            if (Globals.access == 10)
            { textEdit1.Enabled = false; textEdit2.Enabled = false; contextMenuStrip1.Visible = false; }
            if (Globals.access == 32)
            { toolStripMenuItem3.Visible = true; }
            else { toolStripMenuItem3.Visible = false; }
            Globals.setFocus1 = setFocTextEd1;
           DateTime s = DateTime.Today;
      DateTime d = DateTime.Today.AddHours(23.0).AddMinutes(59.0);
      if (Globals.access == 17)
      {
          this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
         int i= call_cBindingSource.Count;
          this.sprSlujbaTableAdapter.FillBy(this.call_centerDataSet11.sprSlujba, Globals.tDivision1);
      string name_sl = (string)((DataRowView)sprSlujbaBindingSource.Current).Row["nazvanie_slujby"];
      advBandedGridView1.Columns["nazvanie_slujby"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
      advBandedGridView1.ActiveFilterString = "[nazvanie_slujby] ='"+name_sl+"'";
      }
      else {
          this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
      }
     
          
            Globals.select_taby = loadabon;
            Globals.select_taby2 = loadprom;   
        }
        public void loadabon(){
            textEdit1.Text = Globals.abonshet;
            textEdit1.Focus();
        }

       
        

        public void loadprom()
        {
            textEdit2.Text = Globals.abonshet;
            textEdit2.Focus();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.abonTableAdapter.Fill(this.call_centerDataSet.abon, textEdit1.Text);
            #region
            if (abonBindingSource.Count > 0)
            {
                if (((DataRowView)(abonBindingSource.Current)).Row["tp"].ToString() == "")
                { Globals.ctp = null; }
                else
                {
                    Globals.ctp = (string)((DataRowView)(abonBindingSource.Current)).Row["tp"];
                }

                if (((DataRowView)(abonBindingSource.Current)).Row["zavNomer"].ToString() == "")
                { Globals.czavnom = null; }
                else
                {
                    Globals.czavnom = (string)((DataRowView)(abonBindingSource.Current)).Row["zavNomer"];
                }
                if (((DataRowView)(abonBindingSource.Current)).Row["idMarka"].ToString() == "")
                { Globals.cidmarka = 0; }
                else
                {
                    Globals.cidmarka = (int)((DataRowView)(abonBindingSource.Current)).Row["idMarka"];
                }
               
                if (((DataRowView)(abonBindingSource.Current)).Row["raion"].ToString() == "")
                { Globals.craion = 0; }
                else
                {
                    Globals.craion = (int)((DataRowView)(abonBindingSource.Current)).Row["raion"];
                }
                if (((DataRowView)(abonBindingSource.Current)).Row["nch"].ToString() == "")
                { Globals.clishet = null; }
                else
                {
                    Globals.clishet = (string)((DataRowView)(abonBindingSource.Current)).Row["nch"];
                }
                if (((DataRowView)(abonBindingSource.Current)).Row["fio"].ToString() == "")
                { Globals.cfio = null; }
                else
                {
                    Globals.cfio = (string)((DataRowView)(abonBindingSource.Current)).Row["fio"];
                }

                if (((DataRowView)(abonBindingSource.Current)).Row["address1"].ToString() == "")
                { Globals.cadress1 = null; }
                else
                {
                    Globals.cadress1 = (string)((DataRowView)(abonBindingSource.Current)).Row["address1"];
                }
                if (((DataRowView)(abonBindingSource.Current)).Row["address2"].ToString() == "")
                { Globals.cadress2 = null; }
                else
                {
                    Globals.cadress2 = (string)((DataRowView)(abonBindingSource.Current)).Row["address2"];
                }
                if (((DataRowView)(abonBindingSource.Current)).Row["debet"].ToString() == "")
                { Globals.cdebet = 0; }
                else
                {
                    Globals.cdebet = Math.Round((Decimal)((DataRowView)(abonBindingSource.Current)).Row["debet"], 2);
                }
                if (((DataRowView)(abonBindingSource.Current)).Row["akt"].ToString() == "")
                { Globals.cakt = 0; }
                else
                {
                    Globals.cakt = Math.Round((Decimal)((DataRowView)(abonBindingSource.Current)).Row["akt"], 2);
                }
                if (((DataRowView)(abonBindingSource.Current)).Row["penya"].ToString() == "")
                { Globals.cpenya = 0; }
                else
                {
                    Globals.cpenya = Math.Round((Decimal)((DataRowView)(abonBindingSource.Current)).Row["penya"], 2);
                }

                DateTime s = DateTime.Today;
                DateTime d = DateTime.Today.AddHours(23.0).AddMinutes(59.0);
                if (Globals.access == 17)
                {
                    this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
                    int i = call_cBindingSource.Count;
                    this.sprSlujbaTableAdapter.FillBy(this.call_centerDataSet11.sprSlujba, Globals.tDivision1);
                    string name_sl = (string)((DataRowView)sprSlujbaBindingSource.Current).Row["nazvanie_slujby"];
                    advBandedGridView1.Columns["nazvanie_slujby"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                    advBandedGridView1.ActiveFilterString = "[nazvanie_slujby] ='" + name_sl + "'";
                }
                else
                {
                    this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
                }
                if (operators_zayavkaBindingSource.Count < 1)
                {

                    this.poisk_idmarkaTableAdapter.Fill(this.call_centerDataSet.poisk_idmarka, Globals.cidmarka, Globals.czavnom);
                    if (poisk_idmarkaBindingSource.Count > 0)
                    {
                        Globals.tip_shetchika = "умный";
                        this.otkl_successTableAdapter.Fill(this.call_centerDataSet11.otkl_success, Globals.czavnom);
                       // this.otklTableAdapter.Fill(this.call_centerDataSet.otkl, Globals.czavnom);
                       
                        if (otkl_successBindingSource.Count ==1 )
                        
                        {

                            DateTime daotkl = ((DateTime)((DataRowView)(otkl_successBindingSource.Current)).Row["data_otkl"]);
                            string timeout = ((string)((DataRowView)(otkl_successBindingSource.Current)).Row["timeout"]);
                            MessageBox.Show("Вы отключены службой АИСКУЭ" + "\n" + "Дата/время откл: " + daotkl + "\n"+"Статус: "+timeout+ "\n" + "Лиц. счет: " + Globals.clishet + "\n" + "Ф.И.О: " + Globals.cfio + "\n" + "Адрес: " + Globals.cadress1 + ", " + Globals.cadress2 + "\n" + "Долг/пеня: " + Globals.cdebet + "c / " + Globals.cpenya + "c" + "\n" + "Акт: " + Globals.cakt + " c  ");
                            textEdit1.Text = "";
                            return;
                           

                        }
                        //else
                        //{
                            //if ((((DataRowView)(otkl_successBindingSource.Current)).Row["data_vkl"]) == DBNull.Value)
                            //{
                            //    Globals.umdatavkl = null;
                            //}
                            //else
                            //{
                            //    Globals.umdatavkl = ((DateTime)((DataRowView)(otkl_successBindingSource.Current)).Row["data_vkl"]);
                            //}
                        //}
                    }
                    else { Globals.tip_shetchika = "не умный"; }

                    this.sprTPTableAdapter.FillBy(this.call_centerDataSet.sprTP, Globals.ctp);
                    if (sprTPBindingSource.Count < 1)
                    {

                        //MessageBox.Show("Этот абонент неправильно привязан к ТП заявка отправлена к диспетчеру");

                        try
                        {
                           Form f = new zayavka_nulltp(this);
                           f.Show();
                            textEdit1.Text = "";

                        }
                        // TODO: данная строка кода позволяет загрузить данные в таблицу "call_centerDataSet.call_c". При необходимости она может быть перемещена или удалена.
                        catch { MessageBox.Show("Вы нам уже звонили!!!"); }
                        return;
                    }







                    this.callcpoisk6TableAdapter1.Fill(this.call_centerDataSet11.callcpoisk6, Globals.ctp,Globals.craion);
                    if (callcpoisk6BindingSource.Count < 1)
                    {
                        callcpoisk4GridControl.DataSource = callcpoisk4BindingSource;
                        this.callcpoisk4TableAdapter1.Fill(this.call_centerDataSet11.callcpoisk4, Globals.ctp,Globals.craion);


                    }
                    else
                    {
                        callcpoisk4GridControl.DataSource = null;
                        textEdit1.Text = "";
                        return;
                    }
                    callcpoisk4GridControl.DataSource = callcpoisk4BindingSource;
                    this.callcpoisk35TableAdapter.Fill(this.call_centerDataSet.callcpoisk35, Globals.ctp);

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
                        textEdit1.Text = "";
                        return;


                    }


                    bool ee;
                    this.abontpTableAdapter.Fill(this.call_centerDataSet.abontp, Globals.ctp);
                    if ((bool)((DataRowView)(abontpBindingSource.Current)).Row["abon"] == false)
                    { ee = false; }
                    ee = (bool)((DataRowView)(abontpBindingSource.Current)).Row["abon"];
                    if (abontpBindingSource.Count > 0 && ee == false)
                    {
                        if (callcpoisk4BindingSource.Count == 0)
                        {
                           Form h = new addzayavka(this);
                           h.Show();
                        }
                        else
                        {
                            try
                            {

                                DateTime? data_otkl = DateTime.Now;
                                queriesTableAdapter1.updzayavka(Globals.idUser, Globals.clishet, Globals.cfio, Globals.ctp, Globals.cadress1, Globals.cadress2, null, null, null, data_otkl, s, d);
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

                            this.queriesTableAdapter1.proverka(Globals.clishet, s, d);
                            MessageBox.Show("Вы нам уже звонили!!!");
                            textEdit1.Text = "";


                        }
                        // TODO: данная строка кода позволяет загрузить данные в таблицу "call_centerDataSet.call_c". При необходимости она может быть перемещена или удалена.
                        catch
                        {
                            textEdit1.Text = "";
                            Form f = new energosbyt();
                            f.Show();
                        }
                        return;
                    }


                }
                else { MessageBox.Show("Вы нам уже звонили!!!"); }

            }
            else
            {
                MessageBox.Show("Такой лицевой счет не существует");
            }
            textEdit1.Text = "";
            timer1.Start();
            #endregion
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime s = DateTime.Today;
            DateTime d = DateTime.Today.AddHours(23.0).AddMinutes(59.0);
            if (Globals.access == 17)
            {
                this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
                int i = call_cBindingSource.Count;
                this.sprSlujbaTableAdapter.FillBy(this.call_centerDataSet11.sprSlujba, Globals.tDivision1);
                string name_sl = (string)((DataRowView)sprSlujbaBindingSource.Current).Row["nazvanie_slujby"];
                advBandedGridView1.Columns["nazvanie_slujby"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                advBandedGridView1.ActiveFilterString = "[nazvanie_slujby] ='" + name_sl + "'";
            }
            else
            {
                this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
            }
        }

        private void call_cGridControl_Enter(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void call_cGridControl_Leave(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void textEdit1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton3_Click(null, null);
            }
        }

        private void textEdit2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                simpleButton4_Click(null, null);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            DateTime s = Convert.ToDateTime(dateEdit1.Text);
            DateTime d = Convert.ToDateTime(dateEdit2.Text);
            if (Globals.access == 17)
            {
                this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
                int i = call_cBindingSource.Count;
                this.sprSlujbaTableAdapter.FillBy(this.call_centerDataSet11.sprSlujba, Globals.tDivision1);
                string name_sl = (string)((DataRowView)sprSlujbaBindingSource.Current).Row["nazvanie_slujby"];
                advBandedGridView1.Columns["nazvanie_slujby"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                advBandedGridView1.ActiveFilterString = "[nazvanie_slujby] ='" + name_sl + "'";
            }
            else
            {
                this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            dateEdit1.Text = "";
            dateEdit2.Text = "";
            DateTime s = DateTime.Today;
            DateTime d = DateTime.Today.AddHours(23.0).AddMinutes(59.0);
            if (Globals.access == 17)
            {
                this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
                int i = call_cBindingSource.Count;
                this.sprSlujbaTableAdapter.FillBy(this.call_centerDataSet11.sprSlujba, Globals.tDivision1);
                string name_sl = (string)((DataRowView)sprSlujbaBindingSource.Current).Row["nazvanie_slujby"];
                advBandedGridView1.Columns["nazvanie_slujby"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                advBandedGridView1.ActiveFilterString = "[nazvanie_slujby] ='" + name_sl + "'";
            }
            else
            {
                this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
            }
            timer1.Start();
            textEdit1.Text = "";
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            DateTime s = DateTime.Today;
            DateTime d = DateTime.Today.AddHours(23.0).AddMinutes(59.0);
            ToolStripItem l = e.ClickedItem;
            if (l.Name == "toolStripMenuItem2")
            {
                if (call_cBindingSource.Count > 0)
                {
                    if (((DataRowView)(call_cBindingSource.Current)).Row["tp"].ToString() == "")
                    { Globals.uptp = null; }
                    else
                    {
                        Globals.uptp = (string)((DataRowView)(call_cBindingSource.Current)).Row["tp"];
                    }
                    Globals.updataotkl = (DateTime)((DataRowView)(call_cBindingSource.Current)).Row["data_otkl"];
                }

                queriesTableAdapter1.updzayavkanote(Globals.idUser, Globals.uptp, Globals.updataotkl);
                
                if (Globals.access == 17)
                {
                    this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
                    int i = call_cBindingSource.Count;
                    this.sprSlujbaTableAdapter.FillBy(this.call_centerDataSet11.sprSlujba, Globals.tDivision1);
                    string name_sl = (string)((DataRowView)sprSlujbaBindingSource.Current).Row["nazvanie_slujby"];
                    advBandedGridView1.Columns["nazvanie_slujby"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                    advBandedGridView1.ActiveFilterString = "[nazvanie_slujby] ='" + name_sl + "'";
                }
                else
                {
                    this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
                }
            }

            if (l.Name == "toolStripMenuItem1")
            {
                Form f = new updzayavka(this);
                f.Show();
            }
            if (l.Name == "toolStripMenuItem3")
            {
                if (call_cBindingSource.Count > 0)
                {
                    if (((DataRowView)(call_cBindingSource.Current)).Row["tp"].ToString() == "")
                    { Globals.uptp = null; }
                    else
                    {
                        Globals.uptp = (string)((DataRowView)(call_cBindingSource.Current)).Row["tp"];
                    }
                    Globals.updataotkl = (DateTime)((DataRowView)(call_cBindingSource.Current)).Row["data_otkl"];
                }

                queriesTableAdapter2.update_control(Globals.idUser, Globals.uptp, Globals.updataotkl);
                
                if (Globals.access == 17)
                {
                    this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
                    int i = call_cBindingSource.Count;
                    this.sprSlujbaTableAdapter.FillBy(this.call_centerDataSet11.sprSlujba, Globals.tDivision1);
                    string name_sl = (string)((DataRowView)sprSlujbaBindingSource.Current).Row["nazvanie_slujby"];
                    advBandedGridView1.Columns["nazvanie_slujby"].FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
                    advBandedGridView1.ActiveFilterString = "[nazvanie_slujby] ='" + name_sl + "'";
                }
                else
                {
                    this.call_cTableAdapter1.FillBy1(this.call_centerDataSet11.call_c, s, d);
                }
            }


        }

        private void advBandedGridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (call_cBindingSource.Count > 0)
            {
                if (((DataRowView)(call_cBindingSource.Current)).Row["tp"].ToString() == "")
                { Globals.uptp = null; }
                else
                {
                    Globals.uptp = (string)((DataRowView)(call_cBindingSource.Current)).Row["tp"];
                }
                Globals.updataotkl = (DateTime)((DataRowView)(call_cBindingSource.Current)).Row["data_otkl"];
                if (((DataRowView)(call_cBindingSource.Current)).Row["ulisa"].ToString() == "")
                { Globals.upadress1 = null; }
                else
                {
                    Globals.upadress1 = (string)((DataRowView)(call_cBindingSource.Current)).Row["ulisa"];
                }
                if (((DataRowView)(call_cBindingSource.Current)).Row["dom"].ToString() == "")
                { Globals.upadress2 = null; }
                else
                {
                    Globals.upadress2 = (string)((DataRowView)(call_cBindingSource.Current)).Row["dom"];
                }
                if (((DataRowView)(call_cBindingSource.Current)).Row["note"].ToString() == "")
                { Globals.upnote = null; }
                else
                {
                    Globals.upnote = (string)((DataRowView)(call_cBindingSource.Current)).Row["note"];
                }

                if (((DataRowView)(call_cBindingSource.Current)).Row["tel"].ToString() == "")
                { Globals.uptel = null; }
                else
                {
                    Globals.uptel = (string)((DataRowView)(call_cBindingSource.Current)).Row["tel"];
                }
                if (((DataRowView)(call_cBindingSource.Current)).Row["FIO"].ToString() == "")
                { Globals.upfio = null; }
                else
                {
                    Globals.upfio = (string)((DataRowView)(call_cBindingSource.Current)).Row["FIO"];
                }
                if (((DataRowView)(call_cBindingSource.Current)).Row["abon_shet"].ToString() == "")
                { Globals.uplishet = null; }
                else
                {
                    Globals.uplishet = (string)((DataRowView)(call_cBindingSource.Current)).Row["abon_shet"];
                }

            }
        }

      

       

        private void advBandedGridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"])) == "")
                {
                    e.Appearance.BackColor = Color.Pink;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    DateTime f = DateTime.Now;
                    DateTime d=Convert.ToDateTime((View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"])));
                    if (d > f)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else { e.Appearance.BackColor = Color.YellowGreen;
                    e.Appearance.ForeColor = Color.Black;
                    }
                }

            }
        }

        private void call_cBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            try
            {
                if (call_cBindingSource.Count > 0)
                {
                    if (((DataRowView)(call_cBindingSource.Current)).Row["tp"].ToString() == "")
                    { Globals.uptp = null; }
                    else
                    {
                        Globals.uptp = (string)((DataRowView)(call_cBindingSource.Current)).Row["tp"];
                    }
                    Globals.updataotkl = (DateTime)((DataRowView)(call_cBindingSource.Current)).Row["data_otkl"];
                    if (((DataRowView)(call_cBindingSource.Current)).Row["ulisa"].ToString() == "")
                    { Globals.upadress1 = null; }
                    else
                    {
                        Globals.upadress1 = (string)((DataRowView)(call_cBindingSource.Current)).Row["ulisa"];
                    }
                    if (((DataRowView)(call_cBindingSource.Current)).Row["dom"].ToString() == "")
                    { Globals.upadress2 = null; }
                    else
                    {
                        Globals.upadress2 = (string)((DataRowView)(call_cBindingSource.Current)).Row["dom"];
                    }
                    if (((DataRowView)(call_cBindingSource.Current)).Row["note"].ToString() == "")
                    { Globals.upnote = null; }
                    else
                    {
                        Globals.upnote = (string)((DataRowView)(call_cBindingSource.Current)).Row["note"];
                    }

                    if (((DataRowView)(call_cBindingSource.Current)).Row["tel"].ToString() == "")
                    { Globals.uptel = null; }
                    else
                    {
                        Globals.uptel = (string)((DataRowView)(call_cBindingSource.Current)).Row["tel"];
                    }
                    if (((DataRowView)(call_cBindingSource.Current)).Row["FIO"].ToString() == "")
                    { Globals.upfio = null; }
                    else
                    {
                        Globals.upfio = (string)((DataRowView)(call_cBindingSource.Current)).Row["FIO"];
                    }
                    if (((DataRowView)(call_cBindingSource.Current)).Row["abon_shet"].ToString() == "")
                    { Globals.uplishet = null; }
                    else
                    {
                        Globals.uplishet = (string)((DataRowView)(call_cBindingSource.Current)).Row["abon_shet"];
                    }

                }
            }
            catch { }
        }

        private void bandedGridView1_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"])) == "")
                {
                    e.Appearance.BackColor = Color.Pink;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    DateTime f = DateTime.Now;
                    DateTime d = Convert.ToDateTime((View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"])));
                    if (d > f)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.YellowGreen;
                        e.Appearance.ForeColor = Color.Black;
                    }
                }

            }
        }

        private void bandedGridView2_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {

            GridView View = sender as GridView;
            if (e.RowHandle >= 0)
            {
                if ((View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"])) == "")
                {
                    e.Appearance.BackColor = Color.Pink;
                    e.Appearance.ForeColor = Color.Black;
                }
                else
                {
                    DateTime f = DateTime.Now;
                    DateTime d = Convert.ToDateTime((View.GetRowCellDisplayText(e.RowHandle, View.Columns["data_vkl"])));
                    if (d > f)
                    {
                        e.Appearance.BackColor = Color.Yellow;
                        e.Appearance.ForeColor = Color.Black;
                    }
                    else
                    {
                        e.Appearance.BackColor = Color.YellowGreen;
                        e.Appearance.ForeColor = Color.Black;
                    }
                }

            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.prom_abonTableAdapter1.Fill(this.call_centerDataSet11.prom_abon, textEdit2.Text,Globals.raion_prom);
            if (prom_abonBindingSource.Count > 0)
            {
                if (((DataRowView)(prom_abonBindingSource.Current)).Row["tp"].ToString() == "")
                { Globals.ctp = null; }
                else
                {
                    Globals.ctp = (string)((DataRowView)(prom_abonBindingSource.Current)).Row["tp"];
                }

                if (((DataRowView)(prom_abonBindingSource.Current)).Row["zavNomer"].ToString() == "")
                { Globals.czavnom = null; }
                else
                {
                    Globals.czavnom = (string)((DataRowView)(prom_abonBindingSource.Current)).Row["zavNomer"];
                }
                if (((DataRowView)(prom_abonBindingSource.Current)).Row["idMarka"].ToString() == "")
                { Globals.cidmarka = 0; }
                else
                {
                    Globals.cidmarka = (int)((DataRowView)(prom_abonBindingSource.Current)).Row["idMarka"];
                }
                if (((DataRowView)(prom_abonBindingSource.Current)).Row["raion"].ToString() == "")
                { Globals.craion = 0; }
                else
                {
                    Globals.craion = (int)((DataRowView)(prom_abonBindingSource.Current)).Row["raion"];
                }
                if (((DataRowView)(prom_abonBindingSource.Current)).Row["nch"].ToString() == "")
                { Globals.clishet = null; }
                else
                {
                    Globals.clishet = (string)((DataRowView)(prom_abonBindingSource.Current)).Row["nch"];
                }
                if (((DataRowView)(prom_abonBindingSource.Current)).Row["fio"].ToString() == "")
                { Globals.cfio = null; }
                else
                {
                    Globals.cfio = (string)((DataRowView)(prom_abonBindingSource.Current)).Row["fio"];
                }

                if (((DataRowView)(prom_abonBindingSource.Current)).Row["address1"].ToString() == "")
                { Globals.cadress1 = null; }
                else
                {
                    Globals.cadress1 = (string)((DataRowView)(prom_abonBindingSource.Current)).Row["address1"];
                }
                if (((DataRowView)(prom_abonBindingSource.Current)).Row["address2"].ToString() == "" || ((DataRowView)(prom_abonBindingSource.Current)).Row["address2"] is DBNull)
                { Globals.cadress2 = null; }
                else
                {
                    Globals.cadress2 = (string)((DataRowView)(prom_abonBindingSource.Current)).Row["address2"];
                }
                if (((DataRowView)(prom_abonBindingSource.Current)).Row["debet"].ToString() == "")
                { Globals.cdebet = 0; }
                else
                {
                    Globals.cdebet = Math.Round((Decimal)((DataRowView)(prom_abonBindingSource.Current)).Row["debet"], 2);
                }
                //if (((DataRowView)(abonBindingSource.Current)).Row["akt"].ToString() == "")
                //{ Globals.cakt = 0; }
                //else
                //{
                //    Globals.cakt = Math.Round((Decimal)((DataRowView)(abonBindingSource.Current)).Row["akt"], 2);
                //}
                if (((DataRowView)(prom_abonBindingSource.Current)).Row["penya"].ToString() == "")
                { Globals.cpenya = 0; }
                else
                {
                    Globals.cpenya = Math.Round((Decimal)((DataRowView)(prom_abonBindingSource.Current)).Row["penya"], 2);
                }
                if (((DataRowView)(prom_abonBindingSource.Current)).Row["potrebitel"].ToString() == "")
                { Globals.cpotreb = null; }
                else
                {
                    Globals.cpotreb = (string)((DataRowView)(prom_abonBindingSource.Current)).Row["potrebitel"];
                }
                if (((DataRowView)(prom_abonBindingSource.Current)).Row["abonent"].ToString() == "")
                { Globals.cabon = null; }
                else
                {
                    Globals.cabon = (string)((DataRowView)(prom_abonBindingSource.Current)).Row["abonent"];
                }
              
                DateTime s = DateTime.Today;
                DateTime d = DateTime.Today.AddHours(23.0).AddMinutes(59.0);
                this.operators_zayavkaTableAdapter.zapros(this.call_centerDataSet1.operators_zayavka, Globals.clishet, s, d);
                if (operators_zayavkaBindingSource.Count < 1)
                {

                    this.poisk_idmarkaTableAdapter.Fill(this.call_centerDataSet.poisk_idmarka, Globals.cidmarka, Globals.czavnom);
                    if (poisk_idmarkaBindingSource.Count > 0)
                    {
                        Globals.tip_shetchika = "умный";
                        this.otkl_successTableAdapter.Fill(this.call_centerDataSet11.otkl_success, Globals.czavnom);
                        // this.otklTableAdapter.Fill(this.call_centerDataSet.otkl, Globals.czavnom);

                        if (otkl_successBindingSource.Count == 1)
                        {

                            DateTime daotkl = ((DateTime)((DataRowView)(otkl_successBindingSource.Current)).Row["data_otkl"]);
                            string timeout = ((string)((DataRowView)(otkl_successBindingSource.Current)).Row["timeout"]);
                            MessageBox.Show("Вы отключены службой АИСКУЭ" + "\n" + "Дата/время откл: " + daotkl + "\n" + "Лиц. счет: " + Globals.clishet + "\n" +"Статус: "+timeout+ "\n" + "Ф.И.О: " + Globals.cfio + "\n" + "Адрес: " + Globals.cadress1 + ", " + Globals.cadress2 + "\n" + "Долг/пеня: " + Globals.cdebet + "c / " + Globals.cpenya + "c" + "\n" + "Акт: " + Globals.cakt + " c  ");
                            textEdit2.Text = "";
                            return;


                        }
                    }
                    else
                    { Globals.tip_shetchika = "не умный"; }

                    this.sprTPTableAdapter.FillBy(this.call_centerDataSet.sprTP, Globals.ctp);
                    if (sprTPBindingSource.Count < 1)
                    {

                        //MessageBox.Show("Этот абонент неправильно привязан к ТП заявка отправлена к диспетчеру");

                        try
                        {
                            Form f = new zayavka_nulltp(this);
                            f.Show();
                            textEdit2.Text = "";

                        }
                        // TODO: данная строка кода позволяет загрузить данные в таблицу "call_centerDataSet.call_c". При необходимости она может быть перемещена или удалена.
                        catch { MessageBox.Show("Вы нам уже звонили!!!"); }
                        return;
                    }







                    this.callcpoisk6TableAdapter1.Fill(this.call_centerDataSet11.callcpoisk6, Globals.ctp,Globals.craion);
                    if (callcpoisk6BindingSource.Count < 1)
                    {
                        callcpoisk4GridControl.DataSource = callcpoisk4BindingSource;
                        this.callcpoisk4TableAdapter1.Fill(this.call_centerDataSet11.callcpoisk4, Globals.ctp,Globals.craion);


                    }
                    else
                    {
                        callcpoisk4GridControl.DataSource = null;
                        textEdit2.Text = "";
                        return;
                    }
                    callcpoisk4GridControl.DataSource = callcpoisk4BindingSource;
                    this.callcpoisk35TableAdapter.Fill(this.call_centerDataSet.callcpoisk35, Globals.ctp);

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
                        textEdit2.Text = "";
                        return;


                    }


                    bool ee;
                    this.abontpTableAdapter.Fill(this.call_centerDataSet.abontp, Globals.ctp);
                    if ((bool)((DataRowView)(abontpBindingSource.Current)).Row["abon"] == false)
                    { ee = false; }
                    ee = (bool)((DataRowView)(abontpBindingSource.Current)).Row["abon"];
                    if (abontpBindingSource.Count > 0 && ee == false)
                    {
                        if (callcpoisk4BindingSource.Count == 0)
                        {
                            Form h = new addzayavka(this);
                            h.Show();
                        }
                        else
                        {
                            try
                            {

                                DateTime? data_otkl = DateTime.Now;
                                queriesTableAdapter1.updzayavka(Globals.idUser, Globals.clishet, Globals.cfio, Globals.ctp, Globals.cadress1, Globals.cadress2, null, null, null, data_otkl, s, d);
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

                            this.queriesTableAdapter1.proverka(Globals.clishet, s, d);
                            MessageBox.Show("Вы нам уже звонили!!!");
                            textEdit2.Text = "";


                        }
                        // TODO: данная строка кода позволяет загрузить данные в таблицу "call_centerDataSet.call_c". При необходимости она может быть перемещена или удалена.
                        catch
                        {
                            textEdit2.Text = "";
                            Form f = new energosbyt();
                            f.Show();
                        }
                        return;
                    }


                }
                else { MessageBox.Show("Вы нам уже звонили!!!"); }

            }
            else
            {
                MessageBox.Show("Такой лицевой счет не существует");
            }
            textEdit2.Text = "";
            timer1.Start();
        }
        private void setFocTextEd1()
        {
            this.textEdit1.Focus();
        }

       

       


     
    }
}
