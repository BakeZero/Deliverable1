using System;

class Deliverable1
{
    static void Main()
    {
        int sodaStock = 100, chipsStock = 40, candyStock = 60; // Base quantity
        int soldSoda, soldChips, soldCandy; // Input values
        bool restocked = false; // Message if nothing needs to be stocked

        Console.WriteLine("Welcome to the restocking tool.");

        // Input for soda
        Console.WriteLine("{0} {1} {2}", "How many Sodas have been sold today?", sodaStock, "are in stock");
        soldSoda = int.Parse(Console.ReadLine());
        if (soldSoda <= sodaStock)
            Console.WriteLine("{0} {1} {2}", "There are", sodaStock - soldSoda, "Sodas left\n");
        else
            Console.WriteLine("That value is too high. Stock not adjusted\n");

        // Input for chips
        Console.WriteLine("{0} {1} {2}", "How many Chips have been sold today?", chipsStock, "are in stock");
        soldChips = int.Parse(Console.ReadLine());
        if (soldChips <= chipsStock)
            Console.WriteLine("{0} {1} {2}", "There are", chipsStock - soldChips, "Chips left\n");
        else
            Console.WriteLine("That value is too high. Stock not adjusted\n");

        // Input for candy
        Console.WriteLine("{0} {1} {2}", "How much Candy have been sold today?", candyStock, "are in stock");
        soldCandy = int.Parse(Console.ReadLine());
        if (soldCandy <= candyStock)
            Console.WriteLine("{0} {1} {2}", "There are", candyStock - soldCandy, "Sodas left\n");
        else
            Console.WriteLine("That value is too high. Stock not adjusted\n");

        // Display which items need to be restocked
        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked");
        if (soldSoda <= sodaStock && sodaStock - soldSoda <= 40)
        {
            Console.WriteLine("Soda needs to be restocked");
            restocked = true;
        }
        if (soldChips <= chipsStock && chipsStock - soldChips <= 20)
        {
            Console.WriteLine("Chips needs to be restocked");
            restocked = true;
        }
        if (soldCandy <= candyStock && candyStock - soldCandy <= 40)
        {
            Console.WriteLine("Candy needs to be restocked");
            restocked = true;
        }
        if (restocked == false)
            Console.WriteLine("Nothing needs to be restocked");

        Console.WriteLine("Goodbye!");
    }
}