interface SomeEvent
{
    string Name { get; set; }
    void excute();

}

class ClickEvent : SomeEvent
{
    string Name { get; set; }
    void excute()
    {
        Console.WriteLine("Click Click");
    }
}
