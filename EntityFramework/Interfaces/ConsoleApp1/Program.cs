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
            MusteriController musteriController= new MusteriController();
            musteriController.musteriEkle(new SqlServer());
            musteriController.musteriEkle(new MySql());
            musteriController.musteriEkle(new Oracle());
            
            Console.ReadLine();
        }
    }
}
