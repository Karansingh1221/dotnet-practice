using System;
public class Program{
    public static double CalculateArea(double rad){
        double area=Math.PI*rad*rad;
        return Math.Round(area,2,MidpointRounding.AwayFromZero);
    }
    public static void Main(string[] args){
        Console.WriteLine("Enter Radius:");
        double radius=double.Parse(Console.ReadLine());
        double Area=CalculateArea(radius);
        Console.WriteLine($"Area: {Area}");
    }
}