using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace RomanNumerals;

public class RomanNumeralComplexTest
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
        var map = romanNumeral.ToCharArray()
            .Select((c, i) => new { Index = i, Value = c, Number = $"{c}".FromBaseRomanNumeralSymbols() }).ToList();
        foreach (var item in map)
        {
            if (map.Find(x => x.Index == item.Index - 1)?.Number < item.Number)
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


}