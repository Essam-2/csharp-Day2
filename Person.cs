using System;
using System.Text.RegularExpressions;

class Person
{

    //    Getter(get) : Code outside the class can read the value
    //    Setter(set): Marked private here, so only the class itself can change it.
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateTime BirthDate { get; private set; }

    public string FullName => $"{FirstName} {LastName}";


    public int Age
    {
        get
        {
            var today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }

    // Default constructor (optional if you want object initializers)
    public Person()
    {
        FirstName = "Unknown";
        LastName = "Unknown";
        BirthDate = DateTime.Today;
    }

    // Parameterized constructor with basic validation
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        SetName(firstName, lastName);
        SetBirthDate(birthDate);
    }


    private void SetName(string firstName, string lastName)
    {
        if (string.IsNullOrWhiteSpace(firstName)) throw new ArgumentException("First name is required.");
        if (string.IsNullOrWhiteSpace(lastName)) throw new ArgumentException("Last name is required.");
        FirstName = firstName.Trim();
        LastName = lastName.Trim();
    }


    private void SetBirthDate(DateTime date)
    {
        if (date > DateTime.Today) throw new ArgumentException("Birth date cannot be in the future.");
        BirthDate = date.Date;
    }


    public void Rename(string firstName, string lastName) => SetName(firstName, lastName);

    public string Introduce() => $"Hi, I’m {FullName}, {Age} years old.";



}
