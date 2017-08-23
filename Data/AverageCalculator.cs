using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class AverageCalculator
    {
        /// <summary>
        /// Calculates the mean average of a provided set of values
        /// </summary>
        public static float CalculateMeanAverage<T>(IEnumerable<T> values) where T : IValueProvider
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            float average = 0f;
            foreach (var value in values)
            {
                average += value.Value;
            }

            // if (values.Count() > 0)
            //{
            average /= values.Count();
            // }

            return average;
        }
    }
}
