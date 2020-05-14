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
            var current = numbers.First();
            var missingArithmatic = 0;

            numbers.ForEach(n =>
            {
                if (current == n)
                {
                    current += step;
                }
                else
                {
                    missingArithmatic = current;
                    return;
                }
            });

            return missingArithmatic;
        }
    }
}
