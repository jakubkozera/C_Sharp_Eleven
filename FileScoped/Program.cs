// See https://aka.ms/new-console-template for more information
using FileScoped;

Console.WriteLine("Hello, World!");

var person = new Person()
{
    FirstName = "Jakub",
    LastName = "Test"
};

Console.WriteLine(person.CalculateSalary());
