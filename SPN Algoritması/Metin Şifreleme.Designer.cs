namespace SPN_Algoritması
{
    partial class frmMetinSifrele
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
            this.btnMetinSifrele = new System.Windows.Forms.Button();
            this.txtSifrelenmisMetin = new System.Windows.Forms.TextBox();
            this.lblSifrelenmisMetin = new System.Windows.Forms.Label();
            this.txtGirilecekMetin = new System.Windows.Forms.TextBox();
            this.lblGirilecekMetin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCalismaZamani = new System.Windows.Forms.TextBox();
            this.btnSifrelenmisMetinKopyala = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(184, 122);
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
            this.lblAnahtar.Location = new System.Drawing.Point(27, 121);
            this.lblAnahtar.Name = "lblAnahtar";
            this.lblAnahtar.Size = new System.Drawing.Size(75, 21);
            this.lblAnahtar.TabIndex = 5;
            this.lblAnahtar.Text = "Anahtar:";
            // 
            // btnMetinSifrele
            // 
            this.btnMetinSifrele.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMetinSifrele.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetinSifrele.Location = new System.Drawing.Point(31, 211);
            this.btnMetinSifrele.Name = "btnMetinSifrele";
            this.btnMetinSifrele.Size = new System.Drawing.Size(399, 62);
            this.btnMetinSifrele.TabIndex = 3;
            this.btnMetinSifrele.Text = "METNİ ŞİFRELE";
            this.btnMetinSifrele.UseVisualStyleBackColor = false;
            this.btnMetinSifrele.Click += new System.EventHandler(this.btnMetinSifrele_Click);
            // 
            // txtSifrelenmisMetin
            // 
            this.txtSifrelenmisMetin.Location = new System.Drawing.Point(185, 300);
            this.txtSifrelenmisMetin.Multiline = true;
            this.txtSifrelenmisMetin.Name = "txtSifrelenmisMetin";
            this.txtSifrelenmisMetin.ReadOnly = true;
            this.txtSifrelenmisMetin.Size = new System.Drawing.Size(245, 35);
            this.txtSifrelenmisMetin.TabIndex = 7;
            // 
            // lblSifrelenmisMetin
            // 
            this.lblSifrelenmisMetin.AutoSize = true;
            this.lblSifrelenmisMetin.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifrelenmisMetin.Location = new System.Drawing.Point(8, 299);
            this.lblSifrelenmisMetin.Name = "lblSifrelenmisMetin";
            this.lblSifrelenmisMetin.Size = new System.Drawing.Size(144, 21);
            this.lblSifrelenmisMetin.TabIndex = 6;
            this.lblSifrelenmisMetin.Text = "Şifrelenmiş Metin:";
            // 
            // txtGirilecekMetin
            // 
            this.txtGirilecekMetin.Location = new System.Drawing.Point(184, 18);
            this.txtGirilecekMetin.Multiline = true;
            this.txtGirilecekMetin.Name = "txtGirilecekMetin";
            this.txtGirilecekMetin.Size = new System.Drawing.Size(245, 64);
            this.txtGirilecekMetin.TabIndex = 1;
            this.txtGirilecekMetin.Leave += new System.EventHandler(this.txtGirilecekMetin_Leave);
            // 
            // lblGirilecekMetin
            // 
            this.lblGirilecekMetin.AutoSize = true;
            this.lblGirilecekMetin.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirilecekMetin.Location = new System.Drawing.Point(26, 18);
            this.lblGirilecekMetin.Name = "lblGirilecekMetin";
            this.lblGirilecekMetin.Size = new System.Drawing.Size(125, 21);
            this.lblGirilecekMetin.TabIndex = 4;
            this.lblGirilecekMetin.Text = "Girilecek Metin:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(13, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Çalışma Zamanı:";
            // 
            // txtCalismaZamani
            // 
            this.txtCalismaZamani.Location = new System.Drawing.Point(185, 359);
            this.txtCalismaZamani.Multiline = true;
            this.txtCalismaZamani.Name = "txtCalismaZamani";
            this.txtCalismaZamani.ReadOnly = true;
            this.txtCalismaZamani.Size = new System.Drawing.Size(245, 37);
            this.txtCalismaZamani.TabIndex = 9;
            // 
            // btnSifrelenmisMetinKopyala
            // 
            this.btnSifrelenmisMetinKopyala.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSifrelenmisMetinKopyala.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrelenmisMetinKopyala.Location = new System.Drawing.Point(184, 408);
            this.btnSifrelenmisMetinKopyala.Name = "btnSifrelenmisMetinKopyala";
            this.btnSifrelenmisMetinKopyala.Size = new System.Drawing.Size(245, 39);
            this.btnSifrelenmisMetinKopyala.TabIndex = 10;
            this.btnSifrelenmisMetinKopyala.Text = "Şifrelenmiş Metin Kopyala";
            this.btnSifrelenmisMetinKopyala.UseVisualStyleBackColor = false;
            this.btnSifrelenmisMetinKopyala.Click += new System.EventHandler(this.btnSifrelenmisMetinKopyala_Click);
            // 
            // frmMetinSifrele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(457, 459);
            this.Controls.Add(this.btnSifrelenmisMetinKopyala);
            this.Controls.Add(this.txtCalismaZamani);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.lblAnahtar);
            this.Controls.Add(this.btnMetinSifrele);
            this.Controls.Add(this.txtSifrelenmisMetin);
            this.Controls.Add(this.lblSifrelenmisMetin);
            this.Controls.Add(this.txtGirilecekMetin);
            this.Controls.Add(this.lblGirilecekMetin);
            this.Name = "frmMetinSifrele";
            this.Text = "Metin Şifreleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAnahtar;
        private System.Windows.Forms.Button btnMetinSifrele;
        private System.Windows.Forms.TextBox txtSifrelenmisMetin;
        private System.Windows.Forms.Label lblSifrelenmisMetin;
        private System.Windows.Forms.TextBox txtGirilecekMetin;
        private System.Windows.Forms.Label lblGirilecekMetin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCalismaZamani;
        private System.Windows.Forms.Button btnSifrelenmisMetinKopyala;
        public System.Windows.Forms.TextBox txtAnahtar;
    }
}