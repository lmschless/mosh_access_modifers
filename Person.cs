using System;

namespace AccessModifiers
{
    public class Person
    {
        // create a constructor that sets the birthdate once and it cannot be changed.
        public string Name { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        // complier automatically creates a private field when it sees get; set;
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

    }
}
