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
            Inimene inimene1 = new Inimene(); // 1. способ
            inimene1.Nimi = "Juku";
            inimene1.Vanus = 12;
            inimene1.Tervita();

            Inimene inimene2 = new Inimene("Kati", 23); // 2. способ
            inimene2.Tervita();

            Töötaja töötaja1 = new Töötaja();
            töötaja1.Nimi = "Mati";
            töötaja1.Vanus = 45;
            töötaja1.Ametikoht = "Autojuht";
            töötaja1.Tervita();
            töötaja1.Töötan();


            Klass õpilane1 = new Klass();
            õpilane1.Nimi = "Mari";
            õpilane1.Vanus = 14;
            õpilane1.Klas = 7;

        }
    }
}
