namespace DXApplication4 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            DevExpress.Utils.Animation.ClockTransition clockTransition1 = new DevExpress.Utils.Animation.ClockTransition();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.uCzayavka1 = new DXApplication4.UCzayavka();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.uCbyt1 = new DXApplication4.UCbyt();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.uCprom1 = new DXApplication4.UCprom();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.uCoper_zayavki1 = new DXApplication4.UCoper_zayavki();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            this.uCpoiskumn1 = new DXApplication4.UCpoiskumn();
            this.xtraTabPage6 = new DevExpress.XtraTab.XtraTabPage();
            this.uCplanotkl1 = new DXApplication4.UCplanotkl();
            this.xtraTabPage7 = new DevExpress.XtraTab.XtraTabPage();
            this.uCjaloby_obr1 = new DXApplication4.UCjaloby_obr();
            this.xtraTabPage8 = new DevExpress.XtraTab.XtraTabPage();
            this.uCpredr1 = new DXApplication4.UCpredr();
            this.windowsUIButtonPanel1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.transitionManager1 = new DevExpress.Utils.Animation.TransitionManager();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.queriesTableAdapter1 = new DXApplication4.call_centerDataSetTableAdapters.QueriesTableAdapter();
            this.call_cBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.call_centerDataSet = new DXApplication4.call_centerDataSet();
            this.call_cTableAdapter = new DXApplication4.call_centerDataSetTableAdapters.call_cTableAdapter();
            this.bSprom = new System.Windows.Forms.BindingSource(this.components);
            this.prom_abonTableAdapter = new DXApplication4.call_centerDataSetTableAdapters.prom_abonTableAdapter();
            this.bSbyt = new System.Windows.Forms.BindingSource(this.components);
            this.abonTableAdapter = new DXApplication4.call_centerDataSetTableAdapters.abonTableAdapter();
            this.containerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            this.xtraTabPage4.SuspendLayout();
            this.xtraTabPage5.SuspendLayout();
            this.xtraTabPage6.SuspendLayout();
            this.xtraTabPage7.SuspendLayout();
            this.xtraTabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.call_cBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSprom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSbyt)).BeginInit();
            this.SuspendLayout();
            // 
            // containerPanel
            // 
            this.containerPanel.Controls.Add(this.xtraTabControl1);
            this.containerPanel.Controls.Add(this.windowsUIButtonPanel1);
            this.containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.containerPanel.Location = new System.Drawing.Point(0, 0);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(1108, 699);
            this.containerPanel.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(12, 111);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1084, 585);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3,
            this.xtraTabPage4,
            this.xtraTabPage5,
            this.xtraTabPage6,
            this.xtraTabPage7,
            this.xtraTabPage8});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.uCzayavka1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1078, 557);
            this.xtraTabPage1.Text = "Заявки";
            // 
            // uCzayavka1
            // 
            this.uCzayavka1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCzayavka1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.uCzayavka1.Appearance.Options.UseBackColor = true;
            this.uCzayavka1.Location = new System.Drawing.Point(3, 3);
            this.uCzayavka1.Name = "uCzayavka1";
            this.uCzayavka1.Size = new System.Drawing.Size(1076, 542);
            this.uCzayavka1.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.uCbyt1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.PageVisible = false;
            this.xtraTabPage2.Size = new System.Drawing.Size(1078, 557);
            this.xtraTabPage2.Text = "Бытовые абоненты";
            // 
            // uCbyt1
            // 
            this.uCbyt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCbyt1.Location = new System.Drawing.Point(3, 3);
            this.uCbyt1.Name = "uCbyt1";
            this.uCbyt1.Size = new System.Drawing.Size(1073, 513);
            this.uCbyt1.TabIndex = 0;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.uCprom1);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.PageVisible = false;
            this.xtraTabPage3.Size = new System.Drawing.Size(1078, 557);
            this.xtraTabPage3.Text = "Промышленные абоненты";
            // 
            // uCprom1
            // 
            this.uCprom1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCprom1.Location = new System.Drawing.Point(7, 0);
            this.uCprom1.Name = "uCprom1";
            this.uCprom1.Size = new System.Drawing.Size(1076, 528);
            this.uCprom1.TabIndex = 0;
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Controls.Add(this.uCoper_zayavki1);
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.PageVisible = false;
            this.xtraTabPage4.Size = new System.Drawing.Size(1078, 557);
            // 
            // uCoper_zayavki1
            // 
            this.uCoper_zayavki1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCoper_zayavki1.Location = new System.Drawing.Point(0, 0);
            this.uCoper_zayavki1.Name = "uCoper_zayavki1";
            this.uCoper_zayavki1.Size = new System.Drawing.Size(1076, 532);
            this.uCoper_zayavki1.TabIndex = 0;
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Controls.Add(this.uCpoiskumn1);
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.PageVisible = false;
            this.xtraTabPage5.Size = new System.Drawing.Size(1078, 557);
            this.xtraTabPage5.Text = "Поиск по умным счетчикам";
            // 
            // uCpoiskumn1
            // 
            this.uCpoiskumn1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCpoiskumn1.Location = new System.Drawing.Point(-1, 3);
            this.uCpoiskumn1.Name = "uCpoiskumn1";
            this.uCpoiskumn1.Size = new System.Drawing.Size(1072, 511);
            this.uCpoiskumn1.TabIndex = 0;
            // 
            // xtraTabPage6
            // 
            this.xtraTabPage6.Controls.Add(this.uCplanotkl1);
            this.xtraTabPage6.Name = "xtraTabPage6";
            this.xtraTabPage6.PageVisible = false;
            this.xtraTabPage6.Size = new System.Drawing.Size(1078, 557);
            this.xtraTabPage6.Text = "Плановые отключения по ВЛ 0,4кВ и ВЛ 6-10кВ";
            // 
            // uCplanotkl1
            // 
            this.uCplanotkl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCplanotkl1.Location = new System.Drawing.Point(0, 0);
            this.uCplanotkl1.Name = "uCplanotkl1";
            this.uCplanotkl1.Size = new System.Drawing.Size(1083, 521);
            this.uCplanotkl1.TabIndex = 0;
            // 
            // xtraTabPage7
            // 
            this.xtraTabPage7.Controls.Add(this.uCjaloby_obr1);
            this.xtraTabPage7.Name = "xtraTabPage7";
            this.xtraTabPage7.PageVisible = false;
            this.xtraTabPage7.Size = new System.Drawing.Size(1078, 557);
            this.xtraTabPage7.Text = "Жалобы и обращения";
            // 
            // uCjaloby_obr1
            // 
            this.uCjaloby_obr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCjaloby_obr1.Location = new System.Drawing.Point(4, 4);
            this.uCjaloby_obr1.Name = "uCjaloby_obr1";
            this.uCjaloby_obr1.Size = new System.Drawing.Size(1086, 530);
            this.uCjaloby_obr1.TabIndex = 0;
            // 
            // xtraTabPage8
            // 
            this.xtraTabPage8.Controls.Add(this.uCpredr1);
            this.xtraTabPage8.Name = "xtraTabPage8";
            this.xtraTabPage8.PageVisible = false;
            this.xtraTabPage8.Size = new System.Drawing.Size(1078, 557);
            this.xtraTabPage8.Text = "Абоненты которых надо предупреждать";
            // 
            // uCpredr1
            // 
            this.uCpredr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCpredr1.Location = new System.Drawing.Point(0, 0);
            this.uCpredr1.Name = "uCpredr1";
            this.uCpredr1.Size = new System.Drawing.Size(1083, 526);
            this.uCpredr1.TabIndex = 0;
            // 
            // windowsUIButtonPanel1
            // 
            this.windowsUIButtonPanel1.AllowHtmlDraw = true;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.Options.UseTextOptions = true;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.windowsUIButtonPanel1.AppearanceButton.Hovered.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.windowsUIButtonPanel1.AppearanceButton.Normal.Options.UseTextOptions = true;
            this.windowsUIButtonPanel1.AppearanceButton.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.windowsUIButtonPanel1.AppearanceButton.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.windowsUIButtonPanel1.AppearanceButton.Normal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(119)))), ((int)(((byte)(176)))));
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Image = ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.AppearanceButton.Pressed.Image")));
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseBorderColor = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseImage = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.Options.UseTextOptions = true;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.windowsUIButtonPanel1.AppearanceButton.Pressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.windowsUIButtonPanel1.ButtonInterval = 50;
            this.windowsUIButtonPanel1.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Заявки", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.Buttons"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Поиск<br>бытового <br>абонента ", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.Buttons1"))), -1, DevExpress.XtraBars.Docking2010.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, "", true, -1, true, null, true, false, true, null, "", -1, false, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Поиск <br>промыш.<br>абонента", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.Buttons2"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Заявки<br> оператора", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.Buttons3"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Поиск<br> по умным<br> счетчикам ", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.Buttons4"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("План. откл. <br>ВЛ6-10кВ<br> и по ВЛ0,4кВ", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.Buttons5"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Жалобы <br> и обращения ", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.Buttons6"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Предупр.<br> абонентов", ((System.Drawing.Image)(resources.GetObject("windowsUIButtonPanel1.Buttons7"))), -1, DevExpress.XtraBars.Docking2010.ButtonStyle.CheckButton, -1)});
            this.windowsUIButtonPanel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.windowsUIButtonPanel1.Location = new System.Drawing.Point(12, 12);
            this.windowsUIButtonPanel1.Name = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.Size = new System.Drawing.Size(1001, 93);
            this.windowsUIButtonPanel1.TabIndex = 1;
            this.windowsUIButtonPanel1.Text = "windowsUIButtonPanel1";
            this.windowsUIButtonPanel1.WrapButtons = true;
            this.windowsUIButtonPanel1.ButtonChecked += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanel1_ButtonChecked);
            // 
            // transitionManager1
            // 
            transition1.Control = null;
            transition1.ShowWaitingIndicator = DevExpress.Utils.DefaultBoolean.True;
            clockTransition1.Parameters.FramesCount = null;
            transition1.TransitionType = clockTransition1;
            this.transitionManager1.Transitions.Add(transition1);
            // 
            // call_cBindingSource
            // 
            this.call_cBindingSource.DataMember = "call_c";
            this.call_cBindingSource.DataSource = this.call_centerDataSet;
            // 
            // call_centerDataSet
            // 
            this.call_centerDataSet.DataSetName = "call_centerDataSet";
            this.call_centerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // call_cTableAdapter
            // 
            this.call_cTableAdapter.ClearBeforeFill = true;
            // 
            // bSprom
            // 
            this.bSprom.DataMember = "prom_abon";
            this.bSprom.DataSource = this.call_centerDataSet;
            // 
            // prom_abonTableAdapter
            // 
            this.prom_abonTableAdapter.ClearBeforeFill = true;
            // 
            // bSbyt
            // 
            this.bSbyt.DataMember = "abon";
            this.bSbyt.DataSource = this.call_centerDataSet;
            // 
            // abonTableAdapter
            // 
            this.abonTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 699);
            this.Controls.Add(this.containerPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.LookAndFeel.SkinName = "Blueprint";
            this.Name = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.containerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            this.xtraTabPage4.ResumeLayout(false);
            this.xtraTabPage5.ResumeLayout(false);
            this.xtraTabPage6.ResumeLayout(false);
            this.xtraTabPage7.ResumeLayout(false);
            this.xtraTabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.call_cBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.call_centerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSprom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bSbyt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Animation.TransitionManager transitionManager1;
        private System.Windows.Forms.Panel containerPanel;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanel1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private call_centerDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.BindingSource call_cBindingSource;
        private call_centerDataSet call_centerDataSet;
        private call_centerDataSetTableAdapters.call_cTableAdapter call_cTableAdapter;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private UCzayavka uCzayavka1;
        private UCbyt uCbyt1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage6;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage7;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage8;
        private UCprom uCprom1;
        private System.Windows.Forms.BindingSource bSprom;
        private call_centerDataSetTableAdapters.prom_abonTableAdapter prom_abonTableAdapter;
        private System.Windows.Forms.BindingSource bSbyt;
        private call_centerDataSetTableAdapters.abonTableAdapter abonTableAdapter;
        private UCoper_zayavki uCoper_zayavki1;
        private UCpoiskumn uCpoiskumn1;
        private UCplanotkl uCplanotkl1;
        private UCjaloby_obr uCjaloby_obr1;
        private UCpredr uCpredr1;

    }
}

