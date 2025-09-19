using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Elektritõukeratas : ISõiduk
    {
        public string Nimi { get; set; }
        public double Hind { get; set; }
        public double Kütusekulu { get; set; }

        public Elektritõukeratas(string nimi, double hind, double kütusekulu)
        {
            Nimi = nimi;
            Hind = hind;
            Kütusekulu = kütusekulu;
        }
        public double ArvutaKulu() => Kütusekulu; // kWh/100km
        public double ArvutaVahemaa() => 100; // km
        public override string ToString()
        {
            return $"{Nimi}, Hind: {Hind}€, Kütusekulu: {Kütusekulu}kWh/100km";
        }
    }

}
