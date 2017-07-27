using System;
using System.IO;

public class Program
{
    static void Main()
    {
        try {
            StreamReader streamReader = new StreamReader(@"C:\csharp\csharphub\TestingFiles\data2.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
        catch(Exception ex)
        {

        }        
    }

}
 