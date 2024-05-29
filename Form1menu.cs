/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:PROJE ÖDEVİ
**				ÖĞRENCİ ADI............:EREN KARTAL
**				ÖĞRENCİ NUMARASI.......:B231210065
**              DERSİN ALINDIĞI GRUP...:1. ÖĞRETİM B GRUBU
****************************************************************************/


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
    public partial class Form1menu : Form
    {
        
        public Form1menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4islemler form4 = new Form4islemler();
            form4.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2randevu form2=new Form2randevu();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3calisanlar form3 = new Form3calisanlar();
            form3.Show();
        }
    }
}
