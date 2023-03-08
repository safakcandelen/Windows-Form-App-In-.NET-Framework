using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KahveSatis
{
    public partial class SatışEkranı : Form
    {
        Dictionary<string, string> menu = new Dictionary<string, string>();

        public SatışEkranı()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            int adet, fiyat,tutar;
            string sfiyat;
            int toplamTutar=0;
            rTxtEkran.AppendText("Ürün Adı \t\t Adet \t Fiyat \t Tutar");
            rTxtEkran.AppendText("\n\n");

            if (numLatte.Value>0)
            {
                adet = (int) numLatte.Value;
              
               sfiyat = menu["Cafe Latte"];
                
                fiyat = Convert.ToInt32(sfiyat);
                tutar = adet * fiyat;
                rTxtEkran.AppendText("\nCafe Latte \t" +adet+ "\t "+ fiyat + "\t"+ tutar);
                toplamTutar += tutar;
            }
            if (numAmericano.Value > 0)
            {
                adet = (int)numAmericano.Value;
              
                sfiyat = menu["Türk Kahvesi"];

                fiyat = Convert.ToInt32(sfiyat);
                tutar = adet * fiyat;
                rTxtEkran.AppendText("\nTürk Kahvesi \t" + adet + "\t " + fiyat + "\t" + tutar);
                toplamTutar += tutar;
            }
            if (numEspresso.Value > 0)
            {
                adet = (int)numEspresso.Value;

                sfiyat = menu["Espresso"];

                fiyat = Convert.ToInt32(sfiyat);
                tutar = adet * fiyat;
                rTxtEkran.AppendText("\nEspresso \t\t" + adet + "\t " + fiyat + "\t" + tutar);
                toplamTutar += tutar;
            }

            if (numFiltre.Value > 0)
            {
                adet = (int)numFiltre.Value;

                sfiyat = menu["Latte"];

                fiyat = Convert.ToInt32(sfiyat);
                tutar = adet * fiyat;
                rTxtEkran.AppendText("\nLatte \t\t" + adet + "\t " + fiyat + "\t" + tutar);
                toplamTutar += tutar;
            }

            rTxtEkran.AppendText("\n\n\n\n\t\t\t Toplam :" + toplamTutar + "TL");

        }

        private void valueChange(object sender, EventArgs e)
        {
            NumericUpDown num = (NumericUpDown)sender;
            int total = (int)(numLatte.Value + numAmericano.Value + numEspresso.Value + numFiltre.Value);
            txtToplam.Text  = total.ToString();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            numLatte.Value = 0;
            numFiltre.Value = 0;
            numAmericano.Value = 0;
            numEspresso.Value = 0;
            rTxtEkran.Clear();
        }

        private void menuAl()
        {
            XDocument xDoc = XDocument.Load(@"..\..\urunler.xml");
            

            XElement rootElement = xDoc.Root;
            

            String urun = "", fiyat = "", ID;
           

            foreach (XElement urunler in rootElement.Elements())
            
            {

                ID = urunler.Attribute("id").Value;
                urun = urunler.Element("urunadi").Value;
               
                fiyat = urunler.Element("fiyati").Value;

                menu.Add(urun, fiyat);
               

               
            }
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            menuAl();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {

            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("Custom", 600, 500);
            printDocument1.PrintPage += new PrintPageEventHandler(this.PrintDocument_PrintPage);
            PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();
            printPreviewDialog1.Document = printDocument1;
            DialogResult result = printPreviewDialog1.ShowDialog();
            if (result == DialogResult.OK)
                printDocument1.Print();
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rTxtEkran.Text, new Font(rTxtEkran.Font.ToString(), rTxtEkran.Font.Size), System.Drawing.Brushes.Red, 66, 50);
        }
    }
}
