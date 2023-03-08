namespace KahveSatis
{
    partial class SatışEkranı
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SatışEkranı));
            this.numLatte = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numAmericano = new System.Windows.Forms.NumericUpDown();
            this.numEspresso = new System.Windows.Forms.NumericUpDown();
            this.numFiltre = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.rTxtEkran = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLatte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmericano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspresso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltre)).BeginInit();
            this.SuspendLayout();
            // 
            // numLatte
            // 
            this.numLatte.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numLatte.Location = new System.Drawing.Point(102, 43);
            this.numLatte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numLatte.Name = "numLatte";
            this.numLatte.Size = new System.Drawing.Size(60, 20);
            this.numLatte.TabIndex = 0;
            this.numLatte.ValueChanged += new System.EventHandler(this.valueChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cafe Latte";
            // 
            // numAmericano
            // 
            this.numAmericano.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numAmericano.Location = new System.Drawing.Point(102, 71);
            this.numAmericano.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numAmericano.Name = "numAmericano";
            this.numAmericano.Size = new System.Drawing.Size(60, 20);
            this.numAmericano.TabIndex = 0;
            this.numAmericano.ValueChanged += new System.EventHandler(this.valueChange);
            // 
            // numEspresso
            // 
            this.numEspresso.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numEspresso.Location = new System.Drawing.Point(102, 104);
            this.numEspresso.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numEspresso.Name = "numEspresso";
            this.numEspresso.Size = new System.Drawing.Size(60, 20);
            this.numEspresso.TabIndex = 0;
            this.numEspresso.ValueChanged += new System.EventHandler(this.valueChange);
            // 
            // numFiltre
            // 
            this.numFiltre.ForeColor = System.Drawing.Color.SaddleBrown;
            this.numFiltre.Location = new System.Drawing.Point(102, 139);
            this.numFiltre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numFiltre.Name = "numFiltre";
            this.numFiltre.Size = new System.Drawing.Size(60, 20);
            this.numFiltre.TabIndex = 0;
            this.numFiltre.ValueChanged += new System.EventHandler(this.valueChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Türk Kahvesi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Espresso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Latte";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 215);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Toplam";
            // 
            // txtToplam
            // 
            this.txtToplam.ForeColor = System.Drawing.Color.SaddleBrown;
            this.txtToplam.Location = new System.Drawing.Point(102, 211);
            this.txtToplam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.ReadOnly = true;
            this.txtToplam.Size = new System.Drawing.Size(52, 20);
            this.txtToplam.TabIndex = 2;
            this.txtToplam.Text = "0";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(217, 306);
            this.btnHesapla.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(78, 29);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(305, 306);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(78, 29);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(394, 306);
            this.btnYazdir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(78, 29);
            this.btnYazdir.TabIndex = 3;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // rTxtEkran
            // 
            this.rTxtEkran.ForeColor = System.Drawing.Color.SaddleBrown;
            this.rTxtEkran.Location = new System.Drawing.Point(180, 43);
            this.rTxtEkran.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rTxtEkran.Name = "rTxtEkran";
            this.rTxtEkran.Size = new System.Drawing.Size(298, 240);
            this.rTxtEkran.TabIndex = 4;
            this.rTxtEkran.Text = "";
            // 
            // SatışEkranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KahveSatis.Properties.Resources._69678850_a12a_4e51_bb7b_e3604e62a45a;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 355);
            this.Controls.Add(this.rTxtEkran);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numFiltre);
            this.Controls.Add(this.numEspresso);
            this.Controls.Add(this.numAmericano);
            this.Controls.Add(this.numLatte);
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SatışEkranı";
            this.Text = "Satış Ekranı";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLatte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmericano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEspresso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiltre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numLatte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numAmericano;
        private System.Windows.Forms.NumericUpDown numEspresso;
        private System.Windows.Forms.NumericUpDown numFiltre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.RichTextBox rTxtEkran;
    }
}