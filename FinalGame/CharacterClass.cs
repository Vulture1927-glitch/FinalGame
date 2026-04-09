using System;
using System.Collections.Generic;
using System.Text;
using MyInterfaces;
using MyClasses;
namespace MyClasses
{
    internal class Character : ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public List<Item> Inventory { get; set; }
        public int Gold { get; set; }
        public int Ranking { get; set; }

        public Character(string name)
        {
            this.Name = name;
            Inventory = new List<Item>();
            Gold = 0;
            Ranking = 0;
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

    }
}
