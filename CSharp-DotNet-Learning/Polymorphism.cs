using System;

// 1. Compile-time polymorphism: method overloading.
class CandidateSearch
{
    public void Search(string name)
    {
        Console.WriteLine($"Searching for candidate: {name}");
    }

    public void Search(string location, string skill)
    {
        Console.WriteLine($"Searching for {skill} candidates in {location}.");
    }
}

// Expected output:
// Searching for candidate: Mercy
// Searching for C# candidates in Nairobi.


// 2. Runtime polymorphism: a derived class overrides a base class method.
class Employee
{
    public string Name { get; set; }

    public virtual void DescribeRole()
    {
        Console.WriteLine($"{Name} works in TalentCRM.");
    }
}

class Recruiter : Employee
{
    public override void DescribeRole()
    {
        Console.WriteLine($"{Name} manages candidates and job applications.");
    }
}

class HiringManager : Employee
{
    public override void DescribeRole()
    {
        Console.WriteLine($"{Name} manages the hiring process.");
    }
}

// Expected output:
// Mercy manages candidates and job applications.
// John manages the hiring process.


class Program
{
    static void Main()
    {
        // Example 1: Method overloading
        CandidateSearch search = new CandidateSearch();

        search.Search("Mercy");
        search.Search("Nairobi", "C#");

        // Example 2: Runtime polymorphism
        Employee recruiter = new Recruiter
        {
            Name = "Mercy"
        };

        Employee manager = new HiringManager
        {
            Name = "John"
        };

        recruiter.DescribeRole();
        manager.DescribeRole();
    }
}