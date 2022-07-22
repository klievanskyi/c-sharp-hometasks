using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcAsync.TaskPrintSeqAsync(4);
            CalcAsync.TaskPrintSeqAsync(3);
            Console.WriteLine("Hello World!");
        }
    }

    public static class Calc
    {
        public static int Seq(int n)
        {
            Random rnd = new Random(10);
            int value = rnd.Next(0, 10);
            return value;
        }
    }

    public static class CalcAsync
    {
        public static async Task TaskPrintSeqAsync(int n)
        {
            await Task.Run(() => Console.WriteLine($"Seq[{n}] = {Calc.Seq(n)}"));
        }

        public static void PrintStatusIfChanged(this Task task, ref TaskStatus prevTaskStatus)
        {
            if (task.Status > prevTaskStatus)
            {
                prevTaskStatus = task.Status;
            }
        }

        public static void TrackStatus(this Task task)
        {
            TaskStatus status = TaskStatus.Created;
            while (status != TaskStatus.RanToCompletion)
            {
                task.PrintStatusIfChanged(ref status);
            }
        }
    }
}