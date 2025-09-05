using System;

namespace osa_2C
{
    internal class Juku
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine("Mis sinu nimi on?");
        //    string eesnimi = Console.ReadLine();

        //    if (eesnimi.ToLower() == "juku")
        //    {
        //        Console.WriteLine("Lähme kinno");
        //        Console.WriteLine("Sisesta vanus:");
        //        string vanusSisend = Console.ReadLine();


        //        int vanusjuku = int.Parse(vanusSisend);

        //        string pilet = vanus(vanusjuku);
        //        Console.WriteLine("Sinu pilet on: " + pilet);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Me ei lähe kinno");
        //    }
        //}

        //public static string vanus(int vanusjuku)
        //{
        //    string pilet = "";

        //    if (vanusjuku <= 0 || vanusjuku > 100)
        //    {
        //        pilet = "viga";
        //    }
        //    else if (vanusjuku <= 6)
        //    {
        //        pilet = "tasuta";
        //    }
        //    else if (vanusjuku <= 14)
        //    {
        //        pilet = "lastepilet";
        //    }
        //    else if (vanusjuku <= 65)
        //    {
        //        pilet = "täispilet";
        //    }
        //    else
        //    {
        //        pilet = "sooduspilet";
        //    }

        //    return pilet;
        //}
        public static void temp(string[] args)
        {
            Console.WriteLine("Milline temperatuur on toas?");
            double temp = double.Parse(Console.ReadLine());
            if (temp >= 18)
            {
                Console.WriteLine("toas on soe");
            }

            else
            {
                Console.WriteLine("toas on kulm");
            }
        }
            public static void Main(string[] args)
        {
            Console.WriteLine("kas sa tahad tead pikk?");
            string vas = Console.ReadLine();
            if (vas.ToLower() != "jah")
            {
                Console.WriteLine("bebe loh ");
            }
            else
            {
                try
                {
                    Console.Write("kirjuta oma pikkust:");
                    int pikk = int.Parse(Console.ReadLine());
                    string pikk1 = funk.pikkus(pikk);
                    Console.WriteLine($"sina oled: {pikk1}");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            }




        }

    }
}
