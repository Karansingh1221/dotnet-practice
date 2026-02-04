using System;
public class Program{
    public static void Main(string[] args){
        Console.WriteLine("Enter the height in (cm):");
        int height=int.Parse(Console.ReadLine());
        string category="";
        if(height<150){
            category="short";
        }else if(height>=150 && height<180){
            category="average";
        }else if(height>=180){
            category="tall";
        }
        Console.WriteLine("Height category="+category);
    }
}