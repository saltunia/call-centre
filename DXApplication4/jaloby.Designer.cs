namespace DXApplication4
{
    partial class jaloby
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jaloby));
            this.uCjaloby_obr1 = new DXApplication4.UCjaloby_obr();
            this.SuspendLayout();
            // 
            // uCjaloby_obr1
            // 
            this.uCjaloby_obr1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uCjaloby_obr1.Location = new System.Drawing.Point(3, 1);
            this.uCjaloby_obr1.Name = "uCjaloby_obr1";
            this.uCjaloby_obr1.Size = new System.Drawing.Size(948, 545);
            this.uCjaloby_obr1.TabIndex = 0;
            this.uCjaloby_obr1.Load += new System.EventHandler(this.uCjaloby_obr1_Load);
            // 
            // jaloby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 550);
            this.Controls.Add(this.uCjaloby_obr1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "jaloby";
            this.Text = "Жалобы и обращения";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.jaloby_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private UCjaloby_obr uCjaloby_obr1;


    }
}