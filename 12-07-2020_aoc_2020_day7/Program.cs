using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12_07_2020_aoc_2020_day7
{
    class Program
    {
        public static List<Bag> bagList = new List<Bag>();
        public static List<string> parentLog = new List<string>();
        public static List<string> input = new List<string>();

        private static int parentsOfShinyGold;
        private static string outerParent;

        static void Main(string[] args)
        {
            PartOne();
        }

        static void PartOne() {
            input = File.ReadAllLines("input.txt").ToList();
            string bagName;

            // take while the character is not an empty space with the word "bag" after it
            // this smells like a regex thing
            Regex r = new Regex(@"^.+?(?=\sbag)");

            for (int i = 0; i < input.Count; i++) {
                bagName = r.Match(input[i]).Value;

                bagList.Add(new Bag(bagName, input[i]));
                bagList[i].GetInternalBags();
            }

            for (int i = 0; i < bagList.Count; i++) {
                if (bagList[i].Name != "shiny gold") {
                    outerParent = bagList[i].Name;
                    RecurseBags(bagList[i]);
                }
            }

            Console.ReadKey();
        }

        static void RecurseBags(Bag bag) {
            if (bag.Name == "shiny gold") {
                if (!parentLog.Contains(outerParent)) {
                    parentsOfShinyGold++;
                    Console.WriteLine($"Parent found!! {outerParent} eventually contains shiny gold bags. Total parents: {parentsOfShinyGold}");
                    parentLog.Add(outerParent);
                    return;
                }
            }

            for (int i = 0; i < bag.InternalBagNames.Count; i++) {
                RecurseBags(bagList.FirstOrDefault(e => e.Name == bag.InternalBagNames[i]));
            }
        }
    }
}
