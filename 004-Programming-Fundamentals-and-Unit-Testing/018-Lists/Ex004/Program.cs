namespace Ex004;

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
                case "Add":
                {
                    var number = int.Parse(commandElements[1]);

                    numbers.Add(number);
                    break;
                }
                case "Insert":
                {
                    var number = int.Parse(commandElements[1]);
                    var position = int.Parse(commandElements[2]);

                    numbers.Insert(position, number);
                    break;
                }
                case "Remove":
                {
                    var number = int.Parse(commandElements[1]);
                    numbers.Remove(number);
                    break;
                }
                case "RemoveAt":
                {
                    var position = int.Parse(commandElements[1]);
                    numbers.RemoveAt(position);
                    break;
                }
            }

            command = Console.ReadLine();
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}