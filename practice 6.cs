using System;

public class Program6
{
    public static string Expand(string s, int left, int right)
    {
        while (left >= 0 &&
               right < s.Length &&
               s[left] == s[right])
        {
            left--;
            right++;
        }

        return s.Substring(left + 1,
                             right - left - 1);
    }

    static void Main()
    {
        string s = "babad";
        string longest = "";

        for (int i = 0; i < s.Length; i++)
        {
            string odd = Expand(s, i, i);
            string even = Expand(s, i, i + 1);

            if (odd.Length > longest.Length)
                longest = odd;

            if (even.Length > longest.Length)
                longest = even;
        }

        Console.WriteLine(longest);
    }
}