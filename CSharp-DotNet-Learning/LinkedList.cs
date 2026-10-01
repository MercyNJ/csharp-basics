using System;
using System.Collections.Generic;

LinkedList<string> candidates = new LinkedList<string>();

// Add candidates to the recruitment pipeline
candidates.AddLast("Mercy");
candidates.AddFirst("John");
candidates.AddLast("Amina");
candidates.AddLast("Peter");

Console.WriteLine("Candidates in the recruitment pipeline:");

foreach (string candidate in candidates)
{
    Console.WriteLine(candidate);
}

// Add candidates before and after existing candidates
LinkedListNode<string>? john = candidates.Find("John");

if (john != null)
{
    candidates.AddAfter(john, "Brian");
}

LinkedListNode<string>? Amina = candidates.Find("Amina");

if (Amina != null)
{
    candidates.AddBefore(Amina, "Grace");
}

Console.WriteLine("\nUpdated recruitment pipeline:");

foreach (string candidate in candidates)
{
    Console.WriteLine(candidate);
}

// Remove a specific candidate
candidates.Remove("Brian");

Console.WriteLine("\nAfter removing Brian:");

foreach (string candidate in candidates)
{
    Console.WriteLine(candidate);
}

// Remove the first candidate
candidates.RemoveFirst();

Console.WriteLine("\nAfter removing the first candidate:");

foreach (string candidate in candidates)
{
    Console.WriteLine(candidate);
}

// Remove the last candidate
candidates.RemoveLast();

Console.WriteLine("\nAfter removing the last candidate:");

foreach (string candidate in candidates)
{
    Console.WriteLine(candidate);
}

// Check whether candidates are in the pipeline
Console.WriteLine(
    $"\nIs Mercy in the recruitment pipeline? {candidates.Contains("Mercy")}"
);

Console.WriteLine(
    $"Is Peter in the recruitment pipeline? {candidates.Contains("Peter")}"
);

// Clear the recruitment pipeline
candidates.Clear();

Console.WriteLine(
    $"\nCandidates remaining after clearing the pipeline: {candidates.Count}"
);