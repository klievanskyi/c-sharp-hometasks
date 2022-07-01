//Create a program that can be used for calculation of 4 arithmetic operations (+, -, *, /) according to tasks:

//1) declare a delegate CalcDelegate referring to a function Calc with three parameters (two numbers and one - operation sign) and a numerical result;

//2) define a class CalcProgram and within this class:

//2.1) define a static function Calc for computation with the same signature as the delegate. Note: in case of denominator = 0, the function returns 0.

//2.2) create a public object funcCalc of delegate type and pass the function Calc as an argument.

namespace Task1
{

    class CalcProgram
    {
        public delegate int CalcDelegate(int first, int second, char operation);

        public CalcDelegate funcCalc = Calc;

        public static int Calc(int first, int second, char operation)
        {
            int result = 0;
            switch(operation)
            {
                case '-':
                    result = first - second;
                    break;
                case '+':
                    result = first + second;
                    break;
                case '*':
                    result = first * second;
                    break;
                case '/':
                    result = second <= 0 ? result : first / second;
                    break;
            }
            return result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}