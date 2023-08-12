namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_btn = new System.Windows.Forms.Button();
            this.tpl_sayi1 = new System.Windows.Forms.TextBox();
            this.tpl_sayi2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bolme_btn = new System.Windows.Forms.Button();
            this.carpma_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(40, 169);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(127, 54);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "Toplama";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // tpl_sayi1
            // 
            this.tpl_sayi1.Location = new System.Drawing.Point(100, 64);
            this.tpl_sayi1.Name = "tpl_sayi1";
            this.tpl_sayi1.Size = new System.Drawing.Size(156, 22);
            this.tpl_sayi1.TabIndex = 1;
            // 
            // tpl_sayi2
            // 
            this.tpl_sayi2.Location = new System.Drawing.Point(100, 96);
            this.tpl_sayi2.Name = "tpl_sayi2";
            this.tpl_sayi2.Size = new System.Drawing.Size(156, 22);
            this.tpl_sayi2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sayı 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sayı 2";
            // 
            // bolme_btn
            // 
            this.bolme_btn.Location = new System.Drawing.Point(207, 169);
            this.bolme_btn.Name = "bolme_btn";
            this.bolme_btn.Size = new System.Drawing.Size(127, 54);
            this.bolme_btn.TabIndex = 5;
            this.bolme_btn.Text = "Çıkarma";
            this.bolme_btn.UseVisualStyleBackColor = true;
            this.bolme_btn.Click += new System.EventHandler(this.bolme_btn_Click);
            // 
            // carpma_btn
            // 
            this.carpma_btn.Location = new System.Drawing.Point(129, 229);
            this.carpma_btn.Name = "carpma_btn";
            this.carpma_btn.Size = new System.Drawing.Size(127, 54);
            this.carpma_btn.TabIndex = 7;
            this.carpma_btn.Text = "Çarpma";
            this.carpma_btn.UseVisualStyleBackColor = true;
            this.carpma_btn.Click += new System.EventHandler(this.carpma_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 345);
            this.Controls.Add(this.carpma_btn);
            this.Controls.Add(this.bolme_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tpl_sayi2);
            this.Controls.Add(this.tpl_sayi1);
            this.Controls.Add(this.login_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.TextBox tpl_sayi1;
        private System.Windows.Forms.TextBox tpl_sayi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bolme_btn;
        private System.Windows.Forms.Button carpma_btn;
    }
}

