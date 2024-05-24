using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApp;

public class Song
{
    public string ListType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Time { get; set; } = null!;

    public string AddAndListSongs(string[] songs, string wantedList)
    {
        List<Song> addedSongs = new();

        foreach (var currentSong in songs)
        {
            string[] data = currentSong.Split('_');

            var type = data[0];
            var name = data[1];
            var time = data[2];

            Song song = new()
            {
                ListType = type,
                Name = name,
                Time = time
            };

            addedSongs.Add(song);
        }

        List<Song> filtered = wantedList == "all"
            ? addedSongs
            : addedSongs.Where(s => s.ListType == wantedList).ToList();

        StringBuilder sb = new();
        foreach (var song in filtered) sb.AppendLine(song.Name);

        return sb.ToString().Trim();
    }
}