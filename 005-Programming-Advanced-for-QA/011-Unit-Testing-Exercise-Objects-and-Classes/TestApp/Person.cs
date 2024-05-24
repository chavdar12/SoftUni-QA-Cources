using System.Text;

namespace TestApp;

public class Person
{
    public string Name { get; set; } = null!;

    public string Id { get; set; } = null!;

    public int Age { get; set; }

    public List<Person> AddPeople(string[] people)
    {
        List<Person> peopleList = new();
        foreach (var data in people)
        {
            var split = data.Split();

            var name = split[0];
            var id = split[1];
            var age = int.Parse(split[2]);

            var searchPerson = peopleList.FirstOrDefault(person => person.Id == id);
            if (searchPerson is null)
            {
                peopleList.Add(new Person
                {
                    Name = name,
                    Id = id,
                    Age = age
                });
            }
            else
            {
                searchPerson.Age = age;
                searchPerson.Name = name;
            }
        }

        return peopleList;
    }

    public string GetByAgeAscending(List<Person> people)
    {
        StringBuilder sb = new();
        foreach (var person in people.OrderBy(person => person.Age))
            sb.AppendLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");

        return sb.ToString().Trim();
    }
}