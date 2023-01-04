/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class14
    {
        public static void Main(string[] Args)
        {
            // pass int by reference
            int a = 1;
            ChangeAValueType(ref a);
            Console.WriteLine($"The value of a changed to {a}");

            // The REF parameter
            // pass a reference by reference
            SomeData data1 = new() { Value = 1 };
            ChangingAReferenceByRef(ref data1);
            Console.WriteLine($"The new value of data1.Value is: {data1.Value}");

            SomeValue one = new SomeValue(1, 2, 3, 4);
            SomeValue two = new SomeValue(5, 6, 7, 8);

            SomeValue bigger1 = Max(ref one, ref two);
            

            void ChangeAValueType(ref int x)
            {
                x = 2;
            }

            void ChangingAReferenceByRef(ref SomeData data)
            {
                data.Value = 2;
                data = new SomeData { Value = 3 };
            }

            // The IN parameter
            void PassValueByReferenceReadonly(in SomeValue data)
            {
              // data.Value1 = 4; - you cannot change a value, it's a read-only variable!
            }

            // REF return
            ref SomeValue Max(ref SomeValue x, ref SomeValue y)
            {
                int sumx = x.Value1 + x.Value2 + x.Value3 + x.Value4;
                int sumy = y.Value1 + y.Value2 + y.Value3 + y.Value4;

                ref SomeValue result = ref (sumx > sumy) ? ref x : ref y;
                return ref result;
                Console.WriteLine(result);
            }

           
            Console.Write("Please enter a number: ");
            string? input = Console.ReadLine();
            if(int.TryParse(input, out int x))
            {
                Console.WriteLine();
                Console.WriteLine($"read an int: {x}");
            }
        }
    }

    // The REF parameter
    class SomeData
    {
        public int Value { get; set; }
    }

    // The IN parameter
    struct SomeValue
    {
        public SomeValue(int value1, int value2, int value3, int value4)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
            Value4 = value4;
        }
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public int Value3 { get; set; }
        public int Value4 { get; set; }
        
    }
}
*/