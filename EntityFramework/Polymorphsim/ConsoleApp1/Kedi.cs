using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kedi : Hayvan
    {
        public Kedi(string isim)  : base(isim)
        {

        }
        public override void konus()
        {
            Console.WriteLine(isim + " miyavliyor..");
        }
    }
}
