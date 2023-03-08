using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KahveSatis
{
    public partial class FiyatDeğiştirme : Form
    {
        String sid;
        public FiyatDeğiştirme()
        {
            InitializeComponent();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            XDocument xDoc = XDocument.Load(@"..\..\urunler.xml");
            

            XElement rootElement = xDoc.Root;
            

            foreach (XElement urunler in rootElement.Elements())
            {

                if (urunler.Attribute("id").Value == sid)
                {
                    urunler.Element("fiyati").Value = txtFiyat.Text;
                    break;
                }
            }
            xDoc.Save(@"..\..\urunler.xml");
            
            listele();
            txtFiyat.Text = "";
            cmbUrun.Text = "";
        }

        private void listele()
        {
            XDocument xDoc = XDocument.Load(@"..\..\urunler.xml");
            

            XElement rootElement = xDoc.Root;
            

            String urun = "", fiyat = "", ID;
            cmbUrun.Items.Clear();
            foreach (XElement urunler in rootElement.Elements())
            
            {

                ID = urunler.Attribute("id").Value;
                urun = urunler.Element("urunadi").Value;
                fiyat = urunler.Element("fiyati").Value;

                cmbUrun.Items.Add(ID + " " + urun + " " + fiyat);

            }
        }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void cmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            String kayit = cmbUrun.SelectedItem.ToString();
            String[] bilgiler = kayit.Split(' ');
            sid = bilgiler[0];
            txtFiyat.Text = bilgiler[bilgiler.Length-1];
        }
    }
}
