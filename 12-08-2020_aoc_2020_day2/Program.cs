using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12_08_2020_aoc_2020_day2
{
    class Program
    {
        static private List<string> inputLines = new List<string>();
        static private Regex r = new Regex(@"^(\d+)(?>-)(\d+)(?>\s)(.)(?>:.)(.+)");
        static private int validCount = 0;
        static private int validPartTwoCount = 0;
        static void Main(string[] args)
        {
            PartTwo();
        }

        static void PartOne() {
            inputLines = File.ReadAllLines("input.txt").ToList();

            // debugging bit to determine group indexes: Group 0 is just the full match text.

            // Group 1 is the MINIMUM number of times the character in Group 3 can appear.
            // Group 2 is the MAXIMUM number of times the character in Group 3 can appear.
            // Group 3 is the character we are counting in Group 4.
            // Group 4 is the string we're evaluating.

            // for (int i = 0; i < r.Match(inputLines[0]).Groups.Count; i++) {
            //     Console.WriteLine($"Group {i}: {r.Match(inputLines[0]).Groups[i]}");
            // }

            // Console.ReadKey();

            int min;
            int max;
            char letter;
            string eval;

            for (int i = 0; i < inputLines.Count; i++) {
                min = Convert.ToInt32(r.Match(inputLines[i]).Groups[1].Value);
                max = Convert.ToInt32(r.Match(inputLines[i]).Groups[2].Value);
                letter = r.Match(inputLines[i]).Groups[3].Value[0];
                eval = r.Match(inputLines[i]).Groups[4].Value;

                if (eval.Where(e => e == letter).Count() >= min && eval.Where(e => e == letter).Count() <= max) {
                    validCount++;
                    Console.WriteLine($"Valid password found: {r.Match(inputLines[i]).Groups[0].Value}\nTotal valid: {validCount}");
                }
                else {
                    Console.WriteLine($"Invalid! {r.Match(inputLines[i]).Groups[0].Value}");
                }
            }

            Console.WriteLine($"\nTotal lines OVERALL: {inputLines.Count}");
            Console.ReadKey();
        }

        static void PartTwo() {
            inputLines = File.ReadAllLines("input.txt").ToList();

            // this one's different

            // Group 1 is an index we're evaluating in Group 4 to look for Group 3's character.
            // Group 2 is another index we're evaluating.
            // Group 3 is the character we are counting in Group 4.
            // Group 4 is the string we're evaluating.

            int firstIndex;
            int secondIndex;
            char letter;
            string eval;
            int correctCount;

            for (int i = 0; i < inputLines.Count; i++) {
                correctCount = 0;

                firstIndex = Convert.ToInt32(r.Match(inputLines[i]).Groups[1].Value);
                secondIndex = Convert.ToInt32(r.Match(inputLines[i]).Groups[2].Value);
                letter = r.Match(inputLines[i]).Groups[3].Value[0];
                eval = r.Match(inputLines[i]).Groups[4].Value;

                if (eval[firstIndex - 1] == letter) {
                    correctCount++;
                }

                if (eval[secondIndex - 1] == letter) {
                    correctCount++;
                }

                if (correctCount == 1) {
                    validPartTwoCount++;
                    Console.WriteLine($"Valid pt2 found! {r.Match(inputLines[i]).Groups[0].Value}. Total pt2: {validPartTwoCount}");
                }
                else {
                    Console.WriteLine($"~ ~ ~ INVALID! {correctCount} indexes matched. {r.Match(inputLines[i]).Groups[0].Value}");
                }
            }

            Console.WriteLine($"\nTotal lines OVERALL: {inputLines.Count}");
            Console.ReadKey();
        }
    }
}
