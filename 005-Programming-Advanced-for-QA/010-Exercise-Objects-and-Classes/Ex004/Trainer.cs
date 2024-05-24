namespace Ex004;

public class Trainer
{
    public string Name { get; set; }

    public int NumberOfBadges { get; set; }

    public List<Pokemon> Pokemons { get; set; }

    public Trainer()
    {
    }

    public Trainer(string name)
    {
        Name = name;
        NumberOfBadges = 0;
        Pokemons = new List<Pokemon>();
    }
}