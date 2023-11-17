using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabLibrary;

namespace LabLibraryTest
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write(LogCalc.Ln(5));
            Console.Write("  ");
            Console.WriteLine(LogCalc.Ln(5) == Math.Log(5));
            Console.Write(LogCalc.Lg(5));
            Console.Write("  ");
            Console.WriteLine(LogCalc.Lg(5) == Math.Log10(5));
            Console.ReadKey();
        }
    }
}
