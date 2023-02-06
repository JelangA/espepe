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
    public partial class ManagePetugas : Form
    {
        private DataSet ds;
        private MySqlDataReader rd;
        private MySqlDataAdapter da;
        private MySqlCommand cmd;

        Koneksi koneksi = new Koneksi();

        public ManagePetugas()
        {
            InitializeComponent();
        }
        void tampilData()
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("select * from petugas", conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "petugas");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "petugas";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            conn.Close();
        }

        void bersih()
        {
            txtId.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtLevel.Text = "";
            txtNama.Text = "";
            tampilData();
        }

        private void ManagePetugas_Load(object sender, EventArgs e)
        {
            bersih();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            { 
                cmd = new MySqlCommand("insert into petugas values('" +
                           txtId.Text + "','" +
                           txtUsername.Text + "','" +
                           txtPassword.Text + "','" +
                           txtNama.Text + "','" +
                           txtLevel.Text + "')", conn);
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

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("UPDATE petugas SET username='" +
                    txtUsername.Text + "',password='" +
                    txtPassword.Text + "',nama_petugas='" +
                    txtNama.Text + "',level='" +
                    txtLevel.Text + "'where id_petugas='" +
                    txtId.Text + "'", conn);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            txtId.Text = row.Cells[0].Value.ToString();
            txtUsername.Text = row.Cells[1].Value.ToString();
            txtPassword.Text = row.Cells[2].Value.ToString();
            txtNama.Text = row.Cells[3].Value.ToString();
            txtLevel.Text = row.Cells[4].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                
                cmd = new MySqlCommand("delete from petugas where id_petugas='"
                   + txtId.Text + "'", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berhasil di delete");
                bersih();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }
    }
}
