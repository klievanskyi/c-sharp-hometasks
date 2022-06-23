//An anagram is a word created by rearranging letters from another word. You have to solve the problem of determining if an anagram of the one given string is in the another one string. 

//F.e. anagrams of "bag" are "bag", "bga", "abg", "agb", "gab", "gba". Since none of those anagrams are in "grab", the answer is false. A "g", "a", and "b" are in the string "grab", but they're split up by the "r". But one of the anagrams of "car"  ("cra", "rac", "rca", "acr", "arc") is in word "race".

//To solve this this problem within the class AnagramSolver you have to create:

//- static method IsAnagram() which takes two string parameters. This method returns True if an anagram of the first string is the substring of the second string;

//-create a static method Permutations() that takes generics IEnumerable (given string) and returns generics IEnumerable collection (of an anagram strings). Note: try to use iterator.This method is called from the method IsAnagram().

//Examples:

//IsAnagram("nod", "done") ➞ True

//IsAnagram("bag", "grab') ➞ False

using System;
using System.Collections.Generic;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class AnagramSolver
    {
        static void Main(string[] args)
        {
            IsAnagram("sat", "spatula");
        }

        public static string IsAnagram(string a, string b)
        {
            Permutations(a);
            foreach (var str in list)
            {
                if (b.Contains(str))
                {
                    return "True";
                }
            }
            return "False";
        }

        public static List<string> list = new List<string>();

        public static IEnumerable<string> Permutations(string word)
        {
            list = new List<string>();
            char[] arr = word.ToCharArray();
            Permute(arr, 0, arr.Length - 1);
            return list;
        }

        public static void Swap(ref char a, ref char b)
        {
            char tmp = a;
            a = b;
            b = tmp;
        }

        public static void Permute(char[] elements, int recursionDepth, int maxDepth)
        {
            if (recursionDepth == maxDepth)
            {
                list.Add(new string(elements));
                return;
            }

            for (int i = recursionDepth; i <= maxDepth; i++)
            {
                Swap(ref elements[recursionDepth], ref elements[i]);
                Permute(elements, recursionDepth + 1, maxDepth);
                Swap(ref elements[recursionDepth], ref elements[i]);
            }
        }
    }
}