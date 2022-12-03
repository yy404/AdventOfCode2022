using System;
using System.Collections.Generic;	// List
using System.Linq;		// ToList

class Solution
{
    static void Main()
    {
        List<string> lines = MyUtilities.GetInput().Split('\n').ToList();
        
        // Part One:
        // int sum = 0;            
        // foreach (var line in lines) {
        //     int len = line.Length;
        //     char p = ' ';
        //     HashSet<char> left = new HashSet<char>();
            
        //     for (int j = 0; j < len/2; j++) 
        //     {
        //         left.Add(line[j]);
        //     }
            
        //     for (int j = len/2; j < len; j++) 
        //     {
        //         if (left.Contains(line[j])) 
        //         {
        //             p = line[j];
        //             break;
        //         }                
        //     }

        //     if (p > 'a') 
        //     {
        //         sum += p - 'a' + 1;    
        //     }
        //     else 
        //     {
        //         sum += p - 'A' + 27;   
        //     }
        // }
        // Console.WriteLine(sum.ToString());
        
        // Part Two:
        int sum = 0;            
        for (int i = 0; i < lines.Count; i+=3) 
        {
            char p = ' ';
            Dictionary<char, int> counts = new Dictionary<char, int>();
            
            // Seems need to trim the lines to remove line break.
            foreach (char c in lines[i].Trim()) { counts[c]=counts.GetValueOrDefault(c)|1; }
            foreach (char c in lines[i+1].Trim()) { counts[c]=counts.GetValueOrDefault(c)|2; }
            foreach (char c in lines[i+2].Trim()) 
            { 
                counts[c]=counts.GetValueOrDefault(c)|4;
                
                if (counts[c]==7)
                {
                    // All three bit flags are set.
                    p = c;    
                }
            }
            if (p > 'a') sum += p - 'a' + 1; else sum += p - 'A' + 27;
        }
        Console.WriteLine(sum.ToString());
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
