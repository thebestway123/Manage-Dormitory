﻿using doandbms.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace doandbms.Design
{
    public partial class QuanLiPhong : UserControl
    {
        QuanLy quanLy = new QuanLy();

        public QuanLiPhong(QuanLy quanLy)
        {
            this.quanLy = quanLy;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
