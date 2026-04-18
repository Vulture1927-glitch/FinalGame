using System;
using System.Collections.Generic;
using System.Text;
using MyInterfaces;
using MyClasses;
namespace MyClasses
{
    internal class Character : ICharacter , IFight
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public List<Item> Inventory { get; set; }
        public int Gold { get; set; }
        public int Ranking { get; set; }
        public string BattleClass { get; set; }
        public int Luck { get; set; }
        public int Level { get; set; }

        public Character(string name = "None", string battleClass = "None")
        {
            this.Name = name;
            Inventory = new List<Item>();
            Gold = 0;
            Ranking = 1;
            BattleClass = battleClass;
            if(battleClass == "warrior")
            {
                Health = 200;
                Luck = 1;
            }
            else if(battleClass == "mage")
            {
                Health = 100;
                Luck = 1;
            }
            else if(BattleClass == "rogue")
            {
                Health = 150;
                Luck = 3;
            }
        }

        public void Display()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Health: {this.Health}");
            Console.WriteLine($"Gold: {this.Gold}");
            Console.WriteLine($"Ranking: {this.Ranking}/8");
            Console.WriteLine($"Class: {this.BattleClass}");
            Console.WriteLine($"Level: {this.Level}");
            Console.WriteLine("Inventory:\n");
            foreach (var item in Inventory)
            {
                Console.WriteLine($"{item.Name} ---- {item.Description} ---- {item.Damage}");
            }
            
        }
        public int Attack(Item weapon)
        {
            Console.WriteLine("Fast attack or slow attack?");
            string response = Console.ReadLine().Trim().ToLower();
            if(response == "fast")
            {
                Console.WriteLine("You attack first");
                Console.WriteLine($"You dealt {weapon.Damage -2} damage");
                return weapon.Damage - 2;
            }
            else if (response == "slow")
            {
                Console.WriteLine("You attack slower");
                return weapon.Damage + 3;
            }
            throw new Exception("Not a valid response");
        }
        public void StartingItems()
        {
            Item sword = new Item("Sword", "A trusty weapon", 4 , 0);
            Item staff = new Item("Staff", "A means to channel magic", 2 , 0);
            Item dagger = new Item("Dagger", "A weapon good for close quarters", 3 , 0);
            Item potion = new Item("Healing Potion", "Restores some Health", 0 , 0);
            Item ironArmor = new Item("Iron armor", "Armor", 0 , 0 );
            Item leatherArmor = new Item("Leather armor", "For those more nimble", 0, 0);
            Item spellbook = new Item("Spellbook","Gifted to every wizard who graduated", 0 , 0);
            switch(BattleClass)
            {
                case "Warrior":
                    Inventory.Add(sword);
                    Inventory.Add(ironArmor);
                    Inventory.Add(potion);
                    break;
                //case "Mage":
                //    Inventory.Add(staff);
                //    Inventory.Add(spellbook);
                //    Inventory.Add(potion);
                //    break;
                case "Rogue":
                    Inventory.Add(dagger);
                    Inventory.Add(leatherArmor);
                    Inventory.Add(potion);
                    break;
                default:
                    Console.WriteLine("No class chosen");
                    break;
            }
        }

        public void LevelUp()
        {
            Random rng = new Random();
            Health += rng.Next(10, 26);
            Luck += rng.Next(1, 3);
            Level++;
        }

    }
}
