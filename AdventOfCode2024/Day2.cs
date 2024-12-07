using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class Day2
    {
        private FileReader FileReader { set; get; }

        public Day2(FileReader fr) 
        { 
            FileReader = fr;
        }

        public void Day2Part1()
        {
            Console.WriteLine("This is day2part1");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "inputs/InputDay2.txt");
            List<string> lines = FileReader.ReadFile(path);

            int safeReports = 0;

            foreach (string line in lines) 
            {
                Console.WriteLine(line);

                int[] numbers = line.Split(' ').Select(int.Parse).ToArray();

                int diff = numbers[0] - numbers[1];

                if (diff > 0 && diff < 4)
                {
                    // decreasing
                    Console.WriteLine("Decreasing");
                    int counter = 1;
                    while (counter < numbers.Length)
                    {
                        if (counter == numbers.Length - 1)
                        {
                            Console.WriteLine("Safe");
                            safeReports++;
                            break;
                        }

                        int sum = numbers[counter] - numbers[counter + 1];

                        if (sum <= 0 || sum > 3)
                        {
                            Console.WriteLine("Unsafe");
                            break;
                        }

                        counter++;
                    }


                } else if (diff < 0 && diff > -4)
                {
                    // increasing
                    Console.WriteLine("Increasing");

                    int counter = 1;
                    while (counter < numbers.Length)
                    {
                        if (counter == numbers.Length - 1)
                        {
                            Console.WriteLine("Safe");
                            safeReports++;
                            break;
                        }

                        int sum = numbers[counter] - numbers[counter + 1];

                        if (sum >= 0 || sum < -3)
                        {
                            Console.WriteLine("Unsafe");
                            break;
                        }

                        counter++;
                    }


                } else
                {
                    Console.WriteLine("Unsafe");
                }
            }

            Console.WriteLine($"{safeReports} safe reports");
        }

        public void Day2Part2()
        {
            Console.WriteLine("This is day2part2");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "inputs/InputDay2.txt");
            List<string> lines = FileReader.ReadFile(path);

            int safeReports = 0;

            foreach (string line in lines)
            {
                Console.WriteLine(line);

                int[] numbers = line.Split(' ').Select(int.Parse).ToArray();

                int diff = numbers[0] - numbers[1];

                if (diff > 0 && diff < 4)
                {
                    // decreasing
                    Console.WriteLine("Decreasing");
                    int counter = 1;
                    while (counter < numbers.Length)
                    {
                        if (counter == numbers.Length - 1)
                        {
                            Console.WriteLine("Safe");
                            safeReports++;
                            break;
                        }

                        int sum = numbers[counter] - numbers[counter + 1];

                        if (sum <= 0 || sum > 3)
                        {
                            Console.WriteLine("Unsafe");
                            break;
                        }

                        counter++;
                    }


                }
                else if (diff < 0 && diff > -4)
                {
                    // increasing
                    Console.WriteLine("Increasing");

                    int counter = 1;
                    while (counter < numbers.Length)
                    {
                        if (counter == numbers.Length - 1)
                        {
                            Console.WriteLine("Safe");
                            safeReports++;
                            break;
                        }

                        int sum = numbers[counter] - numbers[counter + 1];

                        if (sum >= 0 || sum < -3)
                        {
                            Console.WriteLine("Unsafe");
                            break;
                        }

                        counter++;
                    }


                }
                else
                {
                    Console.WriteLine("Unsafe");
                }
            }

            Console.WriteLine($"{safeReports} safe reports");
        }
    }
}
