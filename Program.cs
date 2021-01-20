using System;

namespace FaktöryelHesaplayanProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------Giriş---------------------------------------\\
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hoş Geldin Kullanıcı!");
            Console.WriteLine("Bu programın amacı atanmış sayının faktöryelini hesaplamaktır.");

            //---------------------------------Matematik Fonksiyonu--------------------------------\\
            int sayi1 = 6; //Atanmış sayı
            int sayi2 = 1;

            while (sayi1>0)
            {
                sayi2 = sayi1 * sayi2;
                
                sayi1--;
            }
            //----------------------------------------Sonuç-----------------------------------------\\
            Console.WriteLine(sayi2);
        }
    }
}
