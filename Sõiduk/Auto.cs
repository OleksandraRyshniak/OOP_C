using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Auto : ISõiduk
    {
        public double Kütusekulu { get; set; }  // л / 100 км
        public double Vahemaa { get; set; }     // км
        public double Hind { get; set; }        // €/л

        public Auto(double kütusekulu, double vahemaa, double hind)
        {
            Kütusekulu = kütusekulu;
            Vahemaa = vahemaa;
            Hind = hind;
        }

        public double ArvutaKulu() => (Kütusekulu / 100) * Vahemaa * Hind;
        public double ArvutaVahemaa() => Vahemaa;

        public override string ToString()
        {
            return $"Auto -> Vahemaa: {Vahemaa} km, Kulu: {ArvutaKulu():F2} €";
        }
    }
}
