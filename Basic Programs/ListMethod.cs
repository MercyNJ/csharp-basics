List<Candidate> candidates = new List<Candidate>
{
    new Candidate {Name = "Mercy", Email = "me@gmail.com", YearsOfExperience = 4 },
    new Candidate {Name = "Amina", Email = "amina@gmail.com", YearsOfExperience = 5 },
    new Candidate {Name = "Nina", Email = "me@gmail.com", YearsOfExperience = 1 },
    new Candidate {Name = "Peter", Email = "peter@gmail.com", YearsOfExperience = 3 },
};

void PrintExperiencedCandidates(List<Candidate> candidatesList)
{
    Console.WriteLine("Experienced candidates:");
    foreach (Candidate candidate in candidatesList)
    {
        if (candidate.YearsOfExperience >= 3)
        {
            Console.WriteLine($"{candidate.Name} - {candidate.YearsOfExperience} years");
        }
    }
}

PrintExperiencedCandidates(candidates);

public class Candidate
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public int YearsOfExperience { get; set; }
}