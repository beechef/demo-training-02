using System;
using System.Collections;

namespace ValueTuple
{
    void Run()
    {
        ValueTuple<int, string, string> person = (1, "Bill", "Gates");
        person.Item1;  // returns 1
        person.Item2;   // returns "Bill"
        person.Item3;   // returns "Gates"
        var number = (1);  // int type, NOT a tuple
        var numbers = (1, 2); //valid tuple
        (int Id, string FirstName, string LastName) person = (1, "Bill", "Gates");
        person.Id;   // returns 1
        person.FirstName;  // returns "Bill"
        person.LastName; // returns "Gates"
    }
}