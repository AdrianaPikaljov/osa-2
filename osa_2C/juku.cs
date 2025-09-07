using System;

namespace osa_2C
{
    internal class Juku
    {
        public static void Main(string[] args) {
        Console.WriteLine("Ülesanne 1: Juku kinno");
            juku(args);

        Console.WriteLine(" Ülesanne 2: Pinginaabrid ");
            pinginaaber(args);

        Console.WriteLine("Ülesanne 4: 30% soodustus");
            soodus();

        Console.WriteLine("Ülesanne 5: Temperatuur --");
            temp(args);

        Console.WriteLine("Ülesanne 6: Pikkus ");
            pikk(args);

        Console.WriteLine("Ülesanne 7: Poeostud ");
            leib();

        }


        //1
        public static void juku(string[] args)
        {

            Console.WriteLine("Mis sinu nimi on?");
            string eesnimi = Console.ReadLine();

            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Lähme kinno");
                Console.WriteLine("Sisesta vanus:");
                string vanusSisend = Console.ReadLine();

                int vanusjuku = int.Parse(vanusSisend);
                string pilet = vanus(vanusjuku);
                Console.WriteLine("Sinu pilet on: " + pilet);
            }
            else
            {
                Console.WriteLine("Me ei lähe kinno");
            }
        }

        public static string vanus(int vanusjuku)
        {
            string pilet = "";

            if (vanusjuku <= 0 || vanusjuku > 100)
            {
                pilet = "viga";
            }
            else if (vanusjuku <= 6)
            {
                pilet = "tasuta";
            }
            else if (vanusjuku <= 14)
            {
                pilet = "lastepilet";
            }
            else if (vanusjuku <= 65)
            {
                pilet = "täispilet";
            }
            else
            {
                pilet = "sooduspilet";
            }

            return pilet;
        }

        //5
        public static void temp(string[] args)
        {
            Console.WriteLine("Milline temperatuur on toas?");
            double temp = double.Parse(Console.ReadLine());
            if (temp >= 18)
            {
                Console.WriteLine("Toas on soe");
            }
            else
            {
                Console.WriteLine("Toas on külm");
            }
        }

        //6
        public static void pikk(string[] args)
        {
            Console.WriteLine("Kas sa tahad teada oma pikkust? (jah/ei)");
            string vas = Console.ReadLine();
            if (vas.ToLower() != "jah")
            {
                Console.WriteLine("Olgu, ei küsi siis.");
            }
            else
            {
                try
                {
                    Console.Write("Kirjuta oma pikkus: ");
                    int pikk = int.Parse(Console.ReadLine());


                    string pikk1 = funk.pikkus(pikk);
                    Console.WriteLine($"Sina oled: {pikk1}");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Viga: " + e.Message);
                }
            }
        }

        //2
        public static void pinginaaber(string[] args)
        {
            Console.WriteLine("Kirjuta nimi1:");
            string nimi1 = Console.ReadLine();
            Console.WriteLine("Kirjuta nimi2:");
            string nimi2 = Console.ReadLine();
            Console.WriteLine($"{nimi1} ja {nimi2} on täna pinginaabrid.");
        }

        //7
        public static void leib()
        {
            double summa = 0;

            Console.Write("Kas soovid osta piima (jah/ei)? ");
            if (Console.ReadLine().ToLower() == "jah")
                summa += 1.20;  // piima hind

            Console.Write("Kas soovid osta saia (jah/ei)? ");
            if (Console.ReadLine().ToLower() == "jah")
                summa += 1.00;  // saia hind

            Console.Write("Kas soovid osta leiba (jah/ei)? ");
            if (Console.ReadLine().ToLower() == "jah")
                summa += 1.50;  // leiva hind

            Console.WriteLine($"Kõik ostud kokku maksavad {summa} €.");
        }
        //4
        public static void soodus()
        {
        Console.Write("Sisesta soodushind (30% soodustus): ");
        double soodushind = double.Parse(Console.ReadLine());
        double alghind = soodushind / 0.7;
        Console.WriteLine($"Alghind oli {alghind} €.\n");
        }

    }
}
