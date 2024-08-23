using Genaric_Assignment.Question_1__Bubble_Sort_;
using Genaric_Assignment.Question_2__Range_;

namespace Genaric_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            Sorting<int>.BubbleSort(array);
            foreach (int element in array)
            {
                Console.Write($"{element},");
            }
            #endregion

            #region Question 2
            int min = 10, max = 1000;
            Console.Write($"Min= {min} ,Max = {max}\n ");
            int num;
            do
            {
                Console.Write(" Enter num to Check In Range :");

            }
            while (!int.TryParse(Console.ReadLine(), out num));
            Range<int> R = new Range<int>(min, max);
            Console.WriteLine(((R.IsInRange(num)) ? "Is in Range" : "Not in Range"));
            Console.WriteLine($"Range Lenth Equal : {R.Lenth}");
            #endregion

        }
    }
}
