namespace Hackkathon
{
    partial class FrmLearn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLearn));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnContact = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstWord = new Telerik.WinControls.UI.RadListView();
            this.radListView1 = new Telerik.WinControls.UI.RadListView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lstDanhSach = new System.Windows.Forms.ListView();
            this.btnLearn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnPrenium = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.btnPrenium);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnContact);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lstWord);
            this.panel1.Controls.Add(this.radListView1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1515, 142);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorderThickness = 1;
            this.btnExit.ActiveCornerRadius = 20;
            this.btnExit.ActiveFillColor = System.Drawing.Color.LightCoral;
            this.btnExit.ActiveForecolor = System.Drawing.Color.White;
            this.btnExit.ActiveLineColor = System.Drawing.Color.LightCoral;
            this.btnExit.AutoSize = true;
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.ButtonText = "Exit";
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleCornerRadius = 20;
            this.btnExit.IdleFillColor = System.Drawing.Color.Crimson;
            this.btnExit.IdleForecolor = System.Drawing.Color.White;
            this.btnExit.IdleLineColor = System.Drawing.Color.Crimson;
            this.btnExit.Location = new System.Drawing.Point(1193, 29);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(174, 68);
            this.btnExit.TabIndex = 6;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnContact
            // 
            this.btnContact.ActiveBorderThickness = 1;
            this.btnContact.ActiveCornerRadius = 20;
            this.btnContact.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnContact.ActiveForecolor = System.Drawing.Color.White;
            this.btnContact.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnContact.BackColor = System.Drawing.Color.Black;
            this.btnContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnContact.BackgroundImage")));
            this.btnContact.ButtonText = "Contact";
            this.btnContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContact.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContact.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnContact.IdleBorderThickness = 1;
            this.btnContact.IdleCornerRadius = 20;
            this.btnContact.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btnContact.IdleForecolor = System.Drawing.Color.White;
            this.btnContact.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.btnContact.Location = new System.Drawing.Point(377, 19);
            this.btnContact.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnContact.Name = "btnContact";
            this.btnContact.Size = new System.Drawing.Size(174, 68);
            this.btnContact.TabIndex = 4;
            this.btnContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(-5, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1520, 20);
            this.panel3.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1205, 10);
            this.panel2.TabIndex = 5;
            // 
            // lstWord
            // 
            this.lstWord.Location = new System.Drawing.Point(3, 149);
            this.lstWord.Name = "lstWord";
            this.lstWord.Size = new System.Drawing.Size(180, 405);
            this.lstWord.TabIndex = 3;
            // 
            // radListView1
            // 
            this.radListView1.Location = new System.Drawing.Point(3, 149);
            this.radListView1.Name = "radListView1";
            this.radListView1.Size = new System.Drawing.Size(180, 521);
            this.radListView1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(341, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.BackColor = System.Drawing.Color.Snow;
            this.lstDanhSach.Location = new System.Drawing.Point(-5, 135);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(306, 733);
            this.lstDanhSach.TabIndex = 3;
            this.lstDanhSach.UseCompatibleStateImageBehavior = false;
            this.lstDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // btnLearn
            // 
            this.btnLearn.ActiveBorderThickness = 1;
            this.btnLearn.ActiveCornerRadius = 20;
            this.btnLearn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnLearn.ActiveForecolor = System.Drawing.Color.White;
            this.btnLearn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnLearn.BackColor = System.Drawing.Color.White;
            this.btnLearn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLearn.BackgroundImage")));
            this.btnLearn.ButtonText = "Learn";
            this.btnLearn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLearn.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLearn.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnLearn.IdleBorderThickness = 1;
            this.btnLearn.IdleCornerRadius = 20;
            this.btnLearn.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btnLearn.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnLearn.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.btnLearn.Location = new System.Drawing.Point(60, 214);
            this.btnLearn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnLearn.Name = "btnLearn";
            this.btnLearn.Size = new System.Drawing.Size(174, 97);
            this.btnLearn.TabIndex = 8;
            this.btnLearn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLearn.Click += new System.EventHandler(this.btnLearn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(307, 148);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1196, 683);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1145, 631);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ActiveBorderThickness = 1;
            this.btnTimKiem.ActiveCornerRadius = 20;
            this.btnTimKiem.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.ActiveForecolor = System.Drawing.Color.White;
            this.btnTimKiem.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.BackgroundImage")));
            this.btnTimKiem.ButtonText = "Near English Centers";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimKiem.IdleBorderThickness = 1;
            this.btnTimKiem.IdleCornerRadius = 20;
            this.btnTimKiem.IdleFillColor = System.Drawing.Color.LimeGreen;
            this.btnTimKiem.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.IdleLineColor = System.Drawing.Color.ForestGreen;
            this.btnTimKiem.Location = new System.Drawing.Point(60, 363);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(174, 149);
            this.btnTimKiem.TabIndex = 11;
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPrenium
            // 
            this.btnPrenium.ActiveBorderThickness = 1;
            this.btnPrenium.ActiveCornerRadius = 20;
            this.btnPrenium.ActiveFillColor = System.Drawing.Color.LightBlue;
            this.btnPrenium.ActiveForecolor = System.Drawing.Color.Black;
            this.btnPrenium.ActiveLineColor = System.Drawing.Color.LightSteelBlue;
            this.btnPrenium.BackColor = System.Drawing.Color.Black;
            this.btnPrenium.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrenium.BackgroundImage")));
            this.btnPrenium.ButtonText = "Go to Prenium";
            this.btnPrenium.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrenium.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrenium.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnPrenium.IdleBorderThickness = 1;
            this.btnPrenium.IdleCornerRadius = 20;
            this.btnPrenium.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.btnPrenium.IdleForecolor = System.Drawing.Color.White;
            this.btnPrenium.IdleLineColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrenium.Location = new System.Drawing.Point(605, 19);
            this.btnPrenium.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnPrenium.Name = "btnPrenium";
            this.btnPrenium.Size = new System.Drawing.Size(241, 68);
            this.btnPrenium.TabIndex = 8;
            this.btnPrenium.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmLearn
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1515, 781);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnLearn);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLearn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLearn";
            this.Load += new System.EventHandler(this.FrmLearn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radListView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Telerik.WinControls.UI.RadListView lstWord;
        private Telerik.WinControls.UI.RadListView radListView1;
        private System.Windows.Forms.ListView lstDanhSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnContact;
        private Bunifu.Framework.UI.BunifuThinButton2 btnExit;
        private Bunifu.Framework.UI.BunifuThinButton2 btnLearn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnTimKiem;
        private Bunifu.Framework.UI.BunifuThinButton2 btnPrenium;
    }
}