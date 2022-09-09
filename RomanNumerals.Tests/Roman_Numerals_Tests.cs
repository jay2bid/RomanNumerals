namespace RomanNumeralsTesting;
using RomanNumeralsApp;
using FluentAssertions;

public class Roman_Numerals_Tests
{
    private RomanNumeralsConverter RomanNumeralsConverter;
    [SetUp]

    public void Setup()
    {
        RomanNumeralsConverter = new RomanNumeralsConverter();

    }

    [Test]
    public void Correct_Number_From_Converter()
    {
        RomanNumeralsConverter.ConvertRomanNumerals("I").Should().Be(1);
        RomanNumeralsConverter.ConvertRomanNumerals("II").Should().Be(2);
        RomanNumeralsConverter.ConvertRomanNumerals("III").Should().Be(3);
        RomanNumeralsConverter.ConvertRomanNumerals("IV").Should().Be(4);
        RomanNumeralsConverter.ConvertRomanNumerals("V").Should().Be(5);
        RomanNumeralsConverter.ConvertRomanNumerals("VI").Should().Be(6);
        RomanNumeralsConverter.ConvertRomanNumerals("VII").Should().Be(7);
        RomanNumeralsConverter.ConvertRomanNumerals("VIII").Should().Be(8);
        RomanNumeralsConverter.ConvertRomanNumerals("IX").Should().Be(9);
        RomanNumeralsConverter.ConvertRomanNumerals("X").Should().Be(10);
    }
  
}
