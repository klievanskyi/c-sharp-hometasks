//In class MyProgram :
//  1) Create a method that should take a collection of arguments Position(List<int> numbers) in which find and Console.WriteLine all positions of element 5 in this collection

//  2) Create a method that should take a collection of arguments Remove(List<int> numbers) in which remove from collection all elements, which are greater than 20. and print collection

//  3) Create a method that should take a collection of arguments Insert(List<int> numbers)  in which insert elements -5,-6,-7 in positions 3, 6, 8 and print collection

//  4) Create a method that should take a collection of arguments Sort(List<int> numbers) in which sorting collection and print collection

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2, 5, 23, -1, 5 };
        }
    }

    public class MyProgram
    {
        public static void Position(List<int> numbers)
        {
            for(var i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == 5)
                {
                    Console.WriteLine(i + 1);
                }
            }
        }

        public static void Remove(List<int> numbers)
        {
            numbers.Where(i => i <= 20).ToList().ForEach(i => Console.WriteLine(i));
        }

        public static void Insert(List<int> numbers)
        {
            numbers.Insert(2, -5);
            numbers.Insert(5, -6);
            numbers.Insert(7, -7);
            numbers.ForEach(i => Console.WriteLine(i));
        }

        public static void Sort(List<int> numbers)
        {
            numbers.Sort();
            numbers.ForEach(i => Console.WriteLine(i));
        }
    }
}
