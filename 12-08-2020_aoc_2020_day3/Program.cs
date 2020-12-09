using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;

namespace _12_08_2020_aoc_2020_day3
{
    class Program
    {
        private static List<string> inputMap = new List<string>();
        private static Vector2 position = new Vector2();
        private static int modValue = 0;
        private static int treeCount = 0;

        static void Main(string[] args)
        {
            PartOne();
        }

        static void PartOne() {
            inputMap = File.ReadAllLines("input.txt").ToList();
            modValue = inputMap[0].Count();

            while ((position.Y + 1) <= inputMap.Count) {
                Descend();
            }

            Console.WriteLine($"\nTOTAL TREES encountered: {treeCount}");
            Console.ReadKey();
        }

        static void Descend() {
            // check for tree and iterate if found
            if (inputMap[(int)position.Y][(int)position.X % modValue] == '#') {
                treeCount++;
                Console.WriteLine($"TREE FOUND at row {(int)position.Y}. Total trees seen: {treeCount}");
            }

            // calculate next step and update position
            position = new Vector2(position.X + 3, position.Y + 1);
        }
    }
}
