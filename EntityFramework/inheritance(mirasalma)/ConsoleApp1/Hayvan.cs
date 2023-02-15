using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Hayvan
    {
        public string hayvan_isim;
        public string hayvan_cinsiyet;
        public string hayvan_rengi;
        private int hayvan_yas;

        public int hayvanYasi
        {
           get
            {
                return hayvan_yas;
            }
            set
            {
                hayvan_yas= value;
            }
        }

        public void hayvanBilgisiGoster()
        {
            Console.WriteLine("Hayvanın ismi " + hayvan_isim);
            Console.WriteLine("Hayvan Cinsiyet " + hayvan_cinsiyet);
            Console.WriteLine("Hayvan Rengi " + hayvan_rengi);
            Console.WriteLine("Hayvan yasi " + hayvanYasi);
        }
    }
}
