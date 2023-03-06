using System;
using System.Dynamic;
using System.Transactions;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("       Teklik çiftlik sorugulama");
            Console.WriteLine("*************************************");
            int sayi =Convert.ToInt32(Console.ReadLine());

            if ((sayi % 2) == 0)
            {
                Console.WriteLine("Girilen değer çift sayıdır \a");
            }

            else
            {
                Console.WriteLine("Girilen değer tek sayıdır \a" );
            }

        }
    }

} 