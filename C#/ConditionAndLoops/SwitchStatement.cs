using System;
namespace SwitchStatement
{
    const int MOUSE_LEFT_DOWN = 0;
    const int MOUSE_LEFT_UP = 1;
    const int MOUSE_RIGHT_DOWN = 2;
    const int MOUSE_RIGHT_UP = 3;
    void Run(int mouseEvent)
    {
        string result;
        switch (mouseEvent)
        {
            case MOUSE_LEFT_DOWN:
                {
                    result = "Mouse Left Down";
                    break;
                }
            case MOUSE_LEFT_UP:
                {
                    result = "Mouse Left Up";
                    break;
                }
            case MOUSE_RIGHT_DOWN:
                {
                    result = "Mouse Right Down";
                    break;
                }
            case MOUSE_RIGHT_UP:
                {
                    result = "Mouse Right Down";
                    break;
                }
            default:
                {
                    result = "Undefined Event";
                }
        }
        Console.WriteLine(result);
    }

}