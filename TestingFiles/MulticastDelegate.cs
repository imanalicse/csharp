using System;

public delegate void SampleDelegate();

class Program
{
    static void Main()
    {
        SampleDelegate del = new SampleDelegate(SampleMethodOne);
        del += SampleMethodTwo;
        del += SampleMethodThree;
        del -= SampleMethodTwo;
        del();
    }

    public static void SampleMethodOne()
    {
        Console.WriteLine("SampleMethodOne Invoked");
    }

    public static void SampleMethodTwo() {
        Console.WriteLine("SampleMethodTwo Invoked");
    }
    public static void SampleMethodThree()
    {
        Console.WriteLine("SampleMethodThree Invoked");
    }

}
