using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOfYourAffection_2
{
    using System;

    public class Profile
    {
        // Private fields
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        // Constructor that initializes the fields
        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[] { };
        }

        // Method to view the profile
        public string ViewProfile()
        {
            string hobbiesText = hobbies.Length > 0 ? string.Join(", ", hobbies) : "No hobbies set.";
            return $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}\nHobbies: {hobbiesText}";
        }

        // Method to set the hobbies
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
    }
}