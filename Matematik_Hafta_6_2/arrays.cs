using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_Hafta_6_2
{
    class arrays
    {
        static void Main(string[] args)
        {
            //array dizi = bir değişken içinde 1den fazla değer saklamayı sağlayan bir yapı
            //değikenin bir tipi vardır. 
            //köşeli parantezler değişkenin dizi olduğunu yani içinde birden fazla değer saklanacağını ifade eder.
            //diziler belirtilen kadar hücreden oluşur ve her bir hücrenin bir indis numarası vardır. indis numaraları sıfırdan başlar.
            string dersadi= "Bilgisayar Programlamaya Giriş";
            string[] ad = new string[6] {"ahmet","mehmet","dilek","rabia","abdulkadir","kübra Nur" };
            double[] vize = { 45, 87.5, 90, 100, 25, 80.50 }; //6 elemanlı bir dizi tanımladık.
            double[] final = new double[6];
            //dizi değişkenlerine değer atama
            final[0] = 75;
            final[1] = 45;
            final[5] = 78;
            final[3] = 90;
            final[2] = 25;
            // dizi elemanlarına erişim.

            Console.WriteLine(ad[0]);
            Console.WriteLine(vize[0]);
            Console.WriteLine(final[0]);

            Console.WriteLine(ad[2]);
            Console.WriteLine(vize[2]);
            Console.WriteLine(final[2]);

            Console.WriteLine("ad dizi değişkeninin eleman sayısı : "+ad.Length);

            Console.WriteLine("------------------");
            // aşağıdaki satırlarda 6. indise erişim yapılmak istendiğinden dolayı "System.IndexOutOfRangeException: Dizin, dizi sınırlarının dışındaydı." hatasını alırız. çünkü 6. indis yok.
            //Console.WriteLine(ad[6]);
            //Console.WriteLine(vize[6]);
            //Console.WriteLine(final[6]);

            Console.WriteLine("------for döngüsü-----");
            //dizinin tüm elemanlarına nasıl erişilir(for veya foreach döngüsü)
            Console.WriteLine("Ad Soyad\tVize Notu\tFinal Notu");
            for (int i = 0; i < ad.Length; i++)
            {
                Console.WriteLine($"{ad[i],-15}\t{vize[i],8:N2}\t{final[i],8:N2}");
            }
            Console.WriteLine("------foreach döngüsü-----");
            foreach (var item in ad)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();



         


       

        }
    }
}
