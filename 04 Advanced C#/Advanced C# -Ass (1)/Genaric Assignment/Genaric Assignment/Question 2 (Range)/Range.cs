using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genaric_Assignment.Question_2__Range_
{
    public class Range<T>where T : IComparable<T>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }

        public Range(T minimum, T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum value cannot be greater than the maximum value.");
            }

            Minimum = minimum;
            Maximum = maximum;
        }
        public  bool IsInRange(T value)
        {
            return (Maximum.CompareTo(value) == 1) && (Minimum.CompareTo(value) ==-1);
        }
        public int Lenth()
        {
            dynamic x = Maximum;
            dynamic y = Minimum;
            return (x-y);
        }

    }
}
