// Zip - join first element from first collection with second element from second collection

var letters = new[] { "A", "B", "C", "D", "E", "F", "G" };
var numbers = new[] { 1, 2, 3, 4 };

// Join elements from collections
var zipLettersAndNumbers = letters.Zip(numbers, (l, n) => l + n);

Console.WriteLine("Zipped elements:");
foreach (var item in zipLettersAndNumbers)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("or");
Console.WriteLine();

var zipLettersWithNumbers = letters.Zip(numbers);

Console.WriteLine("Zipped elements:");
foreach (var item in zipLettersWithNumbers)
{
    Console.WriteLine(item);
}
