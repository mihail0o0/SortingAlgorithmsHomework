using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Media;

namespace AlgoritmiZaSortiranje;
class Program
{
    // static void Main(string[] args)
    // {
    //     Stopwatch stopwatch = new Stopwatch();

    //     Console.WriteLine($"Array creation started");
    //     stopwatch.Start();

    //     Int16[] array = RNG.GetInstance().createArray(10000000, 10000);

    //     stopwatch.Stop();
    //     string createdMessage = $"Array with {array.Length} created: {stopwatch.ElapsedMilliseconds} ms";

    //     Console.WriteLine();
    //     Console.WriteLine("STARTED SORTING");
    //     Console.WriteLine();

    //     stopwatch = new Stopwatch();
    //     stopwatch.Start();

    //     Int16[] sortedArr = CountingSort.GetInstance().sort(array, 10000);


    //     string sortedTime = $"Array sorted: {stopwatch.ElapsedMilliseconds} ms";

    //     stopwatch.Stop();
    //     Console.WriteLine(createdMessage);
    //     Console.WriteLine(sortedTime);
    // }

    static void Main(string[] args)
    {
        Stopwatch stopwatch;

        int i = 100;

        while (i <= 10000000)
        {
            short[] array = RNG.GetInstance().createArray(i, 10000);
            stopwatch = new Stopwatch();
            stopwatch.Start();
            short[] sortedArr = BucketSort.GetInstance().sort(array, 10000, 1000);
            stopwatch.Stop();
            System.Console.WriteLine($"Array of {i} elements sorted with Bucket sort in: {stopwatch.ElapsedMilliseconds} ms");

            array = RNG.GetInstance().createArray(i, 10000);
            stopwatch = new Stopwatch();
            stopwatch.Start();
            sortedArr = HeapSort.GetInstance().sort(array);
            stopwatch.Stop();
            System.Console.WriteLine($"Array of {i} elements sorted with Heap sort in: {stopwatch.ElapsedMilliseconds} ms");

            array = RNG.GetInstance().createArray(i, 10000);
            stopwatch = new Stopwatch();
            stopwatch.Start();
            sortedArr = Selection.GetInstance().sort(array);
            stopwatch.Stop();
            System.Console.WriteLine($"Array of {i} elements sorted with Selection sort in: {stopwatch.ElapsedMilliseconds} ms");

            System.Console.WriteLine();
            i *= 10;
        }
    }
}
