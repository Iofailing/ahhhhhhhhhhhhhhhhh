using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace NEA
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("Hello, welcome to 'A game'\nPlease enter 'Start' to start the game");
            string userin = ReadLine();
            string welcome = "I hope you have fun playing the game!!!";

            if(userin.ToLower == "start")
            {
                Print(welcome);
                Clear();
            }
            else
            {
                Print("Are you sure you wouldn't like to play the game. If you would like to, please enter 'Start'");
                string userin2 = ReadLine();
                if(userin2.ToLower == "start")
                {
                    Print(welcome);
                    Clear();
                }
                else
                {
                    Print("That's a shame, goodbye");
                    Clear();
                    Environment.Exit(0);
                }
            }

            Print("You open your eyes and look around, seeing a huge clearing surrounded by giant pine trees that looked to be extremly old.\nYou look down and see your face reflected in the water 'Who am i?' you think to yourself");
            Print("What would you like to do?\nWould you like a tutorial?");
            string userin3 = ReadLine();
            Clear();

            string Tutorial_Basics = "To move, type 'up', 'down', 'left', or 'right'\nIf you come across an enemy, you will have set choices to pick from\nTo pick up an item type 'pick up item' or 'add to inventory'\nTyping 'pick up item' will automatically add the item to your inventory";

            if(userin3.ToLower == "yes")
            {
                Print(Tutorial_Basics);
                Clear();
            }
            else
            {
                Print("Are you sure you wouldn't like a tutorial?");
                string userin4 = ReadLine();
                if(userin4.ToLower == "yes")
                {
                    Print("Alright; if youre sure then");
                    Clear();
                }
                else
                {
                    Print(Tutorial_Basics);
                }
            }
            
            //.ToLower()
            //console.clear();
        }
        public static void Print(string input)
        {

            Thread.Sleep(15);
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                Thread.Sleep(15);
            }
            Console.WriteLine();
        }
    }
}
