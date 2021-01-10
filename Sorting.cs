using System;
using System.Collections.Generic;
using System.Text;

namespace Ordenacao
{
    public class Sorting
    {
        private static void swap(int n1, int n2, int[] arr)
        {
            int swap = arr[n1];
            arr[n1] = arr[n2];
            arr[n2] = swap;

        }

        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[left];
            while (true)
            {

                while (arr[left] < pivot)
                {
                    left++;
                }

                while (arr[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (arr[left] == arr[right]) return right;

                    int temp = arr[left];
                    arr[left] = arr[right];
                    arr[right] = temp;


                }
                else
                {
                    return right;
                }
            }
        }

        public static void BubbleSort(int[] arr)
        {

            for (int firstFor = 1; firstFor < arr.Length; firstFor++)
            {

                for (int secondFor = 0; secondFor < (arr.Length - 1); secondFor++)
                {
                    if (arr[secondFor] > arr[secondFor + 1])
                    {
                        swap(secondFor, (secondFor + 1), arr);
                    }

                }
            }

        }

        public static void SelectionSort(int[] arr)
        {
            for (int firstFor = 0; firstFor < (arr.Length - 1); firstFor++)
            {
                int minimum = firstFor;

                for (int secondFor = (firstFor + 1); secondFor < (arr.Length); secondFor++)
                {
                    if (arr[secondFor] < arr[minimum])
                    {
                        minimum = secondFor;
                    }
                }

                if (minimum != firstFor)
                {
                    swap(firstFor, minimum, arr);
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            for (int forVar = 1; forVar < arr.Length; forVar++)
            {
                int AnalyzedVariable = forVar;
                while (AnalyzedVariable > 0 && arr[AnalyzedVariable - 1] > arr[AnalyzedVariable])
                {
                    swap(AnalyzedVariable, AnalyzedVariable - 1, arr);
                    AnalyzedVariable--;
                }
            }
        }
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                if (pivot > 1)
                {
                    QuickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    QuickSort(arr, pivot + 1, right);
                }
            }
        }

    }
}