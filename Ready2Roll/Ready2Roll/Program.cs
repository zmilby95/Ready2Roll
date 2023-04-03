using System;
using Ready2Roll;

var calculator = new Calculator();
var input = Console.ReadLine();

//introduction 

Console.WriteLine("     Hello, welcome to Ready to Roll");

//loop
static void Main(string[] args);
{
    var repeat = true;
    while (repeat) ;


    Console.WriteLine("How many dice would you like to roll?");
    int dice = int.Parse(Console.ReadLine());

    Console.WriteLine("How many sides do the dice have? ");
    int sides = int.Parse(Console.ReadLine());


    //Dice roll + adding 
    

    // roll again or exit 

    Console.WriteLine("Would you like to roll again? Press 1 for yes 2 to quit.");
    Console.ReadLine();

    switch (input)
    {
        case "1":


        case "2":
            Console.WriteLine("Thank you for rolling!");
            break;
    }

}