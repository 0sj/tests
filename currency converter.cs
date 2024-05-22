internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("what is the current value of the NZD in comparison to the target currency");
        decimal NZD = Convert.ToDecimal(Console.ReadLine());

    Console.WriteLine("how much money does the item cost :3 \n:");

        decimal Amount = Convert.ToDecimal( Console.ReadLine()) * NZD;

        Console.WriteLine("you have " + Amount + "NZD");
    }
}
//meowemdfnjvsdfbnvjdfsgbfgebknb nk