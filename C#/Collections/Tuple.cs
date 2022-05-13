using System;
using System.Collections;


namespace Tuple
{
    void Run()
    {
        var numbers = Tuple.Create(1, 2, 3, 4, 5, 6, 7, Tuple.Create(8, 9, 10, 11, 12, 13));
        numbers.Item1; // returns 1
        numbers.Item7; // returns 7
        numbers.Rest.Item1; //returns (8, 9, 10, 11, 12, 13)
        numbers.Rest.Item1.Item1; //returns 8
        numbers.Rest.Item1.Item2; //returns 9

        var numbers2 = Tuple.Create(1, 2, Tuple.Create(3, 4, 5, 6, 7, 8), 9, 10, 11, 12, 13);
        numbers2.Item1; // returns 1
        numbers2.Item2; // returns 2
        numbers2.Item3; // returns (3, 4, 5, 6, 7,  8)
        numbers2.Item3.Item1; // returns 3
        numbers2.Item4; // returns 9
        numbers2.Rest.Item1; //returns 13
    }
}