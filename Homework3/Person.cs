using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    public class Person
    {
        public Person(string firstName, string lastName, DateTime birthDate, string hobby, string gender)
        {
            FirstName = firstName;
            LastName = lastName;    
            BirthDate = birthDate;  
            Hobby = hobby;
            Gender = gender;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Hobby { get; set; }
        public int Age { get; set; }
        private string _gender;
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                if (value == "f")
                {
                    _gender = "female";
                }
                else if (value == "m")
                {
                    _gender = "male";
                }
                else
                {
                    _gender = "undefined";
                }
            }
        }
        
        public int CalculateAge()
        {
            Age = DateTime.Now.Year - BirthDate.Year;
            return Age;
        }

        public void Greeting()
        {
            Console.WriteLine($"Hello everyone, I'm {FirstName} {LastName}, this year I'm {Age}. My hobbies are: {Hobby}, my gender - {Gender}");
        }
    }

}
