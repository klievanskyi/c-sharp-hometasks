//Inside a class ShowPower define a static method SuperPower(). SuperPower() has two integer input parameters: number and degree. The method will  calculate the power of a given number according to degree parameter.

//Note: Don 't use Pow().

//The method involves to yield the intermediate result of the calculation on the each iteration.

//For example, when calling the method SuperPower():

//for (float item in SuperPower(3, 4))
//{
//    Console.WriteLine("{0} ", item);
//}

//Output:
//3
//9
//27
//81

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class ShowPower
    {
        public static IEnumerable<float> SuperPower(int num, int degree)
        {
            float result = 1;
            if (degree == 0)
            {
                yield return 1;
            }
            else if (num == 0)
            {
                yield return 0;
            }
            else if (degree > 0)
            {
                for (int i = 0; i < degree; i++)
                {
                    yield return result *= num;
                }

            }
            else if (degree < 0)
            {
                for (int i = 0; i > degree; i--)
                {
                    yield return result /= num;
                }
            }
        }
    }
}
