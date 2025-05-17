using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations
    {
        public static int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public static int Subtract(params int[] numbers2)
        {
            if (numbers2 == null || numbers2.Length == 0)
                return 0; // or throw an exception

            var sum = numbers2[0];
            for (int i = 1; i < numbers2.Length; i++)
            {
                sum -= numbers2[i];
            }

            return sum;
        }

        public static int multiply(params int[] numbers3)
        {
            if (numbers3 == null || numbers3.Length == 0)
                return 0; // or throw an exception

            var sum = 1;
            foreach (var number in numbers3)
            {
                sum *= number;
            }
            return sum;
        }

        public static double Divide(params double[] numbers4)
        {
            if (numbers4 == null || numbers4.Length == 0)
                throw new ArgumentException("At least one number is required.");

            double sum = numbers4[0];

            for (int i = 1; i < numbers4.Length; i++)
            {
                if (numbers4[i] == 0)
                {
                    Console.WriteLine("Cannot divide by zero.");
                    return double.NaN; // or throw exception
                }

                sum /= numbers4[i];
            }

            return sum;
        }

    }
}
