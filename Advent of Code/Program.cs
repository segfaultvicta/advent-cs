using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which year/day/side? i.e. 2015.12.b");

            string select = Console.ReadLine();
            string[] selectParts = select.Split('.');

            var solution = SelectSolution(selectParts[0], selectParts[1]);

            // check for the existence of a class defined for that year/day/side

            Console.WriteLine("What file shall we use for input?");

            string infile = Console.ReadLine();
            if (infile.Length == 0) {
                infile = select;
            }

            StreamReader file;
            if (File.Exists(infile)) {
                file = new StreamReader(infile);
            }
            else
            {
                Console.WriteLine("ERROR: file '" + infile + "' does not exist.");
                Console.ReadKey();
                return;
            }

            // call the selected solution method, passing it the input file as parameters
            if (selectParts[2] == "a")
            {
                solution.A(file);
            }
            else
            {
                solution.B(file);
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        private static Solution SelectSolution(string year, string day)
        {
            switch (year) {
                case "2015":
                    switch (day) {
                        case "1": return new Advent.Fifteen.Day1();
                        case "2": return new Advent.NullSolution();
                        case "3": return new Advent.NullSolution();
                        case "4": return new Advent.NullSolution();
                        case "5": return new Advent.NullSolution();
                        case "6": return new Advent.NullSolution();
                        case "7": return new Advent.NullSolution();
                        case "8": return new Advent.NullSolution();
                        case "9": return new Advent.NullSolution();
                        case "10": return new Advent.NullSolution();
                        case "11": return new Advent.NullSolution();
                        case "12": return new Advent.NullSolution();
                        case "13": return new Advent.NullSolution();
                        case "14": return new Advent.NullSolution();
                        case "15": return new Advent.NullSolution();
                        case "16": return new Advent.NullSolution();
                        case "17": return new Advent.NullSolution();
                        case "18": return new Advent.NullSolution();
                        case "19": return new Advent.NullSolution();
                        case "20": return new Advent.NullSolution();
                        case "21": return new Advent.NullSolution();
                        case "22": return new Advent.NullSolution();
                        case "23": return new Advent.NullSolution();
                        case "24": return new Advent.NullSolution();
                        case "25": return new Advent.NullSolution();
                    }
                    break;
                case "2016":
                    switch (day) {
                        case "1": return new Advent.NullSolution();
                        case "2": return new Advent.NullSolution();
                        case "3": return new Advent.NullSolution();
                        case "4": return new Advent.NullSolution();
                        case "5": return new Advent.NullSolution();
                        case "6": return new Advent.NullSolution();
                        case "7": return new Advent.NullSolution();
                        case "8": return new Advent.NullSolution();
                        case "9": return new Advent.NullSolution();
                        case "10": return new Advent.NullSolution();
                        case "11": return new Advent.NullSolution();
                        case "12": return new Advent.NullSolution();
                        case "13": return new Advent.NullSolution();
                        case "14": return new Advent.NullSolution();
                        case "15": return new Advent.NullSolution();
                        case "16": return new Advent.NullSolution();
                        case "17": return new Advent.NullSolution();
                        case "18": return new Advent.NullSolution();
                        case "19": return new Advent.NullSolution();
                        case "20": return new Advent.NullSolution();
                        case "21": return new Advent.NullSolution();
                        case "22": return new Advent.NullSolution();
                        case "23": return new Advent.NullSolution();
                        case "24": return new Advent.NullSolution();
                        case "25": return new Advent.NullSolution();
                    }
                    break;
            }
            return new Advent.NullSolution();
        }

        private static int DayTwo(string line)
        {
            var split = line.Split('x');
            int l = Convert.ToInt32(split[0]);
            int w = Convert.ToInt32(split[1]);
            int h = Convert.ToInt32(split[2]);
            int[] areas = new int[3];
            int[] perims = new int[3];
            areas[0] = l * w;
            areas[1] = w * h;
            areas[2] = h * l;
            perims[0] = l * 2 + w * 2;
            perims[1] = w * 2 + h * 2;
            perims[2] = h * 2 + l * 2;
            int sideA = 2 * areas[0] + 2 * areas[1] + 2 * areas[2] + areas.Min();
            int sideB = l * w * h + perims.Min();
            return sideB;
        }

    }
}
