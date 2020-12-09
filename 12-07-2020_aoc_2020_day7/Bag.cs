using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12_07_2020_aoc_2020_day7 {
    public class Bag {
        // init
        public string Name {get; set;}
        public List<string> InternalBagNames = new List<string>();
        public string FullText {get; set;}

        // private fields
        private Regex r = new Regex(@"(?<=\d\s)(.+?)(?=\sbag)");

        // ctor
        public Bag(string name, string fullText) {
            Name = name;
            FullText = fullText;
        }

        public void GetInternalBags() {
            for (int i = 0; i < r.Matches(FullText).Count; i++) {
                if (r.Matches(FullText).Count == 0) {
                    Console.WriteLine($"{this.Name} has no bags inside!");
                    break;
                }

                InternalBagNames.Add(r.Matches(FullText)[i].Value);
                Console.WriteLine($"Inside {this.Name}, {r.Matches(FullText)[i].Value} was found.");
            }

            Console.WriteLine();
        }
    }
}