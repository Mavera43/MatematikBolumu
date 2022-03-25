using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematilk_Hafta_6_1
{
    class fordongusuveTarih
    {
        //DateTime dateTime = DateTime.Now;
        //Console.WriteLine(dateTime);
        //    dateTime = DateTime.Today;
        //    Console.WriteLine(dateTime.AddDays(1));
        static void Main(string[] args)
        {
            //işe BAŞLANGIÇ ve bitiş tarihlerini aldıktan sonra hafta içi çalışma günlerini belirleyip
            //günlük yevmiye ücretiyle birlikte toplam ödeyeceğimiz ücreti hesaplayan C# kodu yazalım
            //cumartesi ve pazar günleri için ödeme yapılmayacak. saturday ve sunday için
            double toplamUcret = 0;
            int isGunleri = 0;
            double yevmiye = 100;

            //Console.WriteLine("İşe başlama tarihi nedir?");
            //DateTime startDate = DateTime.Parse(Console.ReadLine());//klavyeden değer okumayı sağlar ve enter
            //                                                        //tuşuna basınca girilen değeri değişkene aktarır.

            //Console.WriteLine("İşten ayrılış tarihi nedir?");
            //DateTime endDate =DateTime.Parse( Console.ReadLine());

             for (DateTime d = DateTime.Parse("1/03/2022"); d < DateTime.Parse("25/03/2022");  d=d.AddDays(1) )
           // for (DateTime d = startDate; d <= endDate; d=d.AddDays(1))
            {
                 if(d.DayOfWeek==DayOfWeek.Saturday || d.DayOfWeek==DayOfWeek.Sunday)
                {//bu blok hafta sonu günler oluyor
                    Console.WriteLine($"{d.ToString("dd/MM/yyyy dddd"),-35}|{"-",10:C0}");
                }
                 else
                { //bu blok hafta içi günler olmuş oluyor. isgunlerini ve toplamUcret burada artıracağız
                    isGunleri++;
                    toplamUcret += yevmiye; // toplamUcret= toplamUcret + yevmiye;
                    Console.WriteLine($"{d.ToString("dd/MM/yyyy dddd"),-35}|{toplamUcret,10:C0}");
                }
            }
            Console.WriteLine("\n\n\nÇalıştığı gün sayısı :{0}\nAlacağı ücret : {1:C0}",isGunleri,toplamUcret);

        }
    }
}
