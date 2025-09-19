using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Buss : ISõiduk
    {
        public double Kütusekulu { get; set; } // liitrites 100 km kohta
        public double Vahemaa { get; set; } // km
        public double ReisijateArv { get; set; } // reisijate arv
        public double Hind { get; set; }  // eurot per liiter
        public Buss(double kütusekulu, double vahemaa, double reisijatearv, double hind)
        {
            Kütusekulu = kütusekulu;
            Vahemaa = vahemaa;
            ReisijateArv = reisijatearv;
            Hind = hind;
        }
        public double ArvutaKulu() => Kütusekulu*Hind /ReisijateArv;
        public double ArvutaVahemaa() => Vahemaa;
    }
}
