namespace RomanNumerals.Core;

public static class RomanNumeralHelper
{
    public static int FromBaseSymbol(this string baseSymbol)
    {
        switch (baseSymbol)
        {
            case "I": return 1;
            case "V": return 5;
            case "X": return 10;
            case "L": return 50;
            case "C": return 100;
            case "D": return 500;
            case "M": return 1000;
            default: return 0;
        }
    }

    public static IEnumerable<RomanNumeralCharMap> ToCharMap(this string romanNumeral)
    {
        var map = romanNumeral.ToCharArray()
            .Select((c, i) => new RomanNumeralCharMap { Index = i, Value = c, Number = $"{c}".FromBaseSymbol() });
        return map;
    }
}

public struct RomanNumeralCharMap
{
    public int Index { get; set; }
    public char Value { get; set; }
    public int Number { get; set; }
}