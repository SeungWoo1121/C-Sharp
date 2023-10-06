using System;

class StaticConstructor
{
    static int staticwithlnitializer = 100;
    static int staticwithnolnitializer;

    static StaticConstructor() // 정적 생성자로 매개변수와 접근 수정자를 가질 수 없다
    {
        staticwithnolnitializer = staticwithlnitializer + 100;
    }
    public static void PrintStaticVariable()
    {
        Console.WriteLine("field 1 = {0}, field 2 = {1}", staticwithlnitializer, staticwithnolnitializer);
    }
}
class StaticConstructorApp
{
    public static void Main()
    {
        StaticConstructor.PrintStaticVariable(); // 정적 생성자와 PrintStaticVariable 메소드 실행
    }
}