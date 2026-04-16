using MyInterfaces;
using MyClasses;
public class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to your trial by combat, what is your hero's name?");
        string name = Console.ReadLine().Trim();
        while (true)
        {
            Console.WriteLine($"Choose {name}'s class (type the number)\n" +
                $"1.Warrior" +
                $"2.Rogue");
            string chosenClass = Console.ReadLine();
            if (chosenClass == "1")
            {
                Character hero = new Character(name, "Warrior");
                break;
            }
            if (chosenClass == "2")
            {
                Character hero = new Character(name, "Rogue");
                break;
            }
            else
            {
                Console.WriteLine("That is not a valid class, try again");
            }
        }

    }
}
