using System;
using System.Collections.Generic;

public class Program31
{
    public static void Main()
    {
        
        
        string str = "cat dog cat lion dog tiger";

        string[] words = str.Split(' ');

        Dictionary<string, int> dict = new();

        foreach (string word in words)
        {
            if (dict.ContainsKey(word))
                dict[word]++;
            else
                dict[word] = 1;
        }

        foreach (string word in words)
        {
            if (dict[word] == 1)
            {
                Console.WriteLine(word);
                break;
            }
        }
    }
}