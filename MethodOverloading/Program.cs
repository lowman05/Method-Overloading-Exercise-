using System.Data;
using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sum = Add(1, 2);
            Console.WriteLine(sum);
            var sumDouble = Add(1.5, 2.5);
            Console.WriteLine(sumDouble);
            Add(1, 2, true);


        }
        public static int Add(int num1, int num2)

        {
            return num1 + num2;
        }
        public static double Add(double num1, double num2)

        {
            return num1 + num2;
        }
        public static void Add(int num1, int num2, bool isTrue)

        {
            var sum = num1 + num2;

            if (isTrue == true && sum == 1)
            {
                Console.WriteLine($"{sum} dollars");
            }
            else if (isTrue == true && sum > 1)
            {
                Console.WriteLine($"{sum} dollars");
            }
            else
            {
                Console.WriteLine(sum);
            }

        }
    }
}
