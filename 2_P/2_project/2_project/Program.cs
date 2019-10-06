using System;

namespace _2_project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Podaj bok a: ");
            string a = Console.ReadLine();
            double boka = double.Parse(a);

            double pole = boka * boka;

            Console.WriteLine("Pole kwadratu wynosi: {0}", pole);
            Console.ReadKey();
            */
            //pole kwadratu




            /*
            Console.WriteLine("Podaj bok a: ");
            string a = Console.ReadLine();
            double bok = double.Parse(a);
            Console.WriteLine("Podaj wysokosc trojkata: ");
            string h = Console.ReadLine();
            double wys = double.Parse(h);

            double pole = (bok * wys) / 2;

            Console.WriteLine("Pole trojkata: {0}", pole);
            Console.ReadKey();
            */
            //pole trojkata

            /*
            uint liczba;
            Console.WriteLine("Podaj liczbe calkowita: ");
            string str = Console.ReadLine();
            if (uint.TryParse(str, out liczba) == true)
            {
                if (liczba % 2 == 0)
                    Console.WriteLine("Liczba wynosi: {0}", liczba);
                else
                    Console.WriteLine("Liczba nie jest parzysta");

            }
            else Console.WriteLine("Zly format liczby");

            Console.ReadKey();
            */

            //Sprawdz czy liczba podana z klawiatury jest prawidolowa i parzysta


            int liczba = 11;

            switch(liczba)
            {
                case 1:
                    Console.WriteLine("Liczba ma wartosc 5");
                    break;

                case 2:
                    Console.WriteLine("Liczba ma wartosc 10");
                    break;

                case 3:
                    Console.WriteLine("Liczba ma wartosc 15");
                    break;

                default:
                    Console.WriteLine("Liczba ma wartosc inna wartosc");
                    break;


            }
            Console.ReadKey();

            // switch i case

        }
    }
}
