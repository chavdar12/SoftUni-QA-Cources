namespace Ex009;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please, enter your password.");
        var passWord = "";

        while (passWord != "myPass")
        {
            passWord = Console.ReadLine();
            Console.WriteLine("Wrong Pass");
            Console.WriteLine("Please enter new password");
        }

        Console.WriteLine("Welcome");
    }
}