namespace Ex004;

internal class Program
{
    private static void Main(string[] args)
    {
        var trainers = new Dictionary<string, Trainer>();

        var command = Console.ReadLine();

        while (command != "Tournament")
        {
            var input = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var trainerName = input[0];
            var pokemonName = input[1];
            var pokemonElement = input[2];
            var pokemonHealth = int.Parse(input[3]);

            if (!trainers.ContainsKey(trainerName))
            {
                var trainer = new Trainer(trainerName);
                trainers.Add(trainerName, trainer);
            }

            var pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            trainers[trainerName].Pokemons.Add(pokemon);

            command = Console.ReadLine();
        }

        command = Console.ReadLine();

        while (command != "End")
        {
            if (command == "Fire")
                CheckPokemonForElement(trainers, command);
            else if (command == "Water")
                CheckPokemonForElement(trainers, command);
            else if (command == "Electricity") CheckPokemonForElement(trainers, command);

            command = Console.ReadLine();
        }

        trainers.OrderByDescending(t => t.Value.NumberOfBadges)
            .Select(t =>
            {
                Console.WriteLine($"{t.Value.Name} {t.Value.NumberOfBadges} {t.Value.Pokemons.Count}");

                return 1;
            })
            .ToList();
    }

    private static void CheckPokemonForElement(Dictionary<string, Trainer> trainers, string command)
    {
        foreach (var trainer in trainers.Values)
        {
            var hasElement = trainer.Pokemons.Any(p => p.Element.Equals(command)).Equals(true);
            if (hasElement)
            {
                trainer.NumberOfBadges++;
            }
            else
            {
                trainer.Pokemons.ForEach(p => p.Health -= 10);
                trainer.Pokemons.RemoveAll(p => p.Health <= 0);
            }
        }
    }
}