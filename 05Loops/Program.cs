using System;

namespace _05Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //veri kümelerini dolaşmak için kullanırız.
            // çoğunlukla for yada while kullanılır. Kişiden kişiye değişir.
            //FOR
            //for (int i = 1; i <= 100; i++)
            //{
            //    Console.WriteLine(i);
            //    // i sadece bu blokta kullanılır.

            //}
            ////while
            //int number = 1;
            //while (number <= 100)
            //{
            //    Console.WriteLine(number);
            //    number++;

            //}
            //Do While
            //int number = 10;
            //do
            //{       //şart uymasa bile 1 kere çalışır.
            //    Console.WriteLine(number);
            //    number--; 



            //} while (number >=10);


            // Foreach
            //dizi tabanlı terimleri gezmek için kullanılır.
            //string[] students2 = { "sefa3", "sefa4", "sefa5" };
            //foreach (var students in students2)
            //{
            //    //data gezmek için innumareble değerler için kullanırız
            //    //foreach elemanlarını içeride değiştiremeyiz
            //    Console.WriteLine(students);
            //}

            //EXAMPLE asal sayılar
            Console.WriteLine("bir sayı giriniz:");
            int a = Convert.ToInt32(Console.ReadLine());
            bool x = IsPrimeNumber(a);
            if (x)
            {
                Console.WriteLine("sayı asal");
            }
            else
            {
                Console.WriteLine("sayı asal değil");
            }


        }
        private static bool IsPrimeNumber (int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;

                }
            }
            return result;
        }
    }
}
