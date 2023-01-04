/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII
{
    // YIELD STATEMENT
    class Class32
    {
        public static void Main(String[] Args)
        {
            MusicTitles titles = new();
            foreach(var title in titles)
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();

            Console.WriteLine("reverse");
            foreach(var title in titles.Reverse())
            {
                Console.WriteLine(title);
            }
            Console.WriteLine();

            Console.WriteLine("subset");
            foreach(var title in titles.Subset(2, 2))
            {
                Console.WriteLine(title);
            }

            // SPAN WITH ARRAYS
            Span<int> IntroSpans()
            {
                int[] arr1 = { 1, 4, 5, 11, 13, 18 };
                Span<int> span1 = new(arr1);
                span1[1] = 11;
                Console.WriteLine($"arr1[1] is changed via span1[1]: {arr1[1]}");
                return span1;
            }
            IntroSpans();
            Console.WriteLine();

            // Creating slices
            static Span<int> CreateSlices(Span<int> span1)
            {
                Console.WriteLine(nameof(CreateSlices));
                int[] arr2 = { 3, 5, 7, 9, 11, 13, 15 };
                Span<int> span2 = new(arr2);
                Span<int> span3 = new(arr2, start: 3, length: 3);
                Span<int> span4 = span1.Slice(start: 2, length: 4);

                DisplaySpan("Content of span3", span3);
                DisplaySpan("Content of span4", span4);
                Console.WriteLine();
                return span2;
            }
            int[] arr2 = { 3, 5, 7, 9, 11, 13, 15 };
            int[] arr1 = { 2, 4, 6, 8, 10, 12 };
            Span<int> span1 = new(arr1);
            Span<int> span2 = CreateSlices(arr1);

            static void DisplaySpan(string title, ReadOnlySpan<int> span)
            {
                Console.WriteLine(title);
                for(int i=0; i < span.Length; i++)
                {
                    Console.WriteLine($"{span[i]}");
                }
                Console.WriteLine();
            }

            static void ChangeValues(Span<int> span1, Span<int> span2)
            {
                Console.WriteLine(nameof(ChangeValues));
                Span<int> span4 = span1.Slice(start: 4);
                span4.Clear();
                DisplaySpan("content of span1", span1);
                Span<int> span5 = span2.Slice(start: 3, length: 3);
                span5.Fill(42);
                DisplaySpan("content of span2", span2);
                span5.CopyTo(span1);
                DisplaySpan("content of span1", span1);
                if (!span1.TryCopyTo(span4))
                {
                    Console.WriteLine("Couldn't copy span1 to span4 because span4 is " +
                    "too small");
                    Console.WriteLine($"length of span4: {span4.Length}, length of " +
                    $"span1: {span1.Length}");
                }
                Console.WriteLine();
            }
            ChangeValues(span1, span2);
        }
    }

    class HelloCollection
    {
        public IEnumerator<string> GetEnumerator()
        {
            yield return "Hello";
            yield return "World";
        }
    }

    public class MusicTitles
    {
        string[] names = { "Tubular Bells", "Hergest Ridge", "Ommadawn", "Platinum" };

        public IEnumerator<string> GetEnumerator()
        {
            for(int i = 0; i < 4; i++)
            {
                yield return names[i];
            }
        }

        public IEnumerable<string> Reverse()
        {
            for(int i = 3; i >= 0; i--)
            {
                yield return names[i];
            }
        }

        public IEnumerable<string> Subset(int index, int length)
        {
            for(int i = index; i < index + length; i++)
            {
                yield return names[i];
            }
        }
    }
}
*/