// Skip - skip the given amount of elements

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Skip first 5 elements
var skipFiveElements = numbers.Skip(5);
Console.WriteLine("Skip 5 elements:");
Console.WriteLine(string.Join(", ", skipFiveElements));
Console.WriteLine();

// Skip first 11 elements - will return empty list because list of numbers contains only 10 elements
var skipElevenElements = numbers.Skip(11);
Console.WriteLine("Skip 11 elements:");
Console.WriteLine(string.Join(", ", skipElevenElements));