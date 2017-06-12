namespace _005_DES
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
            this.txtboxVeri = new System.Windows.Forms.TextBox();
            this.btnDES = new System.Windows.Forms.Button();
            this.labelSonuc = new System.Windows.Forms.Label();
            this.txtBoxSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtboxVeri
            // 
            this.txtboxVeri.Location = new System.Drawing.Point(62, 12);
            this.txtboxVeri.Name = "txtboxVeri";
            this.txtboxVeri.Size = new System.Drawing.Size(454, 20);
            this.txtboxVeri.TabIndex = 0;
            // 
            // btnDES
            // 
            this.btnDES.Location = new System.Drawing.Point(12, 64);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(150, 23);
            this.btnDES.TabIndex = 1;
            this.btnDES.Text = "DES";
            this.btnDES.UseVisualStyleBackColor = true;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // labelSonuc
            // 
            this.labelSonuc.AutoSize = true;
            this.labelSonuc.Location = new System.Drawing.Point(12, 96);
            this.labelSonuc.Name = "labelSonuc";
            this.labelSonuc.Size = new System.Drawing.Size(38, 13);
            this.labelSonuc.TabIndex = 2;
            this.labelSonuc.Text = "Sonuc";
            // 
            // txtBoxSifre
            // 
            this.txtBoxSifre.Location = new System.Drawing.Point(62, 38);
            this.txtBoxSifre.Name = "txtBoxSifre";
            this.txtBoxSifre.Size = new System.Drawing.Size(454, 20);
            this.txtBoxSifre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Metin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Anahtar";
            // 
            // txtBoxSonuc
            // 
            this.txtBoxSonuc.Location = new System.Drawing.Point(62, 93);
            this.txtBoxSonuc.Name = "txtBoxSonuc";
            this.txtBoxSonuc.Size = new System.Drawing.Size(454, 20);
            this.txtBoxSonuc.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 523);
            this.Controls.Add(this.txtBoxSonuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxSifre);
            this.Controls.Add(this.labelSonuc);
            this.Controls.Add(this.btnDES);
            this.Controls.Add(this.txtboxVeri);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxVeri;
        private System.Windows.Forms.Button btnDES;
        private System.Windows.Forms.Label labelSonuc;
        private System.Windows.Forms.TextBox txtBoxSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxSonuc;
    }
}

