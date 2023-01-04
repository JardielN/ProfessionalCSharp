/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Immutable;

namespace CURSOIII.collections
{
    // IMMUTABLE COLLECTIONS
    class Class8
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new()
            {
                new("Scrooge McDuck", 667377678765m),
                new("Donald Duck", -200m),
                new("Ludwig von Drake", 20000m)
            };
            ImmutableList<Account> immutableAccounts = accounts.ToImmutableList();
            Console.WriteLine("Using foreach classic loop: ");
            foreach (var account in immutableAccounts)
            {
                Console.WriteLine($"{account.Name}: {account.Amount}");
            }
            Console.WriteLine();

            Console.WriteLine("Using ForEach of ImmutableList<T>: ");
            immutableAccounts.ForEach(a => Console.WriteLine($"{a.Name}: {a.Amount}"));
        }
    }

    public record Account(string Name, decimal Amount);
}
*/