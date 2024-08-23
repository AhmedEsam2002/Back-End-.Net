namespace Genaric_Assignment.Question_1__Bubble_Sort_
{
    public class Sorting<T> where T : IComparable<T>
    {
        public static void Swap(ref T x, ref T y)
        {
            T tmp = x;
            x = y;
            y = tmp;
        }

        public static void BubbleSort(T[] array, int Num_of_Sorted)
        {
            if (array is not null)
            {
                bool flag = true;/// if swaped or not (if not mean array is sorted)
                for (int i = 0; i < Num_of_Sorted && flag; i++)
                {
                    flag = false;
                    for (int j = 0; j < array.Length - i - 1; j++)
                        if (array[j].CompareTo(array[j + 1]) == 1)
                        {
                            Swap(ref array[j], ref array[j + 1]);
                            flag = true;
                        }


                }
            }


        }
        public static void BubbleSort(T[] array)
        {
            if (array is not null)
            {
                BubbleSort(array, array.Length);
            }

        }
    }
}
