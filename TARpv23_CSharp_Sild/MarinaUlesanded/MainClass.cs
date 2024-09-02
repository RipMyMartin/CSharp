using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TARpv23_CSharp_Sild.MarinaUlesanded;

public class MainClass
{
    public static void Main(string[] args)
    {
        //I.osa Andmetüübid, Alamfunktsioonid, if

        Console.OutputEncoding = Encoding.UTF8;
        /*Console.WriteLine("Hello Gleb");
        string nimetus = "Python";
        Console.WriteLine("Hello {0}",nimetus);
        Function.Tere(nimetus);
        Console.Write("Sisesta esimene arv:");
        int a= int.Parse(Console.ReadLine());
        Console.Write("Sisesta Teine arv:");
        int b = int.Parse(Console.ReadLine());
        int vastus=Function.Liitmine(a,b);
        Console.WriteLine(vastus);
        double arv = 5.14214251;
        vastus= Function.Liitmine(a,(int)arv);
        Console.WriteLine(vastus);
        char taht = 'A';

        if (vastus == 0)
        {
            Console.WriteLine(taht);

        }
        else
        {
            Console.WriteLine(vastus);
        }
        */


        /*---------------1----------------*/
        /*
        Console.Write("Sisesta esimese inimese nimi: ");
        string nimi1 = Console.ReadLine();
        Console.Write("Sisesta teise inimese nimi: ");
        string nimi2 = Console.ReadLine();
        Console.WriteLine("{0} ja {1} on täna pinginaabrid.", nimi1, nimi2);
        /*--------------------------------*/

        /*---------------2----------------*/
        /*
        Console.Write("Sisestage toa pikkus (meetrites): ");
        double pikkus = Convert.ToDouble(Console.ReadLine());

        Console.Write("Sisestage toa laius (meetrites): ");
        double laius = Convert.ToDouble(Console.ReadLine());

        double pindala = Function.LeiaPindala(pikkus, laius);
        Console.WriteLine("Toa põranda pindala on: {0} ruutmeetrit.", pindala);

        if (Function.KasKasutajaSoovibRemonti())
        {
            double maksumus = Function.ArvutaRemondiMaksumus(pindala);
            Console.WriteLine("Põranda remondi kogumaksumus on: {0} eurot.", maksumus);
        }
        else
        {
            Console.WriteLine("Remonti ei tehta.");
        }
        /*--------------------------------*/

        /*---------------3----------------*/
        /*
        try
        {
        Console.WriteLine("Mis on sinu pikkus");
        double pikkus1 = Convert.ToDouble(Console.ReadLine());
        string vastus= Function.MäärakePikkus(pikkus1);
        Console.WriteLine("Teie pikkus {0} sa oled {1}", pikkus1, vastus);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        /*--------------------------------*/

        /*--------------4----------------*/
        /*
        Console.WriteLine("Mis on teie toa temperatuur");

        /*--------------------------------*/
        /*
        for (int i = 0; i <7; i++)
        {
            Random random = new Random();
            int paev_nr = random.Next(-1, 10);
            string paev_nim = Function.Paevad(paev_nr);
            Console.WriteLine("Päeva:{0}, Number: {1}",paev_nim, paev_nr);
        }
        /*--------------------------------*/


        string[] nimed = new string[5] { "Sergey", "Martin", "Gleb", "Vlad", "Musor" };
        nimed[0] = "HUUUUUU";

        for (int i = 0; i < nimed.Length; i++)
        {
            Console.WriteLine(i + ": " + nimed[i]);
        }
        Console.WriteLine("//----------------------------------------\\");

        foreach (string nimi in nimed)
        {
            Console.WriteLine(nimi);
        }
        Console.WriteLine("//----------------------------------------\\");
        int Num = 0;
        while (Num < nimed.Length)
        {
            Console.WriteLine(nimed[Num]);
            Num++;
        }
        Console.WriteLine("//----------------------------------------\\");

        do
        {
            Console.WriteLine(nimed[Num - 1]);
            Num--;


        }
        while (Num != 0);
    }
}
