using System;
public class Program{
    public static double convertToCm(int f){
        double cm=(double) f*30.48;
        return Math.Round(cm,2,MidpointRounding.AwayFromZero);
    }
    public static void Main(string[] args){
        Console.WriteLine("Enter foot");
        int foot=int.Parse(Console.ReadLine());
        double cm=convertToCm(foot);
        Console.WriteLine($"{cm}");
    }
}