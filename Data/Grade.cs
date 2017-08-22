using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Grade : IValueProvider
    {
        const int MinScore = 1;
        const int MaxScore = 10;

        public Student Student { get; set; }

        public float Value { get; private set; }

        public void SetScore(float score)
        {
            if(score < MinScore)
            {
                throw new ArgumentException($"Score can't be lower than {MinScore}", nameof(score));
            }

            if (score > MaxScore)
            {
                throw new ArgumentException($"Score can't be larger than {MaxScore}", nameof(score));
            }

            Value = score;
        }
    }
}
