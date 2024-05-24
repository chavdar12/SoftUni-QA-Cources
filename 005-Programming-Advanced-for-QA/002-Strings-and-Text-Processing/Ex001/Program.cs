namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var input = Console.ReadLine();

        while (input != "end")
        {
            var output = "";

            for (var i = input.Length - 1; i >= 0; i--) output += input[i];

            Console.WriteLine(input + " = " + output);

            input = Console.ReadLine();
        }
    }
}