using System;
class Question1{
    public static int SumOdDigits(int n){
        int sum=0;
        while(n>0){
            int rem=n%10;
            sum+=rem;
            n/=10;
        }
        return sum;
    }
    public static void Main(string[] args){
        int m=int.Parse(Console.ReadLine());
        int n=int.Parse(Console.ReadLine());
        int count=0;
        for(int i=m;i<=n;i++){
            if((SumOdDigits(i)*SumOdDigits(i))==SumOdDigits(i*i)){
                // Console.WriteLine($"{i} is Lucky");
                count++;
            }
        }
        Console.WriteLine("Total numbers of lucky number: "+count);
    }
}