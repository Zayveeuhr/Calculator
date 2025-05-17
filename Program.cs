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

            Console.WriteLine("\nEnter two numbers split by comma ',' (e.g., 5,10): ");
            var input = Console.ReadLine();

            // Check for empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("\nThat was not a valid entry.");
                return;
            }

            var inputSplit = input.Split(',');

            //Created an int array, so I can pass to method array
            var intNumbers = new int[inputSplit.Length];

            for (int i = 0; i < inputSplit.Length; i++)
            {
                try
                {
                    // Trim each string before converting
                    intNumbers[i] = Convert.ToInt32(inputSplit[i].Trim());
                }
                catch
                {
                    Console.WriteLine("Invalid input. Please enter only numbers.");
                    return;
                }
            }


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
                    Console.WriteLine(Operations.Add(intNumbers));
                    break;
                case "subtract":
                    Console.WriteLine(Operations.Subtract(intNumbers));
                    break;
                case "multiply":
                    Console.WriteLine(Operations.multiply(intNumbers));
                    break;
                case "divide":
                    Console.WriteLine(Operations.Divide(intNumbers.Select(Convert.ToDouble).ToArray()));
                    break;
                default:
                    Console.WriteLine("That is not a valid option");
                    break;
            }
        }

        
    }
}