using System;
using System.Collections.Generic;

namespace Plant
{
    class PlantGrower
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public PlantGrower(string name, int health)
          {
              Name = name;
              Health = 5;
          }  

        public void StartGame()
        {
            Console.WriteLine("Something that you can do are Water the plant or give it sunshine. [press 1 for water, 2 to give the plant sunshine.");

            string userInput = Console.ReadLine();

            if(userInput== "1")
            {
                Water();
                StartGame();
            }
            else if(userInput == "2")
            {
                Sunshine();
                StartGame();
            }
        
        }

        public void Water()
        {
           Health+= 5;
           Console.WriteLine(Health); 
        }

        public void Sunshine()
        {
            Health+= 10;
            Console.WriteLine(Health);
        }
        

    }
}    