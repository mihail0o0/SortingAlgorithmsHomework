using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiZaSortiranje
{
    internal class Selection
    {
        public static Selection? instance;

        public Selection()
        {

        }

        public static Selection GetInstance()
        {
            instance ??= new Selection();
            return instance;
        }

        public short[] sort(short[] array)
        {
            int max;
            for (int i = array.Length - 1; i > 0; i--)
            {
                max = 0;

                for(int j = 0; j <= i; j++){
                    if(array[j] > array[max]){
                        max = j;
                    }
                }

                (array[i], array[max]) = (array[max], array[i]);
            }

            return array;
        }
    }
}