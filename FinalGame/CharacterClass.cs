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
        public int CompetitorsBeaten { get; set; }
        public int Gold { get; set; }
        public int Prestige { get; set; }

        public Character(string name)
        {
            this.Name = name;
            Inventory = new List<Item>();
            CompetitorsBeaten = 0;
            Gold = 0;
            Prestige = 0;
        }

    }
}
