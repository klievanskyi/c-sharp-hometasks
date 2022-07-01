//Define a class StringExtensions with an extension method WordCount(…) for class String that counts the number of words in a given string. 

//Notes. 

//1. The 'word' means the sequence of letters, digits, and service symbols, which are limited by a space or punctuation symbol.
//2. Try to use string.Split() method and pass array of delimiters (' ', '.', '?', '!', '-', ';', ':', ',') as the first parameter.

namespace Task2
{
    public static class StringExtensions
    {
        public static int WordCount(this string word)
        {
            return word.Split(new char[] { ' ', '!', '.', '?', ':', ';', ',', '-' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string word = "asd sd";
            int count = word.WordCount();

            Console.WriteLine(count);
        }
    }
}
