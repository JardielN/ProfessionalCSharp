/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // OPERACIONES CON BINARIOS
    class Class25
    {
        public static void Main(String[] Args)
        {
            void DisplayBits(string title, uint result, uint left, uint? right = null)
            {
                Console.WriteLine(title);
                Console.WriteLine(left.ToBinaryString().AddSeparators());
                if (right.HasValue)
                {
                    Console.WriteLine(right.Value.ToBinaryString().AddSeparators());
                }
                Console.WriteLine(result.ToBinaryString().AddSeparators());
                Console.WriteLine();
            }
            void SimpleCalculations()
            {
                Console.WriteLine(nameof(SimpleCalculations));
                uint binary1 = 0b1111_0000_1100_0011_1110_0001_0001_1000;
                uint binary2 = 0b0000_1111_1100_0011_0101_1010_1110_0111;
                uint binaryAnd = binary1 & binary2;
                DisplayBits("AND", binaryAnd, binary1, binary2);
                uint binaryOR = binary1 | binary2;
                DisplayBits("OR", binaryOR, binary1, binary2);
                uint binaryXOR = binary1 ^ binary2;
                DisplayBits("XOR", binaryXOR, binary1, binary2);
                uint reverse1 = ~binary1;
                DisplayBits("NOT", reverse1, binary1);
                Console.WriteLine();
            }
            SimpleCalculations();

            // Mostrando el desplazamiento de bits. Tema - Shifting bits.
            void ShiftingBits()
            {
                Console.WriteLine(nameof(ShiftingBits));
                ushort s1 = 0b01;
                Console.WriteLine($"{"Binary",16} {"Decimal",8} {"Hex",6} ");
                for(int i = 0; i<16; i++)
                {
                    Console.WriteLine($"{s1.ToBinaryString(),16} {s1,8} hex: {s1,6:X}");
                    s1 = (ushort)(s1 << 1);
                }
                Console.WriteLine();
            }
            ShiftingBits();

            ushort c = 43;
            char symbol = (char)c;
            Console.WriteLine(symbol);
        }
    }

    public static class BinaryExtentions
    {
        public static string ToBinaryString(this uint number) => Convert.ToString(number, toBase: 2).PadLeft(sizeof(uint) << 3, '0');
        public static string ToBinaryString(this int number) => Convert.ToString(number, toBase: 2).PadLeft(sizeof(int) << 3, '0');
        public static string ToBinaryString(this ushort number) => Convert.ToString(number, toBase: 2).PadLeft(sizeof(ushort) << 3, '0');
        public static string ToBinaryString (this short number) => Convert.ToString(number, toBase: 2).PadLeft(sizeof(short) << 3, '0');

        public static string AddSeparators(this string number) =>
       string.Join("_",
           Enumerable.Range(0, number.Length / 4)
               .Select(i => number.Substring(i * 4, 4)).ToArray());
    }
}
*/