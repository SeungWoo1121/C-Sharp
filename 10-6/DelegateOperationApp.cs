using System;
delegate void MultiDelegate();
class DelegateClass
{
    public void MethodA()
    {
        Console.WriteLine("In the DelegateClass.MethodA ...");
    }
    public void MethodB()
    {
        Console.WriteLine("In the DelegateClass.MethodB ...");
    }
    public void MethodC()
    {
        Console.WriteLine("In the DelegateClass.MethodC ...");
    }
}
class DelegateOperationApp
{
    public static void Main()
    {
        DelegateClass obj = new DelegateClass();
        MultiDelegate dg1, dg2, dg3;
        dg1 = new MultiDelegate(obj.MethodA);
        dg2 = new MultiDelegate(obj.MethodB);
        dg3 = new MultiDelegate(obj.MethodC);

        dg1 = dg1 + dg2;
        dg1 += dg3;
        dg2 = dg1 - dg2;
        dg1();
        Console.WriteLine("After dg1 call ...");
        dg2();
        Console.WriteLine("After dg2 call ...");
        dg3();
    }
}