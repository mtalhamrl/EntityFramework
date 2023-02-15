using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();
            kedi.hayvan_isim = "Boncuk";
            kedi.hayvan_cinsiyet = "Disi";
            kedi.hayvan_rengi = "Beyaz";
            kedi.hayvanYasi = 2;

            kedi.hayvanBilgisiGoster();
            Console.ReadLine();
        }
    }
}
