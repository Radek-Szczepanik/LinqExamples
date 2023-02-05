// MaxBy - returns element with the highest value by condition

using LinqMaxBy;

var people = new List<Person>()
{
    new Person() { Name = "John", Age = 38 },
    new Person() { Name = "Anna", Age = 42 },
    new Person() { Name = "Peter", Age = 33 },
};

// Oldest person in collection
var oldestPerson = people.MaxBy(x => x.Age);
Console.WriteLine($"Name = {oldestPerson.Name}; Age = {oldestPerson.Age}");
