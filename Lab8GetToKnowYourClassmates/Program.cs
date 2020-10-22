using System;

namespace Lab8GetToKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {

            bool runProgram = true;

            string[] studentName = { "Pin", "Bob", "Sue", "Lauren", "Phil", "Lindsey", "Juan", "Jim", "Shai", 
                "Belle", "Lou", "LeBron", "Kobe", "Michael", "Brad", "William", "Smith", "Joey", "Shyu", "Kyrie" };

            string[] homeTown = { "Lansing", "Detroit", "Pontiac", "Warren", "Waterloo", "Kansas City", "Austin", "Louisville", 
                "Duluth", "Grand Haven", "Grand Rapids", "Muskegon", "Auburn Hills", "Rochester", "St. Clair", "St. Louis", 
                "Los Angeles", "Dallas", "Houston", "Atlanta" };

            string[] favoriteFoods = {"Fried Rice", "Pizza", "Yogurt", "Bannanas", "Apples", "Oranges", "Pears", "Burgers", 
                "Sushi", "Lettuce", "Tacos", "Fries", "Cheese", "Chips", "Salads","Spinach", "Pancakes", "Cereal", "Waffles", "Pasta"};

            string[] favoriteColor = { "red", "blue", "yellow", "green", "orange", "black", "white", "beige", "purple", "pink", "mauve",
                "navy blue", "forest green", "grey", "poop brown", "red", "red", "red", "black", "white" };

            string[] favoriteSport = { "basketball", "football", "hockey", "baseball", "soccer", "bowling", "swimming", "basketball", 
                "football", "hockey", "baseball", "soccer", "bowling", "swimming", "basketball", "football", "hockey", "baseball", "soccer", "bowling" };


            Console.WriteLine("Welcome to our C# class!");

            while (runProgram)
            {
                try
                {
                    int inputNumber = int.Parse(GetUserInput("Which student would you like to learn more about? (enter a number from 1-20): "));

                    Console.WriteLine($"Student {inputNumber} is {studentName[inputNumber - 1]}. What would you like to know about {studentName[inputNumber - 1]}? (enter hometown, favorite food, favorite color, or favorite sport)? ");

                    string userInterst = Console.ReadLine().ToLower().Trim();
                    userInterst = ValidateUserInterest(userInterst, "\nSorry, that data doesn't exist. Enter hometown, favorite food, favorite color, or favorite sport.");

                    if (userInterst == "hometown")
                    {
                        Console.WriteLine($"\n{studentName[inputNumber - 1]}'s hometown is {homeTown[inputNumber-1]}.");
                    }
                    else if (userInterst == "favorite food")
                    {
                        Console.WriteLine($"\n{studentName[inputNumber - 1]}'s favorite food is {favoriteFoods[inputNumber-1]}.");
                    }
                    else if (userInterst == "favorite color")
                    {
                        Console.WriteLine($"\n{studentName[inputNumber - 1]}'s favorite color is {favoriteColor[inputNumber-1]}.");
                    }
                    else if (userInterst == "favorite sport")
                    {
                        Console.WriteLine($"\n{studentName[inputNumber - 1]}'s favorite sport is {favoriteSport[inputNumber-1]}.");
                    }
                }
                
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a number next time!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("\nSorry, that student does not exist.");
                }

                runProgram = ValidateContinue("\nWould you like to learn about another student? (y/n) ");

            }

        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string UserInput = Console.ReadLine();
            return UserInput;
        }

        public static string ValidateUserInterest(string UserInterest, string message)
        {
            while(UserInterest != "hometown" && UserInterest != "favorite food" && UserInterest != "favorite color" && UserInterest != "favorite sport")
            {
                Console.WriteLine(message);
                UserInterest = Console.ReadLine().ToLower().Trim();
            }
            return UserInterest;

        }

        public static bool ValidateContinue(string message)
        {
            Console.WriteLine(message);
            
            string userInput = Console.ReadLine().ToLower();

            while (userInput != "y" && userInput !="n")
            {
                Console.WriteLine($"Invalid answer!\n{message}");
                userInput = Console.ReadLine().ToLower();
            }
                
            if(userInput =="y")
            { 
                return true;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Thank you. Have a nice day!");
                return false;
            }

        }

    }
}
