using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneye_Dayali_Programlama_Proje
{
    internal class Calisan
    {
        public string Cinsiyet { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }
        public string Gorev { get; set; }
        public int Maas { get; set; }

        public override string ToString()
        {
            return $"{Cinsiyet}, {Ad} {Soyad}, {Yas}, {TelefonNo},{Adres},{Gorev},{Maas}";
        }
    }
}
