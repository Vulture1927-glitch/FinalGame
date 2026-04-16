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

        public Character(string name, string battleClass)
        {
            this.Name = name;
            Inventory = new List<Item>();
            Gold = 0;
            Ranking = 0;
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
            Console.WriteLine($"Ranking: {this.Ranking}/10");
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
            Item sword = new Item();
            Item staff = new Item();
            Item dagger = new Item();
            Item potion = new Item();
            Item ironArmor = new Item();
            Item leatherArmor = new Item();
            Item spellbook = new Item();
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

    }
}
