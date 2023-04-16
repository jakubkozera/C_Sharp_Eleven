using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileScoped
{
    public class Person
    {
        public string FirstName { get; set; } = default!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = default!;

        public int CalculateSalary()
        { 
            var newCalculator = new Calculator();
            return newCalculator.Calculate(this);
        }
    } 

    file class Calculator
    {
        public int Calculate(Person person)
        {
            return 100;
        }
    }

    file enum Test
    {
        None = 0,
    }
}
