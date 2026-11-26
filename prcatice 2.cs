using System;
using System.Collections.Generic;

public class Program3
{
    public static void Main()
    {
        string text = "C# is good and Java is good and Python is powerful";

        Dictionary<string, int> dict = new();

        foreach (string word in text.Split(' '))
        {
            if (dict.ContainsKey(word))
                dict[word]++;
            else
                dict[word] = 1;
        }

        foreach (var item in dict)
        {
            if (item.Value > 1)
                Console.WriteLine(item.Key);
        }
    }
}