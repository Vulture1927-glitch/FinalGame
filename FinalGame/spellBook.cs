using System;
using System.Collections.Generic;
using System.Text;
using MyClasses;
namespace MyClasses
{
    internal class SpellBookClass
    {
        public Dictionary<string, string> spellBook = new Dictionary<string, string>()
        {
            { "Fireball", "Blast an opponent with fire"},
            { "Ice Spike", "Impale an opponent with ice"},
            {"Heal", "Restore a fair amount of Health"}
        };

    }
}
