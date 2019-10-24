using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputarray = input.ToCharArray();
            Array.Reverse(inputarray);
            string output = new string(inputarray);
            Console.WriteLine(output);
        }
    }
}