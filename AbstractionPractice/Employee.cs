using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionPractice
{
    public abstract class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string  Position { get; set; }

        public abstract void Mission();  // Abstract metot
    }
    
    public class Worker : Employee
    { 
        public Worker(string firstName, string lastName, string department, string position ) 
        {
            FirstName = firstName;  
            LastName = lastName;
            Department = department;
            Position = position;
        }
        public override void Mission()          // Base classtan  gelen metotu override yaparak ezmek.
        {
            Console.WriteLine($"Merhaba ben {FirstName} {LastName},\n{Department} departmanında {Position} pozisyonu olarak çalışıyorum.");
        }


    }
}
