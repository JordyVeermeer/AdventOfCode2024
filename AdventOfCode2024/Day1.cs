using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024
{
    public class Day1
    {
        private FileReader FileReader { set; get; }

        public Day1(FileReader fr) 
        {
            FileReader = fr;
        }

        public void Day1Part1()
        {
            Console.WriteLine("This is day1part1");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "InputDay1.txt");
            List<string> lines = FileReader.ReadFile(path);

            int[] arrLeft = new int[lines.Count];
            int[] arrRight = new int[lines.Count];


            for (int i = 0; i < lines.Count; i++) 
            {
                arrLeft[i] = int.Parse(lines[i].Substring(0, 5));
                arrRight[i] = int.Parse(lines[i].Substring(8, 5));
            }

            Array.Sort(arrLeft);
            Array.Sort(arrRight);

            //foreach (int num in arrLeft) 
            //{
            //    Console.WriteLine(num);
            //}

            //foreach (int num in arrRight)
            //{
            //    Console.WriteLine(num);
            //}

            int totalDistance = 0;

            // Calculate distances
            for (int i = 0; i < arrLeft.Length; i++) 
            {
                int distance = Math.Abs(arrLeft[i] - arrRight[i]);
                Console.WriteLine($"Absolute distance between {arrLeft[i]} and {arrRight[i]} is {distance}");
                totalDistance += distance;
            }

            Console.WriteLine($"Total distance is {totalDistance}");
        }

        public void Day1Part2()
        {
            Console.WriteLine("This is day1part2");

            var path = Path.Combine(Directory.GetCurrentDirectory(), "InputDay1.txt");
            List<string> lines = FileReader.ReadFile(path);

            int[] arrLeft = new int[lines.Count];
            int[] arrRight = new int[lines.Count];


            for (int i = 0; i < lines.Count; i++)
            {
                arrLeft[i] = int.Parse(lines[i].Substring(0, 5));
                arrRight[i] = int.Parse(lines[i].Substring(8, 5));
            }

            Dictionary<int, int> rightList = new Dictionary<int, int>();

            for (int i = 0; i < arrRight.Length; i++) 
            {
                if (!rightList.ContainsKey(arrRight[i]))
                {
                    rightList.Add(arrRight[i], 1);
                } else
                {
                    rightList[arrRight[i]]++;
                }
            }

            int totalSimilarityScore = 0;

            for (int i = 0; i < arrLeft.Length; i++) 
            {
                if (rightList.ContainsKey(arrLeft[i]))
                {
                    totalSimilarityScore += arrLeft[i] * rightList[arrLeft[i]];
                }
            }

            Console.WriteLine($"Total Similarity Score is {totalSimilarityScore}");

        }
    }
}
