using System;

class RWOnlyPropertyApp
{
    private int readOnlyField = 100;
    private int writeOnlyField;

    public int ReadOnlyProperty
    {
        get
        {
            Console.WriteLine("In thr ReadOnlyProperty ...");
            return readOnlyField;
        }
    }

    public int WriteOnlyProperty
    {
        set
        {
            Console.WriteLine("In the WriteOnlyPerperty ...");
            writeOnlyField = value;
        }
    }


    public static void Main()
    {
        RWOnlyPropertyApp obj = new RWOnlyPropertyApp();
        obj.WriteOnlyProperty = obj.ReadOnlyProperty;

        // 배정연산자 오른쪽 set 접근자는 Compile Error
        //Console.WriteLine("value = " + obj.writeOnlyField);
    }
}