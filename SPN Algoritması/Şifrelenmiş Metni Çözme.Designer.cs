namespace SPN_Algoritması
{
    partial class frmMetinCöz
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
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.lblAnahtar = new System.Windows.Forms.Label();
            this.btnSifrelenmisMetinCoz = new System.Windows.Forms.Button();
            this.txtCozülmüsMetin = new System.Windows.Forms.TextBox();
            this.lblCözülmüsMetin = new System.Windows.Forms.Label();
            this.txtCözülecekMetin = new System.Windows.Forms.TextBox();
            this.lblCözülecekMetin = new System.Windows.Forms.Label();
            this.btnSifrelenmisMetinYapıştır = new System.Windows.Forms.Button();
            this.txtCalismaZamani = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(180, 159);
            this.txtAnahtar.Multiline = true;
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(245, 64);
            this.txtAnahtar.TabIndex = 2;
            this.txtAnahtar.Leave += new System.EventHandler(this.txtAnahtar_Leave);
            // 
            // lblAnahtar
            // 
            this.lblAnahtar.AutoSize = true;
            this.lblAnahtar.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnahtar.Location = new System.Drawing.Point(23, 158);
            this.lblAnahtar.Name = "lblAnahtar";
            this.lblAnahtar.Size = new System.Drawing.Size(75, 21);
            this.lblAnahtar.TabIndex = 5;
            this.lblAnahtar.Text = "Anahtar:";
            // 
            // btnSifrelenmisMetinCoz
            // 
            this.btnSifrelenmisMetinCoz.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSifrelenmisMetinCoz.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrelenmisMetinCoz.Location = new System.Drawing.Point(27, 254);
            this.btnSifrelenmisMetinCoz.Name = "btnSifrelenmisMetinCoz";
            this.btnSifrelenmisMetinCoz.Size = new System.Drawing.Size(399, 62);
            this.btnSifrelenmisMetinCoz.TabIndex = 3;
            this.btnSifrelenmisMetinCoz.Text = "ŞİFRELENMİŞ METNİ ÇÖZ";
            this.btnSifrelenmisMetinCoz.UseVisualStyleBackColor = false;
            this.btnSifrelenmisMetinCoz.Click += new System.EventHandler(this.btnSifrelenmisMetinCoz_Click);
            // 
            // txtCozülmüsMetin
            // 
            this.txtCozülmüsMetin.Location = new System.Drawing.Point(181, 343);
            this.txtCozülmüsMetin.Multiline = true;
            this.txtCozülmüsMetin.Name = "txtCozülmüsMetin";
            this.txtCozülmüsMetin.ReadOnly = true;
            this.txtCozülmüsMetin.Size = new System.Drawing.Size(245, 36);
            this.txtCozülmüsMetin.TabIndex = 7;
            // 
            // lblCözülmüsMetin
            // 
            this.lblCözülmüsMetin.AutoSize = true;
            this.lblCözülmüsMetin.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCözülmüsMetin.Location = new System.Drawing.Point(23, 342);
            this.lblCözülmüsMetin.Name = "lblCözülmüsMetin";
            this.lblCözülmüsMetin.Size = new System.Drawing.Size(128, 21);
            this.lblCözülmüsMetin.TabIndex = 6;
            this.lblCözülmüsMetin.Text = "Çözülmüş Metin:";
            // 
            // txtCözülecekMetin
            // 
            this.txtCözülecekMetin.Location = new System.Drawing.Point(180, 21);
            this.txtCözülecekMetin.Multiline = true;
            this.txtCözülecekMetin.Name = "txtCözülecekMetin";
            this.txtCözülecekMetin.ReadOnly = true;
            this.txtCözülecekMetin.Size = new System.Drawing.Size(245, 64);
            this.txtCözülecekMetin.TabIndex = 1;
            this.txtCözülecekMetin.Leave += new System.EventHandler(this.txtCözülecekMetin_Leave);
            // 
            // lblCözülecekMetin
            // 
            this.lblCözülecekMetin.AutoSize = true;
            this.lblCözülecekMetin.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCözülecekMetin.Location = new System.Drawing.Point(22, 21);
            this.lblCözülecekMetin.Name = "lblCözülecekMetin";
            this.lblCözülecekMetin.Size = new System.Drawing.Size(133, 21);
            this.lblCözülecekMetin.TabIndex = 4;
            this.lblCözülecekMetin.Text = "Çözülecek Metin:";
            // 
            // btnSifrelenmisMetinYapıştır
            // 
            this.btnSifrelenmisMetinYapıştır.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrelenmisMetinYapıştır.Location = new System.Drawing.Point(12, 62);
            this.btnSifrelenmisMetinYapıştır.Name = "btnSifrelenmisMetinYapıştır";
            this.btnSifrelenmisMetinYapıştır.Size = new System.Drawing.Size(143, 71);
            this.btnSifrelenmisMetinYapıştır.TabIndex = 13;
            this.btnSifrelenmisMetinYapıştır.Text = "Şifrelenmiş Metni Yapıştır";
            this.btnSifrelenmisMetinYapıştır.UseVisualStyleBackColor = true;
            this.btnSifrelenmisMetinYapıştır.Click += new System.EventHandler(this.btnSifrelenmisMetinYapıştır_Click);
            // 
            // txtCalismaZamani
            // 
            this.txtCalismaZamani.Location = new System.Drawing.Point(181, 394);
            this.txtCalismaZamani.Multiline = true;
            this.txtCalismaZamani.Name = "txtCalismaZamani";
            this.txtCalismaZamani.ReadOnly = true;
            this.txtCalismaZamani.Size = new System.Drawing.Size(245, 37);
            this.txtCalismaZamani.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Çalışma Zamanı:";
            // 
            // frmMetinCöz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(454, 458);
            this.Controls.Add(this.btnSifrelenmisMetinYapıştır);
            this.Controls.Add(this.txtCalismaZamani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.lblAnahtar);
            this.Controls.Add(this.btnSifrelenmisMetinCoz);
            this.Controls.Add(this.txtCozülmüsMetin);
            this.Controls.Add(this.lblCözülmüsMetin);
            this.Controls.Add(this.txtCözülecekMetin);
            this.Controls.Add(this.lblCözülecekMetin);
            this.Name = "frmMetinCöz";
            this.Text = "Şifrelenmiş Metin Çözme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.Label lblAnahtar;
        private System.Windows.Forms.Button btnSifrelenmisMetinCoz;
        private System.Windows.Forms.TextBox txtCozülmüsMetin;
        private System.Windows.Forms.Label lblCözülmüsMetin;
        private System.Windows.Forms.TextBox txtCözülecekMetin;
        private System.Windows.Forms.Label lblCözülecekMetin;
        private System.Windows.Forms.Button btnSifrelenmisMetinYapıştır;
        private System.Windows.Forms.TextBox txtCalismaZamani;
        private System.Windows.Forms.Label label1;
    }
}