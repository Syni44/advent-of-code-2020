using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _12_06_2020_aoc_2020_day6
{
    class Program
    {
        static void Main(string[] args)
        {
            PartOne();
        }

        static void PartOne() {
            /*
            We're gonna read from input.txt. Divide/split the input into groups, separated by successive
            newlines.

            For each group, we count the number of unique characters (a-z).

            Sum up the total for all groups.
            */

            List<string> groups = new List<string>();
            int allGroupsSum = 0;
            
            groups = File.ReadAllText("input.txt")
                .Split(new String[] {Environment.NewLine + Environment.NewLine}, StringSplitOptions.None)
                .ToList();

            Console.WriteLine(groups.Count);

            for (int i = 0; i < groups.Count; i++) {
                int uniqueCharsInGroup = groups[i].Distinct().Count(e => Char.IsLetter(e));
                allGroupsSum += uniqueCharsInGroup;

                Console.WriteLine($"This group has {uniqueCharsInGroup} unique yes votes");
                Console.WriteLine($"In total, all groups together have {allGroupsSum} unique yes votes" + "\n");
            }

            Console.WriteLine($"TOTAL SUM: {allGroupsSum}");

            Console.ReadKey();
        }

        static void PartTwo() {
            char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o',
                'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            List<string> groups = new List<string>();
            int allGroupsSum = 0;
            
            groups = File.ReadAllText("input.txt")
                .Split(new String[] {Environment.NewLine + Environment.NewLine}, StringSplitOptions.None)
                .ToList();

            Console.WriteLine(groups.Count);

            for (int i = 0; i < groups.Count; i++) {
                List<string> lines = new List<string>();
                lines = groups[i].Split("\n").ToList();

                for (int j = 0; j < alphabet.Count(); j++) {
                    lines.All(e => e.Contains())
                }
            }
        }
    }
}
