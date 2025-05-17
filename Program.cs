using System.Collections.Immutable;
using System.Text;
using System.Threading.Channels;
using System.Xml.Serialization;
using Calculator;

namespace FirstCalculator
{
    class program
    {
        static void Main(string[] argS)
        {
            StringBuilder borderBuilder = new StringBuilder();
            borderBuilder.Append('-', 10)
                         .AppendLine()
                         .Append("CALCULATOR")
                         .AppendLine()
                         .Append('-', 10);
            Console.WriteLine(borderBuilder);

            Console.WriteLine("\nEnter two numbers split by comma ',': ");
            var input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("\nThat was not a valid entry.");
            }
            var inputSplit = input.Split(',');

            var numOne = Convert.ToInt32(inputSplit[0].Trim());
            var numTwo = Convert.ToInt32(inputSplit[1].Trim());


            Console.WriteLine("\n\t\t\tChoose what you would like to do.\n" +
                              "\nType Add to add the two numbers." +
                              "\nType Subtract to subtract the two numbers." +
                              "\nType Multiply to multiply the two numbers." +
                              "\nType Divide  to divide the numbers.");
            Console.Write("\nEnter choice: ");
            var choice = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(choice))
            {
                Console.WriteLine("\nThat was not a valid entry.");
            }


            switch (choice)
            {
                case "add":
                    Console.WriteLine(Operations.Add(numOne, numOne));
                    break;
                case "subtract":
                    Console.WriteLine(Operations.Subtract(numOne, numTwo));
                    break;
                case "multiply":
                    Console.WriteLine(Operations.multiply(numOne, numTwo));
                    break;
                case "divide":
                    Console.WriteLine(Operations.Divide(numOne, numTwo));
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }

        
    }
}