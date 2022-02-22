using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Mustafa","Güler",1234,"Yazılım Geliştirme");
            calisan1.CalisanBilgiler();

            Calisan calisan2 = new Calisan("Muhammet","Güler",123457,"Yazılım Uzmanı");
            calisan2.CalisanBilgiler();

            Calisan calisan3 = new Calisan("Hakan","Ozan");
            calisan3.CalisanBilgiler();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
        
        public Calisan()
        {

        }
        public void CalisanBilgiler()
        {
            Console.WriteLine("Çalışan Adı {0}",Ad);
            Console.WriteLine("Çalışan Soyadı {0}",Soyad);
            Console.WriteLine("Çalışan Numarası {0}",No);
            Console.WriteLine("Çalışan Departmanı {0}",Departman);
        }

    }
}

/*Bir sınıftan bir nesne oluşturulduğunda biz tanımlamasak bile arka planda çalışan varsayılan yapıcı metotlara kurucu yada constructor denir. Sınıf nesnesi ilk oluşturulduğunda yapılmasını istediğimiz işleri kurucu metotlar içerisinde yaparız.
*/