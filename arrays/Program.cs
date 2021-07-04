using System;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // bir veri tabanındaki kaydı ve koleksiyonları tutmak için genellikle koleksiyonlar için kullanılır.
            string student1 = "sefa";
            string student2 = " engin";
            // çoklu veri tutmaya yarar
            string[] students = new string[3];
            students[0] = " sefa";
            students[1] = " sefa1";
            students[2] = " sefa2";
       
            //başka bir format
            string[] students2 = { "sefa3", "sefa4", "sefa5" };
            // KISITLAR
            // hangi tipi kullanıyorsan onu yazmak zorundasın --derleme hatası
            //boyut dışında yazamazsın
            //
            foreach (var student  in students2)
            {
                //dizi elemanlarını döner
                Console.WriteLine(student);
            }
            // çok boyutlu Diziler multi dimension

            //tanımlama
            string[,] regions = new string[5,3]
            {
                {"istanbul","izmit","balıkesir" },
                {"ankara","konya","kırıkkale" },
                {"antalya","adana","mersin" },
                {"rize","trabzon","samsun" },
                {"izmir","muğla","samsun" }
                

            };
            for (int i = 0; i < regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j < regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);
                }
                Console.WriteLine("********");
            }



        }
    }
}
