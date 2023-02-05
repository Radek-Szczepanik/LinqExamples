// GroupBy - group collection by condition

using LinqGroup;

var students = new List<Student>()
{
    new Student {Id = 1, Name = "Anna", SchoolSubject = "Art", Grade = 5},
    new Student {Id = 2, Name = "John", SchoolSubject = "Maths", Grade = 4},
    new Student {Id = 3, Name = "Sue", SchoolSubject = "English", Grade = 4},
    new Student {Id = 4, Name = "Mike", SchoolSubject = "Maths", Grade = 5},
    new Student {Id = 5, Name = "Paul", SchoolSubject = "Art", Grade = 3},
    new Student {Id = 6, Name = "Kate", SchoolSubject = "History", Grade = 4},
    new Student {Id = 7, Name = "Adam", SchoolSubject = "Art", Grade = 4},
    new Student {Id = 8, Name = "Ralph", SchoolSubject = "Maths", Grade = 5},
    new Student {Id = 9, Name = "Peter", SchoolSubject = "English", Grade = 5},
    new Student {Id = 10, Name = "Anna", SchoolSubject = "Geography", Grade = 3},
    new Student {Id = 11, Name = "John", SchoolSubject = "Art", Grade = 4},
    new Student {Id = 12, Name = "John", SchoolSubject =  "English", Grade = 3},
    new Student {Id = 13, Name = "Anna", SchoolSubject = "History", Grade = 5},
    new Student {Id = 14, Name = "Peter", SchoolSubject = "Art", Grade = 4},
    new Student {Id = 15, Name = "Sue", SchoolSubject = "History", Grade = 4},
};

// Group students by grade
students.GroupBy(x => x.Grade).ToList().ForEach(x =>
{
    Console.WriteLine("Group by grade:");
    Console.WriteLine(x.Key);
    x.ToList().ForEach(y =>
    {
        Console.WriteLine($"Id = {y.Id}; Name = {y.Name}");
    });
    Console.WriteLine();
});
Console.WriteLine();

// Group students by grade and subject
students.GroupBy(x => new {x.Grade, x.SchoolSubject}).ToList().ForEach(x =>
{
    Console.WriteLine("Group by grade and subject:");
    Console.WriteLine(x.Key);
    x.ToList().ForEach(y =>
    {
        Console.WriteLine($"Id = {y.Id}; Name = {y.Name}");
    });
    Console.WriteLine();
});
Console.WriteLine();

// Group students by name
students.GroupBy(x => x.SchoolSubject).ToList().ForEach(x =>
{
    Console.WriteLine("Group by school subject:");
    Console.WriteLine(x.Key);
    x.Average(g => g.Grade);
    x.ToList().ForEach(y =>
    {
        Console.WriteLine($"Id = {y.Id}; Name = {y.Name}; Grade = {y.Grade}");
    });
    Console.WriteLine($"Average grade = {x.Average(g => g.Grade).ToString("0.00")}");
    Console.WriteLine($"Min grade = {x.Min(g => g.Grade)}");
    Console.WriteLine($"Max grade = {x.Max(g => g.Grade)}");
    Console.WriteLine();
});




