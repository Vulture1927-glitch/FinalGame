using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using MyClasses;
namespace MyClasses
{
    internal class Shop
    {
        public List<Item> Stock { get; set; }

        public int PriceToUpgrade { get; set; }
        public Shop() 
        { 
            Stock = new List<Item>();
            PriceToUpgrade = 10;

            Item starting1 = new Item();
            starting1.Name = "Sword";
            starting1.Description = "Weapon";
            starting1.Damage = 5;
            starting1.Cost = 10;

            Item starting2 = new Item();
            starting2.Name = "Iron Armor";
            starting2.Description = "Armor";
            starting2.Damage = 0;
            starting2.Cost = 10;

            Item starting3 = new Item();
            starting3.Name = "Healing Potion";
            starting3.Description = "Support";
            starting3.Damage = 0;
            starting3.Cost = 2;

            Stock.Add(starting1);
            Stock.Add(starting2);
            Stock.Add(starting3);

        }


        //Upgrade method (weapon deals more damage, armor absorbs more, upgrades increase in price the more they are done)
        public void UpdradeArmament(Item itemToUpgrade)
        {
            
            //if(itemToUpgrade.Description == "armor")
            //{

            //}
            if(itemToUpgrade.Description == "Weapon")
            {
                itemToUpgrade.Damage += 5;
                PriceToUpgrade += 10;
            }
            throw new ArgumentException("Not an upgradeable item");
        }

        public void DisplayShop()
        {
            foreach (Item item in Stock)
            {
                Console.WriteLine(item);
            }
        }
       
        //Buying and selling process
        public void PurchaseItem(Character hero, Item desiredItem)
        {
            if(hero.Gold > desiredItem.Cost)
            {
                hero.Inventory.Add(desiredItem);
            }
            else
            {
                Console.WriteLine("You cannot but this item");
            }
        }
        public void SellItem(Character hero, Item itemToRemove)
        {
            try
            {
            hero.Inventory.Remove(itemToRemove);
            Console.WriteLine($"Removed {itemToRemove}");
            }
            catch
            {
                Console.WriteLine("That is not in your inventory");
            }

        }
    }
}
