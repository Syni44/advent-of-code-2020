using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _12_07_2020_aoc_2020_day1
{
    class Program
    {
        static void Main(string[] args)
        {
            PartTwo();
        }

        static void PartOne() {
            List<int> inputs = new List<int>();
            inputs = File.ReadAllLines("input.txt").Select(int.Parse).ToList();

            for (int i = 0; i < inputs.Count - 1; i++) {
                for (int j = i + 1; j < inputs.Count; j++) {
                    if (inputs[i] + inputs[j] == 2020) {
                        Console.WriteLine($"RESULT FOUND:\nLine {i}: {inputs[i]}\nLine {j}: {inputs[j]}");
                        Console.WriteLine($"SUM: {inputs[i] + inputs[j]}\n");

                        Console.WriteLine($"Product of those: {inputs[i]} * {inputs[j]} = {inputs[i] * inputs[j]}");
                        Console.ReadKey();
                    }
                }
            }
        }

        static void PartTwo() {
            List<int> inputs = new List<int>();
            inputs = File.ReadAllLines("input.txt").Select(int.Parse).ToList();

            for (int i = 0; i < inputs.Count - 2; i++) {
                for (int j = i + 1; j < inputs.Count - 1; j++) {
                    for (int k = j + 1; k < inputs.Count; k++) {
                        if (inputs[i] + inputs[j] + inputs[k] == 2020) {
                            Console.WriteLine($"RESULT FOUND:\nLine {i}: {inputs[i]}\nLine {j}: {inputs[j]}\nLine {k}: {inputs[k]}");
                            Console.WriteLine($"SUM: {inputs[i] + inputs[j] + inputs[k]}\n");

                            Console.WriteLine($"Product of those: {inputs[i]} * {inputs[j]} * {inputs[k]} = {inputs[i] * inputs[j] * inputs[k]}");
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}
