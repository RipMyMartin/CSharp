using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARpv23_CSharp_Sild.Ulesanded.OOP
{
    internal class Func
    {
        public static void Ull()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Sisestage nubmer: ");

            string numbstr = Console.ReadLine();
            string[] numbList = numbstr.Split(" ");
            int[] newList = new int[numbList.Length];

            for (int i = 0; i < numbList.Length; i++)
            {
                int a;
                if (i == 0)
                {
                    a = int.Parse(numbList[numbList.Length - 1]) + int.Parse(numbList[i + 1]);
                }
                else if (i == numbList.Length - 1)
                {
                    a = int.Parse(numbList[i - 1]) + int.Parse(numbList[0]);
                }
                else
                {
                    a = int.Parse(numbList[i - 1]) + int.Parse(numbList[i + 1]);
                }

                newList[i] = a;
            }

            Console.WriteLine("New list of sums: ");
            Console.WriteLine(string.Join(", ", newList));
        }
    }
}
