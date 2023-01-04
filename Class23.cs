/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// GENERICS
namespace CURSOIII
{
    class Class23
    {
        public static void Main(String[] Args)
        {
            /*
            LinkedList<int> list1 = new();
            list1.AddLast(1);
            list1.AddLast(3);
            list1.AddLast(2);
            foreach(var item in list1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            LinkedList<string> list2 = new();
            list2.AddLast("two");
            list2.AddLast("four");
            list2.AddLast("six");
            Console.WriteLine(list2.Last);

            LinkedList<(int, int)> list3 = new();
            list3.AddLast((1, 2));
            list3.AddLast((3, 4));
            foreach(var item in list3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            LinkedList<Person> list4 = new();
            list4.AddLast(new Person("Stephanie", "Nagel", "Mrs"));
            list4.AddLast(new Person("Matthias", "Nagel", "Mr"));
            list4.AddLast(new Person("Katharina", "Nagel", "Mrs"));
            // show the first
            Console.WriteLine(list4.First);
        }
    }

    // Lista enlazada
    public record LinkedListNode<T>(T Value)
    {
        public LinkedListNode<T>? Next { get; internal set; }
        public LinkedListNode<T>? Prev { get; internal set; }
        public override string? ToString() => Value?.ToString();
    }
    public interface ITitle
    {
        string Title { get; }
    }

    public class LinkedList<T> : IEnumerable<T> where T: ITitle
    {
        public LinkedListNode<T>? First { get; private set; }
        public LinkedListNode<T>? Last { get; private set; }
        public LinkedListNode<T> AddLast(T node)
        {
            LinkedListNode<T> newNode = new(node);
            if (First is null || Last is null)
            {
                First = newNode;
                Last = First;
            }
            else
            {
                newNode.Prev = Last;
                LinkedListNode<T> previous = Last;
                Last.Next = newNode;
                Last = newNode;
            }
            return newNode;
        }

        public void DisplayAllTitles()
        {
            foreach(T item in this)
            {
                Console.WriteLine(item.Title);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LinkedListNode<T>? current = First;
            while(current is not null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public record Person(string FirstName, string LastName, string Title) : ITitle { }
}
*/