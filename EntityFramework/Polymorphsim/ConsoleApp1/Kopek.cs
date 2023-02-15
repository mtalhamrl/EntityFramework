using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Kopek : Hayvan 
    {   
        public Kopek(string name) : base(name) 
        {
            
        }
        public override void konus()
        {
            Console.WriteLine(isim + " havlıyor..");
        }
    }
}
