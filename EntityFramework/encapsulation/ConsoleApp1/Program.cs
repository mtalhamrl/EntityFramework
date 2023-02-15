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
            //geter seter metotlarıyla.
            Ogrenci ogrenci1= new Ogrenci();
            ogrenci1.setIsim("Enes"); 
            string gelenIsim = ogrenci1.getIsim();

            if (gelenIsim == "Enes")
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }

            Console.ReadLine();
        }
    }
}
