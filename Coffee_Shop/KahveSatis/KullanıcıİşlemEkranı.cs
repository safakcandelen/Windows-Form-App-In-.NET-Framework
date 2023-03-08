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
    public partial class KullanıcıİşlemEkranı : Form
    {
        string sid;
        public KullanıcıİşlemEkranı()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!kayitli(txtUserName.Text))
            {
                int newId = Sabit.userCount;
                XDocument xDoc = XDocument.Load(@"..\..\user.xml");
                

                XElement rootElement = xDoc.Root;
                

                XElement newElement = new XElement("user");
                

                XAttribute idAttribute = new XAttribute("id", newId.ToString());
                

                XElement user = new XElement("username", txtUserName.Text);
                XElement pwd = new XElement("password", txtParola.Text);


                newElement.Add(idAttribute, user, pwd);

                rootElement.Add(newElement);

                xDoc.Save(@"..\..\user.xml");
                
                Sabit.userCount++;
                txtParola.Clear();
                txtUserName.Clear();
            } else
            {
                MessageBox.Show("Bu kullanıcı adı daha önce kaydedilmiştir. Lütfen farklı bir kullanıcı adı deneyiniz.", "Hata Mesajı" ,MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            listele();
            
        }

        private bool kayitli(String kisi)
        {
            bool durum = false;
            XDocument xDoc = XDocument.Load(@"..\..\user.xml");
            

            XElement rootElement = xDoc.Root;
            

            String username = "", password = "";
            

            foreach (XElement kullanicilar in rootElement.Elements())
            {

                if (txtUserName.Text == kullanicilar.Element("username").Value)
                {
                    durum = true;
                }


               
            }
            return durum;
        }

        private void listele()
        {
            XDocument xDoc = XDocument.Load(@"..\..\user.xml");
            

            XElement rootElement = xDoc.Root;
            

            String username = "", password = "", ID;
            
            listBox1.Items.Clear();
            foreach (XElement kullanicilar in rootElement.Elements())
            {

                ID = kullanicilar.Attribute("id").Value;
                username = kullanicilar.Element("username").Value;
                password = kullanicilar.Element("password").Value;

                listBox1.Items.Add(ID +  " " +username + " "+ password);

            }
        }

        private void setUserCount()
        {
            XDocument xDoc = XDocument.Load(@"..\..\user.xml");

            XElement rootElement = xDoc.Root;
            Sabit.userCount = rootElement.Elements().ToArray().Length;
            Console.WriteLine(Sabit.userCount);
        }

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            setUserCount();
            listele();

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            String kayit = listBox1.SelectedItem.ToString();
            String[] bilgiler = kayit.Split(' ');
            sid = bilgiler[0];
            txtUserName.Text = bilgiler[1];
            txtParola.Text = bilgiler[2];
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            XDocument xDoc = XDocument.Load(@"..\..\user.xml");
            

            XElement rootElement = xDoc.Root;
            

            foreach (XElement kullanicilar in rootElement.Elements())
            {
                if (kullanicilar.Attribute("id").Value == sid)
                
                {
                    kullanicilar.Remove();
                   
                }
            }
            xDoc.Save(@"..\..\user.xml");
            listele();
        }
    }
}
