namespace Dekstop_Datagridview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btnTambah = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 26);
            dataGridView1.Margin = new Padding(6, 6, 6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1423, 747);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnTambah
            // 
            btnTambah.BackColor = SystemColors.ActiveCaption;
            btnTambah.Location = new Point(1306, 797);
            btnTambah.Margin = new Padding(6, 6, 6, 6);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(139, 49);
            btnTambah.TabIndex = 1;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(22, 797);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(418, 39);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(22, 855);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(419, 39);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.HighlightText;
            textBox3.Location = new Point(22, 909);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(419, 39);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.Location = new Point(488, 797);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(392, 39);
            textBox4.TabIndex = 5;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.HighlightText;
            textBox5.Location = new Point(489, 858);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(391, 39);
            textBox5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(32, 800);
            label1.Name = "label1";
            label1.Size = new Size(396, 32);
            label1.TabIndex = 7;
            label1.Text = "FATIMAH AZZAROH  222410101054";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(32, 858);
            label2.Name = "label2";
            label2.Size = new Size(375, 32);
            label2.TabIndex = 8;
            label2.Text = "JETRO SULTHAN F. 222410101064";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(32, 911);
            label3.Name = "label3";
            label3.Size = new Size(313, 32);
            label3.TabIndex = 9;
            label3.Text = "NEIFA ULIL L. 222410101067";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(504, 800);
            label4.Name = "label4";
            label4.Size = new Size(357, 32);
            label4.TabIndex = 10;
            label4.Text = "FARIQ ABDHE M. 222410101069";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(504, 863);
            label5.Name = "label5";
            label5.Size = new Size(322, 32);
            label5.TabIndex = 11;
            label5.Text = "RAFI JAUHARI 222410101087";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnTambah);
            Controls.Add(dataGridView1);
            Margin = new Padding(6, 6, 6, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnTambah;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}