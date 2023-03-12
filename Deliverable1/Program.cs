using System;

class Deliverable1
{
    static void Main()
    {
        int sodaStock = 100, chipsStock = 40, candyStock = 60; // Base quantity
        int soldSoda, soldChips, soldCandy; // Input values
        int restockSoda, restockChips, restockCandy; // Base - Input
        bool restocked = false; // Message if nothing needs to be stocked

        Console.WriteLine("Welcome to the restocking tool.");

        // Input for soda
        Console.WriteLine("{0} {1} {2}", "How many Sodas have been sold today?", sodaStock, "are in stock");
        soldSoda = int.Parse(Console.ReadLine());
        restockSoda = sodaStock - soldSoda;
        if (soldSoda <= sodaStock)
            Console.WriteLine("{0} {1} {2}", "There are", restockSoda, "Sodas left\n");
        else
            Console.WriteLine("That value is too high. Stock not adjusted\n");

        // Input for chips
        Console.WriteLine("{0} {1} {2}", "How many Chips have been sold today?", chipsStock, "are in stock");
        soldChips = int.Parse(Console.ReadLine());
        restockChips = chipsStock - soldChips;
        if (soldChips <= chipsStock)
            Console.WriteLine("{0} {1} {2}", "There are", restockChips, "Chips left\n");
        else
            Console.WriteLine("That value is too high. Stock not adjusted\n");

        // Input for candy
        Console.WriteLine("{0} {1} {2}", "How much Candy have been sold today?", candyStock, "are in stock");
        soldCandy = int.Parse(Console.ReadLine());
        restockCandy = candyStock - soldCandy;
        if (soldCandy <= candyStock)
            Console.WriteLine("{0} {1} {2}", "There are", restockCandy, "Sodas left\n");
        else
            Console.WriteLine("That value is too high. Stock not adjusted\n");

        // Display which items need to be restocked
        Console.WriteLine("Thank you for filling out the values. Here's what needs to be restocked");
        if (soldSoda <= sodaStock && restockSoda <= 40)
        {
            Console.WriteLine("Soda needs to be restocked");
            restocked = true;
        }
        if (soldChips <= chipsStock && restockChips <= 20)
        {
            Console.WriteLine("Chips needs to be restocked");
            restocked = true;
        }
        if (soldCandy <= candyStock && restockCandy <= 40)
        {
            Console.WriteLine("Candy needs to be restocked");
            restocked = true;
        }
        if (restocked == false)
            Console.WriteLine("Nothing needs to be restocked");

        Console.WriteLine("Goodbye!");
    }
}