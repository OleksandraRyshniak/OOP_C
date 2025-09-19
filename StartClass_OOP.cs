using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class StartClass_OOP
    {
        public static void Main(string[] args)
        {
            //// Inimene inimene1 = new Inimene(); // 1. способ

            //Töötaja inimene1 = new Töötaja(); // 1. способ
            //inimene1.Nimi = "Juku";
            //inimene1.Vanus = 12;
            //inimene1.Tervita();

            //Töötaja inimene2 = new Töötaja();
            //inimene2.Mida_teeb();

            //Töötaja töötaja1 = new Töötaja();
            //töötaja1.Nimi = "Mati";
            //töötaja1.Vanus = 45;
            //töötaja1.Ametikoht = "Autojuht";
            //töötaja1.Tervita();
            //töötaja1.Töötan();
            //töötaja1.Mida_teeb();

            //töötaja1.Tunnid = 160;
            //double palk = töötaja1.ArvutaPalk();
            //Console.WriteLine($"{töötaja1.Nimi} teenib kuus {palk} eurot.");
            //Console.WriteLine($"Algne konto on {töötaja1.Konto.Saldo} eurot.");
            //töötaja1.Konto.Saldo += palk;
            //Console.WriteLine($"Pärast palka on kontol {töötaja1.Konto.Saldo} eurot.");
            //töötaja1.Konto.Võta_raha(200);
            //Console.WriteLine($"Pärast sularaha võtmist on kontol {töötaja1.Konto.Saldo} eurot.");
            //töötaja1.Konto.Lisa_raha(500);
            //Console.WriteLine($"Pärast raha lisamist on kontol {töötaja1.Konto.Saldo} eurot.");

            //Klass õpilane1 = new Klass("Mari", 14, 7);
            //õpilane1.Tervita();
            //õpilane1.Õpin();

            //Kool õpilane2 = new Kool("Jaan", 16, "Kool 3");
            //õpilane2.Kooli();

            //Koer koer = new Koer("Huk", 1);
            //koer.TeeHääl();

            //Kass kass = new Kass("Huk", 1);
            //kass.TeeHääl();

            List<IKujund> kujundid = new List<IKujund>();
            while (true)
            {
                Console.WriteLine("\nVali kujund: 1=Ruut, 2=Ring, 3=Kolmnurk, 0=Välju");
                string valik = Console.ReadLine();

                if (valik == "0") break;

                switch (valik)
                {
                    case "1":
                        Console.Write("Sisesta küljepikkus: ");
                        double külg = double.Parse(Console.ReadLine());
                        kujundid.Add(new Ruut(külg));
                        break;

                    case "2":
                        Console.Write("Sisesta raadius: ");
                        double r = double.Parse(Console.ReadLine());
                        kujundid.Add(new Ring(r));
                        break;

                    case "3":
                        Console.Write("Sisesta kolm külge (A B C): ");
                        string[] osad = Console.ReadLine().Split();
                        double a = double.Parse(osad[0]);
                        double b = double.Parse(osad[1]);
                        double c = double.Parse(osad[2]);
                        kujundid.Add(new Kolmnurk(a, b, c));
                        break;

                    default:
                        Console.WriteLine("Tundmatu valik.");
                        break;
                }
            }
            Console.WriteLine("\n--- Kujundite tulemused ---");
            foreach (var kujund in kujundid)
            {
                Console.WriteLine($"Pindala: {kujund.ArvutaPindala():F2}, Ümbermõõt: {kujund.ArvutaÜmbermõõt():F2}");
            }

        }
    }
}
