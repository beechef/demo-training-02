public static class Calculator
{
    private static int _resultStorage = 0;
    public static float PI = 3.14f;

    public static string Type = "Arithmetic";

    public static int Sum(int num1, int num2)
    {
        return num1 + num2;
    }

    public static void Store(int result)
    {
        _resultStorage = result;
    }

    public static float GetPI()
    {
        return PI;
    }
}