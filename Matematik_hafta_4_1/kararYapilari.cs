using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_hafta_4_1
{
    class kararYapilari
    {
        static void Main(string[] args)
        {
            ternaryKullanımı();

            // ifelseifdeyim6();
            // ifelseifDeyim5();
            // ifelsedeyim4();
            // ifelsedeyimi3();
            // ifelseDeyimi2();
            // ifdeyimi1();

        }

        private static void ternaryKullanımı()
        {
            //ternary operatörü kullanımı...
            double ortalama = 55;

            //if(ortalama >=50)
            //    Console.WriteLine("geçti");
            //else
            //    Console.WriteLine("kaldı");


            Console.WriteLine((ortalama >= 50) ? "geçti" : "kaldı");
            string sonuc = (ortalama >= 50) ? "Geçti" : "Kaldı";
        }

        private static void ifelseifdeyim6()
        {
            //Örnek: Bu örnekte basit bir vergi hesabı programı geliştirmek istiyoruz.Gelir vergisinin aşağıdaki kurallara göre belirlendiğini varsayalım:

            double gelir = 4500;
            double netGelir = 0;
            double vergi;

            if (gelir <= 5000)
                vergi = gelir * .25;
            else if (gelir <= 8000)
                vergi = gelir * .30;
            else if (gelir <= 12000)
                vergi = gelir * .35;
            else
                vergi = gelir * .40;
            Console.WriteLine($"Vergi Tutarı : {vergi:C2}\nNet Gelir : {(gelir - vergi):C2}");
        }

        private static void ifelseifDeyim5()
        {
            int sicaklik = 125;
            // sicaklık <0 katı haldedir
            // sicaklık >100  gaz haldedir
            // sicaklık >0 ve <100  sıvı haldedir

            if (sicaklik < 0)
                Console.WriteLine("Su katı haldedir...");
            else if (sicaklik > 100)
                Console.WriteLine("Su gaz halindedir...");
            else if (sicaklik > 0 && sicaklik < 100)
                Console.WriteLine("Su sıvı haldedir...");
        }

        private static void ifelsedeyim4()
        {
            //Öğrencinin vize ve final notunu klavyeden aldıktan sonra ortalamasını hesaplayıp, Daha sonra; Final notu 50 ve üzeri ise ve ortalaması 60’ın üzerinde ise GEÇTİ, değilse KALDI yazacak bir C# programı.

            //string değişken yada ifadeleri sayıya dönüştürmek için Parse yöntemini kullanıyoruz. int.parse(string), double.parse(string), float.parse(string)
            //int x = int.Parse("125");
            //string str = "580";
            //double y = double.Parse(str);


            float vize, final, ortalama;
            Console.WriteLine("Vize Notu Giriniz:");
            vize = float.Parse(Console.ReadLine());

            Console.WriteLine("Final Notu Giriniz:");
            final = float.Parse(Console.ReadLine());

            ortalama = vize * .40f + final * .60f;

            if (ortalama >= 60 && final >= 50)
                Console.WriteLine($"Ortalamanız : {ortalama}\nSonuç : GEÇTİ");
            else
                Console.WriteLine($"Ortalamanız : {ortalama}\nSonuç : KALDI");
        }

        private static void ifelsedeyimi3()
        {
            // Örnek: Brüt Maaş tutarına göre aşağıda verilen tablodaki vergi kesintisini ve net maaşı hesaplayan programı yapın.
            //Açıklama: Brüt maaşı;
            // 10.000’den küçük veya eşitse % 10 vergi oranı,
            // değilse % 15 vergi oranı kabul ederek;

            //Not : hem vergi kesintisi hem de net gelir hesaplanacak...

            //double gelir = 15000;
            //double kesinti = 0;
            //double netGelir = 0;
            //double gelir, kesinti, netGelir;
            double gelir = 9000, kesinti = 0, netGelir = 0;

            if (gelir <= 10000) kesinti = gelir * .10;
            else kesinti = gelir * .15;

            netGelir = gelir - kesinti;
            Console.WriteLine($"Kesinti Tutarı :{kesinti}");
            Console.WriteLine($"Net Gelir :{netGelir}");
        }

        private static void ifelseDeyimi2()
        {
            // genel not ortalaması 3'ün üzerinde olanlara +4 kredi verilecek ve harç tutarı %50 azaltılacak
            //genel not ortalaması 2 ile 3 arasında olanlara ise +2 kredi verilecek. Harç tutarı eksiltilmeyecek
            float gno = 1.2f;// float yerine neden double yada decimal kullanmadık?
            int kredi = 24;
            float harcTutari = 850;

            if (gno >= 3)
            {
                kredi += 4;  //kredi = kredi +4;
                harcTutari /= 2;  // harcTutari = harcTutari / 2;
            }
            else //if bloğundaki koşul yanlış olursa burası çalışır
            {
                if (gno >= 2)
                    kredi += 2;
                else
                    Console.WriteLine("Ortalamanız 2'nin altında olduğundan dolayı krediniz artırılmadı...");
            }


            Console.WriteLine($"Yeni Krediniz : {kredi}\nÖdeyeceğiniz Harç Tutarı : {harcTutari}");
        }

        private static void ifdeyimi1()
        {
            // genel not ortalaması 3'ün üzerinde olanlara +4 kredi verilecek.

            float gno = 2.2f;// float yerine neden double yada decimal kullanmadık?
            int kredi = 24;
            float harcTutari = 850;
            if (gno >= 3)
            {
                kredi += 4;  //kredi = kredi +4;
                harcTutari /= 2;  // harcTutari = harcTutari / 2;
            }
            //   \n enter tuşu anlamına gelir. yani satır atlatır
            Console.WriteLine($"Yeni Krediniz : {kredi}\nÖdeyeceğiniz Harç Tutarı : {harcTutari}");
        }
    }
}
