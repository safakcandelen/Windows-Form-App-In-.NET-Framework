namespace KahveSatis
{
    partial class FrmKahve
    {
       
        private System.ComponentModel.IContainer components = null;

        
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKahve));
            this.kullaniciIslemleriButon = new System.Windows.Forms.Button();
            this.urunIslemleriButon = new System.Windows.Forms.Button();
            this.cikisButon = new System.Windows.Forms.Button();
            this.satisIslemleriButon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // kullaniciIslemleriButon
            // 
            this.kullaniciIslemleriButon.AutoSize = true;
            this.kullaniciIslemleriButon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullaniciIslemleriButon.Location = new System.Drawing.Point(37, 157);
            this.kullaniciIslemleriButon.Name = "kullaniciIslemleriButon";
            this.kullaniciIslemleriButon.Size = new System.Drawing.Size(197, 63);
            this.kullaniciIslemleriButon.TabIndex = 3;
            this.kullaniciIslemleriButon.Text = "Kullanıcı İşlemleri";
            this.kullaniciIslemleriButon.UseVisualStyleBackColor = true;
            this.kullaniciIslemleriButon.Click += new System.EventHandler(this.kullaniciIslemleriButon_Click);
            // 
            // urunIslemleriButon
            // 
            this.urunIslemleriButon.AutoSize = true;
            this.urunIslemleriButon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urunIslemleriButon.Location = new System.Drawing.Point(253, 157);
            this.urunIslemleriButon.Name = "urunIslemleriButon";
            this.urunIslemleriButon.Size = new System.Drawing.Size(161, 63);
            this.urunIslemleriButon.TabIndex = 4;
            this.urunIslemleriButon.Text = "Ürün İşlemleri";
            this.urunIslemleriButon.UseVisualStyleBackColor = true;
            this.urunIslemleriButon.Click += new System.EventHandler(this.urunIslemleriButon_Click);
            // 
            // cikisButon
            // 
            this.cikisButon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisButon.Location = new System.Drawing.Point(429, 157);
            this.cikisButon.Name = "cikisButon";
            this.cikisButon.Size = new System.Drawing.Size(126, 63);
            this.cikisButon.TabIndex = 5;
            this.cikisButon.Text = "Çıkış";
            this.cikisButon.UseVisualStyleBackColor = true;
            this.cikisButon.Click += new System.EventHandler(this.cikisButon_Click);
            // 
            // satisIslemleriButon
            // 
            this.satisIslemleriButon.AutoSize = true;
            this.satisIslemleriButon.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.satisIslemleriButon.Location = new System.Drawing.Point(76, 157);
            this.satisIslemleriButon.Name = "satisIslemleriButon";
            this.satisIslemleriButon.Size = new System.Drawing.Size(158, 63);
            this.satisIslemleriButon.TabIndex = 6;
            this.satisIslemleriButon.Text = "Satış İşlemleri";
            this.satisIslemleriButon.UseVisualStyleBackColor = true;
            this.satisIslemleriButon.Click += new System.EventHandler(this.satisIslemleriButon_Click);
            // 
            // FrmKahve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::KahveSatis.Properties.Resources._69678850_a12a_4e51_bb7b_e3604e62a45a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.satisIslemleriButon);
            this.Controls.Add(this.cikisButon);
            this.Controls.Add(this.urunIslemleriButon);
            this.Controls.Add(this.kullaniciIslemleriButon);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmKahve";
            this.Text = "Admin Paneli";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmKahve_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kullaniciIslemleriButon;
        private System.Windows.Forms.Button urunIslemleriButon;
        private System.Windows.Forms.Button cikisButon;
        private System.Windows.Forms.Button satisIslemleriButon;
    }
}

