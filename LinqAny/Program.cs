// Any - checks if at least one element in the collection fulfils the condition and return a bool

var numbers = new List<int> { 2, 9, 1, 0, 8, 5, 7, 4, 3, 6, 10, 15, 17, 19, 13, 20 };

// Check if collection contains elements greater than 10 - returns true because there is at least elements that fulfil the condition
var numbersGreaterThanTen = numbers.Any(n => n > 10);
Console.WriteLine("Check if collection contains elements greater than 10");
Console.WriteLine(numbersGreaterThanTen);
Console.WriteLine();

// Check if collection contains elements greater than 30 - returns false because there is not at least elements that fulfil the condition
var numbersGreaterThanThirty = numbers.Any(n => n > 30);
Console.WriteLine("Check if collection contains elements greater than 30");
Console.WriteLine(numbersGreaterThanThirty);
