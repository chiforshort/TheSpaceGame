using System;
using System.Collections.Generic;
using System.Text;

namespace TheSpaceGame
{
    class Story
    {
        public static void Introduction()
        {
            Console.WriteLine("Welcome to the Space Game! \n\nYour family has run into some trouble. Money is running low and there's only one way to settle your debt.");
            Console.WriteLine("Work your way throughout different planets, make those trades, and find a way to win back your money. \nYour family is depending on it!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void UserCharacter()
        {
            Console.WriteLine("Choose your characters name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("\nHello " + userName + ", you're almost ready to start your quest. \nLast thing you need to do is choose your ship!");
            Console.ReadLine();
            Console.Clear();
        }

        public static void ShipMessage()
        {
            Console.WriteLine("You have three ships to choose from: ");
            Console.WriteLine("Ship 1: \nSpeed: Fast (between 8-10 times the speed of light \nCapacity: Low");
            Console.WriteLine("\nShip 2: \nSpeed: Medium (between 4-7 times the speed of light) \nCapacity: Medium");
            Console.WriteLine("\nShip 3: \n Speed: Slow (between 1-3 times the speed of light) \nCapacity: Large");
            Console.WriteLine("Which would you like to choose?");



        }

        public static void TravelMessage()
        {
            Console.WriteLine("Select a planet to travel to:"); 

        }

         /* public static void ArrivalMessage()
        {
            string greeting = $"Welcome to {planet}, {userName}!";
            Console.WriteLine(greeting);
            Console.WriteLine("");
            Console.WriteLine("Select the items you wish to purchase:");
            Console.WriteLine("1. Food \n2.Weapons/Ammo \n3. Luxury Goods \n4. Minerals/Ore ");

        } */
    }
}
