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
