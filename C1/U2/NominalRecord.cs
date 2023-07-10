/*
// EQUALITY COMPARISON WITH RECORDS

Book1 book1a = new() { Title = "Professional C#", Publisher = "Wrox Press" };
Book1 book1b = new() { Title = "Professional C#", Publisher = "Wrox Press" };

if (!object.ReferenceEquals(book1a, book1b))
    Console.WriteLine("Two different references for equal records");

if (book1a == book1b)
    Console.WriteLine("Both records have the same value");

public record Book1
{
    public string Title { get; init; } = string.Empty;
    public string Publisher { get; init; } = string.Empty;
}
*/