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
            Araba araba1 = new Araba(4,"Renault","Kırmızı"); //constructor
            //araba1.kapiSayisi = 4;
            //araba1.arabaRengi = "Kırmızı";
            //araba1.arabaModel = "Renault";
            //araba1.motorCalistir();
            //araba1.kapilariKilitle();
            Console.WriteLine("Arabanın Kapı sayısı" +  araba1.kapiSayisi +  "arabanın rengi " +  araba1.arabaRengi  + "arabanın modeli " +  araba1.arabaModel);
            Console.ReadLine();

        }
    }
}
