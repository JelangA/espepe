using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DGVPrinterHelper;

namespace espepe
{
    public partial class ManageSiswa : Form
    {
        private DataSet ds;
        private MySqlCommand cmd;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;

        Koneksi koneksi = new Koneksi();

        public ManageSiswa()
        {
            InitializeComponent();
        }

        void cmbJurusan()
        {
            //get data IdOrder from database to combobox1 
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try

            {
                cmd = new MySqlCommand("select * from kelas", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string sName = rd.GetString(1);
                    cmbKls.Items.Add(sName);
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            conn.Close();
            rd.Close();

        }

        void cmbSpp()
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
                    string sName = rd.GetString(1);
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

        void bersih()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            cmbKls.Text = "Pilih Kelas";
            textBox5.Text = "";
            textBox6.Text = "";
            cmbSPP.Text = "Pilih SPP";
            tampilData();
            
        }
        void tampilData()
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("select * from siswa", conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "siswa");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "siswa";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            conn.Close();
        }
        private void ManageSiswa_Load(object sender, EventArgs e)
        {
            bersih();
            cmbJurusan();
            cmbSpp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("insert into siswa values('" +
                    textBox1.Text + "','" +
                    textBox2.Text + "','" +
                    textBox3.Text + "','" +
                    cmbKls.Text + "','" +
                    textBox5.Text + "','" +
                    textBox6.Text + "','" +
                    cmbSPP.Text + "')", conn);
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
                cmd = new MySqlCommand("UPDATE siswa SET nis='" +
                    textBox2.Text + "',nama='" +
                    textBox3.Text + "',id_kelas='" +
                    cmbKls.Text + "',alamat='" +
                    textBox5.Text + "',no_telpon='" +
                    textBox6.Text + "',id_spp='" +
                    cmbSPP.Text + "'where nisn='" +
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
        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("delete from siswa where nisn='" +
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
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            cmbKls.Text = row.Cells[3].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
            textBox6.Text = row.Cells[5].Value.ToString();
            cmbSPP.Text = row.Cells[6].Value.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.PrintPreviewDataGridView(dataGridView1);
        }
    }
}
