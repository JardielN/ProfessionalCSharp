/*
using System;

// PATTERN MATCHING
Book b = new("Professional C#");
PatternMatching(b);

void PatternMatching(object o)
{
    if (o is null) throw new ArgumentNullException(nameof(o));
    else if(o is Book b)
    {
        Console.WriteLine($"received a book: {b.Title}");
    }
}
class Book
{
    public Book(string title) => Title = title;
    public string Title { get; set; }
    public string? Publisher { get; set; }
}
*/