using System.IO;
using System.Linq;

namespace AdventOfCode_2022_Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElfInventory.ConvertRawData();

            ElfInventory.PrintElfWithMostCalories();

            ElfInventory.PrintTopThreeElvesWithMostCalories();
        }
    }
}