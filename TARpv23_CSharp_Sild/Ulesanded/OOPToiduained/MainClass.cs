using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp_Sild.Ulesanded.OOPToiduained
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Sisestage nimi");
            string nimi = (Console.ReadLine());

            Console.WriteLine("Enter your age:");
            int vanus = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your height in cm:");
            int pikkus = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight in kg:");
            double kaal = double.Parse(Console.ReadLine());

            Console.WriteLine("Select your gender (mees = 0, naine = 1):");
            Sugu sugu = (Sugu)int.Parse(Console.ReadLine());

            Console.WriteLine("Select your lifestyle: 0=Istuv, 1=Vähene, 2=Mõõdukas, 3=Kõrge, 4=Väga:");
            Eluviis eluviis = (Eluviis)int.Parse(Console.ReadLine());

            Inimene inimene = new Inimene(vanus, pikkus, kaal, sugu);

            double bmr = inimene.HBVorrand(eluviis);

            // Output the result
            Console.WriteLine($"The BMR for {inimene.Nimi} is {bmr:F2} calories/day.");
        }
    }
}
