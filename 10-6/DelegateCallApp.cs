using System;

delegate void DelegateOne(); // 델리게이트 정의
delegate void DelegateTwo(int i); // 델리게이트 정의

class DelegateClass
{
    public void MethodA()
    {
        Console.WriteLine("In the DelegateClass.MethodA ...");
    }
    public void MethodB(int i)
    {
        Console.WriteLine("DelegateClass.MethodB, i = " + i);
    }

}
class DelegateCallApp
{
    public static void Main()
    {
        DelegateClass obj = new DelegateClass();
        // 델리게이트할 메소드가 포함된클래스 객체 생성

        DelegateOne d1 = new DelegateOne(obj.MethodA);
        // 정의된 델리게이트 형식으로 델리게이트 객체를 생성하여 메소드 A 연결
        DelegateTwo d2 = new DelegateTwo(obj.MethodB); // 메소드 B 연결

        d1(); // 생성된 델리게이트를 통하여 연결된 MethodA()호출
        d2(10); // invoke MethodB(10)
    }
}