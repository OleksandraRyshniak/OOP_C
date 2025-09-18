using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Töötaja : Inimene
    {
        public string Ametikoht = "Keevitaja";

        public void Töötan()
        {
            Console.WriteLine($"{Nimi} töötan ametikohal {Ametikoht}.");
        }
        public override void Mida_teeb()
        {
            Console.WriteLine($"{Nimi} töötab ametikohal");

        }
    }
}
