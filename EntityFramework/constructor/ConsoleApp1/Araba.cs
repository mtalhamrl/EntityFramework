using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRengi;

        public Araba(int _kapisayisi, string _arabaModel , string _arabaRengi) //constructer void veya int almaz class'la aynı isimde olmalı ilk çalışır...
        {
           kapiSayisi= _kapisayisi;
            arabaModel= _arabaModel;
            arabaRengi= _arabaRengi;
        }
        public void motorCalistir()
        {
            Console.WriteLine("motor calisiyor");
        }
        public void kapilariKilitle()
        {
            Console.WriteLine("kapilar kilitleniyor");
        }
    }
}
