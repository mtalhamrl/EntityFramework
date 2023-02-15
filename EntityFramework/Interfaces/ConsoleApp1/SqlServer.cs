using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class SqlServer : IMusteri
    {
        public void ekle()
        {
            Console.WriteLine("sql server ekledi");
        }

        public void guncelle()
        {
            Console.WriteLine("sql server guncelledi");
        }

        public void sil()
        {
            Console.WriteLine("sql server sildi");
        }
    }
}
