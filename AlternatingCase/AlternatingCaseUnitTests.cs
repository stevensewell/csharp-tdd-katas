namespace AlternatingCase;

public class Tests
{
    
    [Test]
    [TestCase("HELLO WORLD", "hello world")]
    [TestCase("hello world", "HELLO WORLD")]
    [TestCase("hello WORLD", "HELLO world")]
    [TestCase("HeLLo WoRLD", "hEllO wOrld")]
    [TestCase("12345", "12345")]
    [TestCase("1a2b3c4d5e", "1A2B3C4D5E")]
    public void ShouldAlternateCase(string input, string expected)
    {
        Assert.AreEqual(expected, input.ToAlternativeString(input));
    }
}