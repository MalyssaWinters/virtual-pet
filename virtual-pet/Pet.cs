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
        public int Feed { get; set; }
        public int Waste { get; set; }
        public int Exercise { get; set; }
        

        public Pet()
        {
            Feed = 10;
            Waste = 10;
            Exercise = 10;
            
        }

        public int MainMenu()
        {
            Console.Clear();
            int menuChoice = 0;

            Console.WriteLine("\nChoose an option below to interact with " + PetName + ".");
            Console.WriteLine("\n1. Feed");
            Console.WriteLine("2. Waste");
            Console.WriteLine("3. Exercise");
           
            while (true)
            {
                if (menuChoice == 1)
                {
                    Hunger();
                }
                else if (menuChoice == 2)
                {
                    Bathroom();
                }
                else if (menuChoice == 3)
                {
                    Active();
                }
                else
                {
                    while (menuChoice < 1 || menuChoice > 3)
                    {
                        try
                        {
                            string userChoice = Console.ReadLine();
                            menuChoice = Convert.ToInt32(userChoice);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Invalid entry. Choose options 1-3.");
                        }
                    }
                }
            }
            return menuChoice;
        }

        public int Hunger()
        {
            Console.WriteLine(PetName + "'s hunger level is at {0}.",Feed);
            return 0;
        }

        public int Bathroom()
        {
            Console.WriteLine(PetName + "'s bathroom status is at {0}.",Waste);
            return 0;
        }

        public int Active()
        {
            Console.WriteLine(PetName + "'s activity level is at {0}.",Exercise);
            return 0;
        }
      
        private int Tick()
        {
            return 0;
        }
    }
}
