namespace SPN_Algoritması
{
    partial class frmMenu
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
            this.btnMetinSifreleme = new System.Windows.Forms.Button();
            this.btnSifrelenmisMetinCoz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMetinSifreleme
            // 
            this.btnMetinSifreleme.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMetinSifreleme.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMetinSifreleme.Location = new System.Drawing.Point(29, 45);
            this.btnMetinSifreleme.Name = "btnMetinSifreleme";
            this.btnMetinSifreleme.Size = new System.Drawing.Size(240, 82);
            this.btnMetinSifreleme.TabIndex = 0;
            this.btnMetinSifreleme.Text = "Metin Şifreleme";
            this.btnMetinSifreleme.UseVisualStyleBackColor = false;
            this.btnMetinSifreleme.Click += new System.EventHandler(this.btnMetinSifreleme_Click);
            // 
            // btnSifrelenmisMetinCoz
            // 
            this.btnSifrelenmisMetinCoz.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSifrelenmisMetinCoz.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifrelenmisMetinCoz.Location = new System.Drawing.Point(29, 151);
            this.btnSifrelenmisMetinCoz.Name = "btnSifrelenmisMetinCoz";
            this.btnSifrelenmisMetinCoz.Size = new System.Drawing.Size(240, 82);
            this.btnSifrelenmisMetinCoz.TabIndex = 1;
            this.btnSifrelenmisMetinCoz.Text = "Şifrelenmiş Metni Çöz";
            this.btnSifrelenmisMetinCoz.UseVisualStyleBackColor = false;
            this.btnSifrelenmisMetinCoz.Click += new System.EventHandler(this.btnSifrelenmisMetinCoz_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(302, 280);
            this.Controls.Add(this.btnSifrelenmisMetinCoz);
            this.Controls.Add(this.btnMetinSifreleme);
            this.Name = "frmMenu";
            this.Text = "MENÜ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMetinSifreleme;
        private System.Windows.Forms.Button btnSifrelenmisMetinCoz;
    }
}

