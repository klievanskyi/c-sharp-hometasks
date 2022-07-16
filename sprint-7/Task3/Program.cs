//Please, create a method ProductWithCondition that takes a list of integers as a parameter and returns a product of elements that satisfy a condition that is passed as a second parameter.

//The second parameter should be a Func that takes an integer as a parameter and returns bool.

//If the first parameter or result of filtering contains 0 elements the method must return 1.

//(You don't need to verify on null parameter values. Assume that parameters will always be not null)

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static int ProductWithCondition(List<int> list, Func<int, bool> predicate)
        {
            var res = list.Where(predicate);
            return res.Count() == 0 ? 1 : res.Aggregate((first, second) => first * second);
        }
    }
}
