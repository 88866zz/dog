﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formqlsv
{
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn thật sự muốn thoát ? ","thông báo",MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) 
            {
                e.Cancel = true;
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            formdssv f = new formdssv();
            this.Hide();
            f.Show();
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dfdsfdsfdsfdsfdsfdf
        }dsdfdsfdsf
    }
}
