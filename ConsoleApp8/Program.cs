// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Threading.Channels;

public class ExExample
{
    
    public static void Main(string[] args)
    {
        try
        {
            int a = 10;
            int b = 0;
            int x = a / b;
        }
        catch (Exception e)
        { Console.WriteLine(e); }
        finally { Console.WriteLine("Finally block is executed:"); }
        Console.WriteLine("Rest of the code");
        Console.WriteLine("-----------------");
    }
}
//Console.WriteLine("Hello, World!");
//using System;
//public class ExExample
//{
//    public static void Main(string[] args)
//    {
//        try
//        {
//            int a = 10;
//            int b = 0;
//            int x = a / b;
//        }
//        catch (Exception e) 
//        { Console.WriteLine(e); }
//        finally { Console.WriteLine("Finally block is executed"); }
//        Console.WriteLine("Rest of the code");
//    }
//}


