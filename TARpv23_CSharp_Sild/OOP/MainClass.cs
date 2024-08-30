using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp_Sild.OOP
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding= Encoding.UTF8;

            List<Inimene> inimesed = new List<Inimene>();

            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Peeter";
            inimene1.Vanus = 18;

            Inimene inimene2= new Inimene("Jelizaveta");
            inimene2.Vanus = 98;

            Inimene inimene3 = new Inimene("Marina", 45);

            inimesed.Add(inimene1);
            inimesed.Add(inimene2);
            inimesed.Add(inimene3);

            inimesed.Add(new Inimene("Irina", 45));

            foreach (Inimene inimene in inimesed)
            {
                Console.WriteLine(inimene.Nimi + " " + inimene.Vanus + " aasta vana");
            }
        }

    }
}
