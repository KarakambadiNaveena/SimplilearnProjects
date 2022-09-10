using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assistedlabs
{
    internal class Quicksort
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            int[] marks = new int[10];
            marks[0] = 80;
            marks[1] = 90;
            marks[2] = 93;
            marks[3] = 76;
            marks[4] = 77;
            marks[5] = 92;
            marks[6] = 89;
            marks[7] = 78;
            marks[8] = 69;
            marks[9] = 56;

            quickSort(marks, 0, 9);

            for (int i = 0; i < marks.Length; i++)
            {
                Console.WriteLine(marks[i]);
            }
        }

        public static void quickSort(int[] arr, int left, int right)
        {
            int pivot;
            if (left < right)
            {
                pivot = partition(arr, left, right);
                if (pivot > 1)
                {
                    quickSort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, pivot + 1, right);
                }
            }
        }

        public static int partition(int[] arr, int left, int right)
        {
            int pivot;
            pivot = arr[left];
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
                    int temp = arr[right];
                    arr[right] = arr[left];
                    arr[left] = temp;
                }
                else
                {
                    return right;
                }
            }
        }
    }
}



    

