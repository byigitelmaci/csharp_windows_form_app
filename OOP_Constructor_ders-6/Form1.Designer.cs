namespace OOP_Constructor_ders_6
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
            this.btndogum = new System.Windows.Forms.Button();
            this.txtbebek = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btndogum
            // 
            this.btndogum.Location = new System.Drawing.Point(199, 99);
            this.btndogum.Name = "btndogum";
            this.btndogum.Size = new System.Drawing.Size(223, 105);
            this.btndogum.TabIndex = 0;
            this.btndogum.Text = "doğum";
            this.btndogum.UseVisualStyleBackColor = true;
            this.btndogum.Click += new System.EventHandler(this.btndogum_Click);
            // 
            // txtbebek
            // 
            this.txtbebek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbebek.Location = new System.Drawing.Point(199, 275);
            this.txtbebek.Name = "txtbebek";
            this.txtbebek.Size = new System.Drawing.Size(223, 34);
            this.txtbebek.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtbebek);
            this.Controls.Add(this.btndogum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndogum;
        private System.Windows.Forms.TextBox txtbebek;
    }
}

