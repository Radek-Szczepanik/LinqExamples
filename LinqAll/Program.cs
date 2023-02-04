// All - checks collection by condition and returns a bool

using LinqAll;

var numbers = new List<int> { 2, 9, 1, 0, 8, 5, 7, 4, 3, 6, 10, 15, 17, 19, 13, 20 };

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

// Check if the numbers collection contains digits greater than 10 - returns false because collection contains digits less than 10 too
var numbersGreaterThanTen = numbers.All(n => n > 10);
Console.WriteLine("Check if collection contains digits greater than 10");
Console.WriteLine(numbersGreaterThanTen);
Console.WriteLine();

var studentsA = students.Where(x => x.Id > 0 && x.Id < 5).ToList();
var studentsB = students.Where(x => x.Name.Contains('e') || x.Name.StartsWith('A')).ToList();

Console.WriteLine("Students A:");

foreach (var student in studentsA)
{
    Console.WriteLine($"Id = {student.Id}; Name = {student.Name}; SchoolSubject = {student.SchoolSubject}; " +
                      $"Grade = {student.Grade}");
}
Console.WriteLine();

// Check if studentsA contains Id greater than 0 - returns true because the collection contains Id from 0 to 4
Console.WriteLine("Check if studentsA contains Id greater than 0");
var studentsWithIdGreaterThanZero = studentsA.All(s => s.Id > 0);
Console.WriteLine(studentsWithIdGreaterThanZero);

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

// Check if studentsB contains name Anna - returns false because the collection contains other names
Console.WriteLine("Check if studentsB contains name Anna");
var studentWithNameAnna = studentsB.All(s => s.Name == "Anna");
Console.WriteLine(studentWithNameAnna);
