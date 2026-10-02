List<Candidate> candidates = new List<Candidate>();

void AddCandidate(List<Candidate> candidates, string name, string email, int yearsOfExperience)
{
    Candidate candidate = new Candidate();
    candidate.Name = name;
    candidate.Email = email;
    candidate.YearsOfExperience = yearsOfExperience;

    candidates.Add(candidate);
}

AddCandidate(candidates, "Mercy", "me@gmail.com", 4);
AddCandidate(candidates, "Amina", "amina@gmail.com", 5);
AddCandidate(candidates, "Peter", "peter@gmail.com", 3);

//Print candidates
foreach (var candidate in candidates)
{
    Console.WriteLine($"{candidate.Name} - {candidate.Email} - {candidate.YearsOfExperience} years");
}

public class Candidate
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public int YearsOfExperience { get; set; }
}