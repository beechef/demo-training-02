using System;
namespace TernaryOperator
{
    void Run()
    {
        int number1, number2;
        number1 = 1;
        number2 = -1;
        string result = number1 > number2 ? "Number1 greater than Number2" :
                        number1 < number2 ? "Number1 less than Number2" : "Number1 equal Number2";
        Console.WriteLine(result);
    }
}