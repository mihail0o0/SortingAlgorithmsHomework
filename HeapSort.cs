using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiZaSortiranje
{
    internal class HeapSort
    {
        public static HeapSort? instance;

        public HeapSort()
        {

        }

        public static HeapSort GetInstance()
        {
            instance ??= new HeapSort();

            return instance;
        }

        public short[] sort(short[] arr)
        {
            int n = arr.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                heapify(arr, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                (arr[i], arr[0]) = (arr[0], arr[i]);
                heapify(arr, i, 0);
            }

            return arr;
        }

        static void heapify(short[] arr, int n, int i = 0)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left] > arr[largest])
                largest = left;

            if (right < n && arr[right] > arr[largest])
                largest = right;

            if (largest != i)
            {
                (arr[largest], arr[i]) = (arr[i], arr[largest]);
                heapify(arr, n, largest);
            }
        }
    }
}