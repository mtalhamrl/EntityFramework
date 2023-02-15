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
            Personel p1 = new Personel();
            p1.TCkimlikno = "19168058198";
            Console.WriteLine("Tc kimlik numaranız : " + p1.TCkimlikno);
            Console.ReadLine();
        }
    }
}
