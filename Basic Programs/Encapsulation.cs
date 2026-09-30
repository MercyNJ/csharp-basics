Candidate candidate = new Candidate();

candidate.Name = "Milka";
candidate.SetExperience(4);

Console.WriteLine(candidate.GetExperience());

public class Candidate
{
    public string Name { get; set; } = "";
    private int yearsOfExperience;

    public void SetExperience(int years)
    {
        if (years >= 0)
        {
            yearsOfExperience = years;
        }
    }

    public int GetExperience()
    {
        return yearsOfExperience;
    }
}