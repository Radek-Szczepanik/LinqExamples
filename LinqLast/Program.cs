// Last - get last element from collection

var numbers = new List<int> { 5, 2, 1, 6, 3, 1, 4, 5, 6, 1, 7, 8, 9, 10, 1 };

// Get first element
var lastElement = numbers.Last();

Console.WriteLine("Last element:");
Console.WriteLine(lastElement);

Console.WriteLine();

// Get last element equals 10
var lastElementEqualsTen = numbers.Last(x => x == 10);

Console.WriteLine("Last element equals ten:");
Console.WriteLine(lastElementEqualsTen);

Console.WriteLine();

// Get last element equals 11 - there is not in collection (will return exception)
var lastElementEqualsEleven = numbers.Last(x => x == 11);

Console.WriteLine("Last element equals eleven:");
Console.WriteLine(lastElementEqualsEleven);

Console.WriteLine();

// Get last element equals 12 - there is not in collection (use LastOrDefault will return default type)
var lastElementEqualsTwelve = numbers.LastOrDefault(x => x == 12);

Console.WriteLine("Last element equals twelve:");
Console.WriteLine(lastElementEqualsTwelve);

Console.WriteLine();