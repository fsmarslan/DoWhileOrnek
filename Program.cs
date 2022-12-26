using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileOrnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = new Random().Next(0, 100);
            int tahmin=0;
            do
            {
                Console.WriteLine("tuttuğum sayıyı tahmin et.");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin>sayi)
                {
                    Console.WriteLine("aşağı in");
                }
                else if (tahmin<sayi)
                {
                    Console.WriteLine("yukarı çık");
                }
            } while (tahmin!=sayi);
            Console.WriteLine("tebrikler!");
            Console.ReadKey();
        }
    }
}
