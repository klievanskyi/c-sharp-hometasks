//We have class MainThreadProgram. Please create three methods: Calculator, Product and Sum.

//Method Sum() should ask user to enter 5 numbers in form “Enter the 1st number :”, “Enter the 2nd number :” etc.and calculate their sum. After that it should output the message “Sum is <sum>”. 

//Method Product() should generate a List of 10 consequent integer numbers from 1 to 10 and calculate their product. Then it should wait for 10 seconds. After that it should output the message “Product is <product>”. 

//The Calculator() method should create two threads: productThread and sumThread, and call the Product and Sum methods in appropriate threads. This method should return a tuple of two threads: (sumThread, productThread).

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MainThreadProgram.Sum();
            MainThreadProgram.Product();
        }
    }

    class MainThreadProgram
    {
        public static void Sum()
        {
            List<int> list = new List<int>();
            for(int i = 1; i <= 5; i++)
            {
                switch(i)
                {
                    case 1:
                        Console.WriteLine($"Enter the {i}st number:");
                        break;
                    case 2:
                        Console.WriteLine($"Enter the {i}nd number:");
                        break;
                    case 3:
                        Console.WriteLine($"Enter the {i}rd number:");
                        break;
                    default:
                        Console.WriteLine($"Enter the {i}th number:");
                        break;
                }
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine($"Sum is: {list.Sum()}");
        }

        public static void Product()
        {
            List<int> list = Enumerable.Range(1, 10).ToList();
            Thread.Sleep(10000);
            Console.WriteLine($"Product is: {list.Aggregate((acc, elem) => acc *= elem)}");
        }

        public static(Thread, Thread) Calculator()
        {
            Thread productThread = new Thread(Product);
            productThread.Start();

            Thread sumThread = new Thread(Sum);
            sumThread.Start();

            return (sumThread, productThread);
        }
    }
}