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