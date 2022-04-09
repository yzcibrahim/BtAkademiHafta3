
namespace _09_KisiTakipWinform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxSonuc = new System.Windows.Forms.TextBox();
            this.btnSelamla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSayi1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSayi2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxToplam = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(73, 45);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxSurname.Location = new System.Drawing.Point(201, 45);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(100, 23);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.Text = "asd";
            // 
            // textBoxSonuc
            // 
            this.textBoxSonuc.Location = new System.Drawing.Point(72, 109);
            this.textBoxSonuc.Name = "textBoxSonuc";
            this.textBoxSonuc.Size = new System.Drawing.Size(246, 23);
            this.textBoxSonuc.TabIndex = 2;
            // 
            // btnSelamla
            // 
            this.btnSelamla.Location = new System.Drawing.Point(73, 80);
            this.btnSelamla.Name = "btnSelamla";
            this.btnSelamla.Size = new System.Drawing.Size(75, 23);
            this.btnSelamla.TabIndex = 3;
            this.btnSelamla.Text = "Selamla";
            this.btnSelamla.UseVisualStyleBackColor = true;
            this.btnSelamla.Click += new System.EventHandler(this.btnSelamla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sayı1";
            // 
            // textBoxSayi1
            // 
            this.textBoxSayi1.Location = new System.Drawing.Point(113, 216);
            this.textBoxSayi1.Name = "textBoxSayi1";
            this.textBoxSayi1.Size = new System.Drawing.Size(100, 23);
            this.textBoxSayi1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sayı2";
            // 
            // textBoxSayi2
            // 
            this.textBoxSayi2.Location = new System.Drawing.Point(112, 272);
            this.textBoxSayi2.Name = "textBoxSayi2";
            this.textBoxSayi2.Size = new System.Drawing.Size(100, 23);
            this.textBoxSayi2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "+";
            // 
            // textBoxToplam
            // 
            this.textBoxToplam.Enabled = false;
            this.textBoxToplam.Location = new System.Drawing.Point(112, 340);
            this.textBoxToplam.Name = "textBoxToplam";
            this.textBoxToplam.ReadOnly = true;
            this.textBoxToplam.Size = new System.Drawing.Size(100, 23);
            this.textBoxToplam.TabIndex = 10;
            this.textBoxToplam.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(125, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(642, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxToplam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxSayi2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxSayi1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelamla);
            this.Controls.Add(this.textBoxSonuc);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxName);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Kişi Takip Uygulaması";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxSonuc;
        private System.Windows.Forms.Button btnSelamla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSayi1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSayi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxToplam;
        private System.Windows.Forms.Button button1;
    }
}

