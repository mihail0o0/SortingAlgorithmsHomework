using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiZaSortiranje
{
    internal class InsertionSort
    {
        public static InsertionSort? instance;

        public InsertionSort()
        {

        }

        public static InsertionSort GetInstance()
        {
            instance ??= new InsertionSort();
            return instance;
        }

        public List<short> sort(List<short> list)
        {
            for (int i = 1; i < list.Count; i++)
            {
                short currentValue = list[i];
                int j = i;

                while (j > 0 && list[j - 1] > currentValue)
                {
                    list[j] = list[j - 1];
                    j--;
                }

                list[j] = currentValue;
            }

            return list;
        }

        public short[] sort(short[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                short currentValue = array[i];
                int j = i;

                while (j > 0 && array[j - 1] > currentValue)
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = currentValue;
            }

            return array;
        }
    }
}