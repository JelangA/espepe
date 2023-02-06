using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace espepe
{
    public partial class Login : Form
    {
        private MySqlCommand cmd;
        private MySqlDataReader rd;

        Koneksi koneksi = new Koneksi();
        public Login()
        {
            InitializeComponent();
        }

        void batal()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            cmd = new MySqlCommand("select * from petugas where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'", conn);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                if (rd[4].ToString() == "admin")
                {
                    Admin formAdmin = new Admin();
                    formAdmin.Show();
                    this.Hide();
                }
                else if (rd[4].ToString() == "petugas")
                {
                    //Teknis formMenu = new Teknis();
                    //formMenu.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Tidak termasuk Petugas");
                }
            }
            else
            {
                MessageBox.Show("username atau password salah");
            }
            rd.Close();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            batal();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
