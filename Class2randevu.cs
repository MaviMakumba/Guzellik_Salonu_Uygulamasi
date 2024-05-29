using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneye_Dayali_Programlama_Proje
{
    public class Randevu
    {
        public string Cinsiyet { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string TelefonNo { get; set; }
        public string Islem { get; set; }
        public DateTime Tarih { get; set; }

        public override string ToString()
        {
            return $"{Cinsiyet}, {Ad} {Soyad}, {Yas}, {TelefonNo}, {Islem}, {Tarih.ToShortDateString()}";
        }
    }
}
