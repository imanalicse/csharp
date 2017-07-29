using System;


public class Enums
{
    static void Main()
    {

        Gender gender = (Gender)3;
        int Num = (int)Gender.Unknown;

        Console.WriteLine(gender);

        //int[] Values = (int[])Enum.GetValues(typeof(Gender));

        //foreach(int value in Values)
        //{
        //    Console.WriteLine(value);
        //}

        //string[] Names = Enum.GetNames(typeof(Gender));

        //foreach(string name in Names)
        //{
        //    Console.WriteLine(name);
        //}

    }

}

public enum Gender
{
    Unknown = 1,
    Male,
    Female
}
    