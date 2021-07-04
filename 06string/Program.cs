using System;

namespace _06string
{
    class Program
    {
        static void Main(string[] args)
        {   // referans bir tiptir
            //metinsel verileri tutar
            //char arrayleridir
            string city = "Ankara";
            //Console.WriteLine(city[0]);
            //foreach (var item in city)
            //{
            //    Console.WriteLine(item);
            //}

            //stringler toplanabilir
            string city2 = "İstanbul";
            var result = city + city2;
            Console.WriteLine(result);
            Console.WriteLine(string.Format("{0} {1}",city,city2));
            Console.ReadLine();
            // string methodları
            string sentence = " My name is sefa";
            var result1 = sentence.Length; // cümlenin uzunluğunu 
            var result2 = sentence.Clone(); // sentence cümlesnini klonunu başka bir referansa aldık
            bool result3= sentence.EndsWith("ğ"); // yumuşak bir kelime ile bitiyor mu
            bool result4 = sentence.StartsWith("My name"); // ile başlıyor mu
            var result5 = sentence.IndexOf("name"); // kaçıncı indeksten başlıyor yoksa -1 döndürür
            var result6 = sentence.IndexOf(" ");// bulduğu ilk boşluk 
            var result7 = sentence.LastIndexOf(" "); // sondan kaçıncı diye arar
            var result8 = sentence.Insert(0, "hello");//0. indisten sonra hello ekle
            var result9 = sentence.Substring(3,4); //3. karakten sonra 4 indis parçala demek
            var result10 = sentence.ToLower(); // tüm cümleyi küçük harf yapar toUpper da tam tersi
            var result11 = sentence.Replace(" ", "-"); // boşluk yerine hepsini - yap;
            var result12 = sentence.Remove(2); //2 den sonrasını düşür
        }
    }
}
