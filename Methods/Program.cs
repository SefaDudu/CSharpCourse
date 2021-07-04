using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{ //proje isimleri büyük başlar PascalKeys
    //kendimizi tekrarlamamak için kullanırız dont repeat yourself
    class Program
    {
        static void Main(string[] args)
        {

           // Add();
           //var result= add2(2, 3);
           // var result1 = add3(2);
           // Console.WriteLine(result );
           // Console.WriteLine(result1);
           // Console.ReadKey();



            //değer kontrol
            //n2 burada 20 method içinde 30 yaptık result2  ne olur? = 130
            // n1 nedir ? =20 neden ? değer tip olduğu için biz n1 i değil 
            //değerini gönderiyoruz ve maindeki n1 i bağlamaz
            // değişmesi için ref koymalıyız başlarına buda referans tip olur
            //ve n1 değeri artık 30 olur
            // soruda biz değer tip kullanmış olduk ref  n1 olsaydı 30 olacaktı
            //out keyword out n1 olsaydı değerimiz yine 30  olacaktı
            // ***ref ile farkı n1 e değer atamamız gerekiyordu out için gerek yok
            int n1 = 20;
            int n2 = 100;
            var result2 = Add4(ref n1, n2);
            Console.WriteLine(result2);
            Console.WriteLine(n1);

            // PARAMS
            Console.WriteLine(ADD(2,3,4,5,6,7));


        }
        static void Add()
        {
            Console.WriteLine("added");
        }
        //parametreli returnlar
        // void değerler geri döndürmez
        //ne döndürmek istiyorsak değişken odur
        static int add2(int n1 , int n2)
        {
            return n1 + n2;
        }
        //default parametreler ile çalışmak
        //her zaman en sondakine değer verilir baştakine değer veremeyiz
        static int add3(int n1, int n2=40)
        {
            return n1 + n2;
        }

        //challange 
        static int Add4(ref int n1 , int n2 )
        {
            n1 = 30;
            return n1 + n2;
        }

        //method overloading
        static int Multiply(int n1 , int n2)
        {
            return n1 * n2;
        }
        //3 değer istersek 
        //bu biçimde kullanabilir . buna overloading denir
        static int Multiply(int n1, int n2,int n3)
        {
            return n1 * n2 * n3 ;
        }

        //PARAMS
        static int ADD(int n1 , int n2 )
        {
            return n1 + n2;

        }
        static int ADD(int n1, int n2, int n3)
        {
            return n1 + n2;

        }
        //sürekli kullanmak yerine paramsları kullanabiliriz
        // başına değer ekleyebilirz fakat sonuna değer eklenmez
        static int ADD(int number ,params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
