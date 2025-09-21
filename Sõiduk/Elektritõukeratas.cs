using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Elektritõukeratas : ISõiduk
    {
        public double Vahemaa { get; set; } // km
        public double HindKm { get; set; } // €/km
        public Elektritõukeratas(double vahemaa, double hindKm)
        {
            Vahemaa = vahemaa;
            HindKm = hindKm;
        }
        public double ArvutaKulu() => Vahemaa * HindKm; // hinna arvutus
        public double ArvutaVahemaa() => Vahemaa;

        public override string ToString() 
        {
            return $"Elektritõukeratas -> Vahemaa: {Vahemaa} km, Kulu: {ArvutaKulu():F2} €";
        }
    }
}
