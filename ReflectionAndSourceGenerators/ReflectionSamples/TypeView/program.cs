/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CURSOIII.ReflectionAndSourceGenerators.ReflectionSamples.TypeView
{
    internal class program
    {
        public static void Main(string[] args)
        {
            StringBuilder OutputText = new();

            Type t = typeof(double);
            Console.WriteLine();
            AnalyzeType(t);
            Console.WriteLine($"Analysis of type {t.Name}");
            Console.WriteLine(OutputText.ToString());
            Console.ReadLine();

            // El metodo AnalyzeType se implementa llamando
            // a varias propiedades de Type para obtener
            // informacion que necesita sobre los nombres 
            // de los tipos. 
            void AnalyzeType(Type t)
            {
                TypeInfo typeInfo = t.GetTypeInfo();
                AddToOutput($"Type Name: {t.Name}");
                AddToOutput($"Full Name: {t.FullName}");
                AddToOutput($"Namespace: {t.Namespace}");
                Type? tBase = typeInfo.BaseType;

                if (tBase != null)
                {
                    AddToOutput($"Base Type: {tBase.Name}");
                }

                ShowMembers("constructors", t.GetConstructors());
                ShowMembers("methods", t.GetMethods());
                ShowMembers("properties", t.GetProperties());
                ShowMembers("fields", t.GetFields());
                ShowMembers("events", t.GetEvents());
            }

            void ShowMembers(string title, IList<MemberInfo> members)
            {
                if (members.Count == 0) return;
                AddToOutput($"\npublic {title}");
                // elimina miembros sobrecargados mediante 
                // el metodo Distinct. 
                var names = members.Select(m => m.Name).Distinct();
                AddToOutput(string.Join(" ", names));
            }

            void AddToOutput(string Text)
                => OutputText.AppendLine($"{Text}{Environment.NewLine}");
        }
    }
}
*/