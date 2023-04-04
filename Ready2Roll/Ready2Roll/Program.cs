using System;
using Ready2Roll;




var input = Console.ReadLine();


//introduction 

Console.WriteLine("     Hello, welcome to Ready to Roll");


//loop
    static void Main(string[] args)
{
    List<Dice> dices = new List<Dice>();

    int dice = 0;
    do 
    {
        if (dice == 0)
        {
            Console.WriteLine("How many dice would you like to roll? press 0 to quit");
            dice = int.Parse(Console.ReadLine());
        }

        if (dice == 0)
        {
            Console.WriteLine("Thank you for rolling!");
            break;
        }

        for (int i = 0; i < dice; i++)
        { 
        Console.WriteLine("How many sides do the dice have? press 0 to quit");
        int sides = int.Parse(Console.ReadLine());
            if (sides <0)
            {
                Console.WriteLine("sides can not be negative. Please enter a positive integer or 0 to quit");
                i--;
                continue;
            }
            if (sides == 0)
            {
                Console.WriteLine("Thank you for rolling!");
                return;
            }
            Dice die = new Dice();
            die.sides = sides;
            dices.Add(die);
        }
    } while (dice > 0);

    //Dice roll 

    int roll = 0;

        // store the total for the day

        dice--;


    
}
