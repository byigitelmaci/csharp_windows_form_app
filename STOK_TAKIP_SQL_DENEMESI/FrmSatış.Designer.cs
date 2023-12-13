namespace STOK_TAKIP_SQL_DENEMESI
{
    partial class FrmSatış
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
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSatisMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUrunfiyatı = new System.Windows.Forms.TextBox();
            this.txtUrunAdı = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMüşteri = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridMusteriler = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMüşteriAdı = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridUrunler = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriler)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(278, 394);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(170, 86);
            this.btnKapat.TabIndex = 51;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(45, 394);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(170, 86);
            this.btnKaydet.TabIndex = 50;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(11, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 31);
            this.label7.TabIndex = 49;
            this.label7.Text = "Ürün Satış Miktarı";
            // 
            // txtSatisMiktar
            // 
            this.txtSatisMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSatisMiktar.Location = new System.Drawing.Point(255, 305);
            this.txtSatisMiktar.Name = "txtSatisMiktar";
            this.txtSatisMiktar.Size = new System.Drawing.Size(193, 30);
            this.txtSatisMiktar.TabIndex = 48;
            this.txtSatisMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(11, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 31);
            this.label5.TabIndex = 47;
            this.label5.Text = "Ürün Stok";
            // 
            // txtStok
            // 
            this.txtStok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtStok.Location = new System.Drawing.Point(255, 249);
            this.txtStok.Name = "txtStok";
            this.txtStok.ReadOnly = true;
            this.txtStok.Size = new System.Drawing.Size(193, 30);
            this.txtStok.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(11, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 31);
            this.label4.TabIndex = 45;
            this.label4.Text = "Ürün Fiyatı";
            // 
            // txtUrunfiyatı
            // 
            this.txtUrunfiyatı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunfiyatı.Location = new System.Drawing.Point(255, 189);
            this.txtUrunfiyatı.Name = "txtUrunfiyatı";
            this.txtUrunfiyatı.ReadOnly = true;
            this.txtUrunfiyatı.Size = new System.Drawing.Size(193, 30);
            this.txtUrunfiyatı.TabIndex = 44;
            this.txtUrunfiyatı.TextChanged += new System.EventHandler(this.txtUrunfiyatı_TextChanged);
            // 
            // txtUrunAdı
            // 
            this.txtUrunAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrunAdı.Location = new System.Drawing.Point(255, 123);
            this.txtUrunAdı.Name = "txtUrunAdı";
            this.txtUrunAdı.ReadOnly = true;
            this.txtUrunAdı.Size = new System.Drawing.Size(193, 30);
            this.txtUrunAdı.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(11, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 31);
            this.label6.TabIndex = 42;
            this.label6.Text = "Ürün Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(11, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 31);
            this.label3.TabIndex = 41;
            this.label3.Text = "Müşteri Adı";
            // 
            // txtMüşteri
            // 
            this.txtMüşteri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMüşteri.Location = new System.Drawing.Point(255, 53);
            this.txtMüşteri.Name = "txtMüşteri";
            this.txtMüşteri.ReadOnly = true;
            this.txtMüşteri.Size = new System.Drawing.Size(193, 30);
            this.txtMüşteri.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(541, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 640);
            this.panel1.TabIndex = 39;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridMusteriler);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 357);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(426, 283);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Müşteriler";
            // 
            // gridMusteriler
            // 
            this.gridMusteriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMusteriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMusteriler.Location = new System.Drawing.Point(3, 83);
            this.gridMusteriler.Name = "gridMusteriler";
            this.gridMusteriler.ReadOnly = true;
            this.gridMusteriler.RowHeadersWidth = 51;
            this.gridMusteriler.RowTemplate.Height = 24;
            this.gridMusteriler.Size = new System.Drawing.Size(420, 197);
            this.gridMusteriler.TabIndex = 1;
            this.gridMusteriler.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMusteriler_RowEnter);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtMüşteriAdı);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(420, 65);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 31);
            this.label1.TabIndex = 25;
            this.label1.Text = "Müşteri Adı";
            // 
            // txtMüşteriAdı
            // 
            this.txtMüşteriAdı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMüşteriAdı.Location = new System.Drawing.Point(190, 19);
            this.txtMüşteriAdı.Name = "txtMüşteriAdı";
            this.txtMüşteriAdı.Size = new System.Drawing.Size(193, 30);
            this.txtMüşteriAdı.TabIndex = 24;
            this.txtMüşteriAdı.TextChanged += new System.EventHandler(this.txtMüşteriAdı_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridUrunler);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler";
            // 
            // gridUrunler
            // 
            this.gridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.Location = new System.Drawing.Point(3, 81);
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.ReadOnly = true;
            this.gridUrunler.RowHeadersWidth = 51;
            this.gridUrunler.RowTemplate.Height = 24;
            this.gridUrunler.Size = new System.Drawing.Size(420, 273);
            this.gridUrunler.TabIndex = 1;
            this.gridUrunler.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUrunler_RowEnter);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbKategori);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(420, 63);
            this.panel2.TabIndex = 0;
            // 
            // cmbKategori
            // 
            this.cmbKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(190, 17);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(193, 28);
            this.cmbKategori.TabIndex = 16;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Kategori";
            // 
            // FrmSatış
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 640);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSatisMiktar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUrunfiyatı);
            this.Controls.Add(this.txtUrunAdı);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMüşteri);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSatış";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSatış";
            this.Load += new System.EventHandler(this.FrmSatış_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteriler)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSatisMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUrunfiyatı;
        private System.Windows.Forms.TextBox txtUrunAdı;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMüşteri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridMusteriler;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMüşteriAdı;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridUrunler;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.Label label2;
    }
}