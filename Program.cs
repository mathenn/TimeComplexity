using System;

namespace Search
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BubbleSort();
        }

        public static int BinarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            return -1;
        }

        public static void SortingNumbers()
        {
            int[] arrayNumbers = { 5, 7, 2, 3, 8, 6, 1, 4, 9, 0 };

            for (int i = 0; i <= arrayNumbers.Length - 1; i++)
            {
                arrayNumbers[i] = i;
                Console.WriteLine(arrayNumbers[i]);
            }

        }

        public static void BubbleSort()
        {
            int[] arrayNumbers = { 5, 7, 2, 3, 8, 6, 1, 4, 9, 0 };

            for (int i = 0; i < arrayNumbers.Length - 1; i++)
            {
                if (arrayNumbers[i] < arrayNumbers[i + 1])
                {
                    arrayNumbers[i] = arrayNumbers[i];
                }
                else
                {
                    arrayNumbers[i] = arrayNumbers[i + 1];
                }
            }
            foreach (int item in arrayNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}
