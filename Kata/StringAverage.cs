using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kata
{
    public static string AverageString(string str)
    {
        if (string.IsNullOrEmpty(str))
        {
            return "n/a";
        }
        List<string> myLists = new List<string>();
        myLists.Add("zero");
        myLists.Add("one");
        myLists.Add("two");
        myLists.Add("three");
        myLists.Add("four");
        myLists.Add("five");
        myLists.Add("six");
        myLists.Add("seven");
        myLists.Add("eight");
        myLists.Add("nine");
        string[] input = str.Split(' ');
        int sum = 0;
        int count = input.Length;
        foreach (var i in input)
        {
            if (myLists.Contains(i))
            {
                sum += myLists.FindIndex(a => a.Contains(i));
            }
            else
            {
                return "n/a";
            }
        }
        return myLists[sum / count];
    }
}