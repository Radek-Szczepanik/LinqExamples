// Count - count elements in the collection by given condition

var numbers = new List<int> { 1, 2, 3, 4, 5, 1, 1, 1, 2, 3, 3, 4 };

var countDigitOne = numbers.Count(x => x == 1);
Console.WriteLine("Count digit one:");
Console.WriteLine(countDigitOne);