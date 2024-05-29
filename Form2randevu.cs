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

    public partial class Form2randevu : Form
    {
        private string filePath = @"Randevular.txt";


        public Form2randevu()
        {
            InitializeComponent();
            LoadAppointments(); // Form yüklendiğinde randevuları yükle
        }
        private void LoadAppointments()
        {
            listBox1randevular.Items.Clear(); // Liste kutusunu temizle

            // Dosya var mı diye kontrol et
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Randevu dosyası bulunamadı.");
                return;
            }

            // Dosyadan randevuları oku ve liste kutusuna ekle
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    listBox1randevular.Items.Add(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form2randevu_Load(object sender, EventArgs e)
        {
            comboBox1islem.Items.Add("Saç Kesimi (350TL)");
            comboBox1islem.Items.Add("Saç Boyama (3000 TL)");
            comboBox1islem.Items.Add("Manikür (500 TL)");
            comboBox1islem.Items.Add("Pedikür (700 TL)");
            comboBox1islem.Items.Add("Solaryum 100 DK (2000 TL)");
            comboBox1islem.Items.Add("Maşa (1000 TL)");
            comboBox1islem.Items.Add("Masaj 60 DK (1000 TL)");
            comboBox1islem.Items.Add("Örgü (500 TL)");
            comboBox1islem.Items.Add("Oje (200TL)");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            // Tüm alanların doldurulduğunu kontrol et
            if (string.IsNullOrWhiteSpace(textBox1ad.Text) ||
                string.IsNullOrWhiteSpace(textBox2soyad.Text) ||
                string.IsNullOrWhiteSpace(textBox3yas.Text) ||
                string.IsNullOrWhiteSpace(textBox4tel.Text) ||
                comboBox1islem.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
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
            // Kullanıcıdan alınan bilgileri kullanarak yeni bir Randevu nesnesi oluşturun
            Randevu yeniRandevu = new Randevu
            {
                Cinsiyet = radioButton1erkek.Checked ? "Erkek" : "Kadın",
                Ad = textBox1ad.Text,
                Soyad = textBox2soyad.Text,
                Yas = int.Parse(textBox3yas.Text),
                TelefonNo = textBox4tel.Text,
                Islem = comboBox1islem.SelectedItem.ToString(),
                Tarih = dateTimePicker1tarih.Value




            };
            // Randevu bilgilerini bir string olarak hazırla
            string randevuBilgisi = $"{textBox1ad.Text},{textBox2soyad.Text},{(radioButton1erkek.Checked ? "Erkek" : "Kadın")},{textBox3yas.Text},{textBox4tel.Text},{comboBox1islem.SelectedItem.ToString()},{dateTimePicker1tarih.Value.ToString()}";
            // Verileri dosyaya yaz
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(randevuBilgisi);
                }

                MessageBox.Show("Randevu başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }



            // Kullanıcıyı bilgilendirin 
            MessageBox.Show("Randevu başarıyla ayarlandı!");
            // Yeni randevu ekledikten sonra liste kutusunu yeniden yükle
            LoadAppointments();

        }

        private void button2randevusil_Click(object sender, EventArgs e)
        {
            // Silinecek randevuyu al
            string selectedAppointment = listBox1randevular.SelectedItem.ToString();

            // Seçili bir randevu var mı diye kontrol et
            if (selectedAppointment != null)
            {
                // Listbox'tan seçili randevuyu sil
                listBox1randevular.Items.Remove(selectedAppointment);

                // Dosyadan seçili randevuyu sil
                try
                {
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    lines.Remove(selectedAppointment);
                    File.WriteAllLines(filePath, lines.ToArray());
                    MessageBox.Show("Randevu başarıyla silindi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz randevuyu seçin.");
            }
        }

        private void button2randevusil_Click_1(object sender, EventArgs e)
        {
            // Silinecek randevuyu al
            string selectedAppointment = listBox1randevular.SelectedItem.ToString();

            // Seçili bir randevu var mı diye kontrol et
            if (selectedAppointment != null)
            {
                // Listbox'tan seçili randevuyu sil
                listBox1randevular.Items.Remove(selectedAppointment);

                // Dosyadan seçili randevuyu sil
                try
                {
                    List<string> lines = File.ReadAllLines(filePath).ToList();
                    lines.Remove(selectedAppointment);
                    File.WriteAllLines(filePath, lines.ToArray());
                    MessageBox.Show("Randevu başarıyla silindi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Hata: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz randevuyu seçin.");
            }
        }

        private void button3randevuduzenle_Click(object sender, EventArgs e)
        {
            // Seçili randevuyu al
            string selectedAppointment = listBox1randevular.SelectedItem.ToString();

            // Seçili bir randevu var mı diye kontrol et
            if (selectedAppointment != null)
            {
                // Düzenlenecek randevuyu parçala
                string[] randevuBilgileri = selectedAppointment.Split(',');

                // Parçalanan bilgileri ilgili kontrol alanlarına yerleştir
                textBox1ad.Text = randevuBilgileri[0];
                textBox2soyad.Text = randevuBilgileri[1];
                if (randevuBilgileri[2] == "Erkek")
                    radioButton1erkek.Checked = true;
                else
                    radioButton2kadin.Checked = true;
                textBox3yas.Text = randevuBilgileri[3];
                textBox4tel.Text = randevuBilgileri[4];
                comboBox1islem.SelectedItem = randevuBilgileri[5];
                dateTimePicker1tarih.Value = DateTime.Parse(randevuBilgileri[6]);

                // Listbox'tan seçili randevuyu sil
                listBox1randevular.Items.Remove(selectedAppointment);

                MessageBox.Show("Randevu düzenleme moduna geçtiniz. Düzenledikten sonra Kaydet butonuna basmayı unutmayın.");
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz randevuyu seçin.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            // Düzenlenmiş randevu bilgilerini al
            string editedAppointment = $"{textBox1ad.Text},{textBox2soyad.Text},{(radioButton1erkek.Checked ? "Erkek" : "Kadın")},{textBox3yas.Text},{textBox4tel.Text},{comboBox1islem.SelectedItem.ToString()},{dateTimePicker1tarih.Value.ToString()}";

            // Verileri dosyaya yaz
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(editedAppointment);
                }

                MessageBox.Show("Randevu başarıyla kaydedildi!");

                // Düzenlenen randevuyu listbox'a ekle
                listBox1randevular.Items.Add(editedAppointment);

                // Temizleme işlemi
                textBox1ad.Text = "";
                textBox2soyad.Text = "";
                radioButton1erkek.Checked = false;
                radioButton2kadin.Checked = false;
                textBox3yas.Text = "";
                textBox4tel.Text = "";
                comboBox1islem.SelectedIndex = -1;
                dateTimePicker1tarih.Value = DateTime.Now;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }

         
        }
      
    }
}
    

