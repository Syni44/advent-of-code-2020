using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _12_09_2020_aoc_2020_day4
{
    class Program
    {
        static List<string> inputLines = new List<string>();
        static List<string> passports = new List<string>();
        static List<string> validList = new List<string>();
        static int validPassports = 0;
        static void Main(string[] args)
        {
            PartOne();
        }

        static void PartOne() {
            inputLines = File.ReadAllLines("input.txt").ToList();

            string buffer = "";
            for (int i = 0; i < inputLines.Count; i++) {
                if (inputLines[i] != "") {
                    buffer += " " + inputLines[i];
                }
                else {
                    passports.Add(buffer);

                    Console.WriteLine($"New passport identified:\n{buffer}\nPassports count: {passports.Count}\n");
                    buffer = "";
                }
            }

            Console.WriteLine($"Done counting passports\nTotal lines read: {inputLines.Count}");
            Console.ReadKey();

            // determining which are valid
            for (int i = 0; i < passports.Count; i++) {
                if (passports[i].Contains("byr:") && passports[i].Contains("iyr:") && passports[i].Contains("eyr:")
                    && passports[i].Contains("hgt:") && passports[i].Contains("hcl:") && passports[i].Contains("ecl:")
                    && passports[i].Contains("pid:")) {
                        validPassports++;
                        validList.Add(passports[i]);
                        Console.WriteLine($"Valid passport found:\n{passports[i]}\nTotal valid found: {validPassports}\n");
                    }
            }

            Console.WriteLine($"Done determining valid passports\nTotal valid: {validPassports}\nTotal passports: {passports.Count}");
            Console.ReadKey();

            // PART TWO
            for (int i = 0; i < validList.Count; i++) {
                if (Convert.ToInt32(validList[i].Substring(validList[i].IndexOf("byr:") + 4, 5)) >= 1920
                    && Convert.ToInt32(validList[i].Substring(validList[i].IndexOf("byr:") + 4, 5)) <= 2002
                    
                && Convert.ToInt32(validList[i].Substring(validList[i].IndexOf("iyr:") + 4, 5)) >= 2010
                    && Convert.ToInt32(validList[i].Substring(validList[i].IndexOf("iyr:") + 4, 5)) <= 2020
                    
                && Convert.ToInt32(validList[i].Substring(validList[i].IndexOf("eyr:") + 4, 5)) >= 2020
                    && Convert.ToInt32(validList[i].Substring(validList[i].IndexOf("eyr:") + 4, 5)) <= 2030
                    
                && )
            }
        }
    }
}
