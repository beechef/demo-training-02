using System;
class ClassRoom
{
    public string Name { get; set; }
    public int Size { get; set;}
    public ClassRoom(string name, int size)
    {   
        this.Name = name;
        this.Size = size;
    }
    public void Callname()
    {
        Console.WriteLine("Class name: " + Name);
    }
}