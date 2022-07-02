//Define a static method ListWithPositive that receives the List of negative and positive elements as a parameter. 

//The method  ListWithPositive uses the FindAll method on the List type. The argument to FindAll will use the anonymous method syntax. The predicate in FindAll will use a boolean expression that is evaluated, causing the anonymous function to return true if the argument is positive and less then or equal 10.

//The method  ListWithPositive returns the list of positive elements.

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 5, 2, -1, 0 };
            var result = ListProgram.ListWithPositive(list);
            foreach(var val in result)
            {
                Console.WriteLine(val);
            }
        }
    }

    public class ListProgram
    {
        public static List<int> ListWithPositive(List<int> values)
        {
            return values.FindAll(value => value > 0 && value <= 10);
        }
    }

}
