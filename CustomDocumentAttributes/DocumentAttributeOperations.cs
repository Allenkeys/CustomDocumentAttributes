using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomDocumentAttributes
{
    public class DocumentAttributeOperations
    {
        public static void GetDocs()
        {

            var assemblies = AppDomain.CurrentDomain.GetAssemblies();
            var members = from assembly in assemblies
                          from type in assembly.GetTypes()
                          select type.GetMembers();

            foreach (var memberArr in members)
            {
                foreach (var member in memberArr)
                {
                    var attributes = member.GetCustomAttributes(typeof(DocumentAttribute), true);

                    if (attributes.Length > 0)
                    {
                        var doc = (DocumentAttribute)attributes[0];
                        Console.WriteLine($"Member Type: {member.MemberType}");
                        Console.WriteLine($"Name: {member.Name}");
                        Console.WriteLine($"\nDescription: {doc.Description}\nInput: {doc.Input}\n Output: {doc.Output}");

                    }
                }
            }
        }
    }
}
