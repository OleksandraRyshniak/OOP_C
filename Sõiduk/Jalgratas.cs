using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Jalgratas : ISõiduk
    {
        public double Vahemaa { get; set; }

        public Jalgratas(double vahemaa)
        {
            Vahemaa = vahemaa;
        }

        public double ArvutaKulu() => 0;
        public double ArvutaVahemaa() => Vahemaa;

        public override string ToString()
        {
            return $"Jalgratas -> Vahemaa: {Vahemaa} km, Kulu: {ArvutaKulu()} €";
        }
    }
}
