namespace LINQ
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_personelsayi = new System.Windows.Forms.Label();
            this.lbl_personelmaasortalama = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_personelyas = new System.Windows.Forms.Label();
            this.lbl_maas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yeni Personel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_personelsayi
            // 
            this.lbl_personelsayi.AutoSize = true;
            this.lbl_personelsayi.Location = new System.Drawing.Point(91, 83);
            this.lbl_personelsayi.Name = "lbl_personelsayi";
            this.lbl_personelsayi.Size = new System.Drawing.Size(117, 13);
            this.lbl_personelsayi.TabIndex = 1;
            this.lbl_personelsayi.Text = "Şu anda 0 personel var";
            // 
            // lbl_personelmaasortalama
            // 
            this.lbl_personelmaasortalama.AutoSize = true;
            this.lbl_personelmaasortalama.Location = new System.Drawing.Point(91, 113);
            this.lbl_personelmaasortalama.Name = "lbl_personelmaasortalama";
            this.lbl_personelmaasortalama.Size = new System.Drawing.Size(149, 13);
            this.lbl_personelmaasortalama.TabIndex = 2;
            this.lbl_personelmaasortalama.Text = "Personel maaşı ortalama 0 TL.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Son eklenen personelin";
            // 
            // lbl_personelyas
            // 
            this.lbl_personelyas.AutoSize = true;
            this.lbl_personelyas.Location = new System.Drawing.Point(114, 180);
            this.lbl_personelyas.Name = "lbl_personelyas";
            this.lbl_personelyas.Size = new System.Drawing.Size(39, 13);
            this.lbl_personelyas.TabIndex = 4;
            this.lbl_personelyas.Text = "Yaşı 0 ";
            // 
            // lbl_maas
            // 
            this.lbl_maas.AutoSize = true;
            this.lbl_maas.Location = new System.Drawing.Point(114, 203);
            this.lbl_maas.Name = "lbl_maas";
            this.lbl_maas.Size = new System.Drawing.Size(47, 13);
            this.lbl_maas.TabIndex = 5;
            this.lbl_maas.Text = "Maaşı 0 ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_maas);
            this.Controls.Add(this.lbl_personelyas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_personelmaasortalama);
            this.Controls.Add(this.lbl_personelsayi);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_personelsayi;
        private System.Windows.Forms.Label lbl_personelmaasortalama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_personelyas;
        private System.Windows.Forms.Label lbl_maas;
    }
}