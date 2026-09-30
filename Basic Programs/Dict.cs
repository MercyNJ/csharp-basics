Dictionary<string, int> candidates = new Dictionary<string, int>();

candidates.Add("Mercy", 4);
candidates.Add("John", 2);
candidates.Add("Amina", 5);
candidates.Add("Peter", 1);

foreach (var candidate in candidates)
{
    if (candidate.Value >= 3)
    {
        Console.WriteLine($"{candidate.Key}: {candidate.Value} years");
    }
}