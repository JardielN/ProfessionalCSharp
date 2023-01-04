/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.collections
{
    // BUSQUEDAS
    class Class6
    {
        static void Main(string[] args)
        {
            List<Racer> racers = new();
            racers.Add(new Racer(26, "Jacques", "Villeneuve", "Canada", 11));
            racers.Add(new Racer(18, "Alan", "Jons", "Australia", 12));
            racers.Add(new Racer(11, "Jackie", "Stewart", "United Kingdom", 27));
            racers.Add(new Racer(15, "James", "Hunt", "United Kingdom", 10));
            racers.Add(new Racer(5, "Jack", "Brabham", "Australia", 14));

            var lookupRacers = racers.ToLookup(r => r.Country);

            foreach(Racer r in lookupRacers["Australia"])
            {
                Console.WriteLine(r);
            }
        }
    }

    public record Racer(int id, string FirstName, string LastName,
        string Country, int Wins) : IComparable<Racer>, IFormattable
    {
        public Racer(int id, string firstName, string lastName, 
            string country) : this(id, firstName, lastName, country,
                Wins: 0)
        { }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            return format?.ToUpper() switch
            {
                null => ToString(),
                "N" => ToString(),
                "F" => FirstName,
                "L" => LastName,
                "W" => $"{ToString()}, Wins: {Wins}",
                "C" => Country,
                "A" => $"{ToString()}, Country: {Country}, Wins: {Wins}",
                _=> throw new FormatException(string.Format(formatProvider,
                "Format{0} is not supported", format))
            };
        }

        public string? ToString(string format)
        {
            return ToString(format, null);
        }

        public int CompareTo(Racer? other)
        {
            int compare = LastName?.CompareTo(other?.LastName) ?? -1;
            if(compare == 0)
            {
                return FirstName?.CompareTo(other?.FirstName) ?? -1;
            }
            return compare;
        }
    }
}
*/