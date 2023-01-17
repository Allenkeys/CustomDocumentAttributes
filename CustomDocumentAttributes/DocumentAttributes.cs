using System;

namespace CustomDocumentAttributes
{
    [AttributeUsage(AttributeTargets.All)]
    public class DocumentAttributes : Attribute
    {
        public string Description { get; set; }
        public string Input { get; set; }
        public string Output { get; set; }
        public DocumentAttributes(string description, string input = null, string output = null)
        {
            Description = description;
            Input = input;
            Output = output;
        }
    }
}
