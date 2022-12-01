using System;
using System.Collections.Generic;	// List
using System.Linq;		// ToList

class Solution
{
    static void Main()
    {
        List<string> lines = MyUtilities.GetInput().Split('\n').ToList();
        
        List<int> calories = GetSortedCalories(lines); 
        
        Console.WriteLine("Part One: " + calories[0]);
        Console.WriteLine("Part Two: " + calories.Take(3).Sum());
    }
    
    static List<int> GetSortedCalories(List<string> lines)
    {
        List<int> calories = new List<int>(); 
        
        int sum = 0;
        foreach (string s in lines)
        {
            if (s == "")
        	{
        	    calories.Add(sum);
        	    sum = 0;
        	}
            else
        	{
        	    sum += int.Parse(s);
        	}
        }
        
        calories = calories.OrderByDescending(x => x).ToList();
        return calories;
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
