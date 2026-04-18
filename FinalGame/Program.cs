using MyInterfaces;
using MyClasses;
using System.Threading.Channels;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
public class Program
{
    static void Main()
    {
        Character hero = new Character();
        TournamentClass tournamentManager = new TournamentClass();
        Random rng = new Random();


        Console.WriteLine("Welcome to your trial by combat, what is your hero's name?");
        string name = Console.ReadLine().Trim();
        hero.Name = name;
        while (true)
        {
            Console.WriteLine($"Choose {name}'s class (type the number)\n" +
                $"1.Warrior\n" +
                $"2.Rogue");
            string chosenClass = Console.ReadLine();
            if (chosenClass == "1")
            {
                hero.BattleClass = "Warrior";
                hero.Health = 200;
                hero.Luck = 1;
                hero.Ranking = 1;
                hero.Level = 1;
                hero.Gold = rng.Next(10, 101);
                hero.StartingItems();
                break;
            }
            if (chosenClass == "2")
            {
                hero.BattleClass = "Rogue";
                hero.Health = 150;
                hero.Luck = 3;
                hero.Ranking = 1; 
                hero.Level = 1;
                hero.Gold = rng.Next(10, 101);
                hero.StartingItems();
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid class, try again");
            }
        }
        Console.WriteLine("Here are your stats:\n");
        hero.Display();
        SaveManager.Save(hero);
        Console.WriteLine("Game Saved");
        Console.WriteLine("Your first fight begins!");
        tournamentManager.TournamentRound(hero);
         
    }
}
