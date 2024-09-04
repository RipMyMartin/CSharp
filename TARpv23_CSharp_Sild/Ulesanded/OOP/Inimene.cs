using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp_Sild.Ulesanded.OOP
{
    public enum Sugu
    {
        mees,
        naine
    }
    internal class Inimene
    {
        public string Nimi { get; set; }

        public int Vanus { get; set; }

        public Sugu Sugu { get; set; }
        public int Pikkus { get; set; }
        public double Kaal { get; set; }

        public Inimene() { }

        public Inimene(string nimi)
        {
            Nimi = nimi;
        }

        public Inimene(string nimi, int vanus, int pikkus, double kaal, Sugu sugu = Sugu.mees)
        {
            Nimi = nimi;
            Vanus = vanus;
            Pikkus = pikkus;
            Kaal = kaal;
            Sugu = sugu;
        }
    }
}
