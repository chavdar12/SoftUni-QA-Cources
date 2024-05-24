using TestApp;

namespace Tests;

public class SongTests
{
    private Song _song;

    [SetUp]
    public void SetUp()
    {
        _song = new Song();
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsAllSongs_WhenWantedListIsAll()
    {
        // Arrange
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        var wantedList = "all";
        var expected = $"Song1{Environment.NewLine}Song2{Environment.NewLine}Song3";

        // Act
        var actual = _song.AddAndListSongs(songs, wantedList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsFilteredSongs_WhenWantedListIsSpecific()
    {
        // Arrange
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Rap_Like That_4:29" };
        var wantedList = "Rap";
        var expected = $"Like That";

        // Act
        var actual = _song.AddAndListSongs(songs, wantedList);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddAndListSongs_ReturnsEmptyString_WhenNoSongsMatchWantedList()
    {
        // Arrange
        string[] songs = { "Pop_Song1_3:30", "Rock_Song2_4:15", "Pop_Song3_3:00" };
        var wantedList = "Rap";

        // Act
        var actual = _song.AddAndListSongs(songs, wantedList);

        // Assert
        Assert.That(actual, Is.Empty);
    }
}