using System;

namespace Lab03_Review
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Challenge 1
                Console.WriteLine("Please enter three numbers separated by spaces:");
                string inputNum = Console.ReadLine();
                int product = Product3Num(inputNum);
                Console.WriteLine($"The product of these 3 numbers is: {product}");

                // Challenge 2
                CalculateAverage();



            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("End of challenges!");
            }
        }

        public static int Product3Num(string inputNum)
        {
            string[] numbers = inputNum.Split(' ');
            int product = 1;

            for (int i = 0; i < 3; i++)
            {
                if (numbers.Length < 3)
                {
                    product = 0;
                }
                else if (i < numbers.Length && int.TryParse(numbers[i], out int number))
                {
                    product *= number;
                }
                else
                {
                    product *= 1;
                }
            }

            return product;
        }

        static void CalculateAverage()
        {
            Console.WriteLine("Please enter a number between 2-10:");
            if (int.TryParse(Console.ReadLine(), out int number) && number >= 2 && number <= 10)
            {
                double sum = 0;
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i + " of " + number + " - Enter a number:");
                    if (double.TryParse(Console.ReadLine(), out double input) && input >= 0)
                    {
                        sum += input;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                        i--; // Repeat the current iteration
                    }
                }

                double average = sum / number;
                Console.WriteLine("The average of these " + number + " numbers is: " + average);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 2-10.");
            }
        }
    }
}
