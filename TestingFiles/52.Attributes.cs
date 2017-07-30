using System;
using System.Collections.Generic;

namespace IntroductionToCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = Calculator.Add(10, 20);
            //int Sum = Calculator.Add(new List<int>() { 10, 20, 30});

            Console.WriteLine("Sum {0}", Sum);
        }

    }
}

public class Calculator
{
    [Obsolete("Use Add(List<int> Numbers) Method", false)]
    public static int Add(int FirstNumber, int SecondNumber)
    {
        return FirstNumber + SecondNumber;
    }

    public static int Add(List<int> Numbers)
    {
        int Sum = 0;
        foreach(int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
    }

}
