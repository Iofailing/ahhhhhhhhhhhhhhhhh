using System;
using System.Collections.Generic;
using System.Text;

namespace NEA
{
    class Basics_
    {
        //Basics for people and enemies - living things that will most likely be in a fight
        //so therefore need stats for attack, health, exp and level
        public int hp;
        public int attack;
        public int exp;
        public int level;
    }

    class Basics_weapons
    {
        public int attack;
        public int defense;
        public Basics_weapons(int attack1, int defense1)
        {
            attack = attack1;
            defense = defense1;
        }
    }

    class Basic_h_items
    {
        //basics for health items
        public int hp;
        public int rarity;
        public Basic_h_items(int hp1, int rarity1)
        {
            hp = hp1;
            rarity = rarity1;
        }

    }
    
    class money
    {
        public int value;
        public money (int value1)
        {
            value = value1;
        }
    }

    class Player : Basics_
    {
        public Player(int hp1, int attack1, int exp1, int level1)
        {
            hp = hp1;
            attack = attack1;
            exp = exp1;
            level = level1;
        }
    }

    class Enemy : Basics_
    {
        public Enemy(int hp1, int attack1, int exp1, int level1)
        {
            //general class for all enemies and will be used to create multiple different types of enemy
            hp = hp1;
            attack = attack1;
            exp = exp1;
            level = level1;
        }
    }
}
