using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class StringAverage
{
    public string AverageString(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return "n/a";
        }
        List<string> numStringLists = new List<string>();
        numStringLists.Add("zero");
        numStringLists.Add("one");
        numStringLists.Add("two");
        numStringLists.Add("three");
        numStringLists.Add("four");
        numStringLists.Add("five");
        numStringLists.Add("six");
        numStringLists.Add("seven");
        numStringLists.Add("eight");
        numStringLists.Add("nine");
        string[] input = str.Split(' ');
        int sum = 0;
        int count = input.Length;
        foreach (var digit in input)
        {
            if (numStringLists.Contains(digit))
            {
                sum += numStringLists.FindIndex(a => a.Contains(digit));
            }
            else
            {
                return "n/a";
            }
        }
        return numStringLists[sum / count];
    }
}