/*
void ColorSamples()
{
    Color c1 = Color.Red;
    Console.WriteLine(c1);

    Color c2 = (Color)2;
    Console.WriteLine(c2);
    Console.WriteLine((short)c2);
}

ColorSamples();

DaysOfWeek mondayAndWednesday = DaysOfWeek.Monday | DaysOfWeek.Wednesday;
Console.WriteLine(mondayAndWednesday);

DaysOfWeek weekend = DaysOfWeek.Saturday | DaysOfWeek.Sunday;
Console.WriteLine(weekend);

if(Enum.TryParse<Color>("Red", out Color red))
{
    Console.WriteLine($"Successfully parsed {red}");
}

foreach(var color in Enum.GetNames(typeof(Color)))
{
    Console.WriteLine(color);
}

public enum Color : short
{
    Red = 1,
    Green = 2,
    Blue = 3
}

[Flags]
public enum DaysOfWeek
{
    Monday = 0x1,
    Tuesday = 0x2,
    Wednesday = 0x4,
    Thursday = 0x8,
    Friday = 0x10,
    Saturday = 0x20,
    Sunday = 0x40,
    Weekend = Saturday | Sunday,
    Workday = 0x1f,
    AllWeek = Workday | Weekend
}

*/