namespace WarungKu
{
    partial class FormKategori
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
            this.btnbarang = new System.Windows.Forms.Button();
            this.btnkasir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewKategori = new System.Windows.Forms.DataGridView();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtdeskripsi = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtidkategori = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtnamakategori = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnbarang
            // 
            this.btnbarang.BackColor = System.Drawing.Color.Transparent;
            this.btnbarang.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnbarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbarang.ForeColor = System.Drawing.Color.Black;
            this.btnbarang.Location = new System.Drawing.Point(18, 108);
            this.btnbarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnbarang.Name = "btnbarang";
            this.btnbarang.Size = new System.Drawing.Size(178, 65);
            this.btnbarang.TabIndex = 9;
            this.btnbarang.Text = "Barang";
            this.btnbarang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbarang.UseVisualStyleBackColor = false;
            this.btnbarang.Click += new System.EventHandler(this.btnbarang_Click);
            // 
            // btnkasir
            // 
            this.btnkasir.BackColor = System.Drawing.Color.Transparent;
            this.btnkasir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnkasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkasir.ForeColor = System.Drawing.Color.Black;
            this.btnkasir.Location = new System.Drawing.Point(18, 182);
            this.btnkasir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnkasir.Name = "btnkasir";
            this.btnkasir.Size = new System.Drawing.Size(178, 65);
            this.btnkasir.TabIndex = 10;
            this.btnkasir.Text = "Kasir";
            this.btnkasir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkasir.UseVisualStyleBackColor = false;
            this.btnkasir.Click += new System.EventHandler(this.btnkasir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.dataGridViewKategori);
            this.panel1.Controls.Add(this.btnhapus);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.txtdeskripsi);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.txtidkategori);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtnamakategori);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(208, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1560, 815);
            this.panel1.TabIndex = 12;
            // 
            // dataGridViewKategori
            // 
            this.dataGridViewKategori.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewKategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKategori.Location = new System.Drawing.Point(610, 118);
            this.dataGridViewKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewKategori.Name = "dataGridViewKategori";
            this.dataGridViewKategori.Size = new System.Drawing.Size(906, 617);
            this.dataGridViewKategori.TabIndex = 13;
            this.dataGridViewKategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pilihData);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.White;
            this.btnhapus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(64)))));
            this.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.ForeColor = System.Drawing.Color.Black;
            this.btnhapus.Location = new System.Drawing.Point(376, 431);
            this.btnhapus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(160, 49);
            this.btnhapus.TabIndex = 20;
            this.btnhapus.Text = "Hapus";
            this.btnhapus.UseVisualStyleBackColor = false;
            this.btnhapus.Click += new System.EventHandler(this.btnhapus_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.White;
            this.btnedit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(64)))));
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.Black;
            this.btnedit.Location = new System.Drawing.Point(207, 431);
            this.btnedit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(160, 49);
            this.btnedit.TabIndex = 19;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.White;
            this.btnlogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(64)))));
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Black;
            this.btnlogin.Location = new System.Drawing.Point(38, 431);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(160, 49);
            this.btnlogin.TabIndex = 18;
            this.btnlogin.Text = "Tambah";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtdeskripsi
            // 
            this.txtdeskripsi.BackColor = System.Drawing.Color.DarkOrange;
            this.txtdeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdeskripsi.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeskripsi.ForeColor = System.Drawing.Color.White;
            this.txtdeskripsi.Location = new System.Drawing.Point(278, 320);
            this.txtdeskripsi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdeskripsi.Multiline = true;
            this.txtdeskripsi.Name = "txtdeskripsi";
            this.txtdeskripsi.Size = new System.Drawing.Size(242, 38);
            this.txtdeskripsi.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox3.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox3.Location = new System.Drawing.Point(267, 352);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(252, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // txtidkategori
            // 
            this.txtidkategori.BackColor = System.Drawing.Color.DarkOrange;
            this.txtidkategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidkategori.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidkategori.ForeColor = System.Drawing.Color.White;
            this.txtidkategori.Location = new System.Drawing.Point(278, 118);
            this.txtidkategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidkategori.Multiline = true;
            this.txtidkategori.Name = "txtidkategori";
            this.txtidkategori.Size = new System.Drawing.Size(242, 38);
            this.txtidkategori.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox1.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox1.Location = new System.Drawing.Point(267, 149);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtnamakategori
            // 
            this.txtnamakategori.BackColor = System.Drawing.Color.DarkOrange;
            this.txtnamakategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnamakategori.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamakategori.ForeColor = System.Drawing.Color.White;
            this.txtnamakategori.Location = new System.Drawing.Point(278, 215);
            this.txtnamakategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnamakategori.Multiline = true;
            this.txtnamakategori.Name = "txtnamakategori";
            this.txtnamakategori.Size = new System.Drawing.Size(242, 38);
            this.txtnamakategori.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DarkOrange;
            this.pictureBox2.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox2.Location = new System.Drawing.Point(267, 246);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 229);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 335);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Deskripsi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(636, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelola Kategori";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.White;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnexit.FlatAppearance.BorderSize = 2;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(1704, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(57, 54);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "X";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // FormKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1800, 923);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnkasir);
            this.Controls.Add(this.btnbarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKategori";
            this.Load += new System.EventHandler(this.FormKategori_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbarang;
        private System.Windows.Forms.Button btnkasir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtdeskripsi;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtidkategori;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnamakategori;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.DataGridView dataGridViewKategori;
        private System.Windows.Forms.Button btnexit;
    }
}