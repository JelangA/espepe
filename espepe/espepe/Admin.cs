using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace espepe
{
    public partial class Admin : Form
    {
        public static Admin aidi;
        

        public Admin(/*String value*/)
        {
            InitializeComponent();
            aidi = this;
         
        }

        geter Geter = new geter();

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManagePetugas().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageSiswa().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageKelas().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SPP().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Pembayaran().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Report().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(" id =" + Geter.aidi);
        }
    }
}
