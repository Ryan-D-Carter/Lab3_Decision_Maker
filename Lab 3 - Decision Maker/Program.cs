using System;
using System.Text.RegularExpressions;

namespace Lab_3___Decision_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();

            //name validation
            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("You forgot to type your name, try again!");
                name = Console.ReadLine();
            }

            while (!Regex.IsMatch(name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("Please only use letters in your name! Try again!");
                name = Console.ReadLine();
            }

            while (repeat)
            {
                Console.WriteLine($"Hello {name}, please enter an number between 1 and 100! (please, positive numbers only!");

                // getting number
                int input;

                string userinput = (Console.ReadLine());

                //parsing the input to make sure it is a valid number
                bool userParse = int.TryParse(userinput, out input);

                if (!userParse)
                {
                    Console.WriteLine("Sorry, you can only use numbers!");
                }

                // if negative input
                if (input < 0)
                {
                    Console.WriteLine($"Sorry {name}, negative numbers are invalid.");
                }

                // if over 100
                if (input > 100)
                {
                    Console.WriteLine("That's too high!");
                }


                //if Odd
                else if (input % 2 != 0)
                {
                    if (input > 60)
                    {
                        Console.WriteLine($"{input} is odd");
                    }
                    else
                    {
                        Console.WriteLine($"{input} is odd.");
                    }
                }

                //if Even
                else
                {
                    // even 2 - 25 checkpoint
                    if (input <= 25 && input >= 2)
                    {
                        Console.WriteLine($"Even and less than 25");
                    }

                    //even 26 - 60 checkpoint 
                    else if (input <= 60 && input >= 26)
                    {
                        Console.WriteLine($"Even");
                    }

                    else if (input > 60)
                    {
                        Console.WriteLine($"{input} is Even");
                    }
                }




                //continue?
                bool conLoop = true;
                while (conLoop)
                {
                    Console.WriteLine($"Would you like to continue, {name}? y/n");
                    string conAnswer = Console.ReadLine().ToLower();
                    if (conAnswer == "y")
                    {
                        repeat = true;
                        conLoop = false;
                    }
                    else if (conAnswer == "n")
                    {
                        repeat = false;
                        conLoop = false;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, I didn't quite catch that");
                        conLoop = true;
                    }
                }
            }
        }
    }
}
