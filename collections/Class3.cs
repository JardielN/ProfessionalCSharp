/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.collections
{
    // LISTA ENLAZADA
    class Class3
    {
        static void Main(string[] args)
        {

            LinkedList<Document> list = new();
            LinkedListNode<Document> first = list.AddFirst(new Document(1, "first"));
            list.AddAfter(first, new Document(2, "after first"));
            LinkedListNode<Document> last = list.AddLast(new Document(3, "last"));
            Document doc4 = new(4, "before last");
            list.AddBefore(last, doc4);

            list.Remove(doc4);
            Console.WriteLine("after removal");

            foreach(var item in list)
           {
                Console.WriteLine(item);
           }

            void IterateUsingNext(LinkedListNode<Document> start)
            {
                if (start.Value is null) return;
                LinkedListNode<Document>? current = start;
                do
                {
                    Console.WriteLine(current.Value);
                    current = current.Next;
                } while (current is not null);
            }

            if(list.First is not null)
            {
                IterateUsingNext(list.First);
            }
        }
    }

    record Document(int Id, string Text);




}
*/