// Union - join collections and remove duplications, works with collections of the same type

using LinqUnion;

var numbersA = new List<int> { 0, 1, 2, 3, 4, 5 };
var numbersB = new List<int> { 3, 4, 5, 6, 7, 8 };

var students = new List<Student>()
{
    new Student {Id = 1, Name = "Anna", SchoolSubject = "Art", Grade = 5},
    new Student {Id = 2, Name = "John", SchoolSubject = "Maths", Grade = 4},
    new Student {Id = 3, Name = "Sue", SchoolSubject = "English", Grade = 4},
    new Student {Id = 4, Name = "Mike", SchoolSubject = "Maths", Grade = 5},
    new Student {Id = 5, Name = "Paul", SchoolSubject = "Art", Grade = 3},
    new Student {Id = 6, Name = "Kate", SchoolSubject = "History", Grade = 4},
    new Student {Id = 7, Name = "Adam", SchoolSubject = "Art", Grade = 4},
};

// Join numbersA and numbersB
var unionNumbers = numbersA.Union(numbersB);
Console.WriteLine("Joined collections without duplicates:");
Console.WriteLine(string.Join(", ", unionNumbers));
Console.WriteLine();

// Join two collections of students
var studentsA = students.Where(x => x.Id > 0 && x.Id < 5).ToList();
var studentsB = students.Where(x => x.Name.Contains('e') || x.Name.StartsWith('A')).ToList();

Console.WriteLine("Students A:");

foreach (var student in studentsA)
{
    Console.WriteLine($"Id = {student.Id}; Name = {student.Name}; SchoolSubject = {student.SchoolSubject}; " +
                      $"Grade = {student.Grade}");
}
Console.WriteLine();
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("Students B:");

foreach (var student in studentsB)
{
    Console.WriteLine($"Id = {student.Id}; Name = {student.Name}; SchoolSubject = {student.SchoolSubject}; " +
                      $"Grade = {student.Grade}");
}
Console.WriteLine();
Console.WriteLine("---------------------------------------------------------");
Console.WriteLine();

Console.WriteLine("Students A union Students B:");

var unionStudents = studentsA.Union(studentsB);

foreach (var student in unionStudents)
{
    Console.WriteLine($"Id = {student.Id}; Name = {student.Name}; SchoolSubject = {student.SchoolSubject}; " +
                      $"Grade = {student.Grade}");
}