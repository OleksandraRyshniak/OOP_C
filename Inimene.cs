using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public abstract class Inimene
    {
        public string Nimi; //объекты
        public int Vanus;
        public Inimene() { } //1 способ - конструктор

        public Inimene(string nimi, int vanus) //2 способ - конструктор
        {
            Nimi = nimi;
            Vanus = vanus;
        }

        public void Tervita() // - действие
        {
            Console.WriteLine("Tere! Mina olen " + Nimi);
        }

        public abstract void Mida_teeb();
    }
}
