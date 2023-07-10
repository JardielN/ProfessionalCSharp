int a = 1;
ChangeAValueType(ref a);
Console.WriteLine($"The value of a changed to {a}");


void ChangeAValueType(ref int x)
{
    x = 2;
}

void ChangingAReferenceByRef(ref SomeData data)
{
    data.Value = 2;
    data = new SomeData { Value = 3 };
}



class SomeData
{
    public int Value { get; set; }
}

