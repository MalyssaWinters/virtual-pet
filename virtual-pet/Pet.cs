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
        public int VisitVet { get; set; }
        
        public void MainMenu()
        {
            Console.WriteLine("\nChoose an option below to interact with " + PetName +".");
            Console.WriteLine("\n1. Feed");
            Console.WriteLine("2. Waste");
            Console.WriteLine("3. Exercise");
            Console.WriteLine("4. Visit Vet");
        }

        
    }
}
