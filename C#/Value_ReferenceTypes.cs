namespace ReferenceType
{
    //String
    //Class
    //Array
    //Delegate


    // string is special, it's a reference type but immutable, it can't change
    // If change value of string, compiler creates a new string object in the memory and point a variable to the new memory location
    // So, passing a string value to a function will create a new variable in the memory, and any change in the value in the function will not be reflected in the original value, as shown below.
    void ChangeReferenceTypeString(string name)
    {
        name = "Steve";
    }

    void runString()
    {
        string name = "Bill";

        ChangeReferenceTypeString(name);

        Console.WriteLine(name);
    }

    runString();

    void ChangeReferenceTypeClass(Student std2)
    {
        std2.StudentName = "Steve";
    }

    void runClass()
    {
        Student std1 = new Student();
        std1.StudentName = "Bill";

        ChangeReferenceTypeClass(std1);

        Console.WriteLine(std1.StudentName);
    }

    runClass();

    void ChangeReferenceTypeArray(int[] arr)
    {
        arr = new int[] { 1, 2, 3, 4, 5 };
    }

    void runArray()
    {
        int[] arr = new int[] { 0, 5, 2, 1, 6 };
        ChangeReferenceTypeArray(arr);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }
    }

    runArray();

    //Delegate is advance Data Type, I haven't learnt it yet
}

namespace ValueType
{
    // All other Data Type

    void ChangeValue(int x)
    {
        x = 200;

        Console.WriteLine(x);
    }

    void Run(string[] args)
    {
        int i = 100;

        Console.WriteLine(i);

        ChangeValue(i);

        Console.WriteLine(i);
    }
    Run();
}