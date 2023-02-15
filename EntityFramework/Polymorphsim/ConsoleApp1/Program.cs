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
            Hayvan hayvan = new Hayvan("Hayvan");
            hayvan.konus();

            Hayvan kedi = new Kedi("Minnoş");
            kedi.konus();

            Hayvan kopek = new Kopek("Karabaş");
            kopek.konus();
            Console.ReadLine();
        }
    }
}
