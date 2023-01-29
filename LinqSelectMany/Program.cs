// SelectMany - allows iteration on collection in other collection

using LinqSelectMany;

var students = new List<Student>()
{
    new Student() { Id = 1, Name = "Anna", City = new List<string>{"Warszawa"}},
    new Student() { Id = 2, Name = "Zosia", City = new List<string>{"Kraków"}},
    new Student() { Id = 3, Name = "Piotr", City = new List<string>{"Poznań"}},
    new Student() { Id = 4, Name = "Jan", City = new List<string>{"Wrocław"}},
    new Student() { Id = 5, Name = "Basia", City = new List<string>{"Warszawa"}},
    new Student() { Id = 6, Name = "Anna", City = new List<string>{"Gdańsk"}},
    new Student() { Id = 7, Name = "Jacek", City = new List<string>{"Warszawa"}},
};

// Get cities - collection in collection
var cities = students.SelectMany(x => x.City).ToList();

Console.WriteLine("Get cities:");

Console.WriteLine(string.Join(", ", cities));