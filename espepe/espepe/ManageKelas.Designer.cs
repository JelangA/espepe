
namespace espepe
{
    partial class ManageKelas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btninput = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelet = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtkelas = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmbtingkat = new System.Windows.Forms.ComboBox();
            this.cmbjurusan = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(658, 119);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jurusan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tingkat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Manage Kelas";
            // 
            // btninput
            // 
            this.btninput.Location = new System.Drawing.Point(382, 71);
            this.btninput.Name = "btninput";
            this.btninput.Size = new System.Drawing.Size(138, 34);
            this.btninput.TabIndex = 4;
            this.btninput.Text = "Input";
            this.btninput.UseVisualStyleBackColor = true;
            this.btninput.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(464, 118);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(138, 35);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btndelet
            // 
            this.btndelet.Location = new System.Drawing.Point(562, 159);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(138, 35);
            this.btndelet.TabIndex = 4;
            this.btndelet.Text = "Delete";
            this.btndelet.UseVisualStyleBackColor = true;
            this.btndelet.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(23, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "<==";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.txtkelas);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.cmbtingkat);
            this.panel2.Controls.Add(this.cmbjurusan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.btndelet);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btnedit);
            this.panel2.Controls.Add(this.btninput);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(30, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 383);
            this.panel2.TabIndex = 6;
            // 
            // txtkelas
            // 
            this.txtkelas.Location = new System.Drawing.Point(184, 101);
            this.txtkelas.Name = "txtkelas";
            this.txtkelas.Size = new System.Drawing.Size(145, 23);
            this.txtkelas.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 23);
            this.textBox1.TabIndex = 8;
            // 
            // cmbtingkat
            // 
            this.cmbtingkat.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbtingkat.FormattingEnabled = true;
            this.cmbtingkat.Location = new System.Drawing.Point(184, 138);
            this.cmbtingkat.Name = "cmbtingkat";
            this.cmbtingkat.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbtingkat.Size = new System.Drawing.Size(196, 23);
            this.cmbtingkat.TabIndex = 7;
            this.cmbtingkat.Text = "Tingkat";
            // 
            // cmbjurusan
            // 
            this.cmbjurusan.FormattingEnabled = true;
            this.cmbjurusan.Location = new System.Drawing.Point(184, 174);
            this.cmbjurusan.Name = "cmbjurusan";
            this.cmbjurusan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbjurusan.Size = new System.Drawing.Size(196, 23);
            this.cmbjurusan.TabIndex = 7;
            this.cmbjurusan.Text = "Jurusan";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(608, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ubah Tingkat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button5_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Id_Kelas";
            // 
            // ManageKelas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "ManageKelas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageKelas";
            this.Load += new System.EventHandler(this.ManageKelas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btninput;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelet;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbjurusan;
        private System.Windows.Forms.TextBox txtkelas;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbtingkat;
    }
}