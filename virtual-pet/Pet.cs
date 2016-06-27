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
        public int MaxHealth { get; set; }
        public int MinHealth { get; set; }
        public bool IsAlive()
        {
            if (Hunger >= MinHealth && Waste >= MinHealth && Activity >= MinHealth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private int _hunger;
        public int Hunger
        {
            get
            {
                return _hunger;
            }
            set
            {
                _hunger = value;
                if (_hunger > 10)
                {
                    _hunger = MaxHealth;
                }
                if (_hunger < MinHealth)
                {
                    IsAlive();
                }
            }
        }
        private int _waste;
        public int Waste
        {
            get
            {
                return _waste;
            }
            set
            {
                _waste = value;
                if (_waste > 10)
                {
                    _waste = MaxHealth;
                }
                if (_waste < MinHealth)
                {
                    IsAlive();
                }
            }
        }

        private int _activity;
        public int Activity
        {
            get
            {
                return _activity;
            }
            set
            {
                _activity = value;
                if (_activity > 10)
                {
                    _activity = MaxHealth;
                }
                if (_activity < MinHealth)
                {
                    IsAlive();
                }
            }
        }

        public Pet()
        {
            Hunger = 5;
            Waste = 5;
            Activity = 5;
            MaxHealth = 10;
            MinHealth = 1;
        }

        public void MainMenu()
        {
            Console.Clear();
            int menuChoice = 0;

            Console.WriteLine("\nChoose an option below.");
            Console.WriteLine("\n1. Health Status");
            Console.WriteLine("2. Feed");
            Console.WriteLine("3. Bathroom Break");
            Console.WriteLine("4. Exercise");

            while (IsAlive())
            {
                string userChoice = Console.ReadLine();
                if (userChoice == "1" || userChoice == "2" || userChoice == "3" || userChoice == "4")
                {
                    menuChoice = Convert.ToInt32(userChoice);
                }

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
                    Console.WriteLine("Invalid entry. Press enter to continue.");
                    Console.ReadLine();
                    MainMenu();
                }
            }
        }

        public void HealthStatus()
        {
            if (!IsAlive())
            {
                Console.WriteLine(PetName + "'s health status has reached 0.");
                Console.WriteLine("\nGAME OVER!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine(PetName + "'s Health Status");
                Console.WriteLine("\nHealth is full at 10");
                Console.WriteLine("Game is over if Health Status reaches 0");
                Console.WriteLine("\n|\\___/|");
                Console.WriteLine("/ _  _ \\      ,--.");
                Console.WriteLine("( @  @ )     / ,-'");
                Console.WriteLine(" \\__t_/-._ ( (");
                Console.WriteLine("/         `.   \\");
                Console.WriteLine("|        _   \\ |");
                Console.WriteLine("\\ \\ ,  /       |");
                Console.WriteLine(" || |-_\\__    /");
                Console.WriteLine("((_ /`(____,-'");
                Console.WriteLine();

                Console.WriteLine("\nHunger   | " + Hunger);
                Console.WriteLine("Waste    | " + Waste);
                Console.WriteLine("Activity | " + Activity);

                Console.WriteLine("\nPress enter to interact with " + PetName + ".");
            }
            Console.ReadKey();          
            MainMenu();
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
                    Hunger++;
                    Waste -= 1;
                    Activity -= 2;
                    HealthStatus();
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
                    Waste++;
                    Hunger -= 2;
                    HealthStatus();
                }
            }
        }

        public void Exercise()
        {
            Tick();
            for (int i = 1; i <= 1; i++)
            {
                if (Activity >= 10)
                {
                    Console.WriteLine("\n" + PetName + " doesn't need to go exercise.");
                }
                else
                {
                    Activity += 1;
                    Hunger -= 2;
                    HealthStatus();
                }
            }
        }

        public int Tick()
        {
            Hunger += 1;
            return 0;
        }
    }
}
