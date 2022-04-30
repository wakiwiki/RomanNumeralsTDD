using System.Linq;
using FluentAssertions;
using Xunit;

namespace RomanNumerals;

public class RomanNumeralComplexTest
{
    [Theory]
    [InlineData("II",2)]
    public void return_corresponding_number_for_two_and_three(string romanNumeral, int expectedNumber)
    {
        var characters = romanNumeral.ToCharArray();
        var _two = $"{characters[1]}".FromBaseRomanNumeralSymbols();
        _two += $"{characters[0]}".FromBaseRomanNumeralSymbols();
        _two.Should().Be(2);
    }
}