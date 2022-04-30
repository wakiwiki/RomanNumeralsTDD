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
        if (expectedNumber == 2)
        {
            number += $"{characters[1]}".FromBaseRomanNumeralSymbols();
            number += $"{characters[0]}".FromBaseRomanNumeralSymbols();
        }

        if (expectedNumber == 3)
        {
            number += $"{characters[2]}".FromBaseRomanNumeralSymbols();
            number += $"{characters[1]}".FromBaseRomanNumeralSymbols();
            number += $"{characters[0]}".FromBaseRomanNumeralSymbols();
        }
        number.Should().Be(expectedNumber);
    }
}