using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the string :");
        string? s = Console.ReadLine();

        HashSet<char> set = new HashSet<char>();

        int left = 0;
        int maxLength = 0;
        string result = "";

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }

            set.Add(s[right]);

            if (right - left + 1 > maxLength)
            {
                maxLength = right - left + 1;
                result = s.Substring(left, maxLength);
            }
        }

        Console.WriteLine(result);
        Console.WriteLine(maxLength);
    }
}