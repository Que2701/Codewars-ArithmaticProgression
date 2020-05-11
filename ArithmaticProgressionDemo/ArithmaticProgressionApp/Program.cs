using ProgressionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmaticProgressionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Progression.FindMissingProgression(new List<int> { 1, 5, 7, 9, 11 }));
            // Allow the user to close the application
            Console.ReadLine();
        }
    }
}
