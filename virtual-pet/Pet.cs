using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtual_pet
{
    class Pet
    {
        public string PetName { get; set; }
        public int Hunger { get; set; }
        public int Waste { get; set; }
        public int Activity { get; set; }


        public Pet()
        {
            Hunger = 10;
            Waste = 10;
            Activity = 10;
        }

        public int MainMenu()
        {
            Console.Clear();
            int menuChoice = 0;

            Console.WriteLine("\nChoose an option below.");
            Console.WriteLine("\n1. Health Status");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Bathroom Break");
            Console.WriteLine("4. Exercise");
                                   
            while (true)
            {
                string userChoice = Console.ReadLine();
                menuChoice = Convert.ToInt32(userChoice);

                if (menuChoice == 1)
                {
                    HealthStatus();
                }
                else if (menuChoice == 2)
                {
                    Feed();
                }
                else if (menuChoice == 3)
                {
                    Bathroom();
                }
                else if (menuChoice == 4)
                {
                    Exercise();
                }
                else
                {
                    Console.WriteLine("Invalid entry. Please choose option from list above.");
                }
            }
        }

        public int HealthStatus()
        {
            Console.Clear();

            Console.WriteLine(PetName + "'s Health Status");
            Console.WriteLine("\nHunger   | " + Hunger);
            Console.WriteLine("Waste    | " + Waste);
            Console.WriteLine("Activity | " + Activity);

            Console.WriteLine("\nPress enter to interact with " + PetName + ".");
            Console.ReadKey();

            return MainMenu();
         }

        public void Feed()
        {
            for (int i = 1; i <= 1; i++)
            {
                if (Hunger >= 10)
                {
                    Console.WriteLine("\n" + PetName + " is full!");
                }
                else
                {
                    Hunger += 1;
                }
            }
        }
        
        public void Bathroom()
        {
            for (int i = 1; i <= 1; i++)
            {
                if (Waste >= 10)
                {
                    Console.WriteLine("\n" + PetName + " doesn't need to go out.");
                }
                else
                {
                    Waste += 1;
                }
            }
        }

        public void Exercise()
        {
            for(int i = 1; i <= 1; i++)
            {
                if (Activity >= 10)
                {
                    Console.WriteLine("\n" + PetName + " doesn't need to go exercise.");
                }
                else
                {
                    Activity += 1;
                }
            }
        }

        public int Tick()
        {
            return 0;
        }
    }
}
