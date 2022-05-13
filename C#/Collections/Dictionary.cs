using System;
using System.Collections;

namespace Dictionary
{
    void Run()
    {
        var cities = new Dictionary<string, string>(){
    {"UK", "London, Manchester, Birmingham"},
    {"USA", "Chicago, New York, Washington"},
    {"India", "Mumbai, New Delhi, Pune"}
    };

        cities.Remove("UK"); // removes UK 
                             //cities.Remove("France"); //throws run-time exception: KeyNotFoundException

        if (cities.ContainsKey("France"))
        { // check key before removing it
            cities.Remove("France");
        }

        cities.Clear(); //removes all elements

        for (int i = 0; i < cities.Count; i++)
        {
            Console.WriteLine("Key: {0}, Value: {1}", cities.ElementAt(i).Key, cities.ElementAt(i).Value);
        }

    }
}