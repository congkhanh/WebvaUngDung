﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFORMKLShop.ServiceReferenceSanPham;

namespace WFORMKLShop
{
    public partial class FormXemTonKho : Form
    {
        private ServiceSanPhamClient svsp = new ServiceSanPhamClient();
        public FormXemTonKho()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormXemTonKho_Load(object sender, EventArgs e)
        {
            dvXemtonKho.AutoGenerateColumns = false;
            dvXemtonKho.DataSource = svsp.All();
        }
    }
}
