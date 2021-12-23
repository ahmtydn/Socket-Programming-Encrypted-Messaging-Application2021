namespace Client
{
    partial class s
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TXTsonmesaj = new System.Windows.Forms.TextBox();
            this.txtbxCozuldu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.spnchkbox = new System.Windows.Forms.CheckBox();
            this.shachkbox = new System.Windows.Forms.CheckBox();
            this.lblserverbaglantimesaj = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcozmesaj = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblchckboxuyari = new System.Windows.Forms.Label();
            this.lblbaglanti = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblgorunmez = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Bağlan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı :";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(89, 13);
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(282, 20);
            this.txName.TabIndex = 3;
            // 
            // clientListBox
            // 
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.Location = new System.Drawing.Point(15, 108);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(152, 264);
            this.clientListBox.TabIndex = 4;
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(89, 52);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(282, 20);
            this.txt_text.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 21);
            this.button2.TabIndex = 6;
            this.button2.Text = "Gönder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clientler : ";
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(89, 98);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(282, 20);
            this.txtAnahtar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Anahtar  :";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(289, 156);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 21);
            this.button3.TabIndex = 1;
            this.button3.Text = "Şifreyi Çöz";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // TXTsonmesaj
            // 
            this.TXTsonmesaj.Location = new System.Drawing.Point(107, 36);
            this.TXTsonmesaj.Name = "TXTsonmesaj";
            this.TXTsonmesaj.Size = new System.Drawing.Size(282, 20);
            this.TXTsonmesaj.TabIndex = 10;
            // 
            // txtbxCozuldu
            // 
            this.txtbxCozuldu.Location = new System.Drawing.Point(107, 107);
            this.txtbxCozuldu.Name = "txtbxCozuldu";
            this.txtbxCozuldu.Size = new System.Drawing.Size(282, 20);
            this.txtbxCozuldu.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Çözülmüş Mesaj :";
            // 
            // spnchkbox
            // 
            this.spnchkbox.AutoSize = true;
            this.spnchkbox.Location = new System.Drawing.Point(88, 145);
            this.spnchkbox.Name = "spnchkbox";
            this.spnchkbox.Size = new System.Drawing.Size(48, 17);
            this.spnchkbox.TabIndex = 13;
            this.spnchkbox.Text = "SPN";
            this.spnchkbox.UseVisualStyleBackColor = true;
            this.spnchkbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spnchkbox_MouseClick);
            // 
            // shachkbox
            // 
            this.shachkbox.AutoSize = true;
            this.shachkbox.Location = new System.Drawing.Point(88, 178);
            this.shachkbox.Name = "shachkbox";
            this.shachkbox.Size = new System.Drawing.Size(66, 17);
            this.shachkbox.TabIndex = 14;
            this.shachkbox.Text = "SHA256";
            this.shachkbox.UseVisualStyleBackColor = true;
            this.shachkbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.shachkbox_MouseClick);
            // 
            // lblserverbaglantimesaj
            // 
            this.lblserverbaglantimesaj.AutoSize = true;
            this.lblserverbaglantimesaj.ForeColor = System.Drawing.Color.IndianRed;
            this.lblserverbaglantimesaj.Location = new System.Drawing.Point(104, -10);
            this.lblserverbaglantimesaj.Name = "lblserverbaglantimesaj";
            this.lblserverbaglantimesaj.Size = new System.Drawing.Size(0, 13);
            this.lblserverbaglantimesaj.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblcozmesaj);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.lblserverbaglantimesaj);
            this.panel1.Controls.Add(this.txtbxCozuldu);
            this.panel1.Controls.Add(this.TXTsonmesaj);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 257);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 211);
            this.panel1.TabIndex = 16;
            // 
            // lblcozmesaj
            // 
            this.lblcozmesaj.AutoSize = true;
            this.lblcozmesaj.ForeColor = System.Drawing.Color.Red;
            this.lblcozmesaj.Location = new System.Drawing.Point(100, 156);
            this.lblcozmesaj.Name = "lblcozmesaj";
            this.lblcozmesaj.Size = new System.Drawing.Size(0, 13);
            this.lblcozmesaj.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Şİfreli Mesaj :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mesaj     :";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblchckboxuyari);
            this.panel2.Controls.Add(this.lblbaglanti);
            this.panel2.Controls.Add(this.txName);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.shachkbox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.spnchkbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.txt_text);
            this.panel2.Controls.Add(this.txtAnahtar);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 215);
            this.panel2.TabIndex = 17;
            // 
            // lblchckboxuyari
            // 
            this.lblchckboxuyari.AutoSize = true;
            this.lblchckboxuyari.Location = new System.Drawing.Point(215, 182);
            this.lblchckboxuyari.Name = "lblchckboxuyari";
            this.lblchckboxuyari.Size = new System.Drawing.Size(0, 13);
            this.lblchckboxuyari.TabIndex = 16;
            // 
            // lblbaglanti
            // 
            this.lblbaglanti.AutoSize = true;
            this.lblbaglanti.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblbaglanti.Location = new System.Drawing.Point(86, 36);
            this.lblbaglanti.Name = "lblbaglanti";
            this.lblbaglanti.Size = new System.Drawing.Size(0, 13);
            this.lblbaglanti.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.clientListBox);
            this.panel3.Location = new System.Drawing.Point(545, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(185, 456);
            this.panel3.TabIndex = 18;
            // 
            // lblgorunmez
            // 
            this.lblgorunmez.AutoSize = true;
            this.lblgorunmez.Location = new System.Drawing.Point(18, 234);
            this.lblgorunmez.Name = "lblgorunmez";
            this.lblgorunmez.Size = new System.Drawing.Size(35, 13);
            this.lblgorunmez.TabIndex = 19;
            this.lblgorunmez.Text = "label5";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 477);
            this.Controls.Add(this.lblgorunmez);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "s";
            this.Text = "Şifreleme";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TXTsonmesaj;
        private System.Windows.Forms.TextBox txtbxCozuldu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox spnchkbox;
        private System.Windows.Forms.CheckBox shachkbox;
        private System.Windows.Forms.Label lblserverbaglantimesaj;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblbaglanti;
        private System.Windows.Forms.Label lblchckboxuyari;
        private System.Windows.Forms.Label lblcozmesaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblgorunmez;
    }
}

