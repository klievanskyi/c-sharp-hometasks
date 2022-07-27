namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //CalcAsync.PrintSeqElementscaInParallelAsync(5);
            CalcAsync.PrintSeqElementsConsequentlyAsync(5);
            Console.WriteLine("Hello World!");
        }
    }

    public static class Calc
    {
        public static int Seq(int n)
        {
            return n + 1;
        }
    }

    public static class CalcAsync
    {
        public static async Task<int> SeqAsync(int n) => await Task.Run(() => Calc.Seq(n));

        public static async void PrintSeqElementsConsequentlyAsync(int quant)
        {
            for(int i = 1; i <= quant; i++)
            {
                Console.WriteLine($"Seq[{i}] = {await SeqAsync(i)}");
            }
        }

        public static async void PrintSeqElementsInParallelAsync(int quant)
        {
            var task = GetSeqAsyncTasks(quant);
            for(int i = 0; i < task.Length; i++)
            {
                await Task.Run(() => Console.WriteLine($"Seq[{i + 1}] = {task[i].Result}"));
            }
        }

        public static Task<int>[] GetSeqAsyncTasks(int n)
        {
            Task<int>[] tasks = new Task<int>[n];
            Parallel.For(0, tasks.Length, i => tasks[i] = Task.Run(() => Calc.Seq(i + 1)));
            return tasks;
        }
    }
}