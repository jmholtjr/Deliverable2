// See https://aka.ms/new-console-template for more information
//
// Progammer Name: John Holt 
// Company: Coins R US Distributors
// Program Date: 07/21/2024
// Program Description: Restocking Tool

using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
public static class RestockingTool
{
    public static void Main()
    {

        string inputstring;
        string name;
        string heads = "HEADS";
        string tails = "TAILS";
        int correct = 0;

        Console.WriteLine("Welcome to the COIN FLIP CHALLENGE! \nWhat is your name?");
        name = Console.ReadLine();


        Console.WriteLine("Welcome " + name + ". Do you want to do the COIN FLIP CHALLENGE? Yes/No");
        inputstring = Console.ReadLine();
        inputstring = inputstring.ToUpper();

        if (inputstring == "NO")
        { Console.WriteLine("You are a coward " + name); }
        else
        {

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Heads or Tails?");
                inputstring = Console.ReadLine();
                inputstring = inputstring.ToUpper();

                Random random = new Random();
                int number = random.Next(0, 2); // Generates a random integer between 0 and 1

                // Heads = 1
                // Tails = 0

                if (number == 1)
                {
                    if (inputstring == heads)
                    {
                        Console.WriteLine("Correct!" + number);
                        correct++;
                    }
                    else
                    { Console.WriteLine("Wrong!" + number); }
                }

                else
                {
                    if (inputstring == tails)
                    {
                        Console.WriteLine("Correct!" + number);
                        correct++;
                    }
                    else
                    { Console.WriteLine("Wrong!" + number); }

                }


            }
            Console.WriteLine("Thank you " + name + ". You got a score of " + correct);
        }
    }
}



