// TakeWhile - take elements from the collection until the condition is true

using LinqTakeWhile;

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

// Take elements according to the condition
var numbersFromCollection = numbers.TakeWhile(x => x < 5).ToList();
Console.WriteLine("Take elements according to the condition:");
Console.WriteLine(string.Join(", ", numbersFromCollection));
Console.WriteLine();

// Take elements according to the condition (will take only the first matching element)
var studentsFromCollection = students.TakeWhile(x => x.Grade > 4).ToList();
Console.WriteLine("Take elements according to the condition:");

foreach (var student in studentsFromCollection)
{
    Console.WriteLine($"Id = {student.Id}; Name = {student.Name}; School subject = {student.SchoolSubject}; " +
                      $"Grade = {student.Grade}");
}
Console.WriteLine();