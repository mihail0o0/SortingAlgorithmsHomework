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
    internal class BucketSort
    {
        public static BucketSort? instance;

        public BucketSort()
        {

        }

        public static BucketSort GetInstance()
        {
            instance ??= new BucketSort();

            return instance;
        }

        public Int16[] sort(Int16[] array, Int16 limit, int bucketNum = 10000)
        {
            // biram koj algoritam da koristim kao uspomoc bucket-u
            if (limit == bucketNum) return onlyBuckets(array, limit, bucketNum);
            if (limit - bucketNum < limit / 20) return insertionSorted(array, limit, bucketNum);
            return countingSorted(array, limit, bucketNum);
        }

        private Int16[] countingSorted(Int16[] array, Int16 limit, int bucketNum)
        {
            List<Int16>[] buckets = new List<Int16>[bucketNum];

            for (int i = 0; i < bucketNum; i++)
            {
                buckets[i] = new List<Int16>();
            }

            double margin = bucketNum / Convert.ToDouble(limit);

            for (int i = 0; i < array.Length; i++)
            {
                buckets[(int)Math.Floor(array[i] * margin)].Add(array[i]);
            }

            int br = 0;
            for (int i = 0; i < bucketNum; i++)
            {
                buckets[i] = CountingSort.GetInstance().sort(buckets[i], limit);

                foreach (var item in buckets[i])
                {
                    array[br++] = item;
                }
            }

            return array;
        }


        private Int16[] insertionSorted(Int16[] array, Int16 limit, int bucketNum)
        {
            List<Int16>[] buckets = new List<Int16>[bucketNum];

            for (int i = 0; i < bucketNum; i++)
            {
                buckets[i] = new List<Int16>();
            }

            double margin = bucketNum / Convert.ToDouble(limit);

            for (int i = 0; i < array.Length; i++)
            {
                buckets[(int)Math.Floor(array[i] * margin)].Add(array[i]);
            }

            int br = 0;
            for (int i = 0; i < bucketNum; i++)
            {
                foreach (var item in buckets[i])
                {
                    array[br++] = item;
                }
            }

            array = InsertionSort.GetInstance().sort(array);


            return array;
        }

        private Int16[] onlyBuckets(Int16[] array, Int16 limit, int bucketNum)
        {
            List<Int16>[] buckets = new List<Int16>[bucketNum];

            for (int i = 0; i < bucketNum; i++)
            {
                buckets[i] = new List<Int16>();
            }

            double margin = bucketNum / Convert.ToDouble(limit);

            for (int i = 0; i < array.Length; i++)
            {
                buckets[(int)Math.Floor(array[i] * margin)].Add(array[i]);
            }

            int br = 0;
            for (int i = 0; i < bucketNum; i++)
            {
                foreach (var item in buckets[i])
                {
                    array[br++] = item;
                }
            }

            return array;
        }

        private List<Int16> bucketSort(List<Int16> list, Int16 limit)
        {

            return CountingSort.GetInstance().sort(list, limit).ToList<Int16>();
        }
    }
}