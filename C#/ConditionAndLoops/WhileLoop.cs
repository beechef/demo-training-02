using System;
namespace WhileLoop
{
    void Run()
    {
        int count = 0;
        while (count < 10)
        {
            Console.WriteLine(count++);
        }
        
        do
        {
            Console.WriteLine(count++);
        } while (count < 20);
    }
}