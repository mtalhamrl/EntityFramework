using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {

            SelamVer();
            //ToplamaYap(sayi1,sayi2);
            Topla(5, 7);
            Console.ReadLine();
        }
        static void SelamVer() //parametre yok geriye değer yok
        {
            Console.WriteLine("selamlar");
        }
        static void ToplamaYap(int sayi1,int sayi2) //parametre var geriye değer yokkl
        {
            Console.WriteLine("Gönderilen sayilarin toplami : " + (sayi1 + sayi2));
        }
        static int Topla(int sayi1,int sayi2) //parametre var geriye değer var return kullan!
        {
            int sonuc= sayi1+ sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        }
    }
}
