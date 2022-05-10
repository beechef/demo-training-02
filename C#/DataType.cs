using System;
using System.Text;

namespace DataType
{
    #region Basic Type

    string stringType = "String type";
    int intType = 100;
    long longType = 1000000000;
    float floatType = 10.0f;
    bool boolType = true;

    #endregion

    // Type can be store Date Time
    #region DateTime Type 

    // Default value: 01/01/0001 00:00:00
    DateTime dateTimeType1 = new DateTime();
    // Assign year, month, day, hour, min, seconds, UTC timezone
    DateTime dateTimeType2 = new DateTime(2015, 12, 31, 5, 10, 20, DateTimeKind.Utc);
    // Get Now Date
    DateTime dateTimeType3 = DateTime.Now();

    #endregion

    // Type allow create new struct 
    #region Struct Type 

    struct Coordinate
    {
        public int x;
        public int y;
    }

    #endregion

    // Type can be mark a string as a number
    #region Enum Type

    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    enum Categories
    {
        Electronics = 1,
        Food = 5,
        Automotive = 6,
        Arts = 10,
        BeautyCare = 11,
        Fashion = 15,
        WomanFashion = 15
    }

    #endregion

    // Type can be build a string and lesser garbage than normal string type
    #region StringBuilder Type

    void ContainStringBuilder()
    {
        //Create Empty string
        StringBuilder sb = new StringBuilder();

        //Append string to sb
        sb.Append("Hello ");
        //Append string and "break line (\n)" to sb
        sb.AppendLine("World!");
        sb.AppendLine("Hello C#");

    }

    #endregion

    // Type can be store previously uncreated anonymous type
    #region Anonymous Type 

    void ContainAnonymous()
    {
        var student = new { Id = 1, FirstName = "James", LastName = "Bond" };
        Console.WriteLine(student.Id); //output: 1
        Console.WriteLine(student.FirstName); //output: James
        Console.WriteLine(student.LastName); //output: Bond

        student.Id = 2;//Error: cannot change value
        student.FirstName = "Steve";//Error: cannot change value
    }

    #endregion

    // Type can be dynamic store any type over lifecycle
    #region Dynamic Type

    void ContainDynamic()
    {
        dynamic d1 = 100;
        int i = d1;

        d1 = "Hello";
        string greet = d1;

        d1 = DateTime.Now;
        DateTime dt = d1;
    }

    #endregion

    // Type allow using null
    #region Nullable Type

    void ContainNullable()
    {
        Nullable<int> i = null;
        Nullable<string> s = null;
    }

    #endregion

}


