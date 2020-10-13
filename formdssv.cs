using System;
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
    public partial class formdssv : Form
    {
        public formdssv()
        {
            InitializeComponent();
        }
        private void danhsachlop()
        {
            cbokhoa.Items.Clear();
          
           
           
        }
        private void formgiaodien_Load(object sender, EventArgs e)
        {
            danhsachlop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fqllop f = new fqllop();
            this.Hide();
            f.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txbaddnganh.Text.Trim() != "")
            {
                cbokhoa.Items.Add(txbaddnganh.Text);
                txbaddnganh.Text = "";
                danhsachlop();
              

            }
            else
                MessageBox.Show("phai nhap ten nganh !");
        }

        private void loginAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbokhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
             



        }
    }
}
