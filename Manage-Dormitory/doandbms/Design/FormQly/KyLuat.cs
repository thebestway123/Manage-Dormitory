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
    public partial class KyLuat : UserControl
    {
        QuanLy quanLy = new QuanLy();
        public KyLuat(QuanLy quanLy)
        {
            this.quanLy = quanLy;
            InitializeComponent();
        }
    }
}
