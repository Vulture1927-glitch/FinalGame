using MyInterfaces;
using MyClasses;
using System.Threading.Channels;
using System.ComponentModel.DataAnnotations;
public class Program
{
    static void Main()
    {
        Character hero = new Character();
        TournamentClass tournamentManager = new TournamentClass();



        Console.WriteLine("Welcome to your trial by combat, what is your hero's name?");
        string name = Console.ReadLine().Trim();
        hero.Name = name;
        while (true)
        {
            Console.WriteLine($"Choose {name}'s class (type the number)\n" +
                $"1.Warrior" +
                $"2.Rogue");
            string chosenClass = Console.ReadLine();
            if (chosenClass == "1")
            {
                hero.BattleClass = "Warrior";
                break;
            }
            if (chosenClass == "2")
            {
                hero.BattleClass = "Rogue";
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
