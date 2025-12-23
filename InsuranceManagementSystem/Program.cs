using System;
using HealthInsuranceClass;
using LifeInsuranceClass;
using InsuranceClass;
using PolicyDirectorClass;
class MainClass{
    public static void Main(string[] args){
        Authenticate auth=new Authenticate();
        PolicyDirector pd=new PolicyDirector();
        Console.WriteLine("Amit");
        Console.WriteLine("102");
        HealthInsurance h1=new HealthInsurance{
            policyNumber=101,
            name="Karan",
            Premium=1234
        };
        LifeInsurance l1=new LifeInsurance{
            policyNumber=102,
            name="Amit",
            Premium=1200
        }; 
        Console.WriteLine($"Life Premium: {l1.CalculatePremium()}");
        Console.WriteLine($"Health Premium: {h1.CalculatePremium()}");    
        pd[101]="Health Insurance";
        pd[102]="Life Insurance";
        Console.WriteLine(pd[101]);
        Console.WriteLine(pd[102]);      

    }
}
sealed class Authenticate{
    public Authenticate(){
        Console.WriteLine("User authenticated successfully");
    }
}