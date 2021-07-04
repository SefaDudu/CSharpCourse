using System;
using System.IO;

namespace _08tarihVeSatt
{
    class Program
    {
        static void Main(string[] args)
        {
            //pascal Case : baş harfler büyük değişken, sınıf, metod veya fonksiyonun kelimeleri bitişik ve büyük harfle başlayacak şekilde yazılmasıdır.
            //camel case : ilk kelime hariç gerisi büyük
            //TarihSaat();
            // Different();
            //DayCalculated();//gün hesabı
            //HourCalculated();//saat hesabı 

            //tarih formatları 
            //FormatDate();
            // try catch de try da işlemelr yapılırken catch hatalı duurmları belirtir.
            //loglama
            Loglama();
        }

        private static void Loglama()
        {
            try
            {
                Console.WriteLine("bir sayı giriniz:");
                  int sayi = Convert.ToInt32(Console.ReadLine());
                 if (sayi==3)
                {
                throw new Exception("böyle sayı olmaz");

                }
            }
            catch (Exception hata )//hata bilgilerine ulaşmak için exception kullanılır
            {
                File.AppendAllText("log.txt", Environment.UserName);// bilgisayarın adını 

                File.AppendAllText("log.txt", Environment.NewLine);//yeni bir satır yaratır
                File.AppendAllText("log.txt", DateTime.Now.ToString("dd.MM.yyyy HH:mm"));//tarih ekler
                File.AppendAllText("log.txt", "/r/n");//alt satır
                File.AppendAllText("log.txt", hata.Message);// hatanın ne olduğunu bastırır


            }

        }

        private static void FormatDate()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);//pm am tutar
            Console.WriteLine(now.ToShortDateString());//sadece tarih verir
            Console.WriteLine(now.ToLongDateString());//tarihi hangi tarih olduğunu yazarak söyler


        }

        private static void NextDate()
        {
            var now = DateTime.Today;
            var next1month = now.AddMonths(1);
            Console.WriteLine("Today:" +now    );
            Console.WriteLine("Next1Month:" + next1month);

        }

        private static void HourCalculated()
        {
            //gece 23:00 a ne kadar var
            var now = DateTime.Now;
            var finished = Convert.ToDateTime("2021.06.06 23:00:00");
            TimeSpan calculated = finished - now;
            Console.WriteLine(calculated.TotalMinutes);
        }

        private static void DayCalculated()
        {
            //mezuniyet 20.06.2022 ve bugün arası kaç gün var
            DateTime mezuniyet = new DateTime(2022, 06, 22);
            TimeSpan kalansüre = mezuniyet - DateTime.Today;// gün hesabı için kullanılır saatide yazdırabiliriz
            Console.WriteLine(kalansüre);
            Console.WriteLine(kalansüre.TotalDays); // direkt kaç gün kaldığını gösterir
        }

        private static void TarihSaat()
        {
            DateTime today = DateTime.Today;
            Console.WriteLine(today);
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            
        }

        private static void Different()
        {
            DateTime tarih = Convert.ToDateTime("2021-06-06");//db de yıl ay gün tutulur
            Console.WriteLine(tarih);
            DateTime mezuniyet = new DateTime(2021,06,06);
            Console.WriteLine("Yılın "+ mezuniyet.DayOfYear +". günü");// yılın kaçıncı günü olduğunu gösterir dayofweak
        }
    }
}
