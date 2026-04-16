using System;
using System.Collections.Generic;
using System.Text;
using MyInterfaces;
namespace MyClasses
{
    internal class Item
    {
        public string Name { get; set; }
        //Description - Weapon, support, armor
        public string Description { get; set; }
        //Only needed for weapons
        public int Damage { get; set; }
        public int Cost { get; set; }
        //Only implement if time allows
        //public int Protection { get; set; }
    }
}
