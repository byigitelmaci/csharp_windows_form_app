namespace OOP_Constructor_Form_ders_9
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
            this.trcred = new System.Windows.Forms.TrackBar();
            this.trcgreen = new System.Windows.Forms.TrackBar();
            this.trcblue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnbackground = new System.Windows.Forms.Button();
            this.btnname = new System.Windows.Forms.Button();
            this.txtname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trcred)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcgreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcblue)).BeginInit();
            this.SuspendLayout();
            // 
            // trcred
            // 
            this.trcred.Location = new System.Drawing.Point(88, 61);
            this.trcred.Maximum = 255;
            this.trcred.Name = "trcred";
            this.trcred.Size = new System.Drawing.Size(613, 56);
            this.trcred.TabIndex = 2;
            // 
            // trcgreen
            // 
            this.trcgreen.Location = new System.Drawing.Point(88, 205);
            this.trcgreen.Maximum = 255;
            this.trcgreen.Name = "trcgreen";
            this.trcgreen.Size = new System.Drawing.Size(613, 56);
            this.trcgreen.TabIndex = 3;
            // 
            // trcblue
            // 
            this.trcblue.Location = new System.Drawing.Point(88, 357);
            this.trcblue.Maximum = 255;
            this.trcblue.Name = "trcblue";
            this.trcblue.Size = new System.Drawing.Size(613, 56);
            this.trcblue.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(767, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(767, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(767, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blue";
            // 
            // btnbackground
            // 
            this.btnbackground.Location = new System.Drawing.Point(400, 441);
            this.btnbackground.Name = "btnbackground";
            this.btnbackground.Size = new System.Drawing.Size(331, 67);
            this.btnbackground.TabIndex = 8;
            this.btnbackground.Text = "form 2 nin arka plan rengini değistir";
            this.btnbackground.UseVisualStyleBackColor = true;
            this.btnbackground.Click += new System.EventHandler(this.btnbackground_Click);
            // 
            // btnname
            // 
            this.btnname.Location = new System.Drawing.Point(883, 441);
            this.btnname.Name = "btnname";
            this.btnname.Size = new System.Drawing.Size(145, 67);
            this.btnname.TabIndex = 9;
            this.btnname.Text = "isim ile renk değiştirme";
            this.btnname.UseVisualStyleBackColor = true;
            this.btnname.Click += new System.EventHandler(this.btnname_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(915, 205);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(145, 22);
            this.txtname.TabIndex = 10;
            this.txtname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1136, 520);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnname);
            this.Controls.Add(this.btnbackground);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trcblue);
            this.Controls.Add(this.trcgreen);
            this.Controls.Add(this.trcred);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trcred)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcgreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcblue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trcred;
        private System.Windows.Forms.TrackBar trcgreen;
        private System.Windows.Forms.TrackBar trcblue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnbackground;
        private System.Windows.Forms.Button btnname;
        private System.Windows.Forms.TextBox txtname;
    }
}

