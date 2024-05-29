using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneye_Dayali_Programlama_Proje
{
    public partial class Form4islemler : Form
    {
        public Form4islemler()
        {
            InitializeComponent();
        }

        private void Form4islemler_Load(object sender, EventArgs e)
        {
            comboBox1secim.Items.Add("Saç Kesimi (350TL)");
            comboBox1secim.Items.Add("Saç Boyama (3000 TL)");
            comboBox1secim.Items.Add("Manikür (500 TL)");
            comboBox1secim.Items.Add("Pedikür (700 TL)");
            comboBox1secim.Items.Add("Solaryum 100 DK (2000 TL)");
            comboBox1secim.Items.Add("Maşa (1000 TL)");
            comboBox1secim.Items.Add("Masaj 60 DK (1000 TL)");
            comboBox1secim.Items.Add("Örgü (500 TL)");
            comboBox1secim.Items.Add("Oje (200TL)");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1secim.SelectedIndex)
            {
                //Saç Kesimi
                case 0:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    SacKesimi sacKesimi1= new SacKesimi();
                    textBox1secenek.Text = sacKesimi1.secenekler;
                    textBox2personel.Text=sacKesimi1.personel;
                    richTextBox1.Text = sacKesimi1.acıklama;
                    pictureBox1.Load(sacKesimi1.gorsel);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                    break;
                //Saç Boyama
                case 1:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    SacBoyama sacboyama1 = new SacBoyama();
                    textBox1secenek.Text = sacboyama1.secenekler;
                    textBox2personel.Text = sacboyama1.personel;
                    richTextBox1.Text = sacboyama1.acıklama;
                    pictureBox1.Load(sacboyama1.gorsel);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                //Manikür
                case 2:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Manikur manikur1 = new Manikur();
                    textBox1secenek.Text = manikur1.secenekler;
                    textBox2personel.Text = manikur1.personel;
                    richTextBox1.Text = manikur1.acıklama;
                    pictureBox1.Load(manikur1.gorsel);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                //Pedikür
                case 3:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Pedikur pedikur1 = new Pedikur();
                    textBox1secenek.Text = pedikur1.secenekler;
                    textBox2personel.Text = pedikur1.personel;
                    richTextBox1.Text = pedikur1.acıklama;
                    pictureBox1.Load(pedikur1.gorsel);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                //Solaryum
                case 4:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Solaryum solaryum1 = new Solaryum();
                    textBox1secenek.Text = solaryum1.secenekler;
                    textBox2personel.Text = solaryum1.personel;
                    richTextBox1.Text = solaryum1.acıklama;
                    pictureBox1.Load(solaryum1.gorsel);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                //Maşa
                case 5:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Masa masa1 = new Masa();
                    textBox1secenek.Text = masa1.secenekler;
                    textBox2personel.Text = masa1.personel;
                    richTextBox1.Text = masa1.acıklama;
                    pictureBox1.Load(masa1.gorsel);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                //Masaj
                case 6:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Masaj masaj1 = new Masaj();
                    textBox1secenek.Text = masaj1.secenekler;
                    textBox2personel.Text = masaj1.personel;
                    richTextBox1.Text = masaj1.acıklama;
                    pictureBox1.Load(masaj1.gorsel);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                //Örgü
                case 7:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Orgu orgu1 = new Orgu();
                    textBox1secenek.Text = orgu1.secenekler;
                    textBox2personel.Text = orgu1.personel;
                    richTextBox1.Text = orgu1.acıklama;
                    pictureBox1.Load(orgu1.gorsel);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                //Oje
                case 8:
                    pictureBox1.Invalidate();
                    pictureBox1.Refresh();
                    Oje oje1 = new Oje();
                    textBox1secenek.Text = oje1.secenekler;
                    textBox2personel.Text = oje1.personel;
                    richTextBox1.Text = oje1.acıklama;
                    pictureBox1.Load(oje1.gorsel);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
