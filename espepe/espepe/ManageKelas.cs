using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using DGVPrinterHelper;

namespace espepe
{
    public partial class ManageKelas : Form
    {
        private DataSet ds;
        private MySqlCommand cmd;
        private MySqlDataReader rd;
        private MySqlDataAdapter da;

        Koneksi koneksi = new Koneksi();
        public ManageKelas()
        {
            InitializeComponent();
        }
        void bersih()
        {
            textBox1.Text = "";
            txtkelas.Text = "";
            cmbjurusan.Text = "pilih Jurusan";
            cmbtingkat.Text = "pilih Tingkat";
            tampilData();
            
        }
        void tampilData()
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("select * from kelas", conn);
                ds = new DataSet();
                da = new MySqlDataAdapter(cmd);
                da.Fill(ds, "kelas");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "kelas";
            }catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
            conn.Close();
        }

        void cmbJurusan()
        {
            //get data IdOrder from database to combobox1 
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try

            {
                cmd = new MySqlCommand("select * from tjurusan", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string sName = rd.GetString(0);
                    cmbjurusan.Items.Add(sName);
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            conn.Close();
            rd.Close();

        }

        void cmbTingkats()
        {
            //get data IdOrder from database to combobox1 
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try

            {
                cmd = new MySqlCommand("select * from ttingkat", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string sName = rd.GetString(0);
                    cmbtingkat.Items.Add(sName);
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            conn.Close();
            rd.Close();

        }

        private void ManageKelas_Load(object sender, EventArgs e)
        {
            bersih();
            cmbJurusan();
            cmbTingkats();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("insert into kelas values('" +
                           textBox1.Text + "','" +
                           txtkelas.Text + "','" +
                           cmbtingkat.Text + "','" +
                           cmbjurusan.Text + "')", conn);
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new TInkgatJurusan().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bersih();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try
            {
                cmd = new MySqlCommand("UPDATE kelas SET jurusan='" +
                    txtkelas.Text + "',kelas='" +
                    cmbtingkat.Text + "'where id_kelas='" +
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
                cmd = new MySqlCommand("delete from kelas where id_kelas='" +
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            txtkelas.Text = row.Cells[1].Value.ToString();
            cmbtingkat.Text = row.Cells[2].Value.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.PrintPreviewDataGridView(dataGridView1);
        }
    }
}
