using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmiZaSortiranje
{
    internal class Logger
    {

        public Logger()
        {

        }

        public static void logList(List<Int16> list)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            foreach (var item in list)
            {
                System.Console.WriteLine(item);
            }
            stopwatch.Stop();
            System.Console.WriteLine($"List with {list.Count} items printed in: {stopwatch.ElapsedMilliseconds} ms");
        }

        public static void logArr(Int16[] array)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }
            stopwatch.Stop();
            System.Console.WriteLine($"Array with {array.Length} items printed in: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
