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

        void cmbspp()
        {
            //get data IdOrder from database to combobox1 
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try

            {
                cmd = new MySqlCommand("select * from spp", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string sName = rd.GetString(0);
                    cmbSPP.Items.Add(sName);
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            conn.Close();
            rd.Close();

        }

        void cmbpetugas()
        {
            //get data IdOrder from database to combobox1 
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try

            {
                cmd = new MySqlCommand("select * from petugas", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string sName = rd.GetString(0);
                    cmbPetugas.Items.Add(sName);
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            conn.Close();
            rd.Close();
        }

        void cmbNisn()
        {
            //get data IdOrder from database to combobox1 
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try

            {
                cmd = new MySqlCommand("select * from siswa", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string sName = rd.GetString(2);
                    cmbnisn.Items.Add(sName);
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            conn.Close();
            rd.Close();

        }

        void bersih()
        {
            cmbNisn();
            cmb.Text = "";
            cmbnisn.Text = "";
            textBox4.Text = DateTime.Now.ToLocalTime().ToString("dd");
            textBox5.Text = DateTime.Now.ToLocalTime().ToString("MMMM");
            textBox6.Text = DateTime.Now.ToLocalTime().ToString("yyyy"); ;
            textBox8.Text = "";
            tampildata();
        }

        void tampildata()
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("select * from pembayaran", conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "pembayaran");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "pembayaran";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            conn.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("insert into pembayaran values('" +
                    cmb.Text + "','" +
                    cmbPetugas.Text + "','" +
                    cmbnisn.Text + "','" +
                    textBox4.Text + "','" +
                    textBox5.Text + "','" +
                    textBox6.Text + "','" +
                    cmbSPP.Text + "','" +
                    textBox8.Text + "')", conn);
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
            bersih();
            cmbpetugas();
            cmbspp();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("UPDATE pembayaran SET id_petugas='" +
                    cmbPetugas.Text + "',nisn='" +
                    cmbnisn.Text + "',tgl_bayar='" +
                    textBox4.Text + "',bulan_bayar='" +
                    textBox5.Text + "',tahun_bayar='" +
                    textBox6.Text + "',id_spp='" +
                    cmbSPP.Text + "',jumlah_bayar='" +
                    textBox8.Text + "'where id_pembayaran='" +
                    cmb.Text + "'", conn);
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
                cmd = new MySqlCommand("delete from pembayaran where id_pembayaran='" +
                    cmb.Text + "'", conn);
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            cmb.Text = row.Cells[0].Value.ToString();
            cmbPetugas.Text = row.Cells[1].Value.ToString();
            cmbnisn.Text = row.Cells[2].Value.ToString();
            textBox4.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
            cmbSPP.Text = row.Cells[6].Value.ToString();
            textBox8.Text = row.Cells[7].Value.ToString();
        }
    }
}
