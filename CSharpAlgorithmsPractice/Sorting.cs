using System;

namespace CSharpAlgorithmsPractice
{
    public class Sorting
    {
        public static void MergeSort(int[] array)
        {
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low)
                {
                    return;
                }

                int mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
            }

            void Merge(int low, int mid, int high)
            {
                int i = low;
                int j = mid + 1;
                
                
                // Array.Copy();
            }
        }


        public static void ShellSort(int[] array)
        {
            int gap = 1;
            while (gap < array.Length / 3)
            {
                gap = 3 * gap + 1;
            }

            while (gap >= 1)
            {
                for (int i = gap; i < array.Length; i++)
                {
                    for (int j = i; j >= gap && array[j] < array[j - gap]; j -= gap)
                    {
                        Swap(array, j, j - gap);
                    }
                }

                gap /= 3;
            }
        }

        public static void SelectionSort(int[] array)
        {
            for (int partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                int largestAt = 0;
                for (int i = 1; i <= partIndex; i++)
                {
                    if (array[i] > array[largestAt])
                    {
                        largestAt = i;
                    }

                    Swap(array, largestAt, partIndex);
                }
            }
        }

        public static void BubbleSort(int[] array)
        {
            for (var partIndex = array.Length - 1; partIndex > 0; partIndex--)
            {
                for (var i = 0; i < partIndex; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(array, i, i + 1);
                    }
                }
            }
        }

        public static void InsertionSort(int[] array)
        {
            for (var partIndex = 1; partIndex <= array.Length - 1; partIndex++)
            {
                var curUnsorted = array[partIndex];
                int i = 0;

                for (i = partIndex; (i > 0 && curUnsorted < array[i - 1]); i--)
                {
                    array[i] = array[i - 1];
                }

                array[i] = curUnsorted;
            }
        }

        private static void Swap(int[] array, int i, int j)
        {
            if (i == j)
            {
                return;
            }

            //swap using deconstruction
            (array[i], array[j]) = (array[j], array[i]);
        }
    }
}