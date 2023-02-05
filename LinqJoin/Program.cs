// Join - join at least two collections by key - there is not will be null if data not matching (inner join in sql)
// GroupJoin - join element with similar collection

using LinqJoin;

var persons = new List<Person>()
{
    new Person() {Id = 1, Name = "Anna"},
    new Person() {Id = 2, Name = "John"},
    new Person() {Id = 3, Name = "Paul"},
    new Person() {Id = 4, Name = "Sue"},
};

var addresses = new List<Address>()
{
    new Address() {Id = 1, PersonId = 1, Street = "Polna", City = "Warszawa"},
    new Address() {Id = 2, PersonId = 2, Street = "Leśna", City = "Wrocław"},
    new Address() {Id = 3, PersonId = 4, Street = "Pogodna", City = "Kraków"},
    new Address() {Id = 4, PersonId = 4, Street = "Zamkowa", City = "Gdańsk"},
};

// Join persons and addresses
persons.Join(addresses, p => p.Id, a => a.PersonId, (persons, addresses) => new
{
    persons.Name,
    addresses.Street,
    addresses.City
}).ToList().ForEach(x =>
{
    Console.WriteLine($"Name = {x.Name}; Street = {x.Street}, City = {x.City}");
});
Console.WriteLine();

// GroupJoin - join person with addresses collection
persons.GroupJoin(addresses, p => p.Id, a => a.PersonId, (persons, addresses) => new
{
    persons.Name,
    Addresses = addresses
}).ToList().ForEach(x =>
{
    Console.WriteLine($"Name = {x.Name}");
    x.Addresses.ToList().ForEach(y => Console.WriteLine($"Street = {y.Street}; City = {y.City}"));
});