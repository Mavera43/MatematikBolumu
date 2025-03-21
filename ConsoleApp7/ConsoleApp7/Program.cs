using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
      

        static void nothesapla()
        {
            Console.WriteLine("Notlar ve Geçme durumu");
        id:
            Console.Write("Öğrenci No:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 0)
            { Console.WriteLine("Girilen sayı sıfır");
                goto id;
            }

        //3 ders için notları al
        Math:
            Console.Write("Matematik dersi notu :");
            int m = Convert.ToInt32(Console.ReadLine());
            if (m < 0 || m > 100)
            {
                Console.WriteLine("Not 0-100 arasında olmalıdır");
                goto Math;
            }
        Physics:
            Console.Write("Fizik dersi notu:");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p < 0 || p > 100)
            {
                Console.WriteLine("Not 0-100 arasında olmalıdır");
                goto Physics;
            }
        Chemistry:
            Console.Write("Kimya dersi notu:");
            int c = Convert.ToInt32(Console.ReadLine());
            if (c < 0 || c > 100)
            {
                Console.WriteLine("Not 0-100 arasında olmalıdır");
                goto Chemistry;
            }

            int total = m + p + c;
            double avg = (double)total / 3;
            Console.WriteLine($"Notların toplamı:{total}");
            Console.WriteLine($"Notların ortalaması:{avg}");

            string result = string.Empty; string grade = string.Empty;
            if (m >= 35 && p >= 35 && c >= 35)
            {
                result = "geçti";
                if (avg >= 75) grade = "A+";
                else if (avg >= 60) grade = "A";
                else if (avg >= 50) grade = "B";
                else grade = "C";

            }
            else
            {
                result = "başarısız";
                grade = "NA";

            }
            Console.WriteLine($"Sonuç : {result}, Geçme Notu:{grade}");
        }


        static void tarihIFELSE()
        {
            //Dilekleri zamana göre göster
            int hour = DateTime.Now.Hour; //şu anki saati al
            if (hour < 12) Console.WriteLine("Günaydın");
            else if (hour < 16) Console.WriteLine("Tünaydın");
            else Console.WriteLine("İyi akşamlar");

            string day = DateTime.Now.DayOfWeek.ToString().Substring(0, 3).ToLower(); //günün kısa adını al
            if (day == "sat" || day == "sun") //eğer gün cumartesi veya pazar ise
                Console.WriteLine("bugün haftasonu ve  ailenizle olmanın tadını çıkarın"); //
            else
                Console.WriteLine("Bugün hafta içi ve ofiste verimli çalışmaya gayret edin.'");
        }
        static void Main(string[] args)

        {
            nothesapla();

            //int n, r, sum = 0, temp;
            //Console.Write("Enter the Number= ");
            //n = int.Parse(Console.ReadLine());
            //temp = n;
            //while (n > 0)
            //{
            //    r = n % 10;
            //    sum = sum + (r * r * r);
            //    n = n / 10;
            //}
            //if (temp == sum)
            //    Console.Write("Armstrong Number.");
            //else
            //    Console.Write("Not Armstrong Number.");


        }

    }
 
}
