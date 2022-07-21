//Suppose we have a class named Calc which has a method Seq
//generating n-th member of a certain number sequence (starting from 1).

//Define a class named CalcAsync.In this class:

//Write an asynchronous static method PrintSeqAsync taking integer parameter n,
//that prints out the following:
//"Seq[X] = Y", where X is the value of input parameter n, Y is n-th member of the sequence.
//Use void as return type.

using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class CalcAsync
    {
        public static async void PrintSeqAsync(int n)
        {
            await Task.Run(() => Console.WriteLine($"Seq[{n}] = {Calc.Seq(n)}"));
        }
    }
}