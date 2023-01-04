/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    class Class29
    {
        public static void Main(String[] Args)
        {
            try
            {
                Currency balance = new(50, 35);
                Console.WriteLine(balance);
                Console.WriteLine($"Balance is {balance}"); // implicit invoke ToString()
                float balance2 = balance;
                Console.WriteLine($"After converting to float, = {balance2}");
                balance = (Currency)balance2;
                Console.WriteLine($"After converting back to Currency, = {balance}");
                Console.WriteLine("Now attempt to convert out of range value of " +
                        "-$50.50 to a Currency:");
                checked
                {
                    balance = (Currency)(-50.50);
                    Console.WriteLine($"Result is {balance}");
                }
            }
            catch(Exception e){
                Console.WriteLine($"Exception occurred: {e.Message}");
            }
        }
    }

    public readonly struct Currency
    {
        public readonly uint Dollars;
        public readonly ushort Cents;
        public override string ToString()
        {
            return $"${Dollars}.{Cents, -2:00}";
        }

        public Currency(uint dollars, ushort cents)
            => (Dollars, Cents) = (dollars, cents);

        public static implicit operator float(Currency value)
            => value.Dollars + (value.Cents/100.0f);

        public static explicit operator Currency(float value)
        {
            checked
            {
                uint dollars = (uint)value;
                ushort cents = Convert.ToUInt16((value - dollars) * 100);
                return new Currency(dollars, cents);
            }
        }
    }
}
*/