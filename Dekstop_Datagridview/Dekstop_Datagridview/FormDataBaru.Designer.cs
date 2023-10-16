namespace Dekstop_Datagridview
{
    partial class FormDataBaru
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
            label1 = new Label();
            tbNama = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbNip = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            label4 = new Label();
            tbGaji = new TextBox();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            cbBidang = new ComboBox();
            label7 = new Label();
            tbTanggal = new TextBox();
            label8 = new Label();
            tbTelp = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 55);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(312, 56);
            label1.TabIndex = 0;
            label1.Text = "Entri Data PNS";
            label1.Click += label1_Click;
            // 
            // tbNama
            // 
            tbNama.Location = new Point(410, 162);
            tbNama.Margin = new Padding(6, 6, 6, 6);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(713, 39);
            tbNama.TabIndex = 1;
            tbNama.TextChanged += tbNama_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 179);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 32);
            label2.TabIndex = 2;
            label2.Text = "Nama :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 265);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(259, 32);
            label3.TabIndex = 3;
            label3.Text = "Nomor Pegawai (NIP) : ";
            label3.Click += label3_Click;
            // 
            // tbNip
            // 
            tbNip.Location = new Point(410, 258);
            tbNip.Margin = new Padding(6, 6, 6, 6);
            tbNip.Name = "tbNip";
            tbNip.Size = new Size(713, 39);
            tbNip.TabIndex = 4;
            tbNip.TextChanged += tbLuas_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.BackColor = Color.LightGreen;
            btnSimpan.Location = new Point(659, 844);
            btnSimpan.Margin = new Padding(6, 6, 6, 6);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(174, 49);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = false;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.BackColor = Color.Red;
            btnBatal.Location = new Point(1285, 66);
            btnBatal.Margin = new Padding(6, 6, 6, 6);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(139, 49);
            btnBatal.TabIndex = 6;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = false;
            btnBatal.Click += btnBatal_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 350);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(66, 32);
            label4.TabIndex = 7;
            label4.Text = "Gaji :";
            label4.Click += label4_Click;
            // 
            // tbGaji
            // 
            tbGaji.Location = new Point(410, 343);
            tbGaji.Margin = new Padding(6, 6, 6, 6);
            tbGaji.Name = "tbGaji";
            tbGaji.Size = new Size(342, 39);
            tbGaji.TabIndex = 8;
            tbGaji.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 446);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 32);
            label5.TabIndex = 9;
            label5.Text = "Tanggal Lahir :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(410, 433);
            dateTimePicker1.Margin = new Padding(6, 6, 6, 6);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(368, 39);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 640);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 11;
            label6.Text = "Bidang :";
            // 
            // cbBidang
            // 
            cbBidang.FormattingEnabled = true;
            cbBidang.Items.AddRange(new object[] { "Agrikultur", "Kesehatan", "Ekonomi", "Pariwisata" });
            cbBidang.Location = new Point(410, 634);
            cbBidang.Margin = new Padding(6, 6, 6, 6);
            cbBidang.Name = "cbBidang";
            cbBidang.Size = new Size(725, 40);
            cbBidang.TabIndex = 12;
            cbBidang.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 538);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(163, 32);
            label7.TabIndex = 13;
            label7.Text = "Tempat Lahir :";
            // 
            // tbTanggal
            // 
            tbTanggal.Location = new Point(410, 531);
            tbTanggal.Margin = new Padding(6, 6, 6, 6);
            tbTanggal.Name = "tbTanggal";
            tbTanggal.Size = new Size(713, 39);
            tbTanggal.TabIndex = 14;
            tbTanggal.TextChanged += textBox2_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(156, 747);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(109, 32);
            label8.TabIndex = 15;
            label8.Text = "No Telp :";
            // 
            // tbTelp
            // 
            tbTelp.Location = new Point(410, 740);
            tbTelp.Margin = new Padding(6, 6, 6, 6);
            tbTelp.Name = "tbTelp";
            tbTelp.Size = new Size(342, 39);
            tbTelp.TabIndex = 16;
            tbTelp.TextChanged += textBox3_TextChanged;
            // 
            // FormDataBaru
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1486, 960);
            Controls.Add(tbTelp);
            Controls.Add(label8);
            Controls.Add(tbTanggal);
            Controls.Add(label7);
            Controls.Add(cbBidang);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(tbGaji);
            Controls.Add(label4);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(tbNip);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbNama);
            Controls.Add(label1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "FormDataBaru";
            Text = "FormDataBaru";
            Load += FormDataBaru_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNama;
        private Label label2;
        private Label label3;
        private TextBox tbNip;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label4;
        private TextBox tbGaji;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private ComboBox cbBidang;
        private Label label7;
        private TextBox tbTanggal;
        private Label label8;
        private TextBox tbTelp;
    }
}