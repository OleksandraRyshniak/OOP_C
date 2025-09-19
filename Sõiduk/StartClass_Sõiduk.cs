using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class StartClass_Sõiduk
    {
        public static void Main(string[] args)
        {
            List<ISõiduk> sõidukid = new List<ISõiduk>();
            while (true)
            {
                Console.WriteLine("\nVali sõiduk: 1=Auto, 2=Jalgratas, 3=Buss, 0=Välju");
                string valik = Console.ReadLine();
                if (valik == "1")
                {
                    Console.Write("Sisesta liitrites 100 km kohta: ");
                    double kütusekulu = double.Parse(Console.ReadLine());
                    Console.Write("Sisesta vahemaa (km): ");
                    double vahemaa = double.Parse(Console.ReadLine());
                    Auto auto = new Auto(kütusekulu, vahemaa);
                    sõidukid.Add(auto);
                    Console.WriteLine($"Sinu auto kütusekulu {auto.ArvutaKulu()} l/km, sa sõitsid {auto.ArvutaVahemaa()} km.");
                }
                else if (valik == "2")
                {
                    Console.Write("Sisesta vahemaa (km): ");
                    double vahemaa = double.Parse(Console.ReadLine());
                    double kütusekulu = 0;
                    Jalgratas jalgratas = new Jalgratas(vahemaa, kütusekulu);
                    sõidukid.Add(jalgratas);
                    Console.WriteLine($"Sa sõitsid {jalgratas.ArvutaVahemaa()} ja sinu kütusekulu {jalgratas.ArvutaKulu()} l/km");
                }
                else if (valik == "3")
                {
                    Console.Write("Sisesta liitrites 100 km kohta: ");
                    double kütusekulu = double.Parse(Console.ReadLine());
                    Console.Write("Sisesta vahemaa (km): ");
                    double vahemaa = double.Parse(Console.ReadLine());
                    Console.Write("Sisesta kogus reisijate: ");
                    double reisijatearv = double.Parse(Console.ReadLine());
                    Console.Write("Sisesta kütuse hind (eurot per liiter): ");
                    double hind = double.Parse(Console.ReadLine()); // eurot per liiter
                    Buss buss = new Buss(kütusekulu, vahemaa, reisijatearv, hind);
                    sõidukid.Add(buss);
                    Console.WriteLine($"Buss sõitis {buss.ArvutaVahemaa()} km. Iga reisija peab maksma: {buss.ArvutaKulu} euro.");
                }
                else if (valik == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Vale valik, proovi uuesti.");
                }
            }
        }
    }
}
