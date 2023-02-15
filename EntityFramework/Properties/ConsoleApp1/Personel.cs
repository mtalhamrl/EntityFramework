using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Personel
    {
        private string tckimlikno;

        public string  TCkimlikno
        {
            get
            {
                return tckimlikno.Substring(0, 5) + "******";
            }
            set
            {
                bool kontrol = false;
                if (value.Length == 11)
                {
                    for(int i=0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);
                        if (sayiMi)
                        {
                            // yapmam gereken bir şey yok
                        }
                        else
                        {
                            kontrol= true;
                            break;
                        }
                    }
                    if(kontrol)
                    {
                        Console.WriteLine("Tc kimlik numaranızda geçersiz karakter bulundu.");
                    }
                    else
                    {
                        tckimlikno = value;
                    }
                }
                else
                {
                    Console.WriteLine("Girdiginiz tc kimlik no 11 karakter değildir.");
                }
               
            }
        }
    }
}
