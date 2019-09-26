using System;
using System.Collections.Generic;
using Plant;

class Program
{
    static void Main()
    {
        Console.WriteLine("Congratulations on your new plant!");
        Console.WriteLine("Good luck keeping it alive.");
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        PlantGrower newPlant = new PlantGrower(userName, 5);
        newPlant.StartGame();
    }
}