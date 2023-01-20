using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace NEA
{
    class Program
    {
        public void intro()
        {
            //introduction to the game
            Print("Hello, welcome to 'A game'\nPlease enter 'Start' to start the game");
            string userin1 = ReadLine();

            string welcome = "I hope you have fun playing the game!!!";

            if (userin1.ToLower() == "start")
            {
                Print(welcome);
                Clear();
            }
            else
            {
                Print("Are you sure you wouldn't like to play the game. If you would like to, please enter 'Start'");
                string userin2 = ReadLine();
                if (userin2.ToLower() == "start")
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
        }

        public void tutorial()
        {
            Print("You open your eyes and look around, seeing a huge clearing surrounded by giant pine trees that looked to be extremly old.\nYou see that you have but a simple bag on your person.\nYou look down and see your face reflected in the water\n'Who am i?' you think to yourself");
            Clear();
            Print("What would you like to do?\nWould you like a tutorial?\nType 'yes' if you would like a tutorial and 'no' if you would not like a tutorial");
            string userin3 = ReadLine();
            Clear();

            string Tutorial_Basics = "To move, type 'up', 'down', 'left', or 'right'\nIf you come across an enemy, you will have set choices to pick from\nTo pick up an item type 'pick up item' or 'add to inventory'\nTyping 'pick up item' will automatically add the item to your inventory";

            if (userin3.ToLower() == "yes")
            {
                Print(Tutorial_Basics);
                Clear();
            }
            else
            {
                Print("Are you sure you wouldn't like a tutorial?");
                string userin4 = ReadLine();
                if (userin4.ToLower() == "yes")
                {
                    Print("Alright; if you're sure then");
                    Clear();
                }
                else
                {
                    Print(Tutorial_Basics);
                }
            }
            Clear();
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.intro();
            p1.tutorial();



            Basics_ player00 = new Player(25, 15, 0, 1);

            string[] directions = new string[4] { "up", "down", "left", "right" };

            Basics_ slime = new Enemy(10, 10, 23, 1);
            Basics_ giantBat = new Enemy(15, 15, 9, 1);
            Basics_ mossman = new Enemy(20, 5, 15, 1);
            Basics_ scaler = new Enemy(12, 7, 25, 1);
            Basics_ creeper = new Enemy(14, 12, 17, 1);
            Basics_ giantSpider = new Enemy(17, 4, 26, 1);
            Basics_ demon = new Enemy(19, 3, 15, 1);
            Basics_ crawler = new Enemy(13, 5, 10, 1);

            Basics_[] EnemyList = new Basics_[] { slime, giantBat, mossman, scaler, creeper, giantSpider, demon, crawler };
            Random fight = new Random();

            Basic_h_items BasicPotion = new Basic_h_items(5, 1);


            List<string> Bag = new List<string>();

            for(int mtrmvd = 0; mtrmvd < 30; mtrmvd++)
            {
                int Enemy_Fight = fight.Next(0, EnemyList.Length);
                int if_fight = fight.Next(0, 1);

                Print("Please move");
                string dr = ReadLine();
                Clear();
                Random direct = new Random();
                int drnum = direct.Next(0, directions.Length);

                if (dr.ToLower() == directions[drnum])
                {
                    Print("You have moved" + dr + "by" + mtrmvd++ + "meters");
                    Clear();
                    if(if_fight == 1)
                    {
                        Print("Im very sorry, it seems as though an enemy has found you\nWhat would you like to do?\nFight\nRun away");
                        string userin5 = ReadLine();
                        Clear();
                        if(userin5.ToLower() == "Fight")
                        {
                            Print("You have entered a fight!");
                            Print("You have three options:\nAttack\nDefend\nOpen inventory\nWhat would you like to do?");
                            string userin6 = ReadLine();
                            Clear();
                            if(userin6.ToLower() == "Attack")
                            {
                                Print("You have entered a fight!\nThis is your hp: " + player00.hp + "This is your enemy's hp: " + EnemyList[Enemy_Fight].hp);
                                EnemyList[Enemy_Fight].hp -= player00.attack;
                                if(EnemyList[Enemy_Fight].hp <= 0)
                                {
                                    Print("You have successfully defeated the enemy!!!");
                                    //add random droppped item to add to inventory
                                }
                                else
                                {
                                    Print("The enemy has been hit!\nThis is the enemy's hp now: " + EnemyList[Enemy_Fight].hp);
                                    player00.hp -= EnemyList[Enemy_Fight].attack;
                                    //finish
                                }
                                if(player00.hp <= 0)
                                {
                                    Print("I'm very sorry but unfortunately, it seems as though you have lost all of your hp. Thank you for playing the game :)");
                                    //finish
                                }
                            }
                            else if(userin6.ToLower() == "Defend")
                            {
                                //as this is the start area, 70% of the enemy's attack will be blocked


                            }
                            else if(userin6.ToLower() == "Open inventory")
                            {
                                
                            }
                        }
                        else if(userin5.ToLower() == "Run away")
                        {
                            //chance of escaping 1 in 3
                            Random chance = new Random();
                            //int escape = 
                        }
                    }
                }
                else
                {
                    Print("Sorry, that is not correct, you'll have to try again");
                    //mtrmvd--;
                    Clear();
                }
            }


            //.ToLower()
            //console.clear();
        }

        /*public static void Tutorial()
        {
            if ()
        }*/

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
