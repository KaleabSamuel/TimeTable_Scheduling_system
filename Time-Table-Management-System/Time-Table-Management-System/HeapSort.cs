using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_Table_Management_System
{
    class HeapSort
    {
            public static void sort(Schedule[] arr)
            {
                int n = arr.Length;
                for (int i = n / 2 - 1; i >= 0; i--)
                    heapify(arr, n, i);
                for (int i = n - 1; i > 0; i--)
                {
                    Schedule temp = arr[0];
                    arr[0] = arr[i];
                    arr[i] = temp;
                    heapify(arr, i, 0);
                }
            }

        static void heapify(Schedule[] arr, int n, int i)
            {
                int largest = i; 
                int l = 2 * i + 1; 
                int r = 2 * i + 2; 
                if (l < n && arr[l].Contradiction > arr[largest].Contradiction)
                    largest = l;
                if (r < n && arr[r].Contradiction > arr[largest].Contradiction)
                    largest = r;
                if (largest != i)
                {
                    Schedule swap = arr[i];
                    arr[i] = arr[largest];
                    arr[largest] = swap;
                    heapify(arr, n, largest);
                }
            }
        }
}
