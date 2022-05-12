using System;

namespace Array
{
    void Run()
    {
        string[] cities = { "Ho Chi Minh", "Ha Noi", "Da Nang", "Can Tho" };

        // Get Last Element of Array
        int lastIndex = cities.Length - 1;
        Console.WriteLine(cities[lastIndex]);

        // Edit Value of Array's Element
        int hanoiIndex = 1;
        cities[hanoiIndex] = "New Ha Noi";
        Console.WriteLine(cities[hanoiIndex]);

        const int ROW = 3;
        const int COLUMN = 3;
        int[,] matrix = new int[ROW][COLUMN]{
            {1,2,3},
            {4,5,6},
            {7,8,9}
        };

        for (int i = 0; i < ROW; i++)
        {
            for (int j = 0; j < COLUMN; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}