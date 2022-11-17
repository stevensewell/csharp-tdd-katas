using System;

namespace Extensions
{
    public static class StringExt
    {
        public static string ToAlternatingCase (this string s)
        {
            return s
                .ToCharArray()
                .Select(AlternateCase)
                .Aggregate((x, y) => x + y);
        }

        private static string AlternateCase(char chr)
        {
            return chr switch
            {
                _ when char.IsUpper(chr) => char.ToLower(chr).ToString(),
                _ when char.IsLower(chr) => char.ToUpper(chr).ToString(),
                _ => chr.ToString()
            };
        }
    }
}