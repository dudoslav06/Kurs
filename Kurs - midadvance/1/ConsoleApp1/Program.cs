using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Czlowiek adi = new Czlowiek();
            adi.imie = "Adrian";
            adi.Wiek = -20;
            Console.WriteLine($"Jestem {adi.imie} mam lat {adi.Wiek}.");
            Console.ReadKey();
        }

        

        class Czlowiek
        {
            public string imie;
            //private int wiek;
            //public int wiek { get; set; } // to jest prymitywne properties ponizej dajemy pelne 

            private int wiek;

            public static int Wiek
            {
                get { return wiek; }
                set 
                {
                    if (value >= 0 && value <= 200)
                        wiek = value;
                    else
                        wiek = 0;
                }
            }

        }

    }
    //class Czlowiek // mozna w ten sposób wykonac getter setter, tak sie robi, np w Javie, ale
    //w c# jest to dużo bardziej rozbudowane i ułatwione jednocześnie, jak wyżej^
    //{
    //    public string imie;
    //    private int wiek;

    //    public int getWiek()
    //    {
    //        return wiek;
    //    }

    //    public void setWiek(int w)
    //    {
    //        wiek = w;
    //    }
        
    //}

}
