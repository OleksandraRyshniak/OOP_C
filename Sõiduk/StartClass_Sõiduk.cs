using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class StartClass_Sõiduk
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<ISõiduk> sõidukid = new List<ISõiduk>();
            while (true)
            {
                Console.WriteLine("\nVali sõiduk: 1=Auto, 2=Jalgratas, 3=Buss, 4=Elektritõukeratas, 0=Välju");
                string valik = Console.ReadLine();
                if (valik == "0") break;

                try
                {
                    switch (valik)
                    {
                        case "1":
                            Console.Write("Sisesta kütusekulu (l/100km): ");
                            if (!double.TryParse(Console.ReadLine(), out double akulu)) throw new Exception("Vale number");
                            Console.Write("Sisesta vahemaa (km): ");
                            if (!double.TryParse(Console.ReadLine(), out double akm)) throw new Exception("Vale number");
                            Console.Write("Sisesta kütuse hind (€/l): ");
                            if (!double.TryParse(Console.ReadLine(), out double ahind)) throw new Exception("Vale number");
                            sõidukid.Add(new Auto(akulu, akm, ahind));
                            break;

                        case "2":
                            Console.Write("Sisesta vahemaa (km): ");
                            if (!double.TryParse(Console.ReadLine(), out double jkm)) throw new Exception("Vale number");
                            sõidukid.Add(new Jalgratas(jkm));
                            break;

                        case "3":
                            Console.Write("Sisesta kütusekulu (l/100km): ");
                            if (!double.TryParse(Console.ReadLine(), out double bkulu)) throw new Exception("Vale number");
                            Console.Write("Sisesta vahemaa (km): ");
                            if (!double.TryParse(Console.ReadLine(), out double bkm)) throw new Exception("Vale number");
                            Console.Write("Sisesta reisijate arv: ");
                            if (!int.TryParse(Console.ReadLine(), out int reisijad)) throw new Exception("Vale number");
                            Console.Write("Sisesta kütuse hind (€/l): ");
                            if (!double.TryParse(Console.ReadLine(), out double bhind)) throw new Exception("Vale number");
                            sõidukid.Add(new Buss(bkulu, bkm, reisijad, bhind));
                            break;

                        case "4":
                            Console.Write("Sisesta vahemaa (km): ");
                            if (!double.TryParse(Console.ReadLine(), out double ekm)) throw new Exception("Vale number");
                            Console.Write("Sisesta hind €/km: ");
                            if (!double.TryParse(Console.ReadLine(), out double ehind)) throw new Exception("Vale number");
                            sõidukid.Add(new Elektritõukeratas(ekm, ehind));
                            break;

                        default:
                            Console.WriteLine("Tundmatu valik.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Viga: " + ex.Message);
                }
            }
            try
            {
                string path = @"..\..\..\Sõiduk.txt";
                using (StreamWriter writer = new StreamWriter(path, false)) // false = перезаписать файл
                {
                    foreach (var s in sõidukid)
                    {
                        if (s is Auto a)
                            writer.WriteLine($"auto,{a.Kütusekulu},{a.Vahemaa},{a.Hind}");
                        else if (s is Jalgratas j)
                            writer.WriteLine($"jalgratas,{j.Vahemaa}");
                        else if (s is Buss b)
                            writer.WriteLine($"buss,{b.Kütusekulu},{b.Vahemaa},{b.ReisijateArv},{b.Hind}");
                        else if (s is Elektritõukeratas e)
                            writer.WriteLine($"tõukeratas,{e.Vahemaa},{e.HindKm}");
                    }
                }
                Console.WriteLine("\nAndmed salvestatud faili Sõiduk.txt");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Faili salvestamise viga: " + ex.Message);
            }

            // 4) Выводим результат
            double totalKulu = 0;
            Console.WriteLine("\nSõidukite info:");
            foreach (var s in sõidukid)
            {
                Console.WriteLine(s);
                totalKulu += s.ArvutaKulu();
            }
            Console.WriteLine($"\nKõigi sõidukite kogukulu: {totalKulu:F2} €");

        }
    }
}

