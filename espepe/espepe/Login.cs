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

        public static Login aidi;
        public TextBox tb1;

        public Login()
        {
            InitializeComponent();
            aidi = this;
            tb1 = textBox1;
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
            //cmd2 = new MySqlCommand("select * from siswa where nama='" + textBox1.Text + "' and nis='" + textBox2.Text + "'", conn);

            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                if (rd[4].ToString() == "admin")
                {
                    Admin formAdmin = new Admin(/*rd[0].ToString()*/);
                    //Admin.aidi.labe = rd[0].ToString();
                    formAdmin.Show();
                    this.Hide();
                }
                else if (rd[4].ToString() == "petugas")
                {
                    Admin formAdmin = new Admin(/*rd[0].ToString()*/);
                    formAdmin.Show();
                    this.Hide();
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

            //rd2 = cmd2.ExecuteReader();
            //rd2.Read();
            //if (rd2.HasRows)
            //{
            //    if (rd2[4].ToString() == "admin")
            //    {
            //        Admin formAdmin = new Admin();
            //        formAdmin.Show();
            //        this.Hide();
            //        new idUser().Id = rd2[0].ToString();
            //    }
            //    else if (rd2[4].ToString() == "petugas")
            //    {

            //    }
            //    else
            //    {
            //        MessageBox.Show("Tidak termasuk Petugas");
            //    }

            //}
            //else
            //{
            //    MessageBox.Show("username atau password salah");
            //}
            //rd2.Close();
            //conn.Close();
            
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
    class daoetid
    {
        //public String aidi;
        //public daoetid(String value)
    }
}


