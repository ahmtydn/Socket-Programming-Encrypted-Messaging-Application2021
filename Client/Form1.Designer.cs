namespace Client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txName = new System.Windows.Forms.TextBox();
            this.clientListBox = new System.Windows.Forms.ListBox();
            this.txt_text = new System.Windows.Forms.TextBox();
            this.btnMesajGonder = new System.Windows.Forms.Button();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.TXTsonmesaj = new System.Windows.Forms.TextBox();
            this.txtbxCozuldu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.spnchkbox = new System.Windows.Forms.CheckBox();
            this.shachkbox = new System.Windows.Forms.CheckBox();
            this.lblcozmesaj = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblanahtarUyari = new System.Windows.Forms.Label();
            this.lblchckboxuyari = new System.Windows.Forms.Label();
            this.lblbaglanti = new System.Windows.Forms.Label();
            this.lblgorunmez = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtboxdosyaisim = new System.Windows.Forms.TextBox();
            this.btnDosyaGonder = new System.Windows.Forms.Button();
            this.lbldosya = new System.Windows.Forms.Label();
            this.btnDosyaCoz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(244, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı";
            // 
            // txName
            // 
            this.txName.Location = new System.Drawing.Point(12, 96);
            this.txName.Multiline = true;
            this.txName.Name = "txName";
            this.txName.Size = new System.Drawing.Size(226, 25);
            this.txName.TabIndex = 3;
            // 
            // clientListBox
            // 
            this.clientListBox.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.clientListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clientListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientListBox.FormattingEnabled = true;
            this.clientListBox.Location = new System.Drawing.Point(2, 15);
            this.clientListBox.Name = "clientListBox";
            this.clientListBox.Size = new System.Drawing.Size(99, 399);
            this.clientListBox.TabIndex = 4;
            // 
            // txt_text
            // 
            this.txt_text.Location = new System.Drawing.Point(14, 149);
            this.txt_text.Multiline = true;
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(224, 50);
            this.txt_text.TabIndex = 5;
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMesajGonder.BackgroundImage")));
            this.btnMesajGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMesajGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMesajGonder.Location = new System.Drawing.Point(242, 228);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(26, 24);
            this.btnMesajGonder.TabIndex = 6;
            this.btnMesajGonder.UseVisualStyleBackColor = true;
            this.btnMesajGonder.Click += new System.EventHandler(this.btnMesajGonder_Click);
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(12, 228);
            this.txtAnahtar.Multiline = true;
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(224, 24);
            this.txtAnahtar.TabIndex = 5;
            this.txtAnahtar.TextChanged += new System.EventHandler(this.txtAnahtar_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(10, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Anahtar";
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(242, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(28, 30);
            this.button3.TabIndex = 1;
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // TXTsonmesaj
            // 
            this.TXTsonmesaj.Location = new System.Drawing.Point(12, 390);
            this.TXTsonmesaj.Name = "TXTsonmesaj";
            this.TXTsonmesaj.Size = new System.Drawing.Size(224, 20);
            this.TXTsonmesaj.TabIndex = 10;
            // 
            // txtbxCozuldu
            // 
            this.txtbxCozuldu.Location = new System.Drawing.Point(12, 447);
            this.txtbxCozuldu.Multiline = true;
            this.txtbxCozuldu.Name = "txtbxCozuldu";
            this.txtbxCozuldu.Size = new System.Drawing.Size(224, 63);
            this.txtbxCozuldu.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(10, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Çözülmüş Mesaj";
            // 
            // spnchkbox
            // 
            this.spnchkbox.AutoSize = true;
            this.spnchkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.spnchkbox.ForeColor = System.Drawing.Color.White;
            this.spnchkbox.Location = new System.Drawing.Point(16, 258);
            this.spnchkbox.Name = "spnchkbox";
            this.spnchkbox.Size = new System.Drawing.Size(50, 17);
            this.spnchkbox.TabIndex = 13;
            this.spnchkbox.Text = "SPN";
            this.spnchkbox.UseVisualStyleBackColor = true;
            this.spnchkbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.spnchkbox_MouseClick);
            // 
            // shachkbox
            // 
            this.shachkbox.AutoSize = true;
            this.shachkbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.shachkbox.ForeColor = System.Drawing.Color.White;
            this.shachkbox.Location = new System.Drawing.Point(90, 258);
            this.shachkbox.Name = "shachkbox";
            this.shachkbox.Size = new System.Drawing.Size(71, 17);
            this.shachkbox.TabIndex = 14;
            this.shachkbox.Text = "SHA256";
            this.shachkbox.UseVisualStyleBackColor = true;
            this.shachkbox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.shachkbox_MouseClick);
            // 
            // lblcozmesaj
            // 
            this.lblcozmesaj.AutoSize = true;
            this.lblcozmesaj.ForeColor = System.Drawing.Color.Red;
            this.lblcozmesaj.Location = new System.Drawing.Point(124, 430);
            this.lblcozmesaj.Name = "lblcozmesaj";
            this.lblcozmesaj.Size = new System.Drawing.Size(0, 13);
            this.lblcozmesaj.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(13, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Şİfreli Mesaj";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mesaj";
            // 
            // lblanahtarUyari
            // 
            this.lblanahtarUyari.AutoSize = true;
            this.lblanahtarUyari.BackColor = System.Drawing.Color.MistyRose;
            this.lblanahtarUyari.ForeColor = System.Drawing.Color.Red;
            this.lblanahtarUyari.Location = new System.Drawing.Point(15, 272);
            this.lblanahtarUyari.Name = "lblanahtarUyari";
            this.lblanahtarUyari.Size = new System.Drawing.Size(0, 13);
            this.lblanahtarUyari.TabIndex = 18;
            // 
            // lblchckboxuyari
            // 
            this.lblchckboxuyari.AutoSize = true;
            this.lblchckboxuyari.Location = new System.Drawing.Point(207, 265);
            this.lblchckboxuyari.Name = "lblchckboxuyari";
            this.lblchckboxuyari.Size = new System.Drawing.Size(0, 13);
            this.lblchckboxuyari.TabIndex = 16;
            // 
            // lblbaglanti
            // 
            this.lblbaglanti.AutoSize = true;
            this.lblbaglanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbaglanti.ForeColor = System.Drawing.Color.Red;
            this.lblbaglanti.Location = new System.Drawing.Point(74, 41);
            this.lblbaglanti.Name = "lblbaglanti";
            this.lblbaglanti.Size = new System.Drawing.Size(56, 17);
            this.lblbaglanti.TabIndex = 15;
            this.lblbaglanti.Text = "Offline";
            // 
            // lblgorunmez
            // 
            this.lblgorunmez.AutoSize = true;
            this.lblgorunmez.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblgorunmez.Location = new System.Drawing.Point(154, 77);
            this.lblgorunmez.Name = "lblgorunmez";
            this.lblgorunmez.Size = new System.Drawing.Size(0, 13);
            this.lblgorunmez.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(342, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(74, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "CLIENT";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(8, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 2);
            this.panel1.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clientListBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(285, 94);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(103, 416);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CLIENTS";
            // 
            // txtboxdosyaisim
            // 
            this.txtboxdosyaisim.Location = new System.Drawing.Point(14, 306);
            this.txtboxdosyaisim.Multiline = true;
            this.txtboxdosyaisim.Name = "txtboxdosyaisim";
            this.txtboxdosyaisim.Size = new System.Drawing.Size(224, 24);
            this.txtboxdosyaisim.TabIndex = 26;
            // 
            // btnDosyaGonder
            // 
            this.btnDosyaGonder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDosyaGonder.BackgroundImage")));
            this.btnDosyaGonder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDosyaGonder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDosyaGonder.Location = new System.Drawing.Point(244, 306);
            this.btnDosyaGonder.Name = "btnDosyaGonder";
            this.btnDosyaGonder.Size = new System.Drawing.Size(26, 24);
            this.btnDosyaGonder.TabIndex = 27;
            this.btnDosyaGonder.UseVisualStyleBackColor = true;
            this.btnDosyaGonder.Click += new System.EventHandler(this.btnDosyaGonder_Click);
            // 
            // lbldosya
            // 
            this.lbldosya.AutoSize = true;
            this.lbldosya.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldosya.ForeColor = System.Drawing.Color.Purple;
            this.lbldosya.Location = new System.Drawing.Point(15, 290);
            this.lbldosya.Name = "lbldosya";
            this.lbldosya.Size = new System.Drawing.Size(68, 13);
            this.lbldosya.TabIndex = 28;
            this.lbldosya.Text = "Dosya İsmi";
            // 
            // btnDosyaCoz
            // 
            this.btnDosyaCoz.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDosyaCoz.BackgroundImage")));
            this.btnDosyaCoz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDosyaCoz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDosyaCoz.Location = new System.Drawing.Point(240, 347);
            this.btnDosyaCoz.Name = "btnDosyaCoz";
            this.btnDosyaCoz.Size = new System.Drawing.Size(30, 26);
            this.btnDosyaCoz.TabIndex = 29;
            this.btnDosyaCoz.UseVisualStyleBackColor = true;
            this.btnDosyaCoz.Click += new System.EventHandler(this.btnDosyaCoz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(165, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Dosya Çöz";
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClientSize = new System.Drawing.Size(399, 515);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDosyaCoz);
            this.Controls.Add(this.lbldosya);
            this.Controls.Add(this.btnDosyaGonder);
            this.Controls.Add(this.txtboxdosyaisim);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblanahtarUyari);
            this.Controls.Add(this.lblcozmesaj);
            this.Controls.Add(this.lblchckboxuyari);
            this.Controls.Add(this.lblbaglanti);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblgorunmez);
            this.Controls.Add(this.shachkbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbxCozuldu);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.TXTsonmesaj);
            this.Controls.Add(this.spnchkbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_text);
            this.Controls.Add(this.btnMesajGonder);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client";
            this.Text = "CLIENT";
            this.Load += new System.EventHandler(this.s_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txName;
        private System.Windows.Forms.ListBox clientListBox;
        private System.Windows.Forms.TextBox txt_text;
        private System.Windows.Forms.Button btnMesajGonder;
        private System.Windows.Forms.TextBox txtAnahtar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TXTsonmesaj;
        private System.Windows.Forms.TextBox txtbxCozuldu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox spnchkbox;
        private System.Windows.Forms.CheckBox shachkbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblbaglanti;
        private System.Windows.Forms.Label lblchckboxuyari;
        private System.Windows.Forms.Label lblcozmesaj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblanahtarUyari;
        private System.Windows.Forms.Label lblgorunmez;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtboxdosyaisim;
        private System.Windows.Forms.Button btnDosyaGonder;
        private System.Windows.Forms.Label lbldosya;
        private System.Windows.Forms.Button btnDosyaCoz;
        private System.Windows.Forms.Label label5;
    }
}

