﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp_Sild.OOP
{
    internal class Auto
    {
        public string RegNumber { get; set; }
        public Color Varv { get; set; }
        public Inimene Omanik { get; set; }

        public Auto() { }

        public Auto(string regnumber, Color varv, Inimene omanik)
        {
            RegNumber = regnumber;
            Varv = varv;
            Omanik = omanik;
        }

        public void KelleOmaAuto()
        {
            Console.WriteLine($"{Varv.Name} auto regnumber {RegNumber} on {Omanik.Nimi} oma");
        }
    }
}
