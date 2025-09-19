using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Auto : ISõiduk
    {
        public double Kütusekulu { get; set; } // liitrites 100 km kohta
        public double Vahemaa { get; set; } // km
        public Auto(double kütusekulu, double vahemaa)
        {
            Kütusekulu = kütusekulu;
            Vahemaa = vahemaa;
        }
        public double ArvutaKulu() => (Kütusekulu/100)*Vahemaa;
        public double ArvutaVahemaa() => Vahemaa;
    }
}
