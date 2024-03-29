using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace NEA
{
    class Program
    {
        Player player00 = new Player(25, 15, 0, 1);
        //introduction to the game
        public void intro()
        {
            Print("Hello, welcome to 'A game'\nPlease enter 'Start' to start the game");
            string userin1 = ReadLine();
            Clear();

            string welcome = "I hope you have fun playing the game!!!";

            if (userin1.ToLower() == "start")
            {
                Print(welcome);
                ReadLine();
                Clear();
            }
            else
            {
                Print("Are you sure you wouldn't like to play the game. If you would like to, please enter 'Start'");
                string userin2 = ReadLine();
                if (userin2.ToLower() == "start")
                {
                    Print(welcome);
                    ReadLine();
                    Clear();
                }
                else
                {
                    Print("That's a shame, goodbye");
                    ReadLine();
                    Clear();
                    Environment.Exit(0);
                }
            }
        }

        //tutorial of how to play/function the basics game
        public void tutorial()
        {
            Print("You open your eyes and look around.\nYou see a huge clearing surrounded by giant pine trees that look to be extremly old.\nYou see that you have but a simple bag on your person.\nYou look down and see your face reflected in the water.\n'Who am i?' you think to yourself.");
            ReadLine();
            Clear();
            Print("Would you like a tutorial?\nType 'yes' if you would like a tutorial and 'no' if you would not like a tutorial.");
            string userin3 = ReadLine();
            Clear();

            string Tutorial_Basics = "To move, type 'up', 'down', 'left', or 'right'.\nIf you come across an enemy, you will have set choices to pick from.\nTo pick up an item type 'pick up item' or 'add to inventory'\nTyping 'pick up item' will automatically add the item to your inventory.";

            if (userin3.ToLower() == "yes")
            {
                Print(Tutorial_Basics);
                ReadLine();
                Clear();
            }
            else
            {
                Print("Are you sure you wouldn't like a tutorial?");
                string userin4 = ReadLine();
                if (userin4.ToLower() == "yes")
                {
                    Print("Alright; if you're sure then");
                    ReadLine();
                    Clear();
                }
                else
                {
                    Print(Tutorial_Basics);
                    ReadLine();
                }
            }
            Clear();
        }
        //a method for choosing to collect a random dropped item + money
        public void Collection()
        {
            Basic_h_items BasicPotion = new Basic_h_items("Basic Potion", 5, 1);
            Basic_h_items Mushroom = new Basic_h_items("Mushroom", 20, 3);
            Basic_h_items GoldenApple = new Basic_h_items("Golden Apple", 15, 2);
            Basic_h_items SuspiciousBile = new Basic_h_items("Suspicious Bile", 30, 3);
            Basic_h_items GlowingMoss = new Basic_h_items(18, 3);
            Basic_h_items BleedingFairyHelmet = new Basic_h_items(50, 5);
            Basic_h_items EasternJackOLanternMushroom = new Basic_h_items(35, 4);

            Basic_h_items[] DroppedItems = new Basic_h_items[] { BasicPotion, Mushroom, GoldenApple, SuspiciousBile, GlowingMoss, BleedingFairyHelmet, EasternJackOLanternMushroom };

            int Plang = 1;
            Random drop = new Random();


            int CollectItems = drop.Next(0, DroppedItems.Length + 1);
            int numcur = drop.Next(1, 31);
            int money = numcur * Plang;
            Print("The item " + DroppedItems[CollectItems] + " has been droppped.\nWould you like to pick it up?");
            string userin = ReadLine();
            Clear();

            if (userin.ToLower() == "pick up item" || userin.ToLower() == "add to inventory")
            {
                player00.Bag.Add(DroppedItems[CollectItems]);
                Print("Your money counter is now: " + money + " plang\n" + "You also have " + DroppedItems[CollectItems] + " in your inventory");
            }
            else
            {
                Print("It doesn't seem wise to not add this to your inventory\nDo you want to add this to your inventory?");
                string userin1 = ReadLine();
                if (userin1.ToLower() == "yes")
                {
                    Print("'Wise decision' an eerie vice whispers to you");
                    player00.Bag.Add(DroppedItems[CollectItems]);
                    Print("You now have: " + money + "plang");
                }
                else
                {
                    Print("'Not the wisest of decisions you've made today' you think to yourself");
                }
            }
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.intro();
            p1.tutorial();

            string[] directions = new string[4] { "up", "down", "left", "right" };


            //do for this section what you did for the collections method
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


            for(int mtrmvd = 0; mtrmvd < 30; mtrmvd++)
            {
                int Enemy_Fight = fight.Next(0, EnemyList.Length+1);
                int if_fight = fight.Next(0, 2);

                Print("Please move");
                string dr = ReadLine();
                Clear();
                Random direct = new Random();
                int drnum = direct.Next(0, directions.Length);

                if (dr.ToLower() == directions[drnum])
                {
                    Print("You have moved " + dr + " by " + mtrmvd++ + " meters.");
                    ReadLine();
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
                            while (player00.hp > 0 || EnemyList[Enemy_Fight].hp > 0)
                            {
                                //fight, defend, open inventory
                            }
                            if(userin6.ToLower() == "Attack")
                            {
                                Print("You have entered a fight!\nThis is your hp: " + player00.hp + "\nThis is your enemy's hp: " + EnemyList[Enemy_Fight].hp);
                                EnemyList[Enemy_Fight].hp -= player00.attack;
                                if(EnemyList[Enemy_Fight].hp <= 0)
                                {
                                    Print("You have successfully defeated the enemy!!!");
                                    //the method for randomly dropping money and an item
                                    p1.Collection();
                                }
                                else
                                {
                                    Print("The enemy has been hit!\nThis is the enemy's hp now: " + EnemyList[Enemy_Fight].hp);
                                    //finish
                                }
                                player00.hp -= EnemyList[Enemy_Fight].attack;
                                if (player00.hp <= 0)
                                {
                                    //End game
                                    Print("I'm very sorry but unfortunately, it seems as though you have lost all of your hp. Thank you for playing the game :)");
                                    Environment.Exit(0);
                                }

                            }
                            else if(userin6.ToLower() == "Defend")
                            {
                                //as this is the start area, 70% of the enemy's attack will be blocked
                                int defenceattack = (int)(EnemyList[Enemy_Fight].attack * 0.3);
                                player00.hp -= defenceattack;
                                Print("You have defended 70% of the enemy's attack\nHere is your current hp: " + player00.hp);
                            }
                            else if(userin6.ToLower() == "Open inventory")
                            {
                                foreach(var x in Bag)
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

            Print("Well done!!\nYou have finally made it out of the forest and to the town of Eplabra!!");

            //.ToLower()
            //console.clear();
        }

        public static void Print(string input)
        {

            Thread.Sleep(35);
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i]);
                Thread.Sleep(35);
            }
            Console.WriteLine();
        }


    }
}
