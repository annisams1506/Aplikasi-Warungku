namespace WarungKu
{
    partial class FormBarang
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
            this.btnexit = new System.Windows.Forms.Button();
            this.dataGridViewBarang = new System.Windows.Forms.DataGridView();
            this.btnhapus = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtjml = new System.Windows.Forms.TextBox();
            this.txtidbarang = new System.Windows.Forms.TextBox();
            this.txtnamabarang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbfilter = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.cbkategori = new System.Windows.Forms.ComboBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnkasir = new System.Windows.Forms.Button();
            this.btnkategori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnexit.FlatAppearance.BorderSize = 2;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(1136, 6);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(38, 35);
            this.btnexit.TabIndex = 17;
            this.btnexit.Text = "X";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // dataGridViewBarang
            // 
            this.dataGridViewBarang.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBarang.Location = new System.Drawing.Point(405, 97);
            this.dataGridViewBarang.Name = "dataGridViewBarang";
            this.dataGridViewBarang.Size = new System.Drawing.Size(604, 401);
            this.dataGridViewBarang.TabIndex = 13;
            this.dataGridViewBarang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pilihData);
            // 
            // btnhapus
            // 
            this.btnhapus.BackColor = System.Drawing.Color.White;
            this.btnhapus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(64)))));
            this.btnhapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhapus.ForeColor = System.Drawing.Color.Black;
            this.btnhapus.Location = new System.Drawing.Point(239, 425);
            this.btnhapus.Name = "btnhapus";
            this.btnhapus.Size = new System.Drawing.Size(107, 32);
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
            this.btnedit.Location = new System.Drawing.Point(126, 425);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(107, 32);
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
            this.btnlogin.Location = new System.Drawing.Point(13, 425);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(107, 32);
            this.btnlogin.TabIndex = 18;
            this.btnlogin.Text = "Tambah";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtjml
            // 
            this.txtjml.BackColor = System.Drawing.Color.Black;
            this.txtjml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtjml.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjml.ForeColor = System.Drawing.Color.White;
            this.txtjml.Location = new System.Drawing.Point(185, 208);
            this.txtjml.Multiline = true;
            this.txtjml.Name = "txtjml";
            this.txtjml.Size = new System.Drawing.Size(161, 25);
            this.txtjml.TabIndex = 17;
            // 
            // txtidbarang
            // 
            this.txtidbarang.BackColor = System.Drawing.Color.Black;
            this.txtidbarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidbarang.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidbarang.ForeColor = System.Drawing.Color.White;
            this.txtidbarang.Location = new System.Drawing.Point(185, 77);
            this.txtidbarang.Multiline = true;
            this.txtidbarang.Name = "txtidbarang";
            this.txtidbarang.Size = new System.Drawing.Size(161, 25);
            this.txtidbarang.TabIndex = 15;
            // 
            // txtnamabarang
            // 
            this.txtnamabarang.BackColor = System.Drawing.Color.Black;
            this.txtnamabarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnamabarang.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamabarang.ForeColor = System.Drawing.Color.White;
            this.txtnamabarang.Location = new System.Drawing.Point(185, 140);
            this.txtnamabarang.Multiline = true;
            this.txtnamabarang.Name = "txtnamabarang";
            this.txtnamabarang.Size = new System.Drawing.Size(161, 25);
            this.txtnamabarang.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jumlah";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(424, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelola Barang";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.cbfilter);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Controls.Add(this.cbkategori);
            this.panel1.Controls.Add(this.txtharga);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridViewBarang);
            this.panel1.Controls.Add(this.btnhapus);
            this.panel1.Controls.Add(this.btnedit);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.txtjml);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.txtidbarang);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtnamabarang);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(139, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1040, 530);
            this.panel1.TabIndex = 16;
            // 
            // cbfilter
            // 
            this.cbfilter.BackColor = System.Drawing.Color.Black;
            this.cbfilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbfilter.ForeColor = System.Drawing.Color.White;
            this.cbfilter.FormattingEnabled = true;
            this.cbfilter.Location = new System.Drawing.Point(618, 70);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(168, 21);
            this.cbfilter.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 22);
            this.label6.TabIndex = 27;
            this.label6.Text = "Kategori";
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(882, 67);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(84, 24);
            this.btnclear.TabIndex = 26;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.Color.White;
            this.btnfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnfilter.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfilter.Location = new System.Drawing.Point(792, 67);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(84, 24);
            this.btnfilter.TabIndex = 25;
            this.btnfilter.Text = "Filter";
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // cbkategori
            // 
            this.cbkategori.BackColor = System.Drawing.Color.Black;
            this.cbkategori.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbkategori.ForeColor = System.Drawing.Color.White;
            this.cbkategori.FormattingEnabled = true;
            this.cbkategori.Location = new System.Drawing.Point(178, 342);
            this.cbkategori.Name = "cbkategori";
            this.cbkategori.Size = new System.Drawing.Size(168, 21);
            this.cbkategori.TabIndex = 24;
            // 
            // txtharga
            // 
            this.txtharga.BackColor = System.Drawing.Color.Black;
            this.txtharga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtharga.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtharga.ForeColor = System.Drawing.Color.White;
            this.txtharga.Location = new System.Drawing.Point(185, 275);
            this.txtharga.Multiline = true;
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(161, 25);
            this.txtharga.TabIndex = 23;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox4.Location = new System.Drawing.Point(178, 296);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(168, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 21;
            this.label5.Text = "Harga";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox3.Location = new System.Drawing.Point(178, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(168, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox1.Location = new System.Drawing.Point(178, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox2.Location = new System.Drawing.Point(178, 160);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(168, 19);
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
            this.label4.Location = new System.Drawing.Point(21, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama Barang";
            // 
            // btnkasir
            // 
            this.btnkasir.BackColor = System.Drawing.Color.Transparent;
            this.btnkasir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnkasir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkasir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkasir.ForeColor = System.Drawing.Color.Black;
            this.btnkasir.Location = new System.Drawing.Point(18, 86);
            this.btnkasir.Name = "btnkasir";
            this.btnkasir.Size = new System.Drawing.Size(119, 42);
            this.btnkasir.TabIndex = 15;
            this.btnkasir.Text = "Kasir";
            this.btnkasir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkasir.UseVisualStyleBackColor = false;
            this.btnkasir.Click += new System.EventHandler(this.btnkasir_Click);
            // 
            // btnkategori
            // 
            this.btnkategori.BackColor = System.Drawing.Color.Transparent;
            this.btnkategori.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnkategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkategori.ForeColor = System.Drawing.Color.Black;
            this.btnkategori.Location = new System.Drawing.Point(18, 134);
            this.btnkategori.Name = "btnkategori";
            this.btnkategori.Size = new System.Drawing.Size(119, 42);
            this.btnkategori.TabIndex = 14;
            this.btnkategori.Text = "Kategori";
            this.btnkategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkategori.UseVisualStyleBackColor = false;
            this.btnkategori.Click += new System.EventHandler(this.btnkategori_Click);
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnkasir);
            this.Controls.Add(this.btnkategori);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBarang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBarang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView dataGridViewBarang;
        private System.Windows.Forms.Button btnhapus;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtjml;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtidbarang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnamabarang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnkasir;
        private System.Windows.Forms.Button btnkategori;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbfilter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.ComboBox cbkategori;
    }
}