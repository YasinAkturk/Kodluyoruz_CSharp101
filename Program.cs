using System;

namespace uyg1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adınız Nedir?");
            var name = Console.ReadLine();
            Console.WriteLine("Soyadınız Nedir?");
            var surname = Console.ReadLine();
            Console.WriteLine("Merhaba "+name+" "+surname);
            Console.Write($"{Environment.NewLine}Kapatmak için bir tuşa basınız...");
            Console.ReadKey(true);
        }
    }
}
