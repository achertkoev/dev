using System;
using System.Collections.Generic;

var romanNumber="MCMXCIV";
var sol = new RomanToInteger();
var result = sol.RomanToInt(romanNumber);
Console.WriteLine($"""Римское число "{romanNumber}" в десятичной системе "{result}". """);


public class RomanToInteger
{
    Dictionary<char, int> alphabet = new Dictionary<char, int>()
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

        if (s.Length == 1)
            return alphabet[s[0]];

        for (int i = s.Length - 1; i > 0; i--)
        {
            result += Calc(s[i - 1], s[i]);

            i--;
            if (i == 1)
                result += alphabet[s[i - 1]];

        }

        return result;
    }

    int Calc(char left, char right)
    {
        var leftValue = alphabet[left];
        var rightValue = alphabet[right];
        if (leftValue >= rightValue)
        {
            return leftValue + rightValue;
        }
        else
        {
            return rightValue - leftValue;
        }

    }
}