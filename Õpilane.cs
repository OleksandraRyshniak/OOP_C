using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Õpilane : Inimene
    {
        public string Nimi;
        public int Vanus;

        public Õpilane(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public void Tervita() 
        {
            Console.WriteLine($"Tere! Mina olen {Nimi}. Ma olen {Vanus} aastane." );
        }
        public override void Mida_tee()
        {
            Console.WriteLine($"{Nimi} õpib koolis");
        }
    }
    public class Klass : Õpilane 
    {
        public int Klas;

        public Klass(string nimi, int vanus, int klas) : base(nimi, vanus) 
        {
            Klas = klas;
        }
        public void Õpin()
        {
            Console.WriteLine($"Ma õpin {Klas} klassis.");
        }
    }
    public class Kool: Õpilane
    {
        public string Kool1;
        public Kool (string nimi, int vanus, string kool1) : base(nimi, vanus)
        {
            Kool1 = kool1;
        }
        public void Kooli()
        {
            Console.WriteLine($"Ma õpin {Kool1} koolis");
        }

    }
}
