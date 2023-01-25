using System;

namespace DatingProfile
{
    class Profile
    {
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;
        private string hobbiesString;

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
        }

        public string ViewProfile()
        {
            int counter = hobbies.Length;
            foreach (string hobby in this.hobbies)
            {
                this.hobbiesString += (hobby);
                if (counter >= 3)
                {
                    this.hobbiesString += ", ";
                }
                if (counter == 2)
                {
                    this.hobbiesString += ", and ";
                }
                if (counter == 1)
                {
                    this.hobbiesString += ".";
                }
                counter--;
            }

            string profileInfo = $"PROFILE INFO:\nName: {name}\nAge: {age}\nLocation: {city}, {country}\nProunouns: {pronouns}\nHobbies: {hobbiesString}";
            return profileInfo;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }

    }
}
