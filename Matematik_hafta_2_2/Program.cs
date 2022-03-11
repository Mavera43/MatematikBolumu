using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik_hafta_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ürün Fiyatı Nedir ?");
            string f = Console.ReadLine();
            Console.WriteLine("İndirim Oranı Nedir?");
            string o = Console.ReadLine();

            double fiyat = double.Parse(f);
            double oran = double.Parse(o);
            double indirimliFiyat = fiyat - (fiyat * oran);
            Console.WriteLine($"İndirimsiz Ürün Fiyatı :{fiyat:N}");
            Console.WriteLine($"İndirim Tutarı :{(fiyat * oran):N}");
            Console.WriteLine($"İndirimli Ürün Fiyatı :{indirimliFiyat:N}");

            Console.ReadLine();
        }
    }
}
