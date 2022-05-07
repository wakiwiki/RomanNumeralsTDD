using FluentAssertions;
using RomanNumerals.Core;
using System.Linq;
using Xunit;

namespace RomanNumerals.Test;

public class RomanNumeralComplexTests
{
    [Theory]
    [InlineData("II", 2)]
    [InlineData("III", 3)]
    public void return_corresponding_number_for_two_and_three(string romanNumeral, int expectedNumber)
    {
        var characters = romanNumeral.ToCharArray();
        int number = 0;
        for (int i = 0; i < characters.Length; i++)
        {
            number += $"{characters[i]}".FromBaseRomanNumeralSymbols();
        }

        number.Should().Be(expectedNumber);
    }

    [Theory]
    [InlineData("I", 1)]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("V", 5)]
    [InlineData("VII", 7)]
    [InlineData("IX", 9)]
    [InlineData("X", 10)]
    public void return_corresponding_number_from_one_to_ten(string romanNumeral, int expectedNumber)
    {
        int number = 0;
        var map = romanNumeral.ToCharMap();
        foreach (var item in map)
        {
            if (map.FirstOrDefault(x => x.Index == item.Index - 1).Number < item.Number)
            {
                number = item.Number - number;
            }
            else
            {
                number += item.Number;
            }

        }
        number.Should().Be(expectedNumber);
    }


    [Theory]
    [InlineData("I", 1)]
    [InlineData("III", 3)]
    [InlineData("IV", 4)]
    [InlineData("V", 5)]
    [InlineData("VII", 7)]
    [InlineData("IX", 9)]
    [InlineData("X", 10)]
    [InlineData("XLIX", 49)]
    [InlineData("CCCIV", 304)]
    [InlineData("MMMCIV", 3104)]
    [InlineData("MMMCMLXXXVII", 3987)]
    public void return_corresponding_number(string romanNumeral, int expectedNumber)
    {
        int number = 0;
        int prevNumber = 0;
        var map = romanNumeral.ToCharMap().OrderByDescending(x => x.Index);
        foreach (var item in map)
        {
            if (number == 0) number += item.Number;
            else
            {
                if (prevNumber > item.Number) number -= item.Number;
                else number += item.Number;
            }
            prevNumber = item.Number;
        }
        number.Should().Be(expectedNumber);
    }

}