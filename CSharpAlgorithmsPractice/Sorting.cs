using System;

namespace CSharpAlgorithmsPractice
{
    public class Sorting
    {
        public static void MergeSortByArray(int[] array)
        {
            if (array.Length < 2) return;

            int mid = array.Length / 2;
            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            for (int i = 0; i < left.Length; i++)
            {
                left[i] = array[i];
            }

            for (int i = 0; i < right.Length; i++)
            {
                right[i] = array[i + mid];
            }

            MergeSortByArray(left);
            MergeSortByArray(right);
            Merge(left, right, array);


            void Merge(int[] array1, int[] array2, int[] targetArray)
            {
                int array1MinIndex = 0;
                int array2MinIndex = 0;
                int targetArrayMinIndex = 0;

                while (array1MinIndex < array1.Length && array2MinIndex < array2.Length)
                {
                    if (array1[array1MinIndex] <= array2[array2MinIndex])
                        targetArray[targetArrayMinIndex] = array1[array1MinIndex++];
                    else
                        targetArray[targetArrayMinIndex] = array2[array2MinIndex++];

                    targetArrayMinIndex++;
                }

                while (array1MinIndex < array1.Length)
                {
                    targetArray[targetArrayMinIndex++] = array1[array1MinIndex++];
                }

                while (array2MinIndex < array2.Length)
                {
                    targetArray[targetArrayMinIndex++] = array2[array2MinIndex++];
                }
            }
        }

        public static void MergeSortByIndex(int[] array)
        {
            int[] aux = new int[array.Length];
            Sort(0, array.Length - 1);

            void Sort(int low, int high)
            {
                if (high <= low) return;

                int mid = (high + low) / 2;
                Sort(low, mid);
                Sort(mid + 1, high);
                Merge(low, mid, high);
            }

            void Merge(int low, int mid, int high)
            {
                if (array[mid] <= array[mid + 1]) return;

                int i = low;
                int j = mid + 1;

                Array.Copy(array, low, aux, low, high - low + 1);

                for (int k = low; k <= high; k++)
                {
                    if (i > mid) array[k] = aux[j++];
                    else if (j > high) array[k] = aux[i++];
                    else if (aux[j] < aux[i]) array[k] = aux[j++];
                    else array[k] = aux[i++];
                }
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