public class Program
{
    static async void Main()
    {
        Hero hero = new Hero("Ya boi", "Sword");
       
        Console.WriteLine();

        Console.WriteLine("Start Battle");
        Task speedy = FastAttack(hero);
        Task slow = SlowAttack(hero);
        await Task.WhenAll(speedy, slow);
        Console.WriteLine("Battle is done");

    }
    public static async Task<string> FastAttack(Hero hero)
    {
        
        Random rng = new Random();
        await Task.Delay(3000);
        if(hero.Health != 0)
        {
            return $"You attacked with {hero.Weapon} and dealt {hero.Damage - 2}";
        }
        else
        {
            return "Your attack was interuppted";
        }
    }
    public static async Task<string> SlowAttack(Hero hero)
    {

        Random rng = new Random();
        await Task.Delay(6000);
        if (hero.Health != 0)
        {
            return $"You attacked with {hero.Weapon} and dealt {hero.Damage + 2}";
        }
        else
        {
            return "Your attack was interuppted";
        }
    }
}
public class Hero
{
    public string Name { get; set; }
    public string Weapon { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Hero(string name, string weapon)
    {
        Name = name;
        Weapon = weapon;
        Health = 100;
        Damage = 5;
    }
}