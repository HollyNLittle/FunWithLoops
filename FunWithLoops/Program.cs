using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Loops, automation, DRY!!!! DON'T REPEAT YOURSELF
            //foreach loop - USE TO GO THROUGH EACH ELEMENT
            //foreach loops through entire array
            string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Oct", "Nov", "Dec" };
            foreach (string month in months)
            {
                Console.WriteLine(month);
                if (month == "Dec")
                {
                    Console.WriteLine("December is the BEST month!");
                }
                else
                {
                    Console.WriteLine("That month is ok I guess......");
                }
            }
            Console.WriteLine("\n");
            string[] musicians = { "U2", "Maroon5", "Ed Sheeran", "Nas", "Jay-Z" };
            foreach (string band in musicians)
            {
                Console.WriteLine(band);
            }

            //Create a program that asks the user for their favorite food and stores that value in an array.
            //Loop through the array and print all of the foods. 
            //string[] foods = new string[3];
            //Console.WriteLine("What is your favorite food? ");
            //string firstFood = Console.ReadLine();
            //foods[0] = firstFood;
            //Console.WriteLine("What is your favorite food? ");
            //string secondFood = Console.ReadLine();
            //foods[1] = secondFood;
            //Console.WriteLine("What is your favorite food? ");
            //string thirdFood = Console.ReadLine();
            //foods[2] = thirdFood;
            //foreach (string favorite in foods)
            //{
            //    Console.WriteLine(favorite);
            //}

            //Create an array of lucky numbers using a foreach loop print the following:
            //Your Lucky number is: 4
            //Your Lucky number is: 19
            //Your Lucky number is: 7
            int[] luckyNumbers = { 4, 19, 7 };
            foreach (int number in luckyNumbers)
            {
                Console.WriteLine("Your Lucky number is: {0}", number);
            }

            //foreach use for iteration only not for changes/modifications to the elements!!!
            //use for loops to modify
            string[] names = { "Jordan", "Max", "Peter" };
            for (int i = 0; i < names.Length; i++)
            {
                names[i] = names[i].ToLower();
                Console.WriteLine(names[i]);
            }
            //prints every other
            for (int i = 1; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
            //prints 50 to 100
            //for (int i = 50; i <=100; i++)

            //can use a foreach to print contents of a string
            string words = "I like cake";
            foreach (char letter in words)
            {
                Console.WriteLine(letter);
            }

            string greetings = "My name is Holly";
            string[] wordse = greetings.Split();
            for (int i = 0; i < wordse.Length; i++)
            {
                Console.WriteLine(wordse[i]);
                if (wordse[i] == "Holly")
                {
                    wordse[i] = "Max";
                }
            }
            Console.WriteLine("\n");
            //create array called days w/ elements; monday, tuesday...
            //use for loop to print the elements
            string[] days = { "monday", "tuesday", "wednesday",
                "thursday", "friday", "saturday", "sunday" };
            for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
            Console.WriteLine("\n");

            //int[] numbers = { 2, 5, 9, 4, 3, 4, 6, 5 };
            //Array.Reverse(numbers);
            //Console.WriteLine(numbers[0]);

            //create an int array size of 25 put the numbers 1 to 25 in the array and print those numbers
            //to the console
            int[] someNumbers = new int[25];
            for (int i = 0; i < someNumbers.Length; i++)
            {
                someNumbers[i] = i + 1;
                Console.WriteLine(someNumbers[i]);
            }
            Console.WriteLine("\n");
            //Start with the string "Once upon a time"and create an array called story words 
            //using the split method.  Reverse the order of the elements in the array and 
            //using a for loop, print each word.
            //Split - splits it on the white space
            Console.WriteLine("\n");
            string fairy = "Once upon a time.";
            string[] storyWords = fairy.Split();
            for (int i = 0; i < storyWords.Length; i++)
            {
                Console.WriteLine(storyWords[i]);
            }
            Array.Reverse(storyWords);
            for (int i = 0; i < storyWords.Length; i++)
            {
                Console.WriteLine(storyWords[i]);
            }
            Console.WriteLine("\n");
            //indexOf and lastIndexOf
            string[] animals = { "cat", "dog", "bird", "fish", "lion", "dog" };
            int dogIndex = Array.IndexOf(animals, "dog");
            Console.WriteLine("dog index: " + dogIndex);
            int lastDogIndex = Array.LastIndexOf(animals, "dog");
            Console.WriteLine("last dog index: " + lastDogIndex);
            Console.WriteLine("\n");

            //if none found then IndexOf returns -1
            int monkeyIndex = Array.IndexOf(animals, "monkey");
            Console.WriteLine("monkey index" + monkeyIndex);
            Console.WriteLine("\n");

            //String interpolation, a way to inject values into a format string, 
            //using curly-brace-enclosed expressions. ... 
            //it is a more convenient syntax for mixing string literals with expressions. 
            //It's code embedded in a string literal.
            string[] colors = { "red", "blue", "green"};
            foreach (string color in colors)
            {
                Console.WriteLine($"Color = { color}");
            }
            //JOIN: This example uses the Join method to combine the three string literals 
            //within the "elements" array.
            string[] primaryColors = { "red", "yellow", "blue" };
            Console.WriteLine(primaryColors[0]);
            string joined = string.Join("***", primaryColors);
            Console.WriteLine(joined);

            //SPLIT: Finally we invoke Split to change our joined string back into a string array. 
            //The two string arrays are separate in memory.
            //***come back to this!!!

            //while loops - continues until the condition is no longer TRUE
            Console.WriteLine("Do you want to play a game?");
            string playAgain = Console.ReadLine();

            while (playAgain == "Yes")
            {
                Console.WriteLine("Its a rematch!!!");
                Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine();
            }

            Console.WriteLine("What is your favorite ROYGBIV color?");
            string userColor = Console.ReadLine();
            //is something...for the name of a boolean signifies it is a bool
            //bool isROYGBIVColor = false;
            //watch out for infinite loops!
            while (userColor != "red" && userColor != "orange" && userColor != "yellow" && 
                userColor != "green" && userColor != "blue" && userColor != "violet")
            {
                Console.WriteLine("Sorry that is not the ROYGBIV color, please try again!");
                userColor = Console.ReadLine();
            }

            //do while - will always happen at least once!
            //do something - check condition - then do something
            //Like for a 1 free trial run but if person doesn't pay then no more games
            string playAgain2;
            do
            {
                Console.WriteLine("Do you want to build a snowman?");
                Console.WriteLine("That was fun!");
                Console.WriteLine("Do you want to build another snowman?");
                playAgain2 = Console.ReadLine();
            }
            while (playAgain2 == "yes");
            Console.WriteLine("\n");

            //can use CONTINUE and BREAK for any loops!
            //CONTINUE; skips one iteration
            //BREAK; stops the loop early
            //Use for break?timed test=loop through questions but once time is up then break
            //how would you print the mult table to the screen
            //FIZZ BUZZ print numbers between 1-100
            //if number is divisible by 3 print fizz, 5 print buzz, 5 and 3 print fizzbuzz!
            //print all prime numbers between 
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                if (i == 5)
                {
                    break;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
            }
        }
    }
}
