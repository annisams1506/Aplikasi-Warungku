namespace WarungKu
{
    partial class FormPenjualan
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
            this.cbfilter = new System.Windows.Forms.ComboBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnfilter = new System.Windows.Forms.Button();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewPemesanan = new System.Windows.Forms.DataGridView();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnexport = new System.Windows.Forms.Button();
            this.btntambahbarang = new System.Windows.Forms.Button();
            this.txtjml = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtidbarang = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtnamabarang = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btntambah = new System.Windows.Forms.Button();
            this.dataGridViewpenjualan = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.labeltotal = new System.Windows.Forms.Label();
            this.labelgrandtotal = new System.Windows.Forms.Label();
            this.labelidpenjualan = new System.Windows.Forms.Label();
            this.labeldate = new System.Windows.Forms.Label();
            this.dataGridViewfilter = new System.Windows.Forms.DataGridView();
            this.labelkasir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPemesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpenjualan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfilter)).BeginInit();
            this.SuspendLayout();
            // 
            // cbfilter
            // 
            this.cbfilter.BackColor = System.Drawing.Color.Black;
            this.cbfilter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbfilter.ForeColor = System.Drawing.Color.White;
            this.cbfilter.FormattingEnabled = true;
            this.cbfilter.Location = new System.Drawing.Point(21, 486);
            this.cbfilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbfilter.Name = "cbfilter";
            this.cbfilter.Size = new System.Drawing.Size(218, 28);
            this.cbfilter.TabIndex = 28;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclear.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(393, 482);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(126, 37);
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
            this.btnfilter.Location = new System.Drawing.Point(250, 483);
            this.btnfilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(126, 37);
            this.btnfilter.TabIndex = 25;
            this.btnfilter.Text = "Filter";
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // txtharga
            // 
            this.txtharga.BackColor = System.Drawing.Color.Black;
            this.txtharga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtharga.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtharga.ForeColor = System.Drawing.Color.White;
            this.txtharga.Location = new System.Drawing.Point(278, 277);
            this.txtharga.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtharga.Multiline = true;
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(242, 38);
            this.txtharga.TabIndex = 23;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox4.Location = new System.Drawing.Point(267, 309);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(252, 29);
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
            this.label5.Location = new System.Drawing.Point(32, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 36);
            this.label5.TabIndex = 21;
            this.label5.Text = "Harga";
            // 
            // dataGridViewPemesanan
            // 
            this.dataGridViewPemesanan.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPemesanan.Location = new System.Drawing.Point(622, 74);
            this.dataGridViewPemesanan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewPemesanan.Name = "dataGridViewPemesanan";
            this.dataGridViewPemesanan.Size = new System.Drawing.Size(1030, 252);
            this.dataGridViewPemesanan.TabIndex = 13;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.White;
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(64)))));
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Black;
            this.btncancel.Location = new System.Drawing.Point(1492, 762);
            this.btncancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(160, 49);
            this.btncancel.TabIndex = 20;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnexport
            // 
            this.btnexport.BackColor = System.Drawing.Color.White;
            this.btnexport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(64)))));
            this.btnexport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexport.ForeColor = System.Drawing.Color.Black;
            this.btnexport.Location = new System.Drawing.Point(1323, 762);
            this.btnexport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexport.Name = "btnexport";
            this.btnexport.Size = new System.Drawing.Size(160, 49);
            this.btnexport.TabIndex = 19;
            this.btnexport.Text = "Export";
            this.btnexport.UseVisualStyleBackColor = false;
            this.btnexport.Click += new System.EventHandler(this.btnexport_Click);
            // 
            // btntambahbarang
            // 
            this.btntambahbarang.BackColor = System.Drawing.Color.White;
            this.btntambahbarang.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(64)))));
            this.btntambahbarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntambahbarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambahbarang.ForeColor = System.Drawing.Color.Black;
            this.btntambahbarang.Location = new System.Drawing.Point(267, 431);
            this.btntambahbarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntambahbarang.Name = "btntambahbarang";
            this.btntambahbarang.Size = new System.Drawing.Size(252, 43);
            this.btntambahbarang.TabIndex = 18;
            this.btntambahbarang.Text = "Tambah Barang";
            this.btntambahbarang.UseVisualStyleBackColor = false;
            this.btntambahbarang.Click += new System.EventHandler(this.btntambahbarang_Click);
            // 
            // txtjml
            // 
            this.txtjml.BackColor = System.Drawing.Color.Black;
            this.txtjml.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtjml.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjml.ForeColor = System.Drawing.Color.White;
            this.txtjml.Location = new System.Drawing.Point(278, 360);
            this.txtjml.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtjml.Multiline = true;
            this.txtjml.Name = "txtjml";
            this.txtjml.Size = new System.Drawing.Size(242, 38);
            this.txtjml.TabIndex = 17;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox3.Location = new System.Drawing.Point(267, 392);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(252, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // txtidbarang
            // 
            this.txtidbarang.BackColor = System.Drawing.Color.Black;
            this.txtidbarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtidbarang.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidbarang.ForeColor = System.Drawing.Color.White;
            this.txtidbarang.Location = new System.Drawing.Point(278, 118);
            this.txtidbarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidbarang.Multiline = true;
            this.txtidbarang.Name = "txtidbarang";
            this.txtidbarang.Size = new System.Drawing.Size(242, 38);
            this.txtidbarang.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox1.Location = new System.Drawing.Point(267, 149);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtnamabarang
            // 
            this.txtnamabarang.BackColor = System.Drawing.Color.Black;
            this.txtnamabarang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnamabarang.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnamabarang.ForeColor = System.Drawing.Color.White;
            this.txtnamabarang.Location = new System.Drawing.Point(278, 203);
            this.txtnamabarang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtnamabarang.Multiline = true;
            this.txtnamabarang.Name = "txtnamabarang";
            this.txtnamabarang.Size = new System.Drawing.Size(242, 38);
            this.txtnamabarang.TabIndex = 13;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WarungKu.Properties.Resources.underline_label;
            this.pictureBox2.Location = new System.Drawing.Point(267, 234);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(252, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 375);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 36);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jumlah";
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
            this.label2.Size = new System.Drawing.Size(157, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID Barang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(777, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Penjualan";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnexit.FlatAppearance.BorderSize = 2;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(1704, 9);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(57, 54);
            this.btnexit.TabIndex = 21;
            this.btnexit.Text = "X";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama Barang";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btntambah);
            this.panel1.Controls.Add(this.dataGridViewpenjualan);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.labeltotal);
            this.panel1.Controls.Add(this.labelgrandtotal);
            this.panel1.Controls.Add(this.labelidpenjualan);
            this.panel1.Controls.Add(this.labeldate);
            this.panel1.Controls.Add(this.dataGridViewfilter);
            this.panel1.Controls.Add(this.labelkasir);
            this.panel1.Controls.Add(this.cbfilter);
            this.panel1.Controls.Add(this.btnclear);
            this.panel1.Controls.Add(this.btnfilter);
            this.panel1.Controls.Add(this.txtharga);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dataGridViewPemesanan);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnexport);
            this.panel1.Controls.Add(this.btntambahbarang);
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
            this.panel1.Location = new System.Drawing.Point(18, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1750, 815);
            this.panel1.TabIndex = 20;
            // 
            // btntambah
            // 
            this.btntambah.BackColor = System.Drawing.Color.White;
            this.btntambah.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(176)))), ((int)(((byte)(64)))));
            this.btntambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntambah.ForeColor = System.Drawing.Color.Black;
            this.btntambah.Location = new System.Drawing.Point(1154, 762);
            this.btntambah.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntambah.Name = "btntambah";
            this.btntambah.Size = new System.Drawing.Size(160, 49);
            this.btntambah.TabIndex = 37;
            this.btntambah.Text = "Tambah";
            this.btntambah.UseVisualStyleBackColor = false;
            this.btntambah.Click += new System.EventHandler(this.btntambah_Click);
            // 
            // dataGridViewpenjualan
            // 
            this.dataGridViewpenjualan.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewpenjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewpenjualan.Location = new System.Drawing.Point(622, 478);
            this.dataGridViewpenjualan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewpenjualan.Name = "dataGridViewpenjualan";
            this.dataGridViewpenjualan.Size = new System.Drawing.Size(1092, 271);
            this.dataGridViewpenjualan.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1006, 431);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(272, 38);
            this.label11.TabIndex = 35;
            this.label11.Text = "Daftar Penjualan";
            // 
            // labeltotal
            // 
            this.labeltotal.AutoSize = true;
            this.labeltotal.BackColor = System.Drawing.Color.Black;
            this.labeltotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotal.ForeColor = System.Drawing.Color.White;
            this.labeltotal.Location = new System.Drawing.Point(1314, 326);
            this.labeltotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltotal.Name = "labeltotal";
            this.labeltotal.Size = new System.Drawing.Size(53, 36);
            this.labeltotal.TabIndex = 34;
            this.labeltotal.Text = "Rp";
            // 
            // labelgrandtotal
            // 
            this.labelgrandtotal.AutoSize = true;
            this.labelgrandtotal.BackColor = System.Drawing.Color.Black;
            this.labelgrandtotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelgrandtotal.ForeColor = System.Drawing.Color.White;
            this.labelgrandtotal.Location = new System.Drawing.Point(1126, 326);
            this.labelgrandtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelgrandtotal.Name = "labelgrandtotal";
            this.labelgrandtotal.Size = new System.Drawing.Size(183, 36);
            this.labelgrandtotal.TabIndex = 33;
            this.labelgrandtotal.Text = "Grand Total";
            // 
            // labelidpenjualan
            // 
            this.labelidpenjualan.AutoSize = true;
            this.labelidpenjualan.BackColor = System.Drawing.Color.Black;
            this.labelidpenjualan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelidpenjualan.ForeColor = System.Drawing.Color.White;
            this.labelidpenjualan.Location = new System.Drawing.Point(816, 326);
            this.labelidpenjualan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelidpenjualan.Name = "labelidpenjualan";
            this.labelidpenjualan.Size = new System.Drawing.Size(194, 36);
            this.labelidpenjualan.TabIndex = 32;
            this.labelidpenjualan.Text = "Id Penjualan";
            // 
            // labeldate
            // 
            this.labeldate.AutoSize = true;
            this.labeldate.BackColor = System.Drawing.Color.Black;
            this.labeldate.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldate.ForeColor = System.Drawing.Color.White;
            this.labeldate.Location = new System.Drawing.Point(1506, 20);
            this.labeldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldate.Name = "labeldate";
            this.labeldate.Size = new System.Drawing.Size(86, 36);
            this.labeldate.TabIndex = 31;
            this.labeldate.Text = "Date";
            // 
            // dataGridViewfilter
            // 
            this.dataGridViewfilter.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewfilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfilter.Location = new System.Drawing.Point(21, 528);
            this.dataGridViewfilter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewfilter.Name = "dataGridViewfilter";
            this.dataGridViewfilter.Size = new System.Drawing.Size(498, 238);
            this.dataGridViewfilter.TabIndex = 30;
            this.dataGridViewfilter.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pilihData);
            // 
            // labelkasir
            // 
            this.labelkasir.AutoSize = true;
            this.labelkasir.BackColor = System.Drawing.Color.Black;
            this.labelkasir.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelkasir.ForeColor = System.Drawing.Color.White;
            this.labelkasir.Location = new System.Drawing.Point(114, 15);
            this.labelkasir.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelkasir.Name = "labelkasir";
            this.labelkasir.Size = new System.Drawing.Size(90, 38);
            this.labelkasir.TabIndex = 29;
            this.labelkasir.Text = "Kasir";
            // 
            // FormPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 923);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPenjualan";
            this.Load += new System.EventHandler(this.FormPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPemesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewpenjualan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfilter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbfilter;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewPemesanan;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnexport;
        private System.Windows.Forms.Button btntambahbarang;
        private System.Windows.Forms.TextBox txtjml;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtidbarang;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtnamabarang;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btntambah;
        private System.Windows.Forms.DataGridView dataGridViewpenjualan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labeltotal;
        private System.Windows.Forms.Label labelgrandtotal;
        private System.Windows.Forms.Label labelidpenjualan;
        private System.Windows.Forms.Label labeldate;
        private System.Windows.Forms.DataGridView dataGridViewfilter;
        private System.Windows.Forms.Label labelkasir;
    }
}