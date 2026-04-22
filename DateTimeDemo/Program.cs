public class Program
{
    static void Main()
    {
        Console.WriteLine("What is the name of your account");
        string response = Console.ReadLine().Trim();
        Account account = new Account(response);
        account.Display();
    }
}
public class Account
{
    public string Name { get; set; }
    public DateTime Creation;
    public Guid Id;

    public Account(string name)
    {
        this.Name = name; 
        Creation = DateTime.Now;
        Id = Guid.NewGuid();
    }
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Date created: {Creation}");
        Console.WriteLine($"Id: {Id}");
    }
}
