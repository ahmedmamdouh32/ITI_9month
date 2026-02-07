using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO.IsolatedStorage;
using System.Text;

namespace Day2.models
{
    internal class CompareSameCharacters : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            if (x == null || y == null)
            {
                return false;
            }
            else 
            {
                return Normalize(x) == Normalize(y); 
            }
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return 0;
        }


        string Normalize(string word)
        {
            return new string(word.Trim().OrderBy(x => x).ToArray());
        }
    }
}
