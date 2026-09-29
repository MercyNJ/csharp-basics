using System;

// 1. Encapsulation hides fields and provides controlled access through methods.
class Candidate
{
    private int yearsOfExperience;

    public void SetExperience(int years)
    {
        if (years >= 0)
            yearsOfExperience = years;
    }

    public int GetExperience()
    {
        return yearsOfExperience;
    }
}

// Expected output:
// Years of experience: 4


// 2. Properties provide controlled access to private fields.
class Job
{
    private string title;

    public string Title
    {
        get { return title; }
        set
        {
            if (!string.IsNullOrEmpty(value))
                title = value;
        }
    }
}

// Expected output:
// Job Title: Software Developer


class Program
{
    static void Main()
    {
        // Example 1: Controlled access through methods.
        Candidate candidate = new Candidate();
        candidate.SetExperience(4);

        Console.WriteLine($"Years of experience: {candidate.GetExperience()}");

        // Example 2: Controlled access through a property.
        Job job = new Job();
        job.Title = "Software Developer";

        Console.WriteLine($"Job Title: {job.Title}");
    }
}