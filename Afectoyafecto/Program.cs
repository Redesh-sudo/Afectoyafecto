namespace ObjectOfYourAffection_2
{
    using System;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new profile
            Profile alex = new Profile("Alex Johnson", 35, "San Francisco", "USA", "they/them");

            // Add hobbies
            alex.SetHobbies(new string[] {
            "listening to music and audiobooks",
            "playing recreational sports like bowling and kickball",
            "writing a speculative fiction novel",
            "reading advice columns"
        });

            // View the profile and display it in console
            Console.WriteLine(alex.ViewProfile());
        }
    }
}
