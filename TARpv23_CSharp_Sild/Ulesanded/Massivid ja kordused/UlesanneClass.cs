using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp_Sild.Ulesanded
{
    internal class UlesanneClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("//----------------------------------------\\");
            /*
            (int start, int end) = UlesanneFunction.Massiiv();

            Console.WriteLine("Numbrid {0} kuni {1} ja nende ruudud:", start, end);

            for (int i = start; i <= end; i++)
            {
                int square = i * i;
                Console.WriteLine("{0}^2 = {1}", i, square);
            }

            Console.WriteLine("//----------------------------------------\\");

            (int sum, double average, int product) = UlesanneFunction.SummaAritmeetiline();

            Console.WriteLine($"Numbrite summa: {sum}");
            Console.WriteLine($"aritmeetiline keskmine: {average}");
            Console.WriteLine($"Numbrite korrutis: {product}");

            Console.WriteLine("//----------------------------------------\\");

            (int totalAge, double averageAge, string oldestUser, string youngestUser) = UlesanneFunction.NimiSumma();

            Console.WriteLine($"Kasutajate vanuste summa: {totalAge}");
            Console.WriteLine($"Keskmine vanus: {averageAge:F2}");
            Console.WriteLine($"Vanima kasutaja nimi: {oldestUser}");
            Console.WriteLine($"Noorima kasutaja nimi: {youngestUser}");

            Console.WriteLine("//----------------------------------------\\");

            string tsukell = UlesanneFunction.OstaTsukell();
            Console.WriteLine(tsukell);

            Console.WriteLine("//----------------------------------------\\");

            string arvamus = UlesanneFunction.Randnum();
            Console.WriteLine(arvamus);
            */

            List<string> abc = new List<string>();
            try
            {
                foreach (string rida in File.ReadAllLines(@"..\..\..\..\ABC.txt"))
                {
                    abc.Add(rida);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("DALBOЁB!!!");
            }
            foreach (string e in abc)
            {
                Console.WriteLine(e);
            }
            Console.ReadLine();


            ArrayList arrayList= new ArrayList();
            arrayList.Add("Esimene");
            arrayList.Add("Teine");
            arrayList.Add("Kolmas");
            Console.WriteLine("Otsing");
            string vastus = Console.ReadLine();

            if (vastus !=null && arrayList.Contains(vastus))
            {
                Console.WriteLine("Otsitav element asub " + arrayList.IndexOf(vastus) + ".kohal ");
            }
            else
            {
                Console.WriteLine("Kokku oli " + arrayList.Count + "elemente, vaid otsitav puudub ");
            }
            arrayList.Clear();
            arrayList.Insert(0, "Anna");
        }
    }
}
