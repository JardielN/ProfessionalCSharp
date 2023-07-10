// STRUCTS

public readonly struct Dimensions
{
    public Dimensions(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // With C# 10 you can create a custom parameterless
    public Dimensions()
    {
        Length = 0;
        Width = 0;
    }

    public double Diagonal => Math.Sqrt(Length * Length + Width * Width);

    public double Length { get; }
    public double Width { get; }
}