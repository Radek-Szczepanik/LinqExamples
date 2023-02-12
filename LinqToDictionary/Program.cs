// ToDictionary - similar to ToLookup but one key must have only one value

using LinqToDictionary;

var products = new[]
{
    new Product(1, "Smartphone"),
    new Product(2, "Computer"),
    new Product(3, "Fruit"),
    new Product(4, "Car"),
};

var idToProductMapping = products.ToDictionary(i => i.Id, item => item);

foreach (var item in idToProductMapping)
{
    Console.WriteLine($"Category = {item.Key}, Name = {item.Value.Name}");
}
