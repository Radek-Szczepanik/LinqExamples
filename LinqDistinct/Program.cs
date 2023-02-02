// Distinct - remove duplicates, works with only one collection

using LinqDistinct;

var numbers = new List<int> { 1, 2, 3, 3, 3, 4, 5, 6, 6, 7, 8, 1, 1, 9, 10, 5, 5, 2 };

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

// Remove duplicates
var numbersWithoutDuplicates = numbers.Distinct().ToList();
Console.WriteLine("List without duplicates:");
Console.WriteLine(string.Join(", ", numbersWithoutDuplicates));
Console.WriteLine();

// DistinctBy - remove duplicates and create a new collection
var studentsWithoutDuplicates = students.DistinctBy(x => x.SchoolSubject);

foreach (var student in studentsWithoutDuplicates)
{
    Console.WriteLine($"Id = {student.Id}; Name = {student.Name}; SchoolSubject = {student.SchoolSubject}; " +
                      $"Grade = {student.Grade}");
}

