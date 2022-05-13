using System;
using System.Collections;

namespace Stack
{
    void Run()
    {
        Stack<int> myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);
        myStack.Push(4);

        Console.Write("Number of elements in Stack: {0}", myStack.Count);


        if (myStack.Count > 0)
        {
            Console.WriteLine(myStack.Peek()); // prints 4
            Console.WriteLine(myStack.Peek()); // prints 4
        }

        myStack.Contains(2); // returns true
        myStack.Contains(10); // returns false


        while (myStack.Count > 0)
            Console.Write(myStack.Pop() + ",");

        Console.Write("Number of elements in Stack: {0}", myStack.Count);


    }
}