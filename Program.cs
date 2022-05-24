using System;

class MainClass
{
    public static void Main(String[] args)

    {// define variables
        double coffeePrice = 2.00;
        double buffetPrice = 9.99;
        double totalBill = 0;
        int coffeeCount = 0;
        int waterCount = 0;

        //greet customers
        Console.WriteLine("Hi welcome to our Buffet. All you can eat for $9.99! We only charge for coffee. How many people are in your group? \nPlease, parties of 6 or lower.");

        //wait for user input
        int partyCount = int.Parse(Console.ReadLine());

        //formatting
        Console.WriteLine("\n");

        //define party count conditions
        if (partyCount <= 6)
        {
            Console.WriteLine($"A table for {partyCount}! Please follow me and take a seat. \nLet's get started with some drinks. We've got water or coffee.");
        }
        else
        {
            Console.WriteLine("Im very sorry we aren't staffed to serve tables larger than 6. Have a great day!");

            Console.WriteLine("\n");

            Console.WriteLine("Press any key to exit.");

            Console.ReadLine();

            Environment.Exit(0);

        }

        //formatting
        Console.WriteLine("\n");

        //loop drink orders and total
        for (int guest = 1; guest <= partyCount; guest++) 
        {
            Console.WriteLine($"Alright guest {guest}, water or coffee");

            string drinks = Console.ReadLine().ToLower();

            if (drinks == "coffee")
            {
                Console.WriteLine("Coffee, okay!");
                totalBill = coffeePrice + buffetPrice + totalBill;
                coffeeCount++;
                Console.WriteLine("\n");
            }
            else if (drinks == "water")
            {
                Console.WriteLine("Water, good choice!");
                totalBill = buffetPrice + totalBill;
                waterCount++;
                Console.WriteLine("\n");
            }
            else
            {
                Console.WriteLine("We don't have that. No drink for you!");
                totalBill = buffetPrice + totalBill;
                Console.WriteLine("\n");
            }
            if (guest == partyCount)
                {
                Console.WriteLine($"Okay, so that's {coffeeCount} coffees and {waterCount} waters. I'll be right back. Feel Free to grab your food.");

                Console.WriteLine("\n");

                Console.WriteLine($"Here's your bill! Total Price: ${totalBill.ToString("0.00")}");
                
            }
        }

        Console.WriteLine("\n");

        System.Threading.Thread.Sleep(-1);

       
    }
}