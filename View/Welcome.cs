﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace A_232410101042_utspbo.View
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            this.Load += Welcome_Load;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashboardAdmin dashboardAdmin = new DashboardAdmin();
            if (dashboardAdmin.ShowDialog() == DialogResult.OK)
            {
                LoadDataLogin();
            }
            this.Show();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            //Menentukan tindakan ketika form dimuat.LoadDataMahasiswa() dipanggil untuk
            //mengisi DataGridView dengan data mahasiswa.
            LoadDataLogin();
        }


        private void Welcome_Load(object sender, EventArgs e)
        {
            cbWelcome.Items.Add("Halaman Kontak");
            cbWelcome.Items.Add("Halaman Login");
            cbWelcome.Items.Add("Halaman Register");
        }
    }
}
