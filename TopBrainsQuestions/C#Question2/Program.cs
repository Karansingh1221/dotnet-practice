using System;
using System.Collections;
using System.Collections.Generic;
public class Program{
    public static void Main(string[] args){
        string first=Console.ReadLine();
        string last=Console.ReadLine();
        if(first.Length>50 || last.Length>50){
            Console.WriteLine("Input string can not be greater than 50 characters");
            return;
        }
        string vow="aeiou";
        for(int i=0;i<first.Length;i++){
            char ch=first[i];
            if(!vow.Contains(char.ToLower(ch)) && last.Contains(ch.ToString(),StringComparison.OrdinalIgnoreCase)){
                first=first.Remove(i,1);
                i--;
            }
        }
        string res="";
        if(first.Length==0){
            Console.WriteLine("");
            return;
        }
        res+=first[0];
        for(int i=1;i<first.Length;i++){
            if(first[i]!=first[i-1]){
                res+=first[i];
            }
        }
        Console.WriteLine(res);
    }
}
