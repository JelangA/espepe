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
    public partial class TInkgatJurusan : Form
    {
        private DataSet ds;
        private MySqlDataAdapter da;
        //private MySqlDataReader rd;
        private MySqlCommand cmd;

        Koneksi koneksi = new Koneksi();
        public TInkgatJurusan()
        {
            InitializeComponent();
        }

        void bersih()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            tampildataJurusan();
            tampildataTingkat();
        }

        void tampildataJurusan()
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("select * from tjurusan", conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "tjurusan");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "tjurusan";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            conn.Close();
        }
        void tampildataTingkat()
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("select * from ttingkat", conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "ttingkat");
                dataGridView2.DataSource = ds;
                dataGridView2.DataMember = "ttingkat";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            conn.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("insert into ttingkat values('" +
                    textBox2.Text + "')", conn);
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

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("insert into tjurusan values('" +
                    textBox1.Text + "')", conn);
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
    

        private void button8_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("delete from ttingkat where tingkat='" +
                    textBox2.Text + "'", conn);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("delete from tjurusan where jurusan='" +
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

        private void TInkgatJurusan_Load(object sender, EventArgs e)
        {
            bersih();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView2.Rows[e.RowIndex];
            textBox2.Text = row.Cells[0].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ManageKelas().Show();
        }
    }
}
