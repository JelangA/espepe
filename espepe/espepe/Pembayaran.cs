using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace espepe
{
    public partial class Pembayaran : Form
    {

        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;
        private DataSet ds;

        Koneksi koneksi = new Koneksi();

        public Pembayaran()
        {
            InitializeComponent();
        }

        void bersih()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("insert into pembayaran values('" +
                    textBox1.Text + "','" +
                    textBox2.Text + "','" +
                    textBox3.Text + "','" +
                    textBox4.Text + "','" +
                    textBox5.Text + "','" +
                    textBox6.Text + "','" +
                    textBox7.Text + "')", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil di simpan");
                bersih();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            conn.Close();
        }

        private void Pembayaran_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("UPDATE siswa SET id_petugas='" +
                    textBox2.Text + "',nins='" +
                    textBox3.Text + "',tgl_bayar='" +
                    textBox4.Text + "',bulan_bayar='" +
                    textBox5.Text + "',tahun_bayar='" +
                    textBox6.Text + "',id_spp='" +
                    textBox7.Text + "'jumlha_bayar='" +
                    textBox1.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil di simpan");
                bersih();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            conn.Close();
        }
    }
}
