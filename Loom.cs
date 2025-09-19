using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Loom
    {
        public string Nimi;
        public int Vanus;

        public Loom(string nimi, int vanus)
        {
            Nimi = nimi;
            Vanus = vanus;
        }
        public void Tervita() { 
            Console.WriteLine("Tere! Mina olen " + Nimi);
        }

        public abstract void TeeHääl();
    }
    public class Koer : Loom
    {
        public Koer(string nimi, int vanus) : base(nimi, vanus) { }
        public override void TeeHääl()
        {
            Console.WriteLine("Auh-Auh!");
        }
    }
    public class Kass : Loom
    {
        public Kass(string nimi, int vanus) : base(nimi, vanus) { }
        public override void TeeHääl()
        {
            Console.WriteLine("May-may!");
        }
    }
}
