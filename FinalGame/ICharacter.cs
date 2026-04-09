using System;
using System.Collections.Generic;
using System.Text;
using MyClasses;
namespace MyInterfaces
{
    internal interface ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        List<Item> Inventory { get; set; }

        public void Display();
    }
}
