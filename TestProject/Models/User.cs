using System.ComponentModel.DataAnnotations;
using CustomDocumentAttributes;

namespace TestProject.Models
{
    [Document(description: "This class generate a user model")]
    internal class User
    {
        [Document(description: "The name of the user")]
        public string Name { get; set; }

        [Document(description: "This property stores the age of the user")]
        public int Age { get; set; }

        [Document(description: "This property stores the user's phone number")]
        [Phone]

        public long Phone { get; set; }

        [Document(description: "This method returns user's age")]
        public int GetAge()
        {
            return Age;
        }
    }
}
