using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            //int=1000000 sınırı aşar -2147483647 
            //long int 2 katını tutar
            //int 32 bit long 64 bit yer kaplar
            long number2 = -2147483647;

            //short  16 bit yer tutar -32768 ile 32677
            short number3 = -32768;
            //byte 8 bit 0 ile 255 arasında değer tutar
            byte number4 = 255;

            //bool -> true yada false değerleri tutar şart bloklarında kullanır genellikle
            bool condition = true;
            //char -> karakter tutar  tüm ascii karakterlerini tutar (int) yazarsak başına ascii sayısal karşılığını buluruz
            char character = 'A';
            //string -> karakter serisidir
            string city = "Ankara";
            //double ondalıklı sayı tutar 64 bit veri dönüşümü ,den sonra 15 
            double number5 = 10.4;
            //decimal long gibi aynı decimalın sınırının yetmediği yerleri tutar para değerleri için , sonra 129
            decimal number6 = 10.4m;
            //enum MAGIC STRING tip dönüşümleri önemlidir
            Console.WriteLine((int)Days.Friday);

            //var değişken tutmak için kullanılır
            //int kullanırsak stringe dönüştüremeyiz
            var number7 = 19;
            number7 = 'A';
            Console.WriteLine("Number7 is {0}", number7);

            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number3 is {0}", number3);
            Console.WriteLine("Number4 is {0}", number4);
            Console.WriteLine("character is {0}",(int)character);
            Console.WriteLine("Number5 is {0}", number5);
            Console.WriteLine("Number6 is {0}", number6);
            Console.ReadKey();
        }
    }
    //if bloklarında kullanavbiliriz. Days. koyduğumuzda değerler ortaya çıkar 
    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
