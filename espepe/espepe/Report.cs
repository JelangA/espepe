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
    public partial class Report : Form
    {
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlCommand cmd;
        private MySqlDataReader rd;

        Koneksi koneksi = new Koneksi();
        public Report()
        {
            InitializeComponent();
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

        void combobula()
        {
           
            //get data IdOrder from database to combobox1 
            MySqlConnection conn = koneksi.getKon();
            conn.Open();
            try

            {
                cmd = new MySqlCommand("select * from pembayaran", conn);
                rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    string sName = rd.GetString(4);
                    comboBox1.Items.Add(sName);
                }
            }
            catch (Exception g)
            {
                MessageBox.Show(g.Message);
            }
            conn.Close();
            rd.Close();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            tampildata();
            combobula();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "laporan pembayaran spp";
            printer.SubTitle = string.Format(
                "tanggal {0}", DateTime.Now.Date.ToString("dddd-MMMM-yyyy")
                );
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.TitleSpacing = 12;
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dataGridView1);
            printer.PrintMargins.Top = 20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Admin().Show();
        }

       
    }
}
