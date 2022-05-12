using System;
namespace IfStatements
{
    void Run()
    {
        int number1, number2;
        number1 = 100;
        number2 = 200;

        if (number1 < number2)
        {
            Console.WriteLine(number1 + "<" + number2);
        }
        else
         if (number1 > number2)
        {
            Console.WriteLine(number1 + ">" + number2);
        }
        else
        {
            Console.WriteLine(number1 + "=" + number2);
        }

    }

}