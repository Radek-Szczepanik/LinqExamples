// Single - get single element from collection

var numbers = new List<int> { 5, 2, 1, 6, 3, 1, 4, 5, 6, 1, 7, 8, 9, 5, 10, 1 };

// Get single element - number 2 occurs once in collection
var singleElementTwo = numbers.Single(x => x == 2);

Console.WriteLine("Single element two:");
Console.WriteLine(singleElementTwo);

Console.WriteLine();

// Get single element - number 1 occurs a few times in collection (will return exception)
var singleElementOne = numbers.Single(x => x == 1);

Console.WriteLine("Single element one:");
Console.WriteLine(singleElementOne);

Console.WriteLine();

// Get single element - number 5 occurs a few times in collection (use SingleOrDefault will return exception)
var singleElementFive = numbers.SingleOrDefault(x => x == 5);

Console.WriteLine("Single element five:");
Console.WriteLine(singleElementFive);

Console.WriteLine();

// Get single element - number 11 is not in collection (will return exception)
var singleElementEleven = numbers.Single(x => x == 11);

Console.WriteLine("Single element eleven:");
Console.WriteLine(singleElementEleven);

Console.WriteLine();

// Get single element - number 12 is not in collection (use SingleOrDefault will return default type)
var singleElementTwelve = numbers.SingleOrDefault(x => x == 12);

Console.WriteLine("Single element twelve:");
Console.WriteLine(singleElementTwelve);

Console.WriteLine();