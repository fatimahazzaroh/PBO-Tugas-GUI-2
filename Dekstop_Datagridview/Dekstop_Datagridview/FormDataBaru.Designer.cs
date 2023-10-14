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
            tbLuas = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Variable Display", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(84, 38);
            label1.Name = "label1";
            label1.Size = new Size(218, 28);
            label1.TabIndex = 0;
            label1.Text = "Entri Data Agrikultur";
            // 
            // tbNama
            // 
            tbNama.Location = new Point(202, 103);
            tbNama.Name = "tbNama";
            tbNama.Size = new Size(222, 23);
            tbNama.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 106);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 2;
            label2.Text = "Nama Tumbuhan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 146);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 3;
            label3.Text = "Luas Lahan";
            // 
            // tbLuas
            // 
            tbLuas.Location = new Point(202, 143);
            tbLuas.Name = "tbLuas";
            tbLuas.Size = new Size(222, 23);
            tbLuas.TabIndex = 4;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(241, 198);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(75, 23);
            btnSimpan.TabIndex = 5;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += btnSimpan_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(349, 198);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(75, 23);
            btnBatal.TabIndex = 6;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // FormDataBaru
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(tbLuas);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(tbNama);
            Controls.Add(label1);
            Name = "FormDataBaru";
            Text = "FormDataBaru";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbNama;
        private Label label2;
        private Label label3;
        private TextBox tbLuas;
        private Button btnSimpan;
        private Button btnBatal;
    }
}