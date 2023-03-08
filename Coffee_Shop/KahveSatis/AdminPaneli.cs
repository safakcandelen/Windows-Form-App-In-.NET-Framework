using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KahveSatis
{
    public partial class FrmKahve : Form
    {
        public FrmKahve()
        {
            InitializeComponent();
        }

       

        

        private void kullaniciIslemleriButon_Click(object sender, EventArgs e)
        {
            KullanıcıİşlemEkranı kullaniciFrm = new KullanıcıİşlemEkranı();
            kullaniciFrm.Name = "frmKullanici";
            kullaniciFrm.Text = "Kullanici İşlemleri";
            if (Application.OpenForms["frmKullanici"] == null)
            {

                kullaniciFrm.Show();

            }
        }

        private void satisIslemleriButon_Click(object sender, EventArgs e)
        {
            SatışEkranı satisFrm = new SatışEkranı();
            satisFrm.Name = "frmSatis";
            satisFrm.Text = "Satış İşlemleri";
            if (Application.OpenForms["frmSatis"] == null)
            {

                satisFrm.Show();

            }
        }

        private void urunIslemleriButon_Click(object sender, EventArgs e)
        {
            FiyatDeğiştirme urunFrm = new FiyatDeğiştirme();
            urunFrm.Name = "frmUrunler";
            urunFrm.Text = "Ürün İşlemleri";
            if (Application.OpenForms["frmUrunler"] == null)
            {

                urunFrm.Show();

            }
        }

        private void cikisButon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FrmKahve_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        

        public void setMode(int adminmode)
        {
            if (adminmode == 1)
            {
                kullaniciIslemleriButon.Enabled = true;
                kullaniciIslemleriButon.Visible= true;
                urunIslemleriButon.Enabled=true;
                urunIslemleriButon.Visible = true;
                satisIslemleriButon.Enabled = false;
                satisIslemleriButon.Visible = false;
            }
            if (adminmode == 2)
            {
                kullaniciIslemleriButon.Enabled = false;
                kullaniciIslemleriButon.Visible = false;
                urunIslemleriButon.Enabled = false;
                urunIslemleriButon.Visible = false;
                satisIslemleriButon.Enabled = true;
                satisIslemleriButon.Visible = true;
            }
        }

        

        
    }
}
