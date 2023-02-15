using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hayvan
    {
        public string isim { get; set; }   
        public Hayvan(string _isim) 
        {
            isim= _isim;
        }
        public virtual void konus()
        {
            Console.WriteLine("Hayvan konuşuyor..");
        }

    }
}
