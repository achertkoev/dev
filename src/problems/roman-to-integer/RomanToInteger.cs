using System;
using System.Collections.Generic;

var romanNumber = "IVI";
var sol = new RomanToInteger();
var result = sol.RomanToInt(romanNumber);
Console.WriteLine($"""Римское число "{romanNumber}" в десятичной системе "{result}". """);


public class RomanToInteger
{
    Dictionary<char, int> romans = new Dictionary<char, int>()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000}
    };

    public int RomanToInt(string s)
    {
        var result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            if (i == s.Length - 1)
            {
                result += romans[s[i]];
                Console.WriteLine($"{s[i]}({romans[s[i]]})");
            }
            else
            {
                if (romans[s[i]] < romans[s[i + 1]])
                {

                    result += romans[s[i + 1]] - romans[s[i]];
                    i++;
                }
                else
                {
                    result += romans[s[i]];
                }
            }
        }

        return result;
    }
}