using System;
using System.Collections;

namespace ArrayList
{
    void Run()
    {
        var studentNames = new ArrayList();
        studentNames.Add("Minh");
        studentNames.Add("Thuan-BUG");
        studentNames.Add("Ngoc");
        studentNames.Add("Vu");
        studentNames.Add("Bao");

        studentNames[1] = "Thuan";

        foreach (var studentName in studentNames)
            Console.Write(studentName + ", ");

        for (int i = 0; i < studentNames.Count; i++)
            Console.Write(studentNames[i] + ", ");

    }
}