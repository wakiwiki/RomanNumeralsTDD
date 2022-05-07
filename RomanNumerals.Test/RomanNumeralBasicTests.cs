using FluentAssertions;
using RomanNumerals.Core;
using Xunit;

namespace RomanNumerals.Test;

public class RomanNumeralBasicTests
{
    [Fact(DisplayName = "Return 1 for 'I'")]
    public void return_one_for_I_symbol()
    {
        var val = "I".FromBaseRomanNumeralSymbols();
        val.Should().Be(1);
    }

    [Fact(DisplayName = "Return 5 for 'V'")]
    public void return_five_for_V_symbol()
    {
        var val = "V".FromBaseRomanNumeralSymbols();
        val.Should().Be(5);
    }

    [Fact(DisplayName = "Return 10 for 'X'")]
    public void return_ten_for_X_symbol()
    {
        var val = "X".FromBaseRomanNumeralSymbols();
        val.Should().Be(10);
    }

    [Fact(DisplayName = "Return 50 for 'L'")]
    public void return_fifty_for_L_symbol()
    {
        var val = "L".FromBaseRomanNumeralSymbols();
        val.Should().Be(50);
    }

    [Fact(DisplayName = "Return 100 for 'C'")]
    public void return_hundred_for_C_symbol()
    {
        var val = "C".FromBaseRomanNumeralSymbols();
        val.Should().Be(100);
    }

    [Fact(DisplayName = "Return 500 for 'D'")]
    public void return_five_hundred_for_D_symbol()
    {
        var val = "D".FromBaseRomanNumeralSymbols();
        val.Should().Be(500);
    }

    [Fact(DisplayName = "Return 1000 for 'M'")]
    public void return_thousand_for_M_symbol()
    {
        var val = "M".FromBaseRomanNumeralSymbols();
        val.Should().Be(1000);
    }

    [Theory]
    [InlineData("i")]
    [InlineData("x")]
    [InlineData("E")]
    public void return_zero_for_other_symbols(string symbol)
    {
        var val = symbol.FromBaseRomanNumeralSymbols();
        val.Should().Be(0);
    }
}
