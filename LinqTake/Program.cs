// Take - take the given amount of elements

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Get first 3 elements
var threeElements = numbers.Take(3);
Console.WriteLine("First 3 elements:");
Console.WriteLine(string.Join(", ", threeElements));
Console.WriteLine();

// Get first 20 elements - will return only 10 elements (list of numbers contains 10 elements)
var twentyElements = numbers.Take(20);
Console.WriteLine("First 20 elements:");
Console.WriteLine(string.Join(", ", twentyElements));
Console.WriteLine();