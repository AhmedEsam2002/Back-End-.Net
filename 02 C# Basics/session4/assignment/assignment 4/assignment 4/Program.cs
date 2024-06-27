namespace assignment_4
{
    using System;

    class Assignment
    {
        static void Main()
        {
            Console.WriteLine("Choose a question to run:");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter the size of the identity matrix: ");
                    int n = int.Parse(Console.ReadLine());
                    PrintIdentityMatrix(n);
                    break;
                case 2:
                    Console.Write("Enter the elements of the array separated by space: ");
                    int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    Console.WriteLine("Sum of array elements: " + SumOfArrayElements(array));
                    break;
                case 3:
                    Console.Write("Enter the elements of the first array separated by space: ");
                    int[] array1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    Console.Write("Enter the elements of the second array separated by space: ");
                    int[] array2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    int[] mergedArray = MergeAndSortArrays(array1, array2);
                    Console.WriteLine("Merged and sorted array: " + string.Join(", ", mergedArray));
                    break;
                case 4:
                    Console.Write("Enter the elements of the array separated by space: ");
                    int[] freqArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                    CountFrequency(freqArray);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid question number.");
                    break;
            }
        }

        static void PrintIdentityMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }
                Console.WriteLine();
            }
        }

        static int SumOfArrayElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static int[] MergeAndSortArrays(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];
            int i = 0, j = 0, k = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] <= array2[j])
                {
                    mergedArray[k++] = array1[i++];
                }
                else
                {
                    mergedArray[k++] = array2[j++];
                }
            }

            while (i < array1.Length)
            {
                mergedArray[k++] = array1[i++];
            }

            while (j < array2.Length)
            {
                mergedArray[k++] = array2[j++];
            }

            return mergedArray;
        }

        static void CountFrequency(int[] array)
        {
            int[] freq = new int[100]; // Assuming array elements are between 0 and 99
            for (int i = 0; i < array.Length; i++)
            {
                freq[array[i]]++;
            }

            for (int i = 0; i < freq.Length; i++)
            {
                if (freq[i] > 0)
                {
                    Console.WriteLine($"Element {i} appears {freq[i]} times.");
                }
            }
        }
    }

}
