// using System;
// using WalletClass;
// using MathOps;
// class MainClass{
//     public static void Main(string[] args){

        
//         // BankAccount b2=new BankAccount(123,50000);
//         // b2.Deposit(785);

//         // Employee e=new Employee("Jagriti",0);
//         // e.display();

//         // Wallet w=new Wallet();
//         // w.PutMoney(10000);
//         // w.GetBalance();
//         // w.AddMoney(100);
//         // w.GetBalance();

//         // Maths m=new Maths();
//         // Console.WriteLine(m.Add(1,2));
//         // Console.WriteLine($"{m.Add(1.1,2.1):F2}");
//         // Console.WriteLine(m.Add(1,1.2));

//         // string name="karan";
//         // char[] str=name.ToCharArray();
//         // foreach (char c in str){
//         //     Console.WriteLine(c);
//         // }
//         Console.WriteLine(sum(1,2,3,4,5 ));
//         //We cannot use Multiple params in the function parameters
//         // int a=10;
//         // incr(ref a);
//         // Console.WriteLine(a);
//         // int q,r;
//         // MultipleReturn(2,4,out q,out r);
//         // Console.WriteLine(q);
//         // Console.WriteLine(r);

//         // void Print(in int x)
//         // {
//         //     Console.WriteLine(x);
//         // }

//         // int num = 50;
//         // Print(in num);
        
//     }

//     //Multiple return values
//     public static void MultipleReturn(int a,int b,out int quo,out int rem){
//         quo=a/b;
//         rem=a%b;
//     }
//     public static void incr(ref int a){
//         a+=10;
//     }
//     public static int sum(params int[] num){
//         int total=0;
//         foreach (int i in num){
//             total+=i;
//         }
//         // total+=a;
//         return total;
//     }
//     class BankAccount{
//         public int account_no;
//         private double balance;
//         public BankAccount(int a,double  b){
//             this.account_no=a;
//             this.balance=b;
//         }
//         public void Deposit(double amount){
//             balance+=amount;
//             Console.WriteLine($"Current Bank Balance: {balance}");
//         }

//     }

//     class Employee{
//         public string name;
//         public double salary;

//         public Employee(string n,double s){
//             this.name=n;
//             this.salary=s;
//         }
//         public void display(){
//             Console.WriteLine($"Employee Name:{name}, Employee salary:{salary}");
//         }
//     }
// }