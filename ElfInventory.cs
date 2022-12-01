using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode_2022_Day1
{
    internal class ElfInventory
    {
        public static List<uint> _inventory = new List<uint>();

        public static void ConvertRawData() // Converts the raw input data
        {
            uint totalCaloriesForOneElf; // Stores the calories one elf is carrying
            List<uint> oneElfCalories = new List<uint>();
            foreach (string line in File.ReadLines(@"")) //Change this to the Codepath for the ElvesCalories.txt file
            {
                totalCaloriesForOneElf = 0; // Sets the variable to 0 for the next Elf
                if (line == "") // Checks if the line is blank
                {
                    foreach (uint item in oneElfCalories) // Loops through the List<>
                    {
                        totalCaloriesForOneElf += item; // Adds the calories of one item to an elf
                    }
                    oneElfCalories.Clear(); // Clears the List<> now that we dont need it
                    _inventory.Add(totalCaloriesForOneElf); // Adds the total calories for that Elf to the _inventory List<>
                }
                else // if the line actually contains something we add it to the List<>
                {
                    oneElfCalories.Add(uint.Parse(line)); // Adding the line to the List<>
                }
            }
        }
        
        
        // Prints the calories the Top Elf is carrying
        public static void PrintElfWithMostCalories()
        {
            Console.WriteLine("The Elf carrying the most, carries {0} Calories", _inventory.Max());
        }
        
        
        // Prints the calories the Top Three Elves are carrying
        public static void PrintTopThreeElvesWithMostCalories()
        {
            Console.WriteLine("The Top Three Elves are carrying {0} Calories", CheckTopThreeElves());
        }
        
        
        // Checks how many calories the Top Three Elves are carrying
        public static uint CheckTopThreeElves()
        {
            List<uint> topThreeElves = new List<uint>(); // The individual Ammounts
            uint totalTopThreeElves = 0; // The Summed Amount

            for (int i = 0; i < 3; i++)
            {
                topThreeElves.Add(_inventory.Max()); // Adds the Top Elf to the topThreeElves List<>
                _inventory.Remove(_inventory.Max()); // Removes the Top Elf from the _inventory List<>
            }

            foreach (uint item in topThreeElves)
            {
                totalTopThreeElves += item; // Adds one of the Top Three Elves to the total
            }

            return totalTopThreeElves; // returns the Summed Amount
        }
    }
}
