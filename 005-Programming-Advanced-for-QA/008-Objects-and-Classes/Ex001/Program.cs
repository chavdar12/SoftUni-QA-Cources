namespace Ex001;

internal class Song
{
    public string TypeList { get; set; }
    public string Name { get; set; }
    public string Time { get; set; }

    public Song()
    {
    }

    public Song(string typeList, string name, string time)
    {
        TypeList = typeList;
        Name = name;
        Time = time;
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            var numberOfSongs = int.Parse(Console.ReadLine());

            List<Song> songs = new();

            for (var i = 1; i <= numberOfSongs; i++)
            {
                string[] input = Console.ReadLine().Split("_").ToArray();
                var typeList = input[0];
                var name = input[1];
                var time = input[2];

                var song = new Song(typeList, name, time);

                songs.Add(song);
            }

            var outputCommand = Console.ReadLine();

            if (!outputCommand.Equals("all")) songs = songs.Where(t => t.TypeList.Equals(outputCommand)).ToList();

            songs.ForEach(s => Console.WriteLine(s.Name));
        }
    }
}