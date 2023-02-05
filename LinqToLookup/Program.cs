// ToLookup is similar to GroupBy, but the ToLookup performs immediate execution and one key can have list of values

using LinqToLookup;

var products = new[]
{
    new Product("Smartphone", "Electronic"),
    new Product("Computer", "Electronic"),
    new Product("Apple", "Fruit"),
    new Product("Volvo", "Car"),
};

var lookup = products.ToLookup(c => c.Category, item => item);

foreach (var item in lookup)
{
    Console.WriteLine($"Category = {item.Key}");

    foreach (var product in item)
    {
        Console.WriteLine($"Name = {product.Name}");
    }
}

