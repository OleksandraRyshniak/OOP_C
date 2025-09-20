using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Buss : ISõiduk
    {
        public double Kütusekulu { get; set; } // л / 100 км
        public double Vahemaa { get; set; }    // км
        public int ReisijateArv { get; set; }  // пассажиры
        public double Hind { get; set; }       // €/л
        public Buss(double kütusekulu, double vahemaa, int reisijatearv, double hind)
        {
            Kütusekulu = kütusekulu;
            Vahemaa = vahemaa;
            ReisijateArv = reisijatearv > 0 ? reisijatearv : 1; // защита от деления на 0
            Hind = hind;
        }
        public double ArvutaKulu() => (Kütusekulu / 100) * Vahemaa * Hind / ReisijateArv;
        public double ArvutaVahemaa() => Vahemaa;
        public override string ToString()
        {
            return $"Buss -> Vahemaa: {Vahemaa} km, Reisijad: {ReisijateArv}, Kulu inimese kohta: {ArvutaKulu():F2} €";
        }
    }
}
