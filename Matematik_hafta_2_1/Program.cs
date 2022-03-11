using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_hafta_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler ve değişken tanımlama -- Veri tipleri
            string str;
            // değişkeni kullanabilmek için bir değer atanması gerekir
            str = "merhaba";
            Console.WriteLine(str);
            //--------------
            string str2 = "";
            string str3 = "Merhaba Kütahya";
            string str4, str5, str6;
            //--------------
            int intVal = 10;
            // int 1intVal = 25;//değişken isinmleri rakamla başlayamaz. Hata oluşur.

            // aynı isimle birden fazla değişken tanımlanamaz. Büyük/küçük harf duyarlılığı vardır. b1 ile B1 iki farklı değişkendir
            byte b1 = 25;
            byte B1 = 50;
            b1 = 89;
            // B1 = 741; // hata sebebi : byte tipi değişkenle 0-255 arası değer alabilir.
            B1 = 255;
            Console.WriteLine($"b1'in değeri: {b1} \nB1'in değeri: {B1}");

            //Önceden tanımlı bir değişken adı tekrar kullanılamaz
            // long intVal = 80;  //intVal daha önce tanımlandığı için hata oluşur.
            int _intVal = 99;
            _intVal = 101;

            //    sbyte sb = 128; //bir değişkene türünün alabileceği değerden büyük bir değer atanamaz. sbyte tipi -128 ile +127 arasında bir değer alır.
            //------------------------------

            // ondalıklı veriler için değişken tipleri
            float f1;
            // f1 = 78.965; hatalı değer atama. Çünkü sayının sonuna f eki yazılmamış.Doğrusu aşağıdadır.
            f1 = 78.965f;  //büyük F de kullanılabilir

            double d1 = 999.89d;  //d eki zorunlu değil

            d1 = 87;

            int s1 = 40;
            int s2 = 3;

            // int verilerin işlem sonucu yine int olur. İşlem sonucu ondalıklı olsa bile.
          //  int sonuc = Convert.ToInt32((double)s1 / s2);
            //yukarıki satırda int sonuc yerine double sonuc olmalı. Aşağıdaki gibi
            double sonuc = Convert.ToInt32((double)s1 / s2);
            Console.WriteLine($"işlemin tipi :{ (s1 / s2).GetType()}");
           
            Console.WriteLine($"İşlem SOnucu :{sonuc}");
            //decimal değişkenler 25 adet noktadan sonra değer alır. daha fazla girilmişse yuvarlar
            //decimal değişkene veri aktarırken değerin sonuna m yad M eklenir
            decimal de1 = 7920.789455662233222331214567896442454554514455m;
            Console.WriteLine(de1);
            string mesaj1 = "merhaba";
            string mesaj2 = "Hello";
            // mantıksal değişken tanımlama
            bool bol1 = true;
            bool bol2 = 5 > 9;  //false
            bool bol3 = (10 * 2) == 20; //true
            bool bol4 = mesaj1 == mesaj2;

            char a ='g'; //Dikkat: char tipi değişkenlere tek tırnak kullanarak atama yapılır.
            a = 'e';
            string b = "deneme"; // Dikkat : string tipi değişkenlere çift tırnak kullanarak atama yapılır.
            s1 = 25;
            string c = a + b + "Viki" +'m'+s1;
            Console.WriteLine(c);

            int s9 = 10;
            decimal s10 = 33;
            string s5 = "80";  //buradaki 80 değeri sayı değil metindir.Çünkü çift tırnak içinde
            c = s9 + s5 + s10 + s1  ;
            Console.WriteLine("----------------");
            Console.WriteLine(c);
            Console.WriteLine(c.GetType());
            //--------------------
            //rakamları binlik ayraçları ile yazdırma, yada virgülden sonra kaç rakam olacapğını belirleme

            s10 = 784542.589871m;
            Console.WriteLine($"s10 değeri : {s10}");
            Console.WriteLine($"s10 değeri : {s10:N5}");

















        }
    }
}
