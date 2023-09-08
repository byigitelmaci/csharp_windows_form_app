namespace OOP_Constructor_Örnek_ders7
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtısım = new System.Windows.Forms.TextBox();
            this.cmbulke = new System.Windows.Forms.ComboBox();
            this.btnsec = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(91, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "isim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(90, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ulke";
            // 
            // txtısım
            // 
            this.txtısım.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtısım.Location = new System.Drawing.Point(197, 86);
            this.txtısım.Name = "txtısım";
            this.txtısım.Size = new System.Drawing.Size(162, 30);
            this.txtısım.TabIndex = 4;
            // 
            // cmbulke
            // 
            this.cmbulke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbulke.FormattingEnabled = true;
            this.cmbulke.Items.AddRange(new object[] {
            "brezilya",
            "italya",
            "fransa"});
            this.cmbulke.Location = new System.Drawing.Point(197, 146);
            this.cmbulke.Name = "cmbulke";
            this.cmbulke.Size = new System.Drawing.Size(162, 33);
            this.cmbulke.TabIndex = 8;
            // 
            // btnsec
            // 
            this.btnsec.Location = new System.Drawing.Point(464, 76);
            this.btnsec.Name = "btnsec";
            this.btnsec.Size = new System.Drawing.Size(184, 86);
            this.btnsec.TabIndex = 9;
            this.btnsec.Text = "seç";
            this.btnsec.UseVisualStyleBackColor = true;
            this.btnsec.Click += new System.EventHandler(this.btnsec_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 206);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 86);
            this.button1.TabIndex = 10;
            this.button1.Text = "şut at";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(896, 543);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsec);
            this.Controls.Add(this.cmbulke);
            this.Controls.Add(this.txtısım);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtısım;
        private System.Windows.Forms.ComboBox cmbulke;
        private System.Windows.Forms.Button btnsec;
        private System.Windows.Forms.Button button1;
    }
}

