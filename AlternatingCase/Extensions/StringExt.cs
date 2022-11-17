using System;
using System.Linq;

namespace Extensions
{
    public static class StringExt
    {
        public static string ToAlternatingCase (this string s)
        {
            return s
                .Select(AlternateCase)
                .Aggregate((x, y) => x + y);
        }

        private static string AlternateCase(char chr)
        {
            return char.IsUpper(chr) 
                ? char.ToLower(chr).ToString() 
                : char.ToUpper(chr).ToString();
        }
    }
}