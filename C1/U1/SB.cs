/*
// StringBuilder
using System;
using System.Text;

void UsingStringBuilder()
{
    StringBuilder sb = new("the quick");
    sb.Append(' ');
    sb.Append("brown fox jumped over ");
    sb.Append("the lazy dogs 1234567890 times");
    string s = sb.ToString();
    Console.WriteLine(s);
}

UsingStringBuilder();

// String interpolation
int x = 3, y = 4;
string s3 = $"The result of {x} and {y} is {x + y}";
Console.WriteLine(s3);

// FormattableString
void UsingFormattableString()
{
    int x = 3, y = 4;
    FormattableString s = $"The result of {x} + {y} is {x + y}";
    Console.WriteLine($"format: {s.Format}");
    for(int i = 0; i < s.ArgumentCount; i++)
    {
        Console.WriteLine($"argument: {i}: {s.GetArgument(i)}");
    }
    Console.WriteLine();
}
UsingFormattableString();
*/