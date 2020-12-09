using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12_07_2020_aoc_2020_day7 {
    static class TextParser {
        // public static Bag MakeBag(string bagInput) {
        //     // getting the bag name might be useful in its own method, done prior. it
        //     // could save time by preventing trying to make a new bag for a bag that
        //     // has already been added to the bag dictionary

        //     string bagName;
        //     string bagContents;

        //     // take while the character is not an empty space with the word "bag" after it
        //     // this smells like a regex thing
        //     Regex r = new Regex(@"^.+?(?=\sbag)");

        //     bagName = r.Match(bagInput).Value;

        //     Console.WriteLine($"{bagName} recorded as name.");
        //     Console.ReadKey();

        //     // make bag here
            
        //     Bag bag = new Bag(bagName, new List<Bag>());
        //     Program.BagList.Add(bagName, bag);
        //     return bag;
        // }
    }
}