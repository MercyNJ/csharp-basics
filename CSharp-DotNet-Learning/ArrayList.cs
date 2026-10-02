using System;
using System.Collections;

ArrayList candidateRecords = new ArrayList();

candidateRecords.Add("Mercy");
candidateRecords.Add(101);
candidateRecords.Add("Senior .NET Developer");
candidateRecords.Add(true);

Console.WriteLine("Candidate record:");

foreach (object item in candidateRecords)
{
    Console.WriteLine(item);
}

// Access elements by index
Console.WriteLine($"\nCandidate name: {candidateRecords[0]}");
Console.WriteLine($"Application ID: {candidateRecords[1]}");

// Insert an element
candidateRecords.Insert(1, "Software Engineer");

Console.WriteLine("\nRecord after inserting job title:");

foreach (object item in candidateRecords)
{
    Console.WriteLine(item);
}

// Check whether an element exists
Console.WriteLine(
    $"\nContains Mercy? {candidateRecords.Contains("Mercy")}"
);

Console.WriteLine(
    $"Contains John? {candidateRecords.Contains("John")}"
);

// Find the index of an element
Console.WriteLine(
    $"Index of Mercy: {candidateRecords.IndexOf("Mercy")}"
);

// Create an ArrayList with initial capacity
ArrayList shortlistedCandidates = new ArrayList(5);

shortlistedCandidates.Add("John");
shortlistedCandidates.Add("Amina");
shortlistedCandidates.Add("Peter");
shortlistedCandidates.Add("Grace");

Console.WriteLine("\nShortlisted candidates:");

foreach (object candidate in shortlistedCandidates)
{
    Console.WriteLine(candidate);
}

// Create an ArrayList from another collection
string[] interviewCandidates = { "Brian", "Faith", "David" };

ArrayList interviewList = new ArrayList(interviewCandidates);

Console.WriteLine("\nInterview candidates:");

foreach (object candidate in interviewList)
{
    Console.WriteLine(candidate);
}

// Sort candidate application IDs
ArrayList applicationIds = new ArrayList();

applicationIds.Add(104);
applicationIds.Add(101);
applicationIds.Add(103);
applicationIds.Add(102);

applicationIds.Sort();

Console.WriteLine("\nApplication IDs in sorted order:");

foreach (object id in applicationIds)
{
    Console.WriteLine(id);
}

// Reverse the application IDs
applicationIds.Reverse();

Console.WriteLine("\nApplication IDs in reverse order:");

foreach (object id in applicationIds)
{
    Console.WriteLine(id);
}

// Remove the first occurrence of an element
candidateRecords.Remove("Mercy");

Console.WriteLine(
    $"\nRecords after Remove(): {candidateRecords.Count}"
);

// Remove an element at a specific index
candidateRecords.RemoveAt(1);

Console.WriteLine(
    $"Records after RemoveAt(): {candidateRecords.Count}"
);

// Remove a range of elements
candidateRecords.RemoveRange(0, 2);

Console.WriteLine(
    $"Records after RemoveRange(): {candidateRecords.Count}"
);

// Display remaining records
Console.WriteLine("\nRemaining candidate records:");

foreach (object item in candidateRecords)
{
    Console.WriteLine(item);
}

// Clear all elements
candidateRecords.Clear();

Console.WriteLine(
    $"\nRecords after Clear(): {candidateRecords.Count}"
);