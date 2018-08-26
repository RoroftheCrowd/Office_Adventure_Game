using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace textAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            gameTitle();
            first();

        }

        public static void gameTitle()
        {
            Console.WriteLine("Welcome to C# Adventure");
            Console.WriteLine("Press 'Enter' to start.");
            Console.ReadLine();
            Console.Clear();
            first();
        }

        public static void first()
        {
            string choice;

            Console.WriteLine("You wake up in your office with an angry Mr.Briggs looming over you.");
            Console.WriteLine("What do you do ?");
            Console.WriteLine("1. Punch him.");
            Console.WriteLine("2. Cry.");
            Console.WriteLine("3. Wet yourself.");
            Console.Write("Choice: ");
            choice = Console.ReadLine().ToLower();
            Console.Clear();

            switch (choice)
            {
                case "1":
                case "punch him":
                case "punch":
                    {
                        Console.WriteLine("Your fist pounds into Mr. Brigg's face.");
                        Console.WriteLine("All the other employees in the office cheer your name.");
                        Console.WriteLine("His wife hears the commotion and comes to investigate ");
                        Console.WriteLine("When she sees her husband's nose bleeding, she gets her wooden spoon");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                case "cry":
                    {
                        Console.WriteLine("Mr Brigg's face is red with anger");
                        Console.WriteLine("Go and cry out in the hall");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        second();
                        break;
                    }

                case "3":
                case "wet":
                case "wet a little":
                    {
                        Console.WriteLine("Mr. Brigg gets a whiff of it. The other employees begin to plug their nostrils.");
                        Console.WriteLine("If your gonna act like the terrier on my lawn every morning then take it outside.");
                        Console.WriteLine("Press 'Enter' to continue");
                        Console.ReadLine();
                        second();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("I don't understand that command...");
                        Console.WriteLine("Press 'Enter' to try again.");
                        Console.ReadLine();
                        first();
                        break;
                    }
            
        }

        }
        public static void second()
        {
            Random rnd = new Random();
            string[] secOptions = {"In the hallway, you see that police are searching lockers.",
                    "In the hallway, you see your stalker walking toward you.",
                    "In the hallway, the fire alarm goes off."};
            int randomNumber = rnd.Next(0, 3);
            string secText = secOptions[randomNumber];

            string secChoice;

            Console.WriteLine(secText);
            Console.WriteLine("Do you try to hide in the bathroom; Yes or No ?");
            Console.Write("Choice: ");
            secChoice = Console.ReadLine().ToLower();

            if (secChoice == "yes" || secChoice == "y")
            {
                third();
            }
            else if (secChoice == "no" || secChoice == "n")
            {
                Console.WriteLine("An Asteroid slams into the office at the exact moment, killing you instantly.");
                Console.WriteLine("Press 'Enter' to continue.");
                Console.ReadLine();
                first();

            }

        }

        public static void third()
        {
            int age;

            Console.WriteLine("You leg it for the toilet and all of your friends and family are there.");
            Console.WriteLine("They yell 'Surprise!' and you remember it's your birthday");
            Console.WriteLine("How old are you ?");
            Console.Write("Age: ");
            int.TryParse(Console.ReadLine(), out age);

            while(age < 65)
            {
                Console.WriteLine("Seriously ? You look older than that!");
                Console.WriteLine("How old are you really?");
                Console.Write("Age: ");
                int.TryParse(Console.ReadLine(), out age);

            }

            Console.WriteLine("Wow, you're old! You must have been in this industry for quite some time");
            Console.WriteLine("Press 'Enter' to continue.");
            Console.ReadLine();
            youWin();
        }

        public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("At your funeral, they sing songs of your bravery. \nThen, they remember who's funeral they are attending and they take it all back.");
            Console.WriteLine("Better luck next time");
            Console.WriteLine("Press 'Enter' to play again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("Your birthday party was a big hit. \nThe cake was lovely.");
            Console.WriteLine("Great Job! You Won!");
            Console.WriteLine("Press 'Enter' to play again.");
            Console.ReadLine();
            Console.Clear();
            gameTitle();
        }
    }
}
