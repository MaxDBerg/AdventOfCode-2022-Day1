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

        public static void ConvertRawData()
        {
            uint totalCaloriesForOneElf;
            List<uint> oneElfCalories = new List<uint>();
            foreach (string line in File.ReadLines(@"")) //Change this to the Codepath for the ElvesCalories.txt file
            {
                totalCaloriesForOneElf = 0;
                if (line == "")
                {
                    foreach (uint item in oneElfCalories)
                    {
                        totalCaloriesForOneElf += item;
                    }
                    oneElfCalories.Clear();
                    _inventory.Add(totalCaloriesForOneElf);
                }
                else
                {
                    oneElfCalories.Add(uint.Parse(line));
                }
            }
        }

        public static void PrintElfWithMostCalories()
        {
            Console.WriteLine("The Elf carrying the most, carries {0} Calories", _inventory.Max());
        }

        public static void PrintTopThreeElvesWithMostCalories()
        {
            Console.WriteLine("The Top Three Elves are carrying {0} Calories", CheckTopThreeElves());
        }

        public static uint CheckTopThreeElves()
        {
            List<uint> topThreeElves = new List<uint>();
            uint totalTopThreeElves = 0;

            for (int i = 0; i < 3; i++)
            {
                topThreeElves.Add(_inventory.Max());
                _inventory.Remove(_inventory.Max());
            }

            foreach (uint item in topThreeElves)
            {
                totalTopThreeElves += item;
            }

            return totalTopThreeElves;
        }
    }
}
