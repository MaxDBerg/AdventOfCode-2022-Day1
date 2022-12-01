using System.IO;
using System.Linq;

namespace AdventOfCode_2022_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElfInventory.ConvertRawData(); // Converts the raw input data to a usable format

            ElfInventory.PrintElfWithMostCalories(); // Prints the Elf carrying the most calories

            ElfInventory.PrintTopThreeElvesWithMostCalories(); // Prints the Top Three Elves carrying the most calories
        }
    }
}
