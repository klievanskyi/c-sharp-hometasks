﻿//Please, create a static method GetWord takes 2 string parameters: 

//         first - initial string with a sequence of words separated by space 

//         second - a word for comparison.

//The method should find the longest word in the first parameter, that is longer than the second parameter if there is one,

//otherwise, the second parameter should be the result of the search.

//The method should return the part of the found word, starting from the first 'a' char. 

//If there isn't 'a' char in the found word, the method should return an empty string.

//(You don't need to verify on null parameter values. Assume that parameters will always be not null)

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static string GetWord(string input, string seed)
        {
            string longestWord = input.Split(' ').Aggregate(seed,
                (longest, next) => next.Length > longest.Length ? next : longest,
                fruit => fruit.ToLower());
            return longestWord.Contains('a') ? longestWord.Substring(longestWord.IndexOf('a')) : "";
        }
    }
}