namespace VeritabaniKayitGiris
{
    partial class sifremiUnuttum
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUnuttumKullaniciAdi = new System.Windows.Forms.TextBox();
            this.tbUnuttumSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUnuttumSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(95, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Yeni Şifreniz";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // tbUnuttumKullaniciAdi
            // 
            this.tbUnuttumKullaniciAdi.Location = new System.Drawing.Point(237, 32);
            this.tbUnuttumKullaniciAdi.Name = "tbUnuttumKullaniciAdi";
            this.tbUnuttumKullaniciAdi.Size = new System.Drawing.Size(150, 22);
            this.tbUnuttumKullaniciAdi.TabIndex = 13;
            // 
            // tbUnuttumSifre
            // 
            this.tbUnuttumSifre.Location = new System.Drawing.Point(237, 86);
            this.tbUnuttumSifre.Name = "tbUnuttumSifre";
            this.tbUnuttumSifre.Size = new System.Drawing.Size(150, 22);
            this.tbUnuttumSifre.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Yeni Şifreniz (Tekrar)";
            // 
            // tbUnuttumSifreTekrar
            // 
            this.tbUnuttumSifreTekrar.Location = new System.Drawing.Point(237, 135);
            this.tbUnuttumSifreTekrar.Name = "tbUnuttumSifreTekrar";
            this.tbUnuttumSifreTekrar.Size = new System.Drawing.Size(150, 22);
            this.tbUnuttumSifreTekrar.TabIndex = 17;
            // 
            // btnYenile
            // 
            this.btnYenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Location = new System.Drawing.Point(237, 185);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(150, 47);
            this.btnYenile.TabIndex = 18;
            this.btnYenile.Text = "Şifremi Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // sifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(419, 257);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.tbUnuttumSifreTekrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbUnuttumKullaniciAdi);
            this.Controls.Add(this.tbUnuttumSifre);
            this.Name = "sifremiUnuttum";
            this.Text = "sifremiUnuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUnuttumKullaniciAdi;
        private System.Windows.Forms.TextBox tbUnuttumSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUnuttumSifreTekrar;
        private System.Windows.Forms.Button btnYenile;
    }
}