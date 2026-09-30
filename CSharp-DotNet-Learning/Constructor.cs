// method 1: object initializer + required
Candidate candidate = new Candidate { Name = "Mercy", YearsOfExperience = 4 };
candidate.DisplayInfo();
Console.WriteLine();

// method 2: parameterized constructor
CandidateTwo candidateTwo = new CandidateTwo("John", 5);
candidateTwo.DisplayInfoTwo();
Console.WriteLine();

public class Candidate
{
    public required string Name { get; set; }
    public int YearsOfExperience { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Candidate: {Name}");
        Console.WriteLine($"Experience: {YearsOfExperience} years");
    }
}

//parametrized constructor
public class CandidateTwo
{
    public string NameTwo { get; set; }
    public int YearsOfExperienceTwo { get; set; }

    public CandidateTwo(string name, int yearsOfExpe)
    {
        NameTwo = name;
        YearsOfExperienceTwo = yearsOfExpe;
    }

    public void DisplayInfoTwo()
    {
        Console.WriteLine($"Candidate: {NameTwo}");
        Console.WriteLine($"Experience: {YearsOfExperienceTwo} years");
    }
}