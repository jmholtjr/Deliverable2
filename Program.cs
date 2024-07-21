// See https://aka.ms/new-console-template for more information
//
// Progammer Name: John Holt 
// Company: Acme Distributors
// Program Date: 07/20/2024
// Program Description: Restocking Tool

        int beginsodas = 100;
        int restocksodas = 40;
        int currentsodas = 0;
        int beginchips = 40;
        int restockchips = 20;
        int currentchips = 0;
        int begincandy = 60;
        int restockcandy = 40;
        int currentcandy = 0;
        string inputstring;
        int inputint = 0;

        Console.WriteLine("Welcome to the Acme Distributors restocking tool.");


        // SODAS
        Console.WriteLine(" ");
        Console.WriteLine("How many Sodas have been sold today? There are " + beginsodas + " in stock.");
        inputstring = Console.ReadLine();
        inputint = int.Parse(inputstring);
        currentsodas = beginsodas - inputint;
        if (currentsodas < 0)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
            currentsodas = beginsodas;
        }
        else
        { Console.WriteLine("There are " + currentsodas + " Sodas left."); }

        //CHIPS
        Console.WriteLine(" ");
        Console.WriteLine("How many Chips have been sold today? There are " + beginchips + " in stock.");
        inputstring = Console.ReadLine();
        inputint = int.Parse(inputstring);
        currentchips = beginchips - inputint;

        if (currentchips < 0)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
            currentchips = beginchips;
        }
        else
        { Console.WriteLine("There are " + currentchips + " Chips left."); }

        //CANDY 
        Console.WriteLine(" ");
        Console.WriteLine("How many Candy have been sold today? There are " + begincandy + " in stock.");
        inputstring = Console.ReadLine();
        inputint = int.Parse(inputstring);
        currentcandy = begincandy - inputint;

        if (currentcandy < 0)
        {
            Console.WriteLine("That value is too high. Stock not adjusted.");
            currentcandy = begincandy;
        }
        else
        { Console.WriteLine("There are " + currentcandy + " Candy left."); }


        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine("Thank you for filling out the values. Here’s what needs to be restocked.");
        if (currentsodas < restocksodas)
        { Console.WriteLine("Sodas needs to be restocked."); }
        if (currentchips < restockchips)
        { Console.WriteLine("Chips needs to be restocked."); }
        if (currentcandy < restockcandy)
        { Console.WriteLine("Candy needs to be restocked."); }

        Console.WriteLine(" ");
        Console.WriteLine("Goodbye!");
