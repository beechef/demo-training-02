using System;

namespace ForLoop
{
    void Run()
    {
        int[] arr = new int[] { 10, 20, 30, 40, 50 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}