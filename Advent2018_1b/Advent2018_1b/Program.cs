using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advent2018_1b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("../../input.txt");
            List<int> frequencies = new List<int>();
            int frequency = 0;
            int round = 0;
            int i = 0;

            while (i < lines.Length)
            {
                frequency += Int32.Parse(lines[i]);
                Console.WriteLine("New frequency: " + frequency);
                if (frequencies.Contains(frequency)) { 
                    Console.WriteLine("It's a frequency " + frequency);
                    break;
                } else if (i >= lines.Length - 1)
                {
                    i = 0;
                    frequencies.Add(frequency);
                    Console.WriteLine("Round: " + round++);
                }
                else
                {
                    i++;
                    frequencies.Add(frequency);
                }
                   

            }

            //Console.WriteLine("It's a frequency " + frequency);
            Console.WriteLine("Finished. press a button...");
            Console.ReadKey();

        }
    }
}
