// OrderBy - sort collection ascending
// OrderByDescending - sort collection descending

using LinqOrderBy;

var numbers = new List<int> { 5, 9, 3, 10, 8, 4, 2, 1, 0, 6 };

var students = new List<Student>()
{
    new Student {Id = 1, Name = "Anna", SchoolSubject = "Art", Grade = 5},
    new Student {Id = 2, Name = "John", SchoolSubject = "Maths", Grade = 4},
    new Student {Id = 3, Name = "Sue", SchoolSubject = "English", Grade = 4},
    new Student {Id = 4, Name = "Mike", SchoolSubject = "Maths", Grade = 5},
    new Student {Id = 5, Name = "Paul", SchoolSubject = "Art", Grade = 3},
    new Student {Id = 6, Name = "Kate", SchoolSubject = "History", Grade = 4},
    new Student {Id = 7, Name = "Adam", SchoolSubject = "History", Grade = 4},
    new Student {Id = 8, Name = "Adam", SchoolSubject = "Art", Grade = 3},
    new Student {Id = 9, Name = "Kate", SchoolSubject = "Art", Grade = 4},
    new Student {Id = 10, Name = "John", SchoolSubject = "Art", Grade = 3},
};

// Sort collection ascending / descending
var sortedNumbers =  numbers.OrderBy(x => x).ToList();
Console.WriteLine("Sorted numbers:");
Console.WriteLine(string.Join(", ", sortedNumbers));
Console.WriteLine();

// Sort collection ascending / descending by Grade
var sortedStudents = students.OrderBy(x => x.Grade).ToList();

Console.WriteLine("Sorted collection by Grade:");

foreach (var student in sortedStudents)
{
    Console.WriteLine($"Id = {student.Id}; Name = {student.Name}; School subject = {student.SchoolSubject}; " +
                      $"Grade = {student.Grade}");
}
Console.WriteLine();

// ThenBy or ThenByDescending is used to additional sort by other properties
var sortedStudentsByGradeAndName = students.OrderBy(x => x.Grade).ThenBy(y => y.Name).ToList();

Console.WriteLine("Sorted collection by Grade and Name:");

foreach (var student in sortedStudentsByGradeAndName)
{
    Console.WriteLine($"Id = {student.Id}; Name = {student.Name}; School subject = {student.SchoolSubject}; " +
                      $"Grade = {student.Grade}");
}
Console.WriteLine();