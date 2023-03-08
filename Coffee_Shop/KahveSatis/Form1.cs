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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        int baslangicNoktasi = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            baslangicNoktasi += 2;
            progressBar1.Value = baslangicNoktasi;

            if (progressBar1.Value == 100)
            {
                progressBar1.Value = 0;
                timer1.Stop();
                GirişEkranı girişEkranı = new GirişEkranı();
                this.Hide();
                girişEkranı.Show();
            }
        }
    }
}
