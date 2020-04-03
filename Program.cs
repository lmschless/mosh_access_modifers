using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace AccessModifiers
{


    // old way of using private field, getter, and setter.
    //public class Person
    //{
    //    // when variable(field) is private, use an UNDERSCORE and CAMELCASE.
    //    private DateTime _birthdate;

    // using explicit properties to get and set a private field
    //    public DateTime Birthdate
    //    {
    //        get { return _birthdate; }
    //        set { _birthdate = value; }
    //    }

    //    // using the manual way to get and set a private field
    //    public void SetBirthDate(DateTime birthdate)
    //    {
    //        _birthdate = birthdate;
    //    }



    //    // Use type DateTime because you are passing data.
    //    public DateTime GetBirthDate()
    //    {
    //        return _birthdate;
    //    }
    //}


    class Program
    {
        static void Main(string[] args)
        {
            // old way with explicit getters and setters
            //var person = new Person();
            //person.SetBirthDate(new DateTime(1989, 4, 11));
            //Console.WriteLine(person.GetBirthDate());

            // new way
            var person = new Person(new DateTime(1989, 4, 11));
            Console.WriteLine(person.Age);
        }
    }
}
