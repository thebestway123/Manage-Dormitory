﻿namespace doandbms.Design
{
    partial class GiaoDienQuanLi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienQuanLi));
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_qlSv = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_qlDn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_qlPhong = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_qlHd = new System.Windows.Forms.Button();
            this.btn_inforQl = new System.Windows.Forms.Button();
            this.btn_Kl = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.mainForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menuButton.Image = ((System.Drawing.Image)(resources.GetObject("menuButton.Image")));
            this.menuButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuButton.Location = new System.Drawing.Point(8, 17);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(46, 37);
            this.menuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuButton.TabIndex = 0;
            this.menuButton.TabStop = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click_1);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DimGray;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.btn_inforQl);
            this.sidebar.Controls.Add(this.btn_Kl);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(216, 620);
            this.sidebar.MinimumSize = new System.Drawing.Size(72, 620);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(216, 620);
            this.sidebar.TabIndex = 3;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuButton);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 74);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(74, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_qlSv);
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 46);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_qlSv
            // 
            this.btn_qlSv.BackColor = System.Drawing.Color.DimGray;
            this.btn_qlSv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_qlSv.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_qlSv.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qlSv.Image = ((System.Drawing.Image)(resources.GetObject("btn_qlSv.Image")));
            this.btn_qlSv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlSv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_qlSv.Location = new System.Drawing.Point(-13, -13);
            this.btn_qlSv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_qlSv.Name = "btn_qlSv";
            this.btn_qlSv.Padding = new System.Windows.Forms.Padding(18, 6, 0, 0);
            this.btn_qlSv.Size = new System.Drawing.Size(264, 66);
            this.btn_qlSv.TabIndex = 1;
            this.btn_qlSv.Text = "              Quản lí sinh viên";
            this.btn_qlSv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlSv.UseVisualStyleBackColor = false;
            this.btn_qlSv.Click += new System.EventHandler(this.btn_qlSv_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_qlDn);
            this.panel3.Location = new System.Drawing.Point(3, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 46);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btn_qlDn
            // 
            this.btn_qlDn.BackColor = System.Drawing.Color.DimGray;
            this.btn_qlDn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_qlDn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_qlDn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qlDn.Image = ((System.Drawing.Image)(resources.GetObject("btn_qlDn.Image")));
            this.btn_qlDn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlDn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_qlDn.Location = new System.Drawing.Point(-13, -13);
            this.btn_qlDn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_qlDn.Name = "btn_qlDn";
            this.btn_qlDn.Padding = new System.Windows.Forms.Padding(18, 6, 0, 0);
            this.btn_qlDn.Size = new System.Drawing.Size(264, 66);
            this.btn_qlDn.TabIndex = 1;
            this.btn_qlDn.Text = "              Quản lý điện nước";
            this.btn_qlDn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlDn.UseVisualStyleBackColor = false;
            this.btn_qlDn.Click += new System.EventHandler(this.btn_qlDn_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_qlPhong);
            this.panel4.Location = new System.Drawing.Point(3, 180);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(214, 46);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btn_qlPhong
            // 
            this.btn_qlPhong.BackColor = System.Drawing.Color.DimGray;
            this.btn_qlPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_qlPhong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_qlPhong.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qlPhong.Image = ((System.Drawing.Image)(resources.GetObject("btn_qlPhong.Image")));
            this.btn_qlPhong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlPhong.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_qlPhong.Location = new System.Drawing.Point(-13, -13);
            this.btn_qlPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_qlPhong.Name = "btn_qlPhong";
            this.btn_qlPhong.Padding = new System.Windows.Forms.Padding(18, 6, 0, 0);
            this.btn_qlPhong.Size = new System.Drawing.Size(264, 66);
            this.btn_qlPhong.TabIndex = 1;
            this.btn_qlPhong.Text = "              Quản lý phòng";
            this.btn_qlPhong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlPhong.UseVisualStyleBackColor = false;
            this.btn_qlPhong.Click += new System.EventHandler(this.btn_qlPhong_Click_1);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_qlHd);
            this.panel5.Location = new System.Drawing.Point(3, 230);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(214, 46);
            this.panel5.TabIndex = 4;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // btn_qlHd
            // 
            this.btn_qlHd.BackColor = System.Drawing.Color.DimGray;
            this.btn_qlHd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_qlHd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_qlHd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_qlHd.Image = ((System.Drawing.Image)(resources.GetObject("btn_qlHd.Image")));
            this.btn_qlHd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlHd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_qlHd.Location = new System.Drawing.Point(-13, -13);
            this.btn_qlHd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_qlHd.Name = "btn_qlHd";
            this.btn_qlHd.Padding = new System.Windows.Forms.Padding(18, 6, 0, 0);
            this.btn_qlHd.Size = new System.Drawing.Size(264, 66);
            this.btn_qlHd.TabIndex = 1;
            this.btn_qlHd.Text = "              Quản lý hợp đồng";
            this.btn_qlHd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlHd.UseVisualStyleBackColor = false;
            this.btn_qlHd.Click += new System.EventHandler(this.btn_qlHd_Click_1);
            // 
            // btn_inforQl
            // 
            this.btn_inforQl.BackColor = System.Drawing.Color.DimGray;
            this.btn_inforQl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_inforQl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_inforQl.ForeColor = System.Drawing.Color.Transparent;
            this.btn_inforQl.Image = ((System.Drawing.Image)(resources.GetObject("btn_inforQl.Image")));
            this.btn_inforQl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_inforQl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_inforQl.Location = new System.Drawing.Point(3, 280);
            this.btn_inforQl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inforQl.Name = "btn_inforQl";
            this.btn_inforQl.Padding = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.btn_inforQl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_inforQl.Size = new System.Drawing.Size(264, 66);
            this.btn_inforQl.TabIndex = 2;
            this.btn_inforQl.Text = "              Thông tin quản lí";
            this.btn_inforQl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inforQl.UseVisualStyleBackColor = false;
            this.btn_inforQl.Click += new System.EventHandler(this.btn_inforQl_Click_1);
            // 
            // btn_Kl
            // 
            this.btn_Kl.BackColor = System.Drawing.Color.DimGray;
            this.btn_Kl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Kl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Kl.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Kl.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kl.Image")));
            this.btn_Kl.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Kl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn_Kl.Location = new System.Drawing.Point(3, 350);
            this.btn_Kl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Kl.Name = "btn_Kl";
            this.btn_Kl.Padding = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.btn_Kl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Kl.Size = new System.Drawing.Size(264, 66);
            this.btn_Kl.TabIndex = 5;
            this.btn_Kl.Text = "              Kỷ luật";
            this.btn_Kl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Kl.UseVisualStyleBackColor = false;
            this.btn_Kl.Click += new System.EventHandler(this.btn_Kl_Click_1);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // mainForm
            // 
            this.mainForm.Location = new System.Drawing.Point(212, 0);
            this.mainForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainForm.Name = "mainForm";
            this.mainForm.Size = new System.Drawing.Size(1074, 612);
            this.mainForm.TabIndex = 4;
            this.mainForm.Paint += new System.Windows.Forms.PaintEventHandler(this.mainForm_Paint);
            // 
            // GiaoDienQuanLi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 612);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.mainForm);
            this.Name = "GiaoDienQuanLi";
            this.Text = "GiaoDien";
            this.Load += new System.EventHandler(this.GiaoDienQuanLi_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox menuButton;
        private FlowLayoutPanel sidebar;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btn_qlSv;
        private Panel panel3;
        private Button btn_qlDn;
        private Panel panel4;
        private Button btn_qlPhong;
        private Panel panel5;
        private Button btn_qlHd;
        private Button btn_inforQl;
        private Button btn_Kl;
        private System.Windows.Forms.Timer sidebarTimer;
        public Panel mainForm;
    }
}