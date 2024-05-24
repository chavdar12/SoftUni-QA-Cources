namespace Ex002;

internal class Program
{
    private static void Main(string[] args)
    {
        string[] articleInfo = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        var title = articleInfo[0];
        var content = articleInfo[1];
        var author = articleInfo[2];

        var article = new Article(title, content, author);

        var numberOfCommands = int.Parse(Console.ReadLine());

        for (var i = 1; i <= numberOfCommands; i++)
        {
            string[] commandsInput = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            var command = commandsInput[0];
            var newData = commandsInput[1];

            if (command == "Edit")
                article.Edit(newData);
            else if (command == "ChangeAuthor")
                article.ChangeAuthor(newData);
            else if (command == "Rename") article.Rename(newData);
        }

        Console.WriteLine(article.ToString());
    }
}