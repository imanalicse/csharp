using System;
using System.IO;

class Program
{
    public static void Main()
    {
        
        try {
            StreamReader streamReader = new StreamReader(@"D:\Development\Csharp\csharphub\TestingFiles2\data.txt");
            Console.WriteLine(streamReader.ReadToEnd());
            streamReader.Close();
        }
        catch(FileNotFoundException ex)
        {
            Console.WriteLine("Please check if the {0} exists", ex.FileName);
        }
        catch(Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

}
 