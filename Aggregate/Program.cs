// Aggregate - working with collections and performs various operations

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// Sum of numbers
var sumOfNumbers = numbers.Aggregate((a, b) => a + b);
Console.WriteLine($"Sum of numbers: {sumOfNumbers}");
Console.WriteLine();

// Count even numbers
var amountOfEvenNumbers = numbers.Aggregate(0, (total, next) => next % 2 == 0 ? total + 1 : total);
Console.WriteLine($"Amount of even numbers is: {amountOfEvenNumbers}");
Console.WriteLine();

string[] fruits = { "apple", "mango", "orange", "banana", "grape" };

// Which fruit is the longest word - if two then returns the first
string longestName = fruits.Aggregate((longest, next) => next.Length > longest.Length ? next : longest);
Console.WriteLine($"The fruit with the longest name is: {longestName.ToUpper()}");
Console.WriteLine();

// Reverse words in fruits array
var reverse = fruits.Aggregate((word, next) => next + " " + word);
Console.WriteLine("Reverse order in fruit array:");
Console.WriteLine(reverse);