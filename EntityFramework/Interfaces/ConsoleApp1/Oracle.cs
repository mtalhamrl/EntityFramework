using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Oracle : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("Oracle Ekledi");
        }

        public void guncelle()
        {
            Console.WriteLine("Oracle Guncellendi");
        }

        public void sil()
        {
            Console.WriteLine("Oracle Sil");
        }
    }
}
