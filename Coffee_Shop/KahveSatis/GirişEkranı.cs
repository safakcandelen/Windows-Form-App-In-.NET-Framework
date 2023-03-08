using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace KahveSatis
{
    public partial class GirişEkranı : Form
    {
        public GirişEkranı()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int mode;
            String[] kullanıcıBilgiler=null;
            if (txtUserName.Text == "admin")
            {
                 kullanıcıBilgiler = adminGirisKontrol();
                mode = 1;

            } else
            {
                kullanıcıBilgiler = kullanıcıKontrol();
                mode = 2;
            }


            if ((kullanıcıBilgiler[0]==txtUserName.Text.Trim())&& (kullanıcıBilgiler[1] == txtParola.Text.Trim()))
            {
                FrmKahve anaFrm = new FrmKahve();
                anaFrm.Name = "frmKahve";
                if (mode ==1)
                    anaFrm.Text = "Admin Paneli";
                else
                    anaFrm.Text = "Kahve Satışı";

                if (Application.OpenForms["frmKahve"] == null)
                {
                    
                    anaFrm.Show();
                    anaFrm.setMode(mode);
                }
                this.Hide();
            } else
            {
                MessageBox.Show("Hatalı bir giriş yaptınız. Lütfen kullanıcı adınızı veya şifrenizi kontrol ediniz.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string [] adminGirisKontrol()
        {
            XDocument xDoc = XDocument.Load(@"..\..\admin.xml");
            

            XElement rootElement = xDoc.Root;
            
            String username="", password="";
            
            
            foreach (XElement kullanicilar in rootElement.Elements())
            {
               
                
                username = kullanicilar.Element("username").Value;
                password = kullanicilar.Element("password").Value;
               
               
            }

            String[] kullanıcıBilgiler = { username, password };

            return kullanıcıBilgiler;
        }

        private string[] kullanıcıKontrol()
        {
            XDocument xDoc = XDocument.Load(@"..\..\user.xml");
            
           
            XElement rootElement = xDoc.Root;
            

            String username = "", password = "";
            

            foreach (XElement kullanicilar in rootElement.Elements())
            {

                if (txtUserName.Text == kullanicilar.Element("username").Value)
                {
                    username = kullanicilar.Element("username").Value;
                    password = kullanicilar.Element("password").Value;
                }

              
            }

            String[] kullanıcıBilgiler = { username, password };

            return kullanıcıBilgiler;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
