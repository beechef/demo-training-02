using System;
using System.Collections;

namespace SortedList
{
    void Run()
    {
        SortedList<int, string> points = new SortedList<int, string>()
                                    {
                                        {10, "Thuan"},
                                        {9, "Khang"},
                                        {5, "Binh"}
                                    };

        for (int i = 0; i < points.Count; i++)
            Console.WriteLine("Top {0}, Point: {1} - Name: {2}", i, points.Keys[i], points.Value[i]);
    }
}