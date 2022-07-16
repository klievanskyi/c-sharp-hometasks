//Please, implement the SumOfElementsOddPositions method that returns sum of elements with odd indexes in the array of doubles

//(You don't need to verify on null parameter value. Assume that parameter will always be not null)

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[] { 2, 3, 4, 5 };
            double sum = EvaluateSumOfElementsOddPositions(num);
            Console.WriteLine(sum);
        }

        public static double EvaluateSumOfElementsOddPositions(double[] inputData)
        {
            return inputData.Where((x, i) => i % 2 != 0).Sum();
        }
    }
}
