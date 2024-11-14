namespace doandbms
{
    partial class GiaoDienSinhVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GiaoDienSinhVien));
            this.menuButton = new System.Windows.Forms.PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_qlSv = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_qlDn = new System.Windows.Forms.Button();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.mainForm = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_inforQl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.DimGray;
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.btn_inforQl);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidebar.MaximumSize = new System.Drawing.Size(216, 620);
            this.sidebar.MinimumSize = new System.Drawing.Size(72, 620);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(216, 620);
            this.sidebar.TabIndex = 5;
            this.sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebar_Paint);
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
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_qlSv);
            this.panel2.Location = new System.Drawing.Point(3, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 46);
            this.panel2.TabIndex = 1;
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
            this.btn_qlSv.Text = "              Thông tin sinh viên";
            this.btn_qlSv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlSv.UseVisualStyleBackColor = false;
            this.btn_qlSv.Click += new System.EventHandler(this.btn_qlSv_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.btn_qlDn);
            this.panel3.Location = new System.Drawing.Point(3, 130);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(214, 46);
            this.panel3.TabIndex = 2;
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
            this.btn_qlDn.Text = "              Hợp đồng / đổi tòa";
            this.btn_qlDn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qlDn.UseVisualStyleBackColor = false;
            this.btn_qlDn.Click += new System.EventHandler(this.btn_qlDn_Click);
            // 
            // sidebarTimer
            // 
            this.sidebarTimer.Interval = 10;
            this.sidebarTimer.Tick += new System.EventHandler(this.sidebarTimer_Tick);
            // 
            // mainForm
            // 
            this.mainForm.Location = new System.Drawing.Point(213, -4);
            this.mainForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainForm.Name = "mainForm";
            this.mainForm.Size = new System.Drawing.Size(1071, 613);
            this.mainForm.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(3, 180);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(18, 6, 0, 0);
            this.button1.Size = new System.Drawing.Size(264, 66);
            this.button1.TabIndex = 2;
            this.button1.Text = "              Hợp đồng / đổi tòa";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
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
            this.btn_inforQl.Location = new System.Drawing.Point(3, 180);
            this.btn_inforQl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_inforQl.Name = "btn_inforQl";
            this.btn_inforQl.Padding = new System.Windows.Forms.Padding(5, 6, 0, 0);
            this.btn_inforQl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_inforQl.Size = new System.Drawing.Size(264, 66);
            this.btn_inforQl.TabIndex = 3;
            this.btn_inforQl.Text = "              Kỷ luật";
            this.btn_inforQl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_inforQl.UseVisualStyleBackColor = false;
            // 
            // GiaoDienSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 612);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.mainForm);
            this.Name = "GiaoDienSinhVien";
            this.Text = "GiaoDienHocSinh";
            this.Load += new System.EventHandler(this.GiaoDienSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.menuButton)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Timer sidebarTimer;
        public Panel mainForm;
        private Button button1;
        private Button btn_inforQl;
    }
}