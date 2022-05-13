using System;
using System.Collections;

namespace Queue
{
    void Run()
    {
        Queue<int> callerIds = new Queue<int>();
        callerIds.Enqueue(1);
        callerIds.Enqueue(2);
        callerIds.Enqueue(3);
        callerIds.Enqueue(4);

        foreach (var id in callerIds)
            Console.Write(id); //prints 1234

        callerIds.Contains(2); //true
        callerIds.Contains(10); //false

        Queue<string> strQ = new Queue<string>();
        strQ.Enqueue("H");
        strQ.Enqueue("e");
        strQ.Enqueue("l");
        strQ.Enqueue("l");
        strQ.Enqueue("o");

        Console.WriteLine("Total elements: {0}", strQ.Count); //prints 5

        while (strQ.Count > 0)
            Console.WriteLine(strQ.Dequeue()); //prints Hello

        Console.WriteLine("Total elements: {0}", strQ.Count); //prints 0


    }
}