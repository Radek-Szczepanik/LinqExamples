// First - get first element from collection

var numbers = new List<int> { 5, 2, 1, 6, 3, 1, 4, 5, 6, 1, 7, 8, 9, 10, 1 };

// Get first element
var firstElement = numbers.First();

Console.WriteLine("First element:");
Console.WriteLine(firstElement);

Console.WriteLine();

// Get first element equals 1
var firstElementEqualsOne = numbers.First(x => x == 1);

Console.WriteLine("First element equals one:");
Console.WriteLine(firstElementEqualsOne);

Console.WriteLine();

// Get first element equals 11 - there is not in collection (will return exception)
var firstElementEqualsEleven = numbers.First(x => x == 11);

Console.WriteLine("First element equals eleven:");
Console.WriteLine(firstElementEqualsEleven);

Console.WriteLine();

// Get first element equals 12 - there is not in collection (use FirstOrDefault will return default type)
var firstElementEqualsTwelve = numbers.FirstOrDefault(x => x == 12);

Console.WriteLine("First element equals twelve:");
Console.WriteLine(firstElementEqualsTwelve);

Console.WriteLine();
