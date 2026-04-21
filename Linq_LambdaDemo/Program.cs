public class Program
{
    static void Main()
    {
        List<string> formerChampions = new() { "Harry", "Doug", "Robert", "Doug", "Grogliog" };
        List<string> repeatedChampions = formerChampions.Where(r => r == "Doug").ToList();
        List<string> oneHitWonders = formerChampions.Where(o => o != "Doug").ToList();

        foreach(string champion in repeatedChampions)
        {
            Console.WriteLine($"Reapeated winners: {champion}\n");
        }
        foreach(string gloryDays in oneHitWonders)
        {
            Console.WriteLine($"Our champions who came and went:\n{gloryDays}\n");
        }
    }
}