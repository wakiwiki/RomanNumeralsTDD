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
}