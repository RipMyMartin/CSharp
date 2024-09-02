using System.Drawing;
using System.Text;

namespace TARpv23_CSharp_Sild.OOP
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Inimene> inimesed = new List<Inimene>();

            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Peeter";
            inimene1.Vanus = 18;

            Inimene inimene2 = new Inimene("Jelizaveta");
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

            Auto auto1 = new Auto("123ABC", Color.Aqua, inimene1);
            Auto auto2 = new Auto("876CDE", Color.DarkGray, inimene1);
            Auto auto3 = new Auto("097EJK", Color.Gold, inimene1);
            auto1.KelleOmaAuto();

            Dictionary<Auto, Inimene> register = new Dictionary<Auto, Inimene>();

            register.Add(auto1, inimene1);
            register.Add(auto2, inimene2);
            register.Add(auto3, inimene3);

            foreach (var item in register)
            {
                Console.WriteLine($"{item.Key.RegNumber} - {item.Value.Nimi}");
            }

            foreach (KeyValuePair<Auto, Inimene> pair in register)
            {
                Console.WriteLine($"{pair.Key.RegNumber} - {pair.Value.Nimi}");
            }

            List<int> numbers = new List<int>();
            Random rand = new Random();
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(rand.Next(0, 100));
            }

            List<int> evenNumbers = numbers.Where(n => n % 2 == 0).ToList();

            List<int> addNumbers = numbers.Where(n => n % 2 != 0).ToList();

            List<int> sortNumbers = evenNumbers.Concat(addNumbers).ToList();

            Console.WriteLine("Sorteeritud numbers: ");

            sortNumbers.ForEach(n => Console.WriteLine(n + " "));


            // Küsime kasutajalt andmed
            Console.WriteLine("Sisestage oma kaal (kg):");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage oma pikkus (cm):");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage oma vanus:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisestage oma sugu (mees/naine):");
            string gender = Console.ReadLine();

            Console.WriteLine("Sisestage oma aktiivsustase (istuv, vähene, mõõdukas, kõrge, väga kõrge):");
            string activityLevel = Console.ReadLine();

            // Arvutame BMR ja päevased kalorid
            double bmr = ToiduaindeFunc.CalculateBMR(weight, height, age, gender);
            double dailyCalories = ToiduaindeFunc.CalculateDailyCalories(bmr, activityLevel);

            Console.WriteLine($"Teie päevane kaloraaž on: {dailyCalories.ToString("F1")} kalorit.");

            // Kuvame toiduainete nimekirja ja arvutame koguse
            Dictionary<string, double> foodList = ToiduaindeFunc.GetFoodList();
            Console.WriteLine("\nTe võite süüa järgmisi toiduaineid:");

            foreach (var food in foodList)
            {
                double portion = ToiduaindeFunc.CalculateFoodPortion(dailyCalories, food.Value);
                Console.WriteLine($"{food.Key}: {portion.ToString("F1")} grammi");
            }

            List<Inimene> inimenes= new List<Inimene>();
            Inimene inimene1 = new Inimene();
            inimene1.Nimi = "Pjor 1";
            inimene1.Vanus = 352;
            inimene1.Sugu = Sugu.mees;
            inimene1.Pikkus = 200;
            inimene1.Kaal = 100;
            
            Inimene inimene2 = new Inimene("Jelezaveta");
        }   
    }
}
