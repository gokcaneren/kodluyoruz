using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodluyoruzSwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak");
                    break;
                case 2:
                    Console.WriteLine("Şubat");
                    break;
                case 3:
                    Console.WriteLine("Mart");
                    break;
                case 4:
                    Console.WriteLine("Nisan");
                    break;
                default:
                    Console.WriteLine("Yanlış veri girdiniz!");
                    break;


                    switch (month)
                    {
                        case 12:
                        case 1:
                        case 2:
                            Console.WriteLine("Kış ayındasınız!");
                            break;
                        case 3:
                        case 4:
                        case 5:
                            Console.WriteLine("İlkbahar ayındasınız!");
                            break;
                        case 6:
                        case 7:
                        case 8:
                            Console.WriteLine("Yaz ayındasınız!");
                            break;
                        default:
                            break;
                        case 9:
                        case 10:
                        case 11:
                            Console.WriteLine("Sonbahar ayyındasınız!");
                            break;


                    }

            }
            Console.ReadKey();
        }
    }
}
