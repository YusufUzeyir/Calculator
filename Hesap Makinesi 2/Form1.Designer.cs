
namespace Hesap_Makinesi_2
{
    partial class Form1
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
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b0 = new System.Windows.Forms.Button();
            this.bNokta = new System.Windows.Forms.Button();
            this.bEkle = new System.Windows.Forms.Button();
            this.bCikar = new System.Windows.Forms.Button();
            this.bCarp = new System.Windows.Forms.Button();
            this.bBol = new System.Windows.Forms.Button();
            this.bEsit = new System.Windows.Forms.Button();
            this.bC = new System.Windows.Forms.Button();
            this.bCE = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lbSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(88, 83);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(80, 61);
            this.b7.TabIndex = 0;
            this.b7.Text = "7";
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.raklamOlay);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(182, 83);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(80, 61);
            this.b8.TabIndex = 0;
            this.b8.Text = "8";
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.raklamOlay);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(278, 83);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(80, 61);
            this.b9.TabIndex = 0;
            this.b9.Text = "9";
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.raklamOlay);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(88, 164);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(80, 61);
            this.b4.TabIndex = 0;
            this.b4.Text = "4";
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.raklamOlay);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(182, 164);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(80, 61);
            this.b5.TabIndex = 0;
            this.b5.Text = "5";
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.raklamOlay);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(278, 164);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(80, 61);
            this.b6.TabIndex = 0;
            this.b6.Text = "6";
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.raklamOlay);
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(88, 250);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(80, 61);
            this.b1.TabIndex = 0;
            this.b1.Text = "1";
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.raklamOlay);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(182, 250);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(80, 61);
            this.b2.TabIndex = 0;
            this.b2.Text = "2";
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.raklamOlay);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(278, 250);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(80, 61);
            this.b3.TabIndex = 0;
            this.b3.Text = "3";
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.raklamOlay);
            // 
            // b0
            // 
            this.b0.Location = new System.Drawing.Point(88, 336);
            this.b0.Name = "b0";
            this.b0.Size = new System.Drawing.Size(174, 61);
            this.b0.TabIndex = 0;
            this.b0.Text = "0";
            this.b0.UseVisualStyleBackColor = true;
            this.b0.Click += new System.EventHandler(this.raklamOlay);
            // 
            // bNokta
            // 
            this.bNokta.Location = new System.Drawing.Point(278, 336);
            this.bNokta.Name = "bNokta";
            this.bNokta.Size = new System.Drawing.Size(80, 61);
            this.bNokta.TabIndex = 0;
            this.bNokta.Text = ".";
            this.bNokta.UseVisualStyleBackColor = true;
            this.bNokta.Click += new System.EventHandler(this.bNokta_Click);
            // 
            // bEkle
            // 
            this.bEkle.Location = new System.Drawing.Point(374, 336);
            this.bEkle.Name = "bEkle";
            this.bEkle.Size = new System.Drawing.Size(80, 61);
            this.bEkle.TabIndex = 0;
            this.bEkle.Text = "+";
            this.bEkle.UseVisualStyleBackColor = true;
            this.bEkle.Click += new System.EventHandler(this.islemOlay);
            // 
            // bCikar
            // 
            this.bCikar.Location = new System.Drawing.Point(374, 250);
            this.bCikar.Name = "bCikar";
            this.bCikar.Size = new System.Drawing.Size(80, 61);
            this.bCikar.TabIndex = 0;
            this.bCikar.Text = "-";
            this.bCikar.UseVisualStyleBackColor = true;
            this.bCikar.Click += new System.EventHandler(this.islemOlay);
            // 
            // bCarp
            // 
            this.bCarp.Location = new System.Drawing.Point(374, 164);
            this.bCarp.Name = "bCarp";
            this.bCarp.Size = new System.Drawing.Size(80, 61);
            this.bCarp.TabIndex = 0;
            this.bCarp.Text = "x";
            this.bCarp.UseVisualStyleBackColor = true;
            this.bCarp.Click += new System.EventHandler(this.islemOlay);
            // 
            // bBol
            // 
            this.bBol.Location = new System.Drawing.Point(374, 83);
            this.bBol.Name = "bBol";
            this.bBol.Size = new System.Drawing.Size(80, 61);
            this.bBol.TabIndex = 0;
            this.bBol.Text = "/";
            this.bBol.UseVisualStyleBackColor = true;
            this.bBol.Click += new System.EventHandler(this.islemOlay);
            // 
            // bEsit
            // 
            this.bEsit.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bEsit.Location = new System.Drawing.Point(468, 250);
            this.bEsit.Name = "bEsit";
            this.bEsit.Size = new System.Drawing.Size(80, 147);
            this.bEsit.TabIndex = 0;
            this.bEsit.Text = "=";
            this.bEsit.UseVisualStyleBackColor = false;
            this.bEsit.Click += new System.EventHandler(this.bEsit_Click);
            // 
            // bC
            // 
            this.bC.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bC.Location = new System.Drawing.Point(468, 164);
            this.bC.Name = "bC";
            this.bC.Size = new System.Drawing.Size(80, 61);
            this.bC.TabIndex = 0;
            this.bC.Text = "C";
            this.bC.UseVisualStyleBackColor = false;
            this.bC.Click += new System.EventHandler(this.bC_Click);
            // 
            // bCE
            // 
            this.bCE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.bCE.Location = new System.Drawing.Point(468, 83);
            this.bCE.Name = "bCE";
            this.bCE.Size = new System.Drawing.Size(80, 61);
            this.bCE.TabIndex = 0;
            this.bCE.Text = "CE";
            this.bCE.UseVisualStyleBackColor = false;
            this.bCE.Click += new System.EventHandler(this.bCE_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSonuc.Location = new System.Drawing.Point(88, 44);
            this.txtSonuc.Multiline = true;
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(460, 33);
            this.txtSonuc.TabIndex = 1;
            // 
            // lbSonuc
            // 
            this.lbSonuc.AutoSize = true;
            this.lbSonuc.Location = new System.Drawing.Point(85, 24);
            this.lbSonuc.Name = "lbSonuc";
            this.lbSonuc.Size = new System.Drawing.Size(0, 17);
            this.lbSonuc.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 436);
            this.Controls.Add(this.lbSonuc);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.bBol);
            this.Controls.Add(this.bCE);
            this.Controls.Add(this.bC);
            this.Controls.Add(this.bCarp);
            this.Controls.Add(this.bCikar);
            this.Controls.Add(this.bEsit);
            this.Controls.Add(this.bEkle);
            this.Controls.Add(this.bNokta);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b0);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b7);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b0;
        private System.Windows.Forms.Button bNokta;
        private System.Windows.Forms.Button bEkle;
        private System.Windows.Forms.Button bCikar;
        private System.Windows.Forms.Button bCarp;
        private System.Windows.Forms.Button bBol;
        private System.Windows.Forms.Button bEsit;
        private System.Windows.Forms.Button bC;
        private System.Windows.Forms.Button bCE;
        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lbSonuc;
    }
}

