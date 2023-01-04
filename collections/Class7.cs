/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.collections
{
    // SETS
    class Class7
    {
        static void Main(string[] args)
        {
            HashSet<string> companyTeams = new()
            {
                "Ferrari",
                "Mclaren",
                "Mercedes"
            };
            HashSet<string> traditionalTeams = new()
            {
                "Ferrari",
                "Mclaren"
            };
            HashSet<string> privateTeams = new()
            {
                "Red Bull",
                "Toro Rosso",
                "Force India",
                "Sauber"
            };
            if (privateTeams.Add("Williams"))
            {
                Console.WriteLine("Williams added");
            }
            if (!companyTeams.Add("Mclaren"))
            {
                Console.WriteLine("Mclaren was already in this set");
            }
            if (traditionalTeams.IsSubsetOf(companyTeams))
            {
                Console.WriteLine("traditionalTeams is subset of companyTeams");
            }
            if (companyTeams.IsSupersetOf(traditionalTeams))
            {
                Console.WriteLine("companyTeams is a superset of traditionalTeams");
            }

            traditionalTeams.Add("Williams");
            if (privateTeams.Overlaps(traditionalTeams))
            {
                Console.WriteLine("At least one tema is the same with" +
                    "traditional and private teams");
            }

            SortedSet<string> allTeams = new(companyTeams);
            allTeams.UnionWith(privateTeams);
            allTeams.UnionWith(traditionalTeams);
            Console.WriteLine();
            Console.WriteLine("all teams");
            foreach(var team in allTeams)
            {
                Console.WriteLine(team);
            }
        }
    }
}
*/