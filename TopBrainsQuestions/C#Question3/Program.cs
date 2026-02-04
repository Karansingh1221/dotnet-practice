using System;
using System.Collections;
using System.Text;
public class MainClass{
    public static void Main(string[] args){
        string str=Console.ReadLine();
        Dictionary<char,int> dict=new Dictionary<char,int>();
        str=str.Trim();
        StringBuilder sb=new StringBuilder();
        for(int i=0;i<str.Length;i++){
            sb.Append(str[i]);
            while(i<str.Length-1 && str[i]==str[i+1]){
                i++;
            }
        }
        if(sb.Length==0){
            Console.WriteLine("Empty String ");
            return;
        }
        sb[0]=char.ToUpper(sb[0]);
        for(int i=1;i<sb.Length;i++){
            if(sb[i-1]==' '){

                sb[i]=char.ToUpper(sb[i]);
            }
        }
        str=sb.ToString();
        Console.WriteLine(str);
    }
}