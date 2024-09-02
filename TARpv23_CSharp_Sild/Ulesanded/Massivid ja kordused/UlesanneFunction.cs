using System;
using System.Linq;
using System.Reflection.Metadata;

namespace TARpv23_CSharp_Sild.Ulesanded
{
    internal class UlesanneFunction
    {
        private static Random random = new Random();
        public static (int, int) Massiiv()
        {
            Random random = new Random();

            int N = random.Next(-100, 101);
            int M = random.Next(-100, 101);

            int start = Math.Min(N, M);
            int end = Math.Max(N, M);

            return (start, end);
        }

        public static (int sum, double average, int product) SummaAritmeetiline()
        {
            int[] numbers = new int[5];
            int sum = 0;
            int product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Sisestage number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());

                sum += numbers[i];
                product *= numbers[i];
            }

            double average = (double)sum / numbers.Length;

            return (sum, average, product);
        }

        public static (int totalAge, double averageAge, string oldestUser, string youngestUser) NimiSumma()
        {
            var users = new (string Name, int Age)[5];

            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"Sisestage kasutaja nimi {i + 1}:");
                string name = Console.ReadLine();

                Console.WriteLine($"Sisestage kasutaja vanust {i + 1}:");
                int age = int.Parse(Console.ReadLine());

                users[i] = (name, age);
            }

            int totalAge = users.Sum(user => user.Age);
            double averageAge = users.Average(user => user.Age);
            //OrderByDescending -  сортировки коллекции элементов в порядке убывания.

            //OrderBy - ортирует элементы в порядке возрастания.

            //First - ервый элемент коллекции после сортировки.
            var oldestUser = users.OrderByDescending(user => user.Age).First();
            var youngestUser = users.OrderBy(user => user.Age).First();

            return (totalAge, averageAge, oldestUser.Name, youngestUser.Name);
        }

        public static string OstaTsukell()
        {
            string kiri = "";

            while (kiri != "elevant")
            {
                Console.WriteLine("Osta elevant ära!");
                kiri = Console.ReadLine();
            }

            Console.WriteLine("Aitäh! Oled nüüd elevandi omanik!");
            return kiri;
        }
        public static string Randnum()
        {
            int arvutiArv = random.Next(1, 11);
            int katsed = 5;

            Console.WriteLine("Arvuti mõtles välja arvu 1 kuni 10. Sul on 5 katset, et see ära arvata.");

            for (int i = 1; i <= katsed; i++)
            {
                Console.Write($"Katse {i}. Sisesta oma arv: ");
                int kasutajaArv = int.Parse(Console.ReadLine());

                if (kasutajaArv < arvutiArv)
                {
                    Console.WriteLine("Sinu arv on väiksem kui arvuti arv.");
                }
                else if (kasutajaArv > arvutiArv)
                {
                    Console.WriteLine("Sinu arv on suurem kui arvuti arv.");
                }
                else
                {
                    return $"Õige! Arvuti mõtles välja arvu {arvutiArv}.";
                }
            }

            return $"Kahjuks sa ei arvanud õigesti. Arvuti mõtles välja arvu {arvutiArv}.";
        }
    }
}