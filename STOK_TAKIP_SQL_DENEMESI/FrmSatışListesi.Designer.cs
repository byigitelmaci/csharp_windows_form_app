namespace STOK_TAKIP_SQL_DENEMESI
{
    partial class FrmSatışListesi
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chtarih = new System.Windows.Forms.CheckBox();
            this.dpBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.dpBaslamaTarihi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbsEşit = new System.Windows.Forms.RadioButton();
            this.rbsKüçük = new System.Windows.Forms.RadioButton();
            this.rbsBüyük = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEşit = new System.Windows.Forms.RadioButton();
            this.rbKüçük = new System.Windows.Forms.RadioButton();
            this.rbBüyük = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtsatışmiktarı = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUrunfiyatı = new System.Windows.Forms.TextBox();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUrunAdı = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMüşteriAdı = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1114, 251);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnKapat);
            this.panel2.Controls.Add(this.btnSil);
            this.panel2.Controls.Add(this.btnGüncelle);
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 480);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 136);
            this.panel2.TabIndex = 4;
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(662, 30);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(170, 76);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Location = new System.Drawing.Point(474, 30);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(170, 76);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(287, 30);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(170, 76);
            this.btnGüncelle.TabIndex = 13;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(99, 30);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(170, 76);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chtarih);
            this.panel1.Controls.Add(this.dpBitisTarihi);
            this.panel1.Controls.Add(this.dpBaslamaTarihi);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnAra);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtsatışmiktarı);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUrunfiyatı);
            this.panel1.Controls.Add(this.cmbKategori);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUrunAdı);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMüşteriAdı);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 229);
            this.panel1.TabIndex = 3;
            // 
            // chtarih
            // 
            this.chtarih.AutoSize = true;
            this.chtarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chtarih.Location = new System.Drawing.Point(777, 193);
            this.chtarih.Name = "chtarih";
            this.chtarih.Size = new System.Drawing.Size(69, 24);
            this.chtarih.TabIndex = 43;
            this.chtarih.Text = "Tarih";
            this.chtarih.UseVisualStyleBackColor = false;
            // 
            // dpBitisTarihi
            // 
            this.dpBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBitisTarihi.Location = new System.Drawing.Point(509, 185);
            this.dpBitisTarihi.Name = "dpBitisTarihi";
            this.dpBitisTarihi.Size = new System.Drawing.Size(222, 24);
            this.dpBitisTarihi.TabIndex = 42;
            // 
            // dpBaslamaTarihi
            // 
            this.dpBaslamaTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpBaslamaTarihi.Location = new System.Drawing.Point(184, 187);
            this.dpBaslamaTarihi.Name = "dpBaslamaTarihi";
            this.dpBaslamaTarihi.Size = new System.Drawing.Size(218, 24);
            this.dpBaslamaTarihi.TabIndex = 41;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(442, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 31);
            this.label8.TabIndex = 40;
            this.label8.Text = "ile";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(21, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 31);
            this.label7.TabIndex = 39;
            this.label7.Text = "Satış Tarihi";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(965, 124);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(128, 49);
            this.btnTemizle.TabIndex = 37;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Location = new System.Drawing.Point(777, 124);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(128, 49);
            this.btnAra.TabIndex = 36;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbsEşit);
            this.groupBox2.Controls.Add(this.rbsKüçük);
            this.groupBox2.Controls.Add(this.rbsBüyük);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(798, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(295, 51);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            // 
            // rbsEşit
            // 
            this.rbsEşit.AutoSize = true;
            this.rbsEşit.Location = new System.Drawing.Point(210, 17);
            this.rbsEşit.Name = "rbsEşit";
            this.rbsEşit.Size = new System.Drawing.Size(59, 24);
            this.rbsEşit.TabIndex = 2;
            this.rbsEşit.TabStop = true;
            this.rbsEşit.Text = "Eşit";
            this.rbsEşit.UseVisualStyleBackColor = true;
            // 
            // rbsKüçük
            // 
            this.rbsKüçük.AutoSize = true;
            this.rbsKüçük.Location = new System.Drawing.Point(110, 17);
            this.rbsKüçük.Name = "rbsKüçük";
            this.rbsKüçük.Size = new System.Drawing.Size(76, 24);
            this.rbsKüçük.TabIndex = 1;
            this.rbsKüçük.TabStop = true;
            this.rbsKüçük.Text = "Küçük";
            this.rbsKüçük.UseVisualStyleBackColor = true;
            // 
            // rbsBüyük
            // 
            this.rbsBüyük.AutoSize = true;
            this.rbsBüyük.Location = new System.Drawing.Point(19, 15);
            this.rbsBüyük.Name = "rbsBüyük";
            this.rbsBüyük.Size = new System.Drawing.Size(76, 24);
            this.rbsBüyük.TabIndex = 0;
            this.rbsBüyük.TabStop = true;
            this.rbsBüyük.Text = "Büyük";
            this.rbsBüyük.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEşit);
            this.groupBox1.Controls.Add(this.rbKüçük);
            this.groupBox1.Controls.Add(this.rbBüyük);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(798, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 51);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // rbEşit
            // 
            this.rbEşit.AutoSize = true;
            this.rbEşit.Location = new System.Drawing.Point(210, 17);
            this.rbEşit.Name = "rbEşit";
            this.rbEşit.Size = new System.Drawing.Size(59, 24);
            this.rbEşit.TabIndex = 2;
            this.rbEşit.TabStop = true;
            this.rbEşit.Text = "Eşit";
            this.rbEşit.UseVisualStyleBackColor = true;
            // 
            // rbKüçük
            // 
            this.rbKüçük.AutoSize = true;
            this.rbKüçük.Location = new System.Drawing.Point(110, 17);
            this.rbKüçük.Name = "rbKüçük";
            this.rbKüçük.Size = new System.Drawing.Size(76, 24);
            this.rbKüçük.TabIndex = 1;
            this.rbKüçük.TabStop = true;
            this.rbKüçük.Text = "Küçük";
            this.rbKüçük.UseVisualStyleBackColor = true;
            // 
            // rbBüyük
            // 
            this.rbBüyük.AutoSize = true;
            this.rbBüyük.Location = new System.Drawing.Point(19, 15);
            this.rbBüyük.Name = "rbBüyük";
            this.rbBüyük.Size = new System.Drawing.Size(76, 24);
            this.rbBüyük.TabIndex = 0;
            this.rbBüyük.TabStop = true;
            this.rbBüyük.Text = "Büyük";
            this.rbBüyük.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(413, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 31);
            this.label4.TabIndex = 33;
            this.label4.Text = "satış miktarı";
            // 
            // txtsatışmiktarı
            // 
            this.txtsatışmiktarı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsatışmiktarı.Location = new System.Drawing.Point(586, 76);
            this.txtsatışmiktarı.Name = "txtsatışmiktarı";
            this.txtsatışmiktarı.Size = new System.Drawing.Size(193, 30);
            this.txtsatışmiktarı.TabIndex = 32;
            this.txtsatışmiktarı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtsatışmiktarı_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(413, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 31;
            this.label3.Text = "Ürün Fiyatı";
            // 
            // txtUrunfiyatı
            // 
            this.txtUrunfiyatı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunfiyatı.Location = new System.Drawing.Point(586, 30);
            this.txtUrunfiyatı.Name = "txtUrunfiyatı";
            this.txtUrunfiyatı.Size = new System.Drawing.Size(193, 30);
            this.txtUrunfiyatı.TabIndex = 30;
            this.txtUrunfiyatı.TextChanged += new System.EventHandler(this.txtUrunfiyatı_TextChanged);
            this.txtUrunfiyatı.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUrunfiyatı_KeyPress);
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(194, 124);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(193, 28);
            this.cmbKategori.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 31);
            this.label2.TabIndex = 28;
            this.label2.Text = "Kategori";
            // 
            // txtUrunAdı
            // 
            this.txtUrunAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdı.Location = new System.Drawing.Point(194, 74);
            this.txtUrunAdı.Name = "txtUrunAdı";
            this.txtUrunAdı.Size = new System.Drawing.Size(193, 30);
            this.txtUrunAdı.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(21, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 31);
            this.label5.TabIndex = 26;
            this.label5.Text = "Ürün Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Müşteri Adı";
            // 
            // txtMüşteriAdı
            // 
            this.txtMüşteriAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMüşteriAdı.Location = new System.Drawing.Point(191, 25);
            this.txtMüşteriAdı.Name = "txtMüşteriAdı";
            this.txtMüşteriAdı.Size = new System.Drawing.Size(193, 30);
            this.txtMüşteriAdı.TabIndex = 24;
            // 
            // FrmSatışListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 616);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSatışListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSatışListesi";
            this.Load += new System.EventHandler(this.FrmSatışListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chtarih;
        private System.Windows.Forms.DateTimePicker dpBitisTarihi;
        private System.Windows.Forms.DateTimePicker dpBaslamaTarihi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbsEşit;
        private System.Windows.Forms.RadioButton rbsKüçük;
        private System.Windows.Forms.RadioButton rbsBüyük;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEşit;
        private System.Windows.Forms.RadioButton rbKüçük;
        private System.Windows.Forms.RadioButton rbBüyük;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtsatışmiktarı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUrunfiyatı;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUrunAdı;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMüşteriAdı;
    }
}