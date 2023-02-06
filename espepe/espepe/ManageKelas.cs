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

        private void ManageKelas_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
