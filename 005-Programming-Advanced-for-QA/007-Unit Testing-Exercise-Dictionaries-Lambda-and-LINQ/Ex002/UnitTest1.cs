using TestApp;

namespace Ex002;

public class Tests
{
    private Person _person;

    [SetUp]
    public void SetUp()
    {
        _person = new Person();
    }

    [Test]
    public void Test_AddPeople_ReturnsListWithUniquePeople()
    {
        // Arrange
        string[] peopleData = { "Alice A001 25", "Bob B002 30", "Alice A001 35" };
        List<Person> expectedPeopleList = new()
        {
            new Person
            {
                Name = "Alice",
                Id = "A001",
                Age = 35
            },
            new Person
            {
                Name = "Bob",
                Id = "B002",
                Age = 30
            }
        };

        // Act
        var actualPeopleList = _person.AddPeople(peopleData);

        // Assert
        Assert.That(actualPeopleList, Has.Count.EqualTo(2));
        for (var i = 0; i < actualPeopleList.Count; i++)
        {
            Assert.That(actualPeopleList[i].Name, Is.EqualTo(expectedPeopleList[i].Name));
            Assert.That(actualPeopleList[i].Id, Is.EqualTo(expectedPeopleList[i].Id));
            Assert.That(actualPeopleList[i].Age, Is.EqualTo(expectedPeopleList[i].Age));
        }
    }

    [Test]
    public void Test_GetByAgeAscending_SortsPeopleByAge()
    {
        // Arrange
        List<Person> peopleData = new()
        {
            new Person
            {
                Name = "Alice",
                Id = "A001",
                Age = 25
            },
            new Person
            {
                Name = "Bob",
                Id = "B002",
                Age = 30
            },
            new Person
            {
                Name = "Christian",
                Id = "C003",
                Age = 28
            }
        };
        var expected = $"Alice with ID: A001 is 25 years old.{Environment.NewLine}" +
                       $"Christian with ID: C003 is 28 years old.{Environment.NewLine}" +
                       $"Bob with ID: B002 is 30 years old.";

        // Act
        var actual = _person.GetByAgeAscending(peopleData);

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}