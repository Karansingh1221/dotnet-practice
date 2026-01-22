using System;
using AssignmentDll;
using System.Reflection;

public class Program
{
    public static void Main()
    {
        string dllPath = @"C:\Users\Karan\source\repos\AssignmentDll\AssignmentDll\bin\Debug\net10.0\AssignmentDll.dll";

        Assembly assembly = Assembly.LoadFrom(dllPath);

        Console.WriteLine("Classes in DLL:\n");

       
        Console.WriteLine("Methods in dll");
        foreach (Type t in assembly.GetTypes())
        {
            Console.WriteLine("Type: " + t.Name);

            foreach (MethodInfo m in t.GetMethods())
            {
                Console.WriteLine("   Method: " + m.Name);
            }

            Console.WriteLine();
        }


    }
}