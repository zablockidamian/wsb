using System;

namespace _1_firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#");
            Console.WriteLine("##");
            Console.WriteLine("###");
            /*
             *  #
             *  ##
             *  ###
             */

            string name;
            name = "Anna";
            Console.WriteLine(name);
            Console.WriteLine("Masz na imie: " + name);
            Console.WriteLine("Masz na imie: {0}", name);
            Console.ReadKey();

        }
    }
}
