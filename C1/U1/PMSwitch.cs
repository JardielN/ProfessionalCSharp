/*
using System;

// PATTERN MATCHING USING SWITCH

SwitchWithPatternMatching(null);


void SwitchWithPatternMatching(object o)
{
    switch (o)
    {
        case null:
            Console.WriteLine("const pattern with null");
            break;
        case int i when i > 42:
            Console.WriteLine("Type pattern with when and a relational pattern.");
            break;
        case int:
            Console.WriteLine("Type pattern with an int");
            break;
        case Book b:
            Console.WriteLine($"Type pattern with a Book {b.Title}");
            break;
        default:
            break;
    }
}

class Book
{
    public Book(string title) => Title = title;
    public string Title { get; set; }
    public string? Publisher { get; set; }
}
*/