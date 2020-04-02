using System;

namespace AccessModifiers
{
    public class Person
    {
        // when variable(field) is private, use an UNDERSCORE and CAMELCASE.
        private DateTime _birthdate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthdate = birthdate;
        }

        // Use type DateTime because you are passing data.
        public DateTime GetBirthDate()
        {
            return _birthdate;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.SetBirthDate(new DateTime(1989, 4, 11));
            Console.WriteLine(person.GetBirthDate());
        }
    }
}
