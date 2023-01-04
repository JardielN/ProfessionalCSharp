/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.collections
{
    // LISTS
    class Class1
    {
        public static void Main(String[] Args)
        {
            // Agregando corredores por medio del
            // inicializador de collection.
            Racer graham = new(7, "Graham", "Hill", "UK", 14);
            Racer emerson = new(13, "Emerson", "Fittipaldi", "Brazil", 14);
            Racer mario = new(16, "Mario", "Andretti", "USA", 12);
            // Puede agregar corredores al instanciar la lista
            // ya que se le puede pasar cualquier objeto que
            // implemente IEnumerable<T> al constructor de la clase
            // similar al metodo AddRange()
            List<Racer> racers = new(20) { graham, emerson, mario };
            // Agregando corredores usando 
            // explicitamente el metodo Add()
            racers.Add(new Racer(24, "Michael", "Schumacher", "Germany", 91));
            racers.Add(new Racer(27, "Mika", "Hakkinen", "Finland", 20));
            // Agregando corredores usando el metodo AddRange() de la 
            // clase List<T>.
            // Se pueden agregar multiples elementos a la coleccion de una.
            // AddRange() acepta un objecto de tipo IEnumerable<T>.
            // por lo que tambien se le puede pasar un array para agregar.
            racers.AddRange(new Racer[] {
                new(14, "Niki", "Lauda", "Austria", 25),
                new(21, "Alain", "Prost", "France", 51)
            });
            // Puede insertar elementos en una posicion
            // especifica usando Insert()
            racers.Insert(3, new Racer(6, "Phil", "Hill", "USA", 3));

            // Debido a que List<T> implementa la interfaz
            // IEnumerable, puedes iterar sobre la coleccion con foreach
            /*
            foreach(var r in racers)
            {
                Console.WriteLine(r);
            }
            

            int index1 = racers.IndexOf(mario);
            int index2 = racers.FindIndex(r => r.Country == "Finland");
            Racer racer = racers.Find(r => r.FirstName == "Niki");
            List<Racer> bigWinners = racers.FindAll(r => r.Wins > 20);
            bigWinners.Sort(new RacerComparer(RacerComparer.CompareType.Country));
            /*
            foreach (Racer r in bigWinners)
            {
                Console.WriteLine($"{r:A}");
            }
            
            racers.Sort(new RacerComparer(RacerComparer.CompareType.Wins));
            foreach(Racer r in racers)
            {
                Console.WriteLine(r);
            }
            

        }
    }

    public record Racer(int ID, string FirstName, string LastName,
        string Country, int Wins) : IComparable<Racer>,
        IFormattable
    {
        // constructor.
        public Racer(int id, string firstName, string lastName,
            string country) : this(id, firstName, lastName,
                country, Wins: 0)
        { }

        // devuelve el nombre del piloto
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }

        // Metodo de interfaz IFormattable
        // permite el paso de strings de formato personalizada
        public string ToString(string? format, 
            IFormatProvider? formatProvider)
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
                _=> throw new FormatException(
                    string.Format(formatProvider,
                    "Format {0} is not supported", format))
            };
        }

        public string? ToString(string format) =>
            ToString(format, null);

        // Metodo de interfaz IComparable
        // clasifica los elementos del corredor
        public int CompareTo(Racer? other)
        {
            int compare = LastName?.CompareTo(other.LastName) ?? -1;
            if (compare == 0)
            {
                return FirstName?.CompareTo(other?.FirstName) ?? -1;
            }
            return compare;
        }

    }

    /*
     * La clase RaceComparer implementa la interfaz IComparer<T>
     * para tipos Racer. Esta clase permite ordenar por cualquier
     * tipo de propiedad. El tipo de ordenamiento se define por
     * las constantes en el enum CompareType. CompareType se
     * establece en el constructor de la clase Racer. La interfaz 
     * define el metodo Compare(), que se requiere para ordenar algo.
     * En la implementacion, los metodos Compare() y CompareTo()
     * se usan tipos string e int.
     
    public class RacerComparer : IComparer<Racer>
    {
        public enum CompareType
        {
            FirstName,
            LastName,
            Country,
            Wins
        }
        private CompareType _compareType;
        public RacerComparer(CompareType compareType)
            => _compareType = compareType;
        public int Compare(Racer? x, Racer? y)
        {
            if (x is null && y is null) return 0;
            if (x is null) return -1;
            if (y is null) return 1;
            
            int CompareCountry(Racer x, Racer y)
            {
                int result = string.Compare(x.Country, y.Country);
                if(result == 0)
                {
                    result = string.Compare(x.LastName, y.LastName);
                }
                return result;
            }

            return _compareType switch
            {
                CompareType.FirstName =>
                string.Compare(x.FirstName, y.FirstName),
                CompareType.LastName =>
                string.Compare(x.LastName, y.LastName),
                CompareType.Country => CompareCountry(x, y),
                CompareType.Wins =>
                x.Wins.CompareTo(y.Wins),
                _ => throw new ArgumentException("Invalid Compare Type")
            };
        }
    }
}
*/