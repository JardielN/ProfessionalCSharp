/*
// Passing by Value with Structs.
AStruct x1 = new() { A = 1 };
AStruct x2 = x1;
x2.A = 2;
Console.WriteLine($"Original didn't change with a " +
    $"struct: {x1.A}");

// Passing by Refence is used with classes
// The value is changed because after assignment 
// They reference the same object
AClass y1 = new() { A = 1 };
AClass y2 = y1;
y2.A = 2;
Console.WriteLine($"Original changed with class: {y1.A}");

// A record is a a class behind scenes. It passes
// by reference
ARecord z1 = new() { A = 1 };
ARecord z2 = z1;
z2.A = 2;
Console.WriteLine($"Original changed with a record: {z1.A}");

// Tuples
var t1 = (Number: 1, String: "a");
var t2 = t1;
t2.Number = 2;
t2.String = "b";
Console.WriteLine($"Original didn't change with a tuple: {t1.Number}{t1.String}");

public struct AStruct
{
    public int A;
}

public class AClass
{
    public int A;
}

public record ARecord
{
    public int A;
}
*/