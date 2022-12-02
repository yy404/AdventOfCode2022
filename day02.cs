using System;
using System.Collections.Generic;	// List
using System.Linq;		// ToList

class Solution
{
    static void Main()
    {
        List<string> lines = MyUtilities.GetInput().Split('\n').ToList();
        
        var points = new Dictionary<string, Dictionary<string, int>>();

        // Part One:
        // points["X"] = new Dictionary<string, int> {{"A", 4}, {"B", 1}, {"C", 7}};
        // points["Y"] = new Dictionary<string, int> {{"A", 8}, {"B", 5}, {"C", 2}};
        // points["Z"] = new Dictionary<string, int> {{"A", 3}, {"B", 9}, {"C", 6}};
        
        // Part Two:
        points["X"] = new Dictionary<string, int> {{"A", 3}, {"B", 1}, {"C", 2}};
        points["Y"] = new Dictionary<string, int> {{"A", 4}, {"B", 5}, {"C", 6}};
        points["Z"] = new Dictionary<string, int> {{"A", 8}, {"B", 9}, {"C", 7}};
        
        var score = lines
        .Select(e => e.Trim())
        .Select(e => points[e.Split(" ")[1]][e.Split(" ")[0]])
        .Sum();
        
        Console.WriteLine(score);
    }
}

class MyUtilities
{
static public string GetInput()
{
// copy the input to this string
return 
@"";
}
}
