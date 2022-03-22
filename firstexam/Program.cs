using System;

namespace firstexam
{
    class Program
    {
        static void Main(string[] args)
        {

            //int sayı;

            //sayı = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();

            //for (int i = 1; i <= sayı; i++)
            //{
            //    for (int j = sayı; j > i; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write(" " + "*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int t = 1; t <= sayı; t++)
            //{
            //    for (int m = 1; m <= t; m++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int n = sayı; n > t; n--)
            //    {
            //        Console.Write(" " + "*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadLine();

            -------------------------------------------


            //int num, i, k, say = 1;
            //Console.Write("n kaç olacak\n");
            //num = int.Parse(Console.ReadLine());
            //say = num - 1;                                        >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>> dışarıdan eksilttiğim içib döngüde eksiklik var
            //for (k = 1; k <= num; k++)
            //{
            //    for (i = 1; i <= say; i++)
            //        Console.Write(" ");
            //    say--;
            //    for (i = 1; i <= 2 * k - 1; i++)
            //        Console.Write("*");
            //    Console.WriteLine();
            //}
            //say = 1;
            //for (k = 1; k <= say - 1; k++)
            //{
            //    for (i = 1; i <= say; i++)
            //        Console.Write(" ");
            //    say++;
            //    for (i = 1; i <= 2 * (say - k) - 1; i++)
            //        Console.Write("*");
            //    Console.WriteLine();











            //int a, b;
            //Console.WriteLine("sayıgiriniz : ");
            //a = int.Parse(Console.ReadLine());

            //for (b = 2; a > 1; b++)
            //    if (a % b == 0)
            //    {
            //        int z = 0;
            //        while (a % b == 0)
            //        {
            //            a /= b;
            //            z++;
            //        }
            //        Console.WriteLine($"{b} sayısı {x} kere asal!");
            //    }



            //----------------------------------------------------------------
            //     int sayı,i;
            //     Console.WriteLine("sayı giriniz : ");
            //      sayı = Int32.Parse(Console.ReadLine());
            //    for(i = 1; i <= sayı; i++)
            //     if (sayı % 2 == 0)
            //         {

            //             Console.WriteLine("sayı");
            //             Console.WriteLine(i);
            //         }

            //   else  if (sayı % 3 == 0)
            //     {
            //         Console.WriteLine("sayı");
            //         Console.WriteLine(i);
            //     }
            // else    if (sayı % 5 == 0)
            //     {
            //         Console.WriteLine("sayı");
            //         Console.WriteLine(i);
            //     }

            //else     if (sayı % 7 == 0)
            //     {
            //         Console.WriteLine("sayı");
            //         Console.WriteLine(i);
            //     }


            //--------------------------------------------


            //int sa, dk, sn; Console.WriteLine("Saniye giriniz : "); 
            //sn = Int16.Parse(Console.ReadLine()); sa = sn / 3600; sn = sn - (sa * 3600); dk = sn / 60; sn = sn - (dk * 60);

            //Console.WriteLine("{0:D2},{1:D2},{2:D2}", sa, dk, sn);
            //Console.ReadLine();



            //----------------------------------------







            //-----------------------------------------------------



            //}


            //Console.ReadLine();
            //for (int i = 10; i >= 0; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //           for (int i = 1; i <= 100; i++)
            //           { 
            //               if  (i % 2 == 0)
            //               {
            //                   Console.WriteLine(i+"çift");

            //               }
            //               else 
            //{
            //                   Console.WriteLine(i + "tek");

            ////               }
            //------------------------------------------------------

            //string ay;

            //Console.Write(" 1-ocak  ");
            //Console.Write(" 2-şubat ");
            //Console.Write("  3-mart ");
            //Console.Write("  4-nisan ");
            //Console.Write(" 5-mayıs ");
            //Console.Write(" 6-haziran ");
            //Console.Write(" 7-temmuz ");
            //Console.Write(" 8-ağustos ");
            //Console.Write(" 9-eylül ");
            //Console.Write(" 10-ekim ");
            //Console.Write(" 11-kasım ");
            //Console.Write(" 12-aralık ");
            //Console.Write(" ay ismi giriniz : ");
            //ay = Console.ReadLine();
            //switch(ay)
            //{
            //    case "ocak" :
            //        Console.WriteLine("31 gün");

            //            break;
            //    case "şubat":
            //        Console.WriteLine("28 gün");
            //        break;
            //    case  "mart" :
            //        Console.WriteLine("31 gün");
            //        break;

            //    case "nisan":
            //        Console.WriteLine("30 gün");
            //        break;

            //    case "mayıs":
            //        Console.WriteLine("31 gün");
            //        break;

            //    case "haziran":
            //        Console.WriteLine("30 gün");
            //        break;

            //    case "temmuz":
            //        Console.WriteLine("31 gün");
            //        break;

            //    case "ağustos":
            //        Console.WriteLine("31 gün");
            //        break;

            //    case "eylül":
            //        Console.WriteLine("30 gün");
            //        break;

            //    case "ekim":
            //        Console.WriteLine("31 gün");
            //        break;

            //    case "kasım":
            //        Console.WriteLine("30 gün");
            //        break;


            //    case "aralık":
            //        Console.WriteLine("31 gün");
            //        break;
















        }



    }


    }
    


//"1. Console ekranına 10'dan geriye yazdıran programı yazınız. 
//Bilinmesi gereken : for döngüsü"
//2. Console ekranına 1 den 100'e kadar olan sayıları sıralı olarak çift ise çift, tek ise tek olarak yazdırın.
//Bilinmesi gereken : for döngüsü, if/else
//            Ör Çıktı : 
//1 - Tek
//2 - Çift
//3 - Tek vb.


//3.Console ekranına bu yılın girdiğim bir ayının(Ay ismi veya ay numarası ile yapılabilir) gün sayısını veren program.
//Bilinmesi gereken : switch case
//Ör Çıktı:
//    Ayı seçiniz : Şubat
//28

//----------------------------------------------------------------------
//1.Klavyeden bir n sayısı okuyunuz ve aşağıdaki deseni oluşturan programı yazınız (örneğimizde n = 6’dır): 
//Bilinmesi gereken konu : for
//     *
//    ***
//   *****
//  *******
// *********
//***********
// *********
//  *******
//   *****
//    ***
//     *
//2.Parametresi ile aldığı long türden saniye cinsinden süreyi saat, dakika ve saniye olarak ayrıştırarak 
//ekrana yazdıran displayDuration isimli metodu yazınız. Eğer saat, dakika ya da saniye değeri 0(sıfır) ise ekrana 
//yazdırılmayacaktır.
//Bilinmesi gereken konu : saat hesaplamasının nasıl yapılacağı(mod alma vs), metot çağrısı
//Örnek Çıktı : 3678 girildiğinde consoleda yandaki yazmalı : 01 h: 01 m: 18 s


//3.Bir sayının asal çarpanlarını yazdıran programı yazınız. 
//Bilinmesi gereken konu : for, if/else
//        Örneğin: Sayı: 12-> 2 2 3
