namespace LinqSelectMany;

internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> City { get; set; } = new List<string>();
}

