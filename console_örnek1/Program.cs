using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodluyoruzodev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("İsminizi giriniz:");
            string name = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);


            Console.ReadKey();
        }
    }
}
