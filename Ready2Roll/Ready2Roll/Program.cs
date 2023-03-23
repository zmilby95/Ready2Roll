using System;
using Ready2Roll;

var calculator = new Calculator();
var input = Console.ReadLine();

//introduction 

Console.WriteLine("     Hello, welcome to Ready to Roll");

Console.WriteLine("How many dice would you like to roll?");
Console.ReadLine();

Console.WriteLine("How many sides do the dice have? 4, 6, 8, 10, 12, 20");
Console.ReadLine();

//Dice roll + adding 
switch (input)
{
    case "4":


    case "6":


    case "8":


    case "10":

    
    case "12":


    case "20":


    default:
        Console.WriteLine("Invalid choice, please select a type of die");
        break;
}


//loop to roll again or exit 

Console.WriteLine("Would you like to roll again? Press 1 for yes 2 to quit.");
Console.ReadLine();

switch (input)
{
    
        
}