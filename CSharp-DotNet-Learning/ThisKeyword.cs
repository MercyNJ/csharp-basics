using System;

// 1. this refers to the current class instance.
class Candidate
{
    public string Name;

    public string GetName()
    {
        return Name;
    }

    public void SetName(string Name)
    {
        this.Name = Name;
    }
}

// Expected output:
// Mercy


// 2. this() calls another constructor in the same class.
class Employee
{
    public Employee() : this("Unknown")
    {
        Console.WriteLine("Default constructor called");
    }

    public Employee(string name)
    {
        Console.WriteLine($"Employee constructor called for {name}");
    }
}

// Expected output:
// Employee constructor called for Unknown
// Default constructor called


// 3. this can explicitly call another instance method.
class Application
{
    public void Display()
    {
        this.Show();
        Console.WriteLine("Inside Display");
    }

    public void Show()
    {
        Console.WriteLine("Inside Show");
    }
}

// Expected output:
// Inside Show
// Inside Display


// 4. this can refer to the current object when passed to another method.
class Interview
{
    private int score = 85;

    public void Display(Interview interview)
    {
        Console.WriteLine($"Score = {interview.score}");
    }

    public void Show()
    {
        Display(this);
    }
}

// Expected output:
// Score = 85


// 5. this is used to define an indexer that lets an object use [] syntax.
class Week
{
    private string[] days = new string[7];

    public string this[int index]
    {
        get
        {
            return days[index];
        }
        set
        {
            days[index] = value;
        }
    }
}

// Expected output:
// Sun Mon Tue Wed Thu Fri Sat


class Program
{
    static void Main()
    {
        // Example 1
        Candidate candidate = new Candidate();
        candidate.SetName("Mercy");
        Console.WriteLine(candidate.GetName());

        // Example 2
        Employee employee = new Employee();

        // Example 3
        Application application = new Application();
        application.Display();

        // Example 4
        Interview interview = new Interview();
        interview.Show();

        // Example 5
        Week week = new Week();

        week[0] = "Sun";
        week[1] = "Mon";
        week[2] = "Tue";
        week[3] = "Wed";
        week[4] = "Thu";
        week[5] = "Fri";
        week[6] = "Sat";

        for (int i = 0; i < 7; i++)
        {
            Console.Write(week[i] + " ");
        }
    }
}