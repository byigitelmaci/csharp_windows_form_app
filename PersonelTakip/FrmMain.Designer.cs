namespace PersonelTakip
{
    partial class FrmMain
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
            this.btncıkıs = new System.Windows.Forms.Button();
            this.btnoturumukapat = new System.Windows.Forms.Button();
            this.btnpozisyon = new System.Windows.Forms.Button();
            this.btndepartman = new System.Windows.Forms.Button();
            this.btnizin = new System.Windows.Forms.Button();
            this.btnmaas = new System.Windows.Forms.Button();
            this.btnisler = new System.Windows.Forms.Button();
            this.btnPersonel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btncıkıs
            // 
            this.btncıkıs.BackColor = System.Drawing.Color.Red;
            this.btncıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncıkıs.Location = new System.Drawing.Point(437, 335);
            this.btncıkıs.Name = "btncıkıs";
            this.btncıkıs.Size = new System.Drawing.Size(208, 124);
            this.btncıkıs.TabIndex = 15;
            this.btncıkıs.Text = "Çıkış";
            this.btncıkıs.UseVisualStyleBackColor = false;
            this.btncıkıs.Click += new System.EventHandler(this.btncıkıs_Click);
            // 
            // btnoturumukapat
            // 
            this.btnoturumukapat.BackColor = System.Drawing.Color.SteelBlue;
            this.btnoturumukapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnoturumukapat.Location = new System.Drawing.Point(176, 335);
            this.btnoturumukapat.Name = "btnoturumukapat";
            this.btnoturumukapat.Size = new System.Drawing.Size(208, 124);
            this.btnoturumukapat.TabIndex = 14;
            this.btnoturumukapat.Text = "Oturumu Kapat";
            this.btnoturumukapat.UseVisualStyleBackColor = false;
            this.btnoturumukapat.Click += new System.EventHandler(this.btnoturumukapat_Click);
            // 
            // btnpozisyon
            // 
            this.btnpozisyon.BackColor = System.Drawing.Color.Cyan;
            this.btnpozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnpozisyon.Location = new System.Drawing.Point(532, 195);
            this.btnpozisyon.Name = "btnpozisyon";
            this.btnpozisyon.Size = new System.Drawing.Size(208, 124);
            this.btnpozisyon.TabIndex = 13;
            this.btnpozisyon.Text = "Pozisyon İşlemleri";
            this.btnpozisyon.UseVisualStyleBackColor = false;
            this.btnpozisyon.Click += new System.EventHandler(this.btnpozisyon_Click);
            // 
            // btndepartman
            // 
            this.btndepartman.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btndepartman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btndepartman.Location = new System.Drawing.Point(308, 195);
            this.btndepartman.Name = "btndepartman";
            this.btndepartman.Size = new System.Drawing.Size(208, 124);
            this.btndepartman.TabIndex = 12;
            this.btndepartman.Text = "Departman İşlemleri";
            this.btndepartman.UseVisualStyleBackColor = false;
            this.btndepartman.Click += new System.EventHandler(this.btndepartman_Click);
            // 
            // btnizin
            // 
            this.btnizin.BackColor = System.Drawing.Color.Blue;
            this.btnizin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnizin.Location = new System.Drawing.Point(76, 195);
            this.btnizin.Name = "btnizin";
            this.btnizin.Size = new System.Drawing.Size(208, 124);
            this.btnizin.TabIndex = 11;
            this.btnizin.Text = "İzin İşlemleri";
            this.btnizin.UseVisualStyleBackColor = false;
            this.btnizin.Click += new System.EventHandler(this.btnizin_Click);
            // 
            // btnmaas
            // 
            this.btnmaas.BackColor = System.Drawing.Color.Purple;
            this.btnmaas.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmaas.Location = new System.Drawing.Point(532, 36);
            this.btnmaas.Name = "btnmaas";
            this.btnmaas.Size = new System.Drawing.Size(208, 124);
            this.btnmaas.TabIndex = 10;
            this.btnmaas.Text = "Maaş";
            this.btnmaas.UseVisualStyleBackColor = false;
            this.btnmaas.Click += new System.EventHandler(this.btnmaas_Click);
            // 
            // btnisler
            // 
            this.btnisler.BackColor = System.Drawing.Color.Yellow;
            this.btnisler.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnisler.Location = new System.Drawing.Point(308, 36);
            this.btnisler.Name = "btnisler";
            this.btnisler.Size = new System.Drawing.Size(208, 124);
            this.btnisler.TabIndex = 9;
            this.btnisler.Text = "lşler";
            this.btnisler.UseVisualStyleBackColor = false;
            this.btnisler.Click += new System.EventHandler(this.btnisler_Click);
            // 
            // btnPersonel
            // 
            this.btnPersonel.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPersonel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPersonel.Location = new System.Drawing.Point(76, 36);
            this.btnPersonel.Name = "btnPersonel";
            this.btnPersonel.Size = new System.Drawing.Size(208, 124);
            this.btnPersonel.TabIndex = 8;
            this.btnPersonel.Text = "Personel İşlemleri";
            this.btnPersonel.UseVisualStyleBackColor = false;
            this.btnPersonel.Click += new System.EventHandler(this.btnPersonel_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(822, 521);
            this.Controls.Add(this.btncıkıs);
            this.Controls.Add(this.btnoturumukapat);
            this.Controls.Add(this.btnpozisyon);
            this.Controls.Add(this.btndepartman);
            this.Controls.Add(this.btnizin);
            this.Controls.Add(this.btnmaas);
            this.Controls.Add(this.btnisler);
            this.Controls.Add(this.btnPersonel);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Takip";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btncıkıs;
        private System.Windows.Forms.Button btnoturumukapat;
        private System.Windows.Forms.Button btnpozisyon;
        private System.Windows.Forms.Button btndepartman;
        private System.Windows.Forms.Button btnizin;
        private System.Windows.Forms.Button btnmaas;
        private System.Windows.Forms.Button btnisler;
        private System.Windows.Forms.Button btnPersonel;
    }
}