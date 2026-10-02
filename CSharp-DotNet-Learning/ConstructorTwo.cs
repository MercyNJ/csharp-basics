List<Candidate> candidates = new List<Candidate>
    {
        new Candidate {Name= "Mercy", Email = "me@gmail.com", YearsOfExperience = 4 },
        new Candidate {Name = "Milly", Email = "mi@gmail.com", YearsOfExperience = 1 },
        new Candidate{Name = "Mike", Email = "mik@gmail.com", YearsOfExperience = 3 },
    };

foreach (var candidate in candidates)
{
    Console.WriteLine($"{candidate.Name} has {candidate.YearsOfExperience} years of experience");
}
Console.WriteLine();

//Using constructor
List<CandidateTwo> candidatesTwo = new List<CandidateTwo>
{
    new CandidateTwo ("Nikck", "nint@gmail.com", 3),
    new CandidateTwo ("Nina", "nin@gmail.com", 1),
    new CandidateTwo ("Nala", "nt@gmail.com", 7),
};

foreach (var candidateTwo in candidatesTwo)
{
    Console.WriteLine($"{candidateTwo.Name} has {candidateTwo.YearsOfExperience} years of experience");
}

//without constructor
public class Candidate
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public int YearsOfExperience { get; set; }
}



//With constructor
public class CandidateTwo
{
    public string Name { get; set; }
    public string Email { get; set; }
    public int YearsOfExperience { get; set; }

    public CandidateTwo(string name, string email, int yearsOfExperience)
    {
        Name = name;
        Email = email;
        YearsOfExperience = yearsOfExperience;
    }
}