using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgressionLibrary
{
    public class Progression
    {
        public static int FindMissingProgression(List<int> numbers)
        {
            var step = (numbers.Last() - numbers.First()) / numbers.Count;
            int current = numbers.First();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] != current)
                {
                    return current;
                }
                
                current += step;
            }

            throw new ArgumentException("No missing values were found in the provided list.");
        }
    }
}
