using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class ParallelUtils<T, TR>
    {
        public T operand1;
        public T operand2;
        public Func<T, T, TR> func;
        public TR Result { get; set; }

        public ParallelUtils(Func<T, T, TR> func, T operand1, T operand2)
        {
            this.func = func;
            this.operand1 = operand1;
            this.operand2 = operand2;
        }

        public void StartEvaluation()
        {
            Thread thread = new Thread(() => { Result = func(operand1, operand2); });
            thread.Start();
        }

        public void Evaluate()
        {
            Result = func(operand1, operand2);
        }
    }
}