// Where - get data

using LinqWhere;

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

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

// Get numbers above 5
var numbersMoreThanFive = numbers.Where(x => x > 5).ToList();

foreach (var number in numbersMoreThanFive)
{
    Console.WriteLine(number);
}
Console.WriteLine();

// Get even numbers
var evenNumbers = numbers.Where(x => x % 2 == 0).ToList();

foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine();

// Get students with grade equals 4
var studentsWithGradeFour = students.Where(x => x.Grade == 4).ToList();

foreach (var student in studentsWithGradeFour)
{
    Console.WriteLine($"Name = {student.Name}; Grade = {student.Grade}");
}
Console.WriteLine();

// Get maths students
var mathsStudents = students.Where(x => x.SchoolSubject == "Maths").ToList();

foreach (var student in mathsStudents)
{
    Console.WriteLine($"Name = {student.Name}; School subject = {student.SchoolSubject}");
}
Console.WriteLine();

// Get art students with grade above 4
var artStudentsWithGradeAboveFour = students.Where(x => x.SchoolSubject == "Art" && x.Grade > 4).ToList();

foreach (var student in artStudentsWithGradeAboveFour)
{
    Console.WriteLine($"Name = {student.Name}; School subject = {student.SchoolSubject}; Grade = {student.Grade}");
}
