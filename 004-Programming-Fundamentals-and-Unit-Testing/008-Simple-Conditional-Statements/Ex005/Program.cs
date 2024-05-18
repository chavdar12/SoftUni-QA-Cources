namespace Ex005;

internal class Program
{
    private static void Main(string[] args)
    {
        var myPassword = Console.ReadLine();

        Console.WriteLine(myPassword == "s3cr3t!" ? "Welcome" : "Wrong password!");
    }
}