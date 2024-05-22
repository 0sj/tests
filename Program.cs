internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("what is the current value of the NZD in comparison to USD");
        decimal NZD = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("how much money have you gots :3 \t\t:");

        decimal Amount = Convert.ToDecimal( Console.ReadLine()) * NZD;

        Console.WriteLine("you have " + Amount);
    }
}