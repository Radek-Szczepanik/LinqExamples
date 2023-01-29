// Select - select data from collection like where or transform data to other collection

using LinqSelect;

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

// Get students names
var studentsNames = students.Select(s => s.Name);

Console.WriteLine("Students names:");
Console.WriteLine(string.Join(", ", studentsNames));
Console.WriteLine();

// Transform data to StudentDto
var studentDto = students.Select(x => new StudentDto()
{
    Id = x.Id,
    Name = x.Name,
});

Console.WriteLine("Id and name form student dto:");
foreach (var item in studentDto)
{
    Console.WriteLine($"Id = {item.Id}; Name = {item.Name}");
}
Console.WriteLine();

// Return anonymous type - type without class
var anonymousDto = students.Select(x => new
{
    Id = x.Id,
    Name = x.Name,
    Grade = x.Grade,    // You can add any variable
});

Console.WriteLine("Id, name and grade as anonymous type:");
foreach (var item in anonymousDto)
{
    Console.WriteLine($"Id = {item.Id}; Name = {item.Name}; Grade = {item.Grade}");
}
Console.WriteLine();
