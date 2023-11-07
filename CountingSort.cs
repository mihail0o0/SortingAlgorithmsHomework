using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiZaSortiranje
{
    internal class CountingSort
    {
        public static CountingSort? instance;

        public CountingSort()
        {
            
        }

        public static CountingSort GetInstance()
        {

            if(instance == null)
            {
                instance = new CountingSort();
            }

            return instance;
        }

        public List<Int16> sort(List<Int16> list, Int16 limit)
        {
            Int32[] helpArr = new Int32[limit];
            Int16[] sortedArr = new Int16[list.Count];
            

            for(int i = 0; i < list.Count; i++)
            {
                helpArr[list[i]]++;
            }

            for(int i = 1; i < helpArr.Length; i++)
            {
                helpArr[i] = (helpArr[i - 1] + helpArr[i]);
            }

            for(int i = list.Count - 1; i >= 0; i--)
            {
                sortedArr[helpArr[list[i]] - 1] = list[i];
                helpArr[list[i]]--;
            }

            return sortedArr.ToList<Int16>();
        }

        public Int16[] sort(Int16[] array, Int16 limit)
        {
            Int32[] helpArr = new Int32[limit];
            Int16[] sortedArr = new Int16[array.Length];

            for(int i = 0; i < array.Length; i++)
            {
                helpArr[array[i]]++;
            }

            for(int i = 1; i < helpArr.Length; i++)
            {
                helpArr[i] = (helpArr[i - 1] + helpArr[i]);
            }

            for(int i = array.Length - 1; i >= 0; i--)
            {
                sortedArr[helpArr[array[i]] - 1] = array[i];
                helpArr[array[i]]--;
            }

            return sortedArr;
        }
    }
}