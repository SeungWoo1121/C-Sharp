using System;

class Destructor
{
    public Destructor()
    {
        Console.WriteLine("In the Constructor ..."); // 생성자
    }
    ~Destructor()
    {
        Console.WriteLine("In the destructor ..."); // 소멸자
    }
}
class DestructorApp
{
    public static void Main()
    {
        Console.WriteLine("Start of Main");
        Destructor d = new Destructor();
        Console.WriteLine("End of Main");
    }
}
