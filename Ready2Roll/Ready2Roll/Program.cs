using System;
using System.Runtime.Serialization.Formatters;
using Ready2Roll;


//sorts the List showing totals and tracking largest value 

static void ShowBestRolls(List<DiceSession> sessionList)
{
    sessionList.Sort((sessionA, sessionB) =>

        sessionB.total.CompareTo(sessionA.total)
    );
    foreach (DiceSession session in sessionList)
    {
        session.displaySessionInfo();
    }
}



static void Main()
{//introduction
 
    Console.WriteLine("     Hello, welcome to Ready to Roll");
    List<DiceSession> sessionList = new List<DiceSession>();

//loop
    Boolean continueLoop = false;

    do 
    {
        DiceSession session = new DiceSession();
        List<Dice> dices = new List<Dice>();

        
        Console.WriteLine("How many dice would you like to roll? press 0 to quit");
        int dice = int.Parse(Console.ReadLine());
        

        if (dice == 0)
        {
            Console.WriteLine("Thank you for rolling!");
            break;
        }

        for (int i = 0; i < dice; i++)
        { 
        Console.WriteLine("How many sides does the dice have? press 0 to quit");
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

        }//Dice roll 

        int roll = 0;
        foreach (Dice die in dices)
        {
            int currentRoll = die.roll();
            roll += currentRoll;
            Console.WriteLine("The current roll was: " + currentRoll);
        }
        Console.WriteLine("You rolled a total of: " + roll);
        
        session.diceList = dices;
        session.total = roll;
        sessionList.Add(session);

        
        Console.WriteLine("Would you like to roll another session? y/n");
        string reroll = Console.ReadLine();

        if (reroll == "y")
        {
            continueLoop = true;
        } else
        {
           continueLoop = false;
        }
    } while (continueLoop);
    ShowBestRolls(sessionList);
    
    
      
    // store the total for the day

       


    
}
Main();
