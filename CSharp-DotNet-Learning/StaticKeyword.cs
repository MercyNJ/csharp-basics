using System;

// 1. Static fields are shared by all objects of the class.
class Candidate
{
    public static int TotalCandidates = 0;

    public Candidate()
    {
        TotalCandidates++;
    }
}

// Expected output:
// Total candidates: 3


// 2. Static methods belong to the class and can be called without an object.
class CandidateHelper
{
    public static bool MeetsExperienceRequirement(int yearsOfExperience)
    {
        return yearsOfExperience >= 3;
    }
}

// Expected output:
// True


// 3. Static constructors initialize static members once before first use.
class TalentCRMSettings
{
    public static string ApplicationName;

    static TalentCRMSettings()
    {
        ApplicationName = "TalentCRM";
        Console.WriteLine("Static constructor called");
    }
}

// Expected output:
// Static constructor called
// TalentCRM


// 4. Static classes contain only static members and cannot be instantiated.
static class TalentCRMUtility
{
    public static void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }
}

// Expected output:
// Candidate successfully added


class Program
{
    static void Main()
    {
        // Example 1: Static field
        new Candidate();
        new Candidate();
        new Candidate();

        Console.WriteLine($"Total candidates: {Candidate.TotalCandidates}");

        // Example 2: Static method
        bool qualifies = CandidateHelper.MeetsExperienceRequirement(4);
        Console.WriteLine(qualifies);

        // Example 3: Static constructor
        Console.WriteLine(TalentCRMSettings.ApplicationName);

        // Example 4: Static class
        TalentCRMUtility.PrintMessage("Candidate successfully added");
    }
}