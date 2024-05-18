namespace Ex001;

internal class Program
{
    private static void Main(string[] args)
    {
        var numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        var command = Console.ReadLine();

        while (command != "end")
        {
            var commandElements = command.Split().ToArray();

            switch (commandElements[0])
            {
                case "Delete":
                {
                    var number = int.Parse(commandElements[1]);
                    while (numbers.Contains(number)) numbers.Remove(number);
                    break;
                }
                case "Insert":
                {
                    var number = int.Parse(commandElements[1]);
                    var position = int.Parse(commandElements[2]);

                    numbers.Insert(position, number);
                    break;
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}