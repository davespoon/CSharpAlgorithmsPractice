﻿namespace CSharpAlgorithmsPractice
{
    public class Sorting
    {
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