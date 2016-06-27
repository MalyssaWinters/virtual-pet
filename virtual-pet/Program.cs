using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_pet
{
    class Program
    {
        /*
        * Welcome message
        * Create pet name
        * 
        * Pull lever
        * Randomly rolls around and gives you 
        * Machine tells you if you won or not
        */

        static void Main(string[] args)
        {
            Pet myPet = new Pet();

            Console.WriteLine("Welcome, meet your new pet cat!");

            Console.WriteLine("\n|\\___/|");
            Console.WriteLine("/ _  _ \\      ,--.");
            Console.WriteLine("( @  @ )     / ,-'");
            Console.WriteLine(" \\__t_/-._ ( (");
            Console.WriteLine("/         `.   \\");
            Console.WriteLine("|        _   \\ |");
            Console.WriteLine("\\ \\ ,  /       |");
            Console.WriteLine(" || |-_\\__    /");
            Console.WriteLine("((_ /`(____,-'");

            Console.WriteLine("\nPlease name your cat.");
            myPet.PetName = Console.ReadLine();

            while (myPet.IsAlive())
            {
                myPet.HealthStatus();
            }
        }
    }
}
