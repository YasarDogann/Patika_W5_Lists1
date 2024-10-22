using System;

namespace patika_w5_Lists1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List ile dinamik liste oluşturdum ve içine 4 adet string türünde veri girdim.
            List<string> names = new List<string>() { "Bülent Ersoy", "Ajda Pekkan", "Ebru Gündeş", "Hadise" };
            Console.WriteLine("\r\n** GALA **\r\n");

            // list'in Add() methodunu kullanarak ekleme işlemi yaptım
            names.Add("Hande Yener");
            names.Add("Tarkan");
            names.Add("Funda Arar");
            names.Add("Demet Akalın");
            names.Add("Mauro Icardi");
            names.Add("Victor Osimhen");
            names.Add("Gabrie Sara");
            names.Add("Fernando Muslera");

            
            int i = 0;
            foreach (string name in names)
            {
                Console.WriteLine(i+1+". "+name);
                i++;
            }

            // Count() ile listede bulunan eleman sayısı yazdırma
            Console.WriteLine("Listede Bulunan İsim Sayısı: "+ names.Count());

            Console.ReadKey();

        }
    }
}
