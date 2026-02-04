using System;
using System.Collections;
public class Program{
    public static void Main(string[] args){
        List<int> l=new List<int>{1,4,5};
        Dictionary<int,int> dict=new Dictionary<int,int>();
        dict.Add(1,20000);
        dict.Add(4,40000);
        dict.Add(5,15000);
        int total_salary=0;
        foreach(var i in dict){
            total_salary+=i.Value;
        }
        Console.WriteLine("Totay salary of the empoyees: "+total_salary);
    }
}