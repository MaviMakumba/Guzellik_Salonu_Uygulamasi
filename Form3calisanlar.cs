using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nesneye_Dayali_Programlama_Proje
{
    public partial class Form3calisanlar : Form
    {
        private string filePath = @"Çalışanlar.txt";
        public Form3calisanlar()
        {
            InitializeComponent();
            LoadAppointments(); // Form yüklendiğinde çalışanları yükle
        }
        private void LoadAppointments()
        {
            listBox1calisanlar.Items.Clear(); // Liste kutusunu temizle

            // Dosya var mı diye kontrol et
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Çalışan dosyası bulunamadı.");
                return;
            }

            // Dosyadan çalışanları oku ve liste kutusuna ekle
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    listBox1calisanlar.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tüm alanların doldurulduğunu kontrol et
            if (string.IsNullOrWhiteSpace(textBox1ad.Text) ||
                string.IsNullOrWhiteSpace(textBox2soyad.Text) ||
                string.IsNullOrWhiteSpace(textBox3yas.Text) ||
                string.IsNullOrWhiteSpace(textBox4tel.Text) ||
                string.IsNullOrWhiteSpace(textBox5adres.Text) ||
                comboBox1gorev.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(textBox7maas.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }
            // Maaşın sadece rakamlardan oluşup oluşmadığını kontrol et (Maaş Tl kurunda verilmektedir)
            if (!long.TryParse(textBox7maas.Text, out _))
            {
                MessageBox.Show("Maaş sadece rakamlardan oluşmalıdır. (Maaşlar Tl bazında verilmektedir)");
                return;
            }
            // Telefon numarasının sadece rakamlardan oluşup oluşmadığını kontrol et
            if (!long.TryParse(textBox4tel.Text, out _))
            {
                MessageBox.Show("Telefon numarası sadece rakamlardan oluşmalıdır.");
                return;
            }

            // Telefon numarasının 10 haneli olup olmadığını kontrol et
            if (textBox4tel.Text.Length != 10)
            {
                MessageBox.Show("Telefon numarası 10 haneli olmalıdır.");
                return;
            }

            // Yaşın geçerli bir sayı olup olmadığını kontrol et
            if (!int.TryParse(textBox3yas.Text, out int yas))
            {
                MessageBox.Show("Geçerli bir yaş girin.");
                return;
            }
            //Ad Kontrolü
            if (string.IsNullOrWhiteSpace(textBox1ad.Text) || textBox1ad.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Ad kısmına geçerli bir isim girin.");
                return;
            }
            //Soyad Kontrolü
            if (string.IsNullOrWhiteSpace(textBox2soyad.Text) || textBox2soyad.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Soyad kısmına geçerli bir soyisim girin.");
                return;
            }

            // Kullanıcıdan alınan bilgileri kullanarak yeni bir çalışan nesnesi oluşturun
            Calisan yeniCalisan = new Calisan
            {
                Cinsiyet = radioButton1erkek.Checked ? "Erkek" : "Kadın",
                Ad = textBox1ad.Text,
                Soyad = textBox2soyad.Text,
                Yas = int.Parse(textBox3yas.Text),
                TelefonNo = textBox4tel.Text,
                Adres = textBox5adres.Text,
                Gorev = comboBox1gorev.SelectedItem.ToString(),
                Maas=int.Parse(textBox7maas.Text)




            };
            // Çalışan bilgilerini bir string olarak hazırla
            string calisanBilgisi = $"{textBox1ad.Text},{textBox2soyad.Text},{(radioButton1erkek.Checked ? "Erkek" : "Kadın")},{textBox3yas.Text},{textBox4tel.Text},{textBox5adres.Text},{comboBox1gorev.SelectedItem.ToString()},{textBox7maas.Text}";
            // Verileri dosyaya yaz
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(calisanBilgisi);
                }

                MessageBox.Show("Çalışan başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }



            // Kullanıcıyı bilgilendirin 
            MessageBox.Show("Çalışan başarıyla ayarlandı!");
            // Yeni çalışan ekledikten sonra liste kutusunu yeniden yükle
            LoadAppointments();
        }
       
        private void button1sil_Click(object sender, EventArgs e)
        {
            // Seçili çalışanı al
            string selectedAppointment3 = listBox1calisanlar.SelectedItem.ToString();

            // Seçili bir çalışan var mı diye kontrol et
            if (selectedAppointment3 != null)
            {
                // Düzenlenecek çalışanı parçala
                string[] CalisanBilgileri = selectedAppointment3.Split(',');

                // Parçalanan bilgileri ilgili kontrol alanlarına yerleştir
                textBox1ad.Text = CalisanBilgileri[0];
                textBox2soyad.Text = CalisanBilgileri[1];
                if (CalisanBilgileri[2] == "Erkek")
                    radioButton1erkek.Checked = true;
                else
                    radioButton2kadin.Checked = true;
                textBox3yas.Text = CalisanBilgileri[3];
                textBox4tel.Text = CalisanBilgileri[4];
                textBox5adres.Text = CalisanBilgileri[5];
                comboBox1gorev.SelectedItem = CalisanBilgileri[6];
                textBox7maas.Text = CalisanBilgileri[7];


                // Listbox'tan seçili çalışanı sil
                listBox1calisanlar.Items.Remove(selectedAppointment3);

                MessageBox.Show("Çalışan düzenleme moduna geçtiniz. Düzenledikten sonra Kaydet butonuna basmayı unutmayın.");
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz çalışanı seçin.");
            }
        }

        private void button2düzenle_Click(object sender, EventArgs e)
        {
            // Silinecek çalışanı al
            string selectedAppointment2 = listBox1calisanlar.SelectedItem.ToString();

            // Seçili bir çalışan var mı diye kontrol et
            if (selectedAppointment2 != null)
            {
                // Listbox'tan seçili çalışanı sil
                listBox1calisanlar.Items.Remove(selectedAppointment2);

                // Dosyadan seçili çalışanı sil
                try
                {
                    List<string> lines2 = File.ReadAllLines(filePath).ToList();
                    lines2.Remove(selectedAppointment2);
                    File.WriteAllLines(filePath, lines2.ToArray());
                    MessageBox.Show("Çalışan başarıyla silindi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz çalışanı seçin.");
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Düzenlenmiş çalışan bilgilerini al
            string editedAppointment2 = $"{textBox1ad.Text},{textBox2soyad.Text},{(radioButton1erkek.Checked ? "Erkek" : "Kadın")},{textBox3yas.Text},{textBox4tel.Text},{textBox5adres.Text},{comboBox1gorev.SelectedItem.ToString()},{textBox7maas.Text}";

            // Verileri dosyaya yaz
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(editedAppointment2);
                }

                MessageBox.Show("Çalışan başarıyla kaydedildi!");

                // Düzenlenen çalışanı listbox'a ekle
                listBox1calisanlar.Items.Add(editedAppointment2);

                // Temizleme işlemi
                textBox1ad.Text = "";
                textBox2soyad.Text = "";
                radioButton1erkek.Checked = false;
                radioButton2kadin.Checked = false;
                textBox3yas.Text = "";
                textBox4tel.Text = "";
                textBox5adres.Text = "";
                textBox7maas.Text = "";
                textBox7maas.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }


        }

        private void Form3calisanlar_Load(object sender, EventArgs e)
        {
            comboBox1gorev.Items.Add("Saç Kesim-Boya");
            comboBox1gorev.Items.Add("Tırnak Bakımı");
            comboBox1gorev.Items.Add("Masör");
            comboBox1gorev.Items.Add("Solaryum Uzmanı");
            comboBox1gorev.Items.Add("Saç Bakımı Uzmanı");
        }
    }
}
