using System.IO;
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
                //Console.WriteLine("Please enter three numbers separated by spaces:");
                //string inputNum = Console.ReadLine();
                //int product = Product3Num(inputNum);
                //Console.WriteLine($"The product of these 3 numbers is: {product}");

                // Challenge 2
                //CalculateAverage();

                // Challenge 3
                //PrintPattern();

                // Challenge 4
                //Console.Write("Please enter array elements you want to find most appears element: ");
                //string? arr = Console.ReadLine()!;
                //string[] arrElements = arr.Split(' ');

                //int[] ints = new int[arrElements.Length];

                //for (int i = 0; i < arrElements.Length; i++)
                //{
                  //  int.TryParse(arrElements[i], out ints[i]);

                //}
                //int MostAppearsNumber = MostAppearsNumberInArray(ints);
                //Console.WriteLine($"Most Appears Number In This Array is {MostAppearsNumber}");

                // Challenge 5
                //Console.Write("Please enter array elements you want to find max value element: ");
                //string? arr2 = Console.ReadLine()!;
                //if (arr2.Length < 1) throw new Exception("The array cannot be null!");
                //string[] arrElements2 = arr2.Split(' ');

                //int[] ints2 = new int[arrElements2.Length];

                //for (int i = 0; i < arrElements2.Length; i++)
                //{
                  //  int.TryParse(arrElements2[i], out ints2[i]);

                //}
              //  int maxValue = MaxValueInArray(ints2);
                //Console.WriteLine(maxValue);

                // Challenge 6
                string path = "../../../TextFile1.txt";
                
                WriteWord(path);
                ReadFileText(path);

                // Challenge 7
                ReadWord(path);

                // Challenge 8
                Console.WriteLine("Enter the word to remove:");
                string wordToRemove = Console.ReadLine();
                RemoveWordFromFile(path, wordToRemove);
                Console.WriteLine("Word removed successfully.");

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


        public static void CalculateAverage()
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
                        i--; 
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


        static void PrintPattern()
        {
            int size = 5;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            for (int i = size - 2; i >= 0; i--)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }

        public static int MostAppearsNumberInArray(int[] numbers)
        {
            Dictionary<int, int> counts = new();

            foreach (int number in numbers)
            {
                if (counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts[number] = 1;
                }
            }

            int maxCount = counts.Values.Max();
            int mostFrequentNumber = numbers[0];

            foreach (int number in numbers)
            {
                if (counts[number] == maxCount)
                {
                    mostFrequentNumber = number;
                    break;
                }
            }

            return mostFrequentNumber;
        }

        public static int MaxValueInArray(int[] numbers)
        {
            if (numbers.Length <= 0)
                throw new Exception("The array cannot be empty.");


            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            return max;
        }


        static void ReadFileText(string path)
        {
            string dataFromFile = File.ReadAllText(path);


            Console.WriteLine(dataFromFile);
        }

        static void WriteWord(string path)
        {
            Console.WriteLine("Enter a word:");
            string word = Console.ReadLine();

            File.AppendAllText(path, word + " ");
        }

        static void ReadWord(string path)
        {
            string[] lines = File.ReadAllLines(path);
            int i = 0;
            foreach (string line in lines)
            {
                Console.WriteLine($"{line} in {i}");
                i++;
            }
        }

        public static void RemoveWordFromFile(string path, string wordToRemove)
        {
           string[] lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == wordToRemove)
                {
                    lines[i] = string.Empty;
                }
            }

            File.WriteAllLines(path, lines);
        }
    }
}
