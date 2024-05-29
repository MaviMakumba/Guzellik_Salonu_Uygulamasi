using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nesneye_Dayali_Programlama_Proje
{
    public class Class1islemler
    {
        public string isim { get; set; }
        public string secenekler { get; set; }
        public string personel { get; set; }
        public string acıklama { get; set; }
        public string gorsel { get; set; }

        public Class1islemler(string ism,string sec,string person,string acik,string gor)
        {
            this.isim = ism;
            this.secenekler = sec;
            this.personel = person;
            this.acıklama = acik;
            this.gorsel = gor;
        }
    }

    public class SacKesimi:Class1islemler
    {
        public SacKesimi()
            :base("Saç Kesimi","Standart Kesim, Kısa Kesim, Katlı Kesim", "Eren Kartal, Alaaddin Tokgöz",
                 "Bu salonu açmamıza sebep olan yegane hizmet.\nHala aradığınız o kesimi bulamadınız mı ? Merak etmeyin, biz buradayız. Size en yakışan saç kesimleri ve kaliteli malzemelerimiz ile 7/24 hizmetinizdeyiz.",
                 "image\\kesim.jpg")
        {
            
        }
    }

    public class SacBoyama : Class1islemler
    {
        public SacBoyama()
            : base("Saç Boyama", "Tam Boyama, Dip Boyama, Balyaj", "Alaaddin Tokgöz, Mazlum Yanılmaz", "Yıllardır o renkten bıkmadınız mı ?\nFarklı şeyler denemeye ne dersiniz. Bize güvenebilirsiniz. Sadece Kuaför Vedat içeriğinde bulunan 50 farklı boya çeşitiyle saçlarınız öncekinden daha parlak görünecek", "image\\boyama.jpg")
        {

        }
    }

    public class Manikur : Class1islemler
    {
        public Manikur()
            : base("Manikür", "Klasik Manikür, Kuru Manikür, Fransız Manikürü", "İrem Kartal", "El tırnaklarınız hiç de istediğiniz gibi durmuyor mu ?\n Hem estetik hem de sağlıklı çözümler için doğru yerdesiniz. Birkaç seanslık derinlikli çözümler ve tek seanslık hızlı mı hızlı ani çözümler ile artık tırnaklarınızı saklamak zorunda kalmayacaksınız.", "image\\manikür.jpg")
        {

        }
    }

    public class Pedikur : Class1islemler
    {
        public Pedikur()
            : base("Pedikür", "Standart Pedikür, Keratin Pedikür, Medikal Pedikür", "İrem Kartal", "Pediküre ne gerek var diyenlere kulak asmayın. Bu her insanın en doğal hakkı ve ihtiyacıdır. Herkes bakımlı olmak ister. Kaliteli Pedikür Hizmetlerimiz ile Karşınızdayız. Bekleriz", "image\\pedikür.jpg")
        {

        }
    }

    public class Solaryum : Class1islemler
    {
        public Solaryum()
            : base("Solaryum", "10 Dk, 30 Dk, 60 Dk", "Emma Stone", "Bu yaz izin hakkınız mı bitti ? Tatil yeri mi bulamadınız ? Evinize güneş mi vurmuyor ? Üzülmeyin. Bu sorunu da BİZ ÇÖZERİZ. Doğal güneş ışığı aydınlatmalar ile kusursuz bir cilt artık hiç uzak değil. 10 dakika ila 100 dakika arası değişen seans sürelerimiz ile artık EN BRONZ SİZ OLACAKSINIZ!", "image\\solaryum.jpg")
        {

        }
    }

    public class Masaj : Class1islemler
    {
        public Masaj()
            : base("Masaj", "İsveç Masajı, Hint Masajı, Spiritüel Masaj", "Ersoy Kartal, Fatim Nebarroyeav Elmiskinskı", "Sırt ağrıları, boyun ağrıları, bel fıtığı, skolyoz, duruş bozukluğu hatta ALZHEIMER... Hepsinin çözümü bir çift sağlıklı ele bakar. Uzman masörlerimiz ile uzak doğu masajlarından isveç masajına kadar envai çeşit masaj için adresimizi biliyorsunuz. Yine bekleriz...", "image\\masaj.jpg")
        {

        }
    }

    public class Masa : Class1islemler
    {
        public Masa()
            : base("Maşa", "Dalgalı, Düz, Bukle", "Gönül İşleyen, Hayati Başıbüyük", "Herkes kendi başına en iyi maşayı yapabilir. Ama hepimizin bunun için zamanı olmayabilir. Merak etmeyin çözüm çok basit. KUAFÖR VEDAT. Kaliteli maşa hizmeti ile sağlıklı ve havalı saçlar.", "image\\maşa.jpg")
        {

        }
    }

    public class Orgu : Class1islemler
    {
        public Orgu()
            : base("Örgü", "Balık Sırtı, Mısır Örgü, Fransız Örgü", "Gönül İşleyen, Hayati Başıbüyük", "Saçınıza annenizin örmesi aratmayan bir örgü. Bu işin duayeni uzmanlarımız tarafından narin saçlarınıza hafif eller tarafından muhteşem örgüler. Çekinmeyin, bekleriz.", "image\\örgü.jpg")
        {

        }
    }

    public class Oje : Class1islemler
    {
        public Oje()
            : base("Oje", "Standart Oje, Jel Oje, Kalıcı Oje", "İrem Kartal", "Tırnaklarınızın boş kalmasından sıkıldınız mı ? İşte size karar vermekte zor anlar yaşayacağınız kadar çeşit içeren oje envanterimiz. Parlak - mat, açık - koyu, kalıcı - geçici bir çok model burada. Kaçırmayın...", "image\\oje.jpeg")
        {

        }
    }


}
