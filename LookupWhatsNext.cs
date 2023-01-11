
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WhatsNewAttributes;
using VectorClass;

[assembly: SupportsWhatsNew]
namespace CURSOIII
{
    public class LookupWhatsNext
    {
        public static void Main(string[] args)
        {
            
            StringBuilder outputText = new(1000);
            DateTime backDateTo = new(2023, 1, 11);

            Assembly theAssembly = Assembly.Load(new AssemblyName("VectorClass"));
            Attribute? supportsAttribute = theAssembly.GetCustomAttribute(
                typeof(SupportsWhatsNewAttribute) );

            void AddToOutput(string Text)
                => outputText.AppendLine($"{Text}{Environment.NewLine}");

            AddToOutput($"Assembly: {theAssembly.FullName}");

            if(supportsAttribute is null)
            {
                Console.WriteLine("This Assembly does not support WhatsNew attributes");
                return;
            }
            else
            {
                AddToOutput("Defined Types");
            }

            IEnumerable<Type> types = theAssembly.ExportedTypes;
            foreach (Type definedType in types)
            {
                DisplayTypeInfo(definedType);
            }

            Console.WriteLine($"What's New since {backDateTo}");
            Console.WriteLine(outputText.ToString());
            Console.ReadLine();

            void DisplayTypeInfo(Type type)
            {
                // Make sure we only pick out classes
                // Lo primero es confirmar que la referencia type realmente
                // representa una clase. Debido a que el atributo LastModified 
                // solo se puede aplicar a clases o a metodos de miembros, 
                // estarias perdiendo el tiempo al realizar cualquier procesamiento
                // si el elemento no es una clase (como un delegate o un enum).
                if(!type.GetTypeInfo().IsClass)
                {
                    return;
                }

                AddToOutput($"{Environment.NewLine}class {type.Name}");
                
                IEnumerable<LastModifiedAttribute> lastModifiedAttributes =
                    type.GetTypeInfo().GetCustomAttributes()
                    .OfType<LastModifiedAttribute>()
                    .Where(a => a.DateModified >= backDateTo).ToArray();

                if(lastModifiedAttributes.Count() == 0)
                {
                    AddToOutput($"\tNo changes to the class {type.Name}" +
                        $"{Environment.NewLine}");
                }
                else
                {
                    foreach(LastModifiedAttribute attribute in lastModifiedAttributes)
                    {
                        WriteAttributeInfo(attribute);
                    }
                }
                AddToOutput("Changes to methods of this class:");

                foreach(MethodInfo method in 
                    type.GetTypeInfo().DeclaredMembers.OfType<MethodInfo>())
                {
                    // utilizar el metodo type.GetTypeInfo().GetCustomAttributes()
                    // para determinar si esta clase tiene instancias de LastModifiedAttribute.
                    // Si es asi, utiliza WriteAttributeInfo() para agregar sus detalles al
                    // texto de salida.
                    IEnumerable<LastModifiedAttribute> attributesToMethods =
                        method.GetCustomAttributes().OfType<LastModifiedAttribute>()
                        .Where(a => a.DateModified >= backDateTo).ToArray();

                    if(attributesToMethods.Count() > 0)
                    {
                        AddToOutput($"{method.ReturnType} {method.Name}()");
                        foreach(Attribute attribute in attributesToMethods)
                        {
                            WriteAttributeInfo(attribute);
                        }
                    }
                }
            }

            void WriteAttributeInfo(Attribute attribute)
            {
                if(attribute is LastModifiedAttribute lastModifiedAttribute)
                {
                    AddToOutput($"\tmodified: {lastModifiedAttribute.DateModified:D}" +
                        $"{lastModifiedAttribute.Changes}");
                    if (lastModifiedAttribute.Issues != null)
                    {
                        AddToOutput($"\tOutstanding Issues: {lastModifiedAttribute.Issues}");
                    }
                }
            }
        }
    }
}
