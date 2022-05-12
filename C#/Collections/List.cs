using System;
using System.Collections;

namespace List
{
    void Run()
    {
        List<int> primeNumbers = new List<int>();
        primeNumbers.Add(1);
        primeNumbers.Add(3);
        primeNumbers.Add(5);
        primeNumbers.Add(7);

        var cities = new List<string>();
        cities.Add("New York");
        cities.Add("London");
        cities.Add("Mumbai");
        cities.Add("Chicago");
        cities.Add(null);

        var bigCities = new List<string>()
                    {
                        "New York",
                        "London",
                        "Mumbai",
                        "Chicago"
                    };
        bigCities.Insert(1, "After London");
        bigCities.RemoveAt(2, "London");
        Console.WriteLine("Is London in list? " + bigCities.Contains("London"));
        for (int i = 0; i < primeNumbers.Count; i++)
            Console.WriteLine(primeNumbers[i]);
        for (int i = 0; i < cities.Count; i++)
            Console.WriteLine(cities[i]);
        for (int i = 0; i < bigCities.Count; i++)
            Console.WriteLine(bigCities[i]);
    }
}