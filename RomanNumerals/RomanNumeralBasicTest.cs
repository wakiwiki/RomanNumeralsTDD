using System;
using FluentAssertions;
using Xunit;

namespace RomanNumerals
{
    public class RomanNumeralBasicTest
    {
        [Fact]
        public void return_one_for_I_symbols()
        {
            var val = "I".FromBaseRomanNumeralSymbols();
            val.Should().Be(1);
        }

        [Fact]
        public void return_five_for_V_symbols()
        {
            var val = "V".FromBaseRomanNumeralSymbols();
            val.Should().Be(5);
        }

        [Fact]
        public void return_ten_for_X_symbols()
        {
            var val = "X".FromBaseRomanNumeralSymbols();
            val.Should().Be(10);
        }        
        
        [Fact]
        public void return_fifty_for_L_symbols()
        {
            var val = "L".FromBaseRomanNumeralSymbols();
            val.Should().Be(50);
        }

        [Fact]
        public void return_hundred_for_C_symbols()
        {
            var val = "C".FromBaseRomanNumeralSymbols();
            val.Should().Be(100);
        }

        [Fact]
        public void return_five_hundred_for_D_symbols()
        {
            var val = "D".FromBaseRomanNumeralSymbols();
            val.Should().Be(500);
        }

        [Fact]
        public void return_thousand_for_M_symbols()
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
}