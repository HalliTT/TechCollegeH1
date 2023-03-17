using System;

namespace Automaten
{
    class Program
    {

        static bool LoginOK()
        {
            Console.Write("Indtast brugernavn: ");
            String brugernavn = Console.ReadLine();
            Console.Write("Indtast adgangskode: ");
            String adgangskode = Console.ReadLine();
            if (brugernavn == "Admin" && adgangskode == "Nimda")
                return true;
            else
            {
                Console.WriteLine("Brugernavn og adgangskode er forkert. Tryk en vilkårlig tast for at afslutte.");
                Console.ReadKey();
                return false;
            }
        }

        static int Menu()
        {
            int ret = 0;
            do
            {
                ret = 0;
                Console.WriteLine();
                Console.WriteLine("------ Booking Menu ------");
                Console.WriteLine("1. Vis liste af produkter");
                Console.WriteLine("2. Vis liste af kunder");
                Console.WriteLine("--------------------------");
                Console.WriteLine("x. Afslut program");
                String menuvalg = Console.ReadLine();
                if (menuvalg == "1")
                    ret = 1;
                if (menuvalg == "2")
                    ret = 2;
                if (menuvalg == "x")
                    ret = 10;
            } while (ret == 0);
            return ret;
        }

        static String[] produkter = { "Sofabord lille", "Spisebord 1,20m x 3,00m", "Sofa 3 pers.", "Sofa 2 pers.", "Sækkestol stor", "", "" };
        static String[] kunder = { "Lisa", "Lise", "Lusa", "Lasa", "Lysa", "", "" };


        static void ProduktListe()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(produkter[i]);
            }
        }

        static void KundeListe()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(kunder[i]);
            }
        }

        static void Main(string[] args)
        {
            ///// ------- OPGAVE 2 ------- /////

            //float height;
            //Console.WriteLine("Enter  the Height (in centimeters) \n");
            //height = int.Parse(Console.ReadLine());
            //Console.WriteLine(height);
            //if (height < 150.0)
            //    Console.WriteLine("Dwarf \n");

            //else if ((height >= 150.0) && (height <= 165.0))
            //    Console.WriteLine(" Average Height \n");

            //else if ((height > 165.0) && (height <= 195.0))
            //    Console.WriteLine("Taller \n");

            //else
            //    Console.WriteLine("Abnormal height \n");

            ///// ------- OPGAVE 2 ------- /////
            //string[] Sange = { "Old time road", "Paris", "SOS", "So Am I" };

            //Console.WriteLine("Her er mine ynglingssange");
            //foreach (string i in Sange)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            ///// ------- OPGAVE 3 ------- /////

            // string name, password;

            // name = "Steven";
            // password = "Steven123";

            // if (name == "Steven" && password == "Steven123"){
            //     Console.WriteLine("Login Successful");
            // }

            //else {
            //     Console.WriteLine("Unauthorised access");
            // }

            // Console.ReadLine();

            ///// ------- OPGAVE 4 ------- /////
            //if (LoginOK())
            //{
            //    int valg;
            //    do
            //    {
            //        valg = Menu();
            //        if (valg == 1)
            //            ProduktListe();
            //        if (valg == 2)
            //            KundeListe();
            //    } while (valg != 10);
            //}
        }
    }
}
