using System;
using System.Collections.Generic;

public record Candidate(string Name, int YearsOfExperience);

List<Candidate> candidates =
[
    new("Mike", 4),
    new("John", 1),
    new("Amina", 5),
    new("Peter", 2)
];

int minExperience = 3;

foreach(var candidate in candidates)
{
    if(candidate.YearsOfExperience >= minExperience)
    {
        Console.WriteLine($"{candidate.Name} can proceed to screening");
    }
}