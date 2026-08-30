using System;
using System.Text;

namespace depi_day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1 - Parse and Convert
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();

            try
            {
                int number1 = int.Parse(input);
                int number2 = Convert.ToInt32(input);

                Console.WriteLine("Using int.Parse: " + number1);
                Console.WriteLine("Using Convert.ToInt32: " + number2);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format. Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("The number is too large or too small.");
            }


            // Q2 - TryParse
            Console.Write("\nEnter an integer: ");
            string input2 = Console.ReadLine();

            if (int.TryParse(input2, out int number))
            {
                Console.WriteLine("Valid number: " + number);
            }
            else
            {
                Console.WriteLine("Error: Invalid integer.");
            }


            // Q3 - GetHashCode
            object obj;

            obj = 10;
            Console.WriteLine("\nInteger HashCode: " + obj.GetHashCode());

            obj = "Hello";
            Console.WriteLine("String HashCode: " + obj.GetHashCode());

            obj = 10.5;
            Console.WriteLine("Double HashCode: " + obj.GetHashCode());


            // Q4 - Reference Equality
            MyClass first = new MyClass();
            first.Value = 10;

            MyClass second = first;

            first.Value = 20;

            Console.WriteLine("\nValue using first reference: " + first.Value);
            Console.WriteLine("Value using second reference: " + second.Value);

            Console.WriteLine("Are both references pointing to the same object? "
            + ReferenceEquals(first, second));


            // Q5 - String Immutability
            string text = "Hello";

            Console.WriteLine("\nHashCode before modification: "
            + text.GetHashCode());

            text = text + " Hi Willy";

            Console.WriteLine("HashCode after modification: "
            + text.GetHashCode());

            Console.WriteLine("Modified string: " + text);


            // Q6 - StringBuilder
            StringBuilder sb = new StringBuilder("Hello");

            Console.WriteLine("\nStringBuilder HashCode before modification: "
            + sb.GetHashCode());

            sb.Append(" Hi Willy");

            Console.WriteLine("StringBuilder HashCode after modification: "
            + sb.GetHashCode());

            Console.WriteLine("Modified StringBuilder: " + sb);


            // Q7 - String Formatting
            Console.Write("\nEnter first number: ");
            int input1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int input3 = int.Parse(Console.ReadLine());

            int sum = input1 + input3;

            // Concatenation
            Console.WriteLine("Sum is " + input1 + " + " + input3 + " = " + sum);

            // Composite Formatting
            Console.WriteLine(string.Format(
            "Sum is {0} + {1} = {2}", input1, input3, sum));

            // String Interpolation
            Console.WriteLine($"Sum is {input1} + {input3} = {sum}");


            // Q8 - StringBuilder Methods
            StringBuilder builder = new StringBuilder("Hello World");

            // Append
            builder.Append("!");

            // Replace
            builder.Replace("World", "Willy");

            // Insert
            builder.Insert(0, "Hi ");

            // Remove
            builder.Remove(0, 3);

            Console.WriteLine("\nFinal StringBuilder: " + builder);
        }
    }

    class MyClass
    {
        public int Value { get; set; }
    }
}
    

