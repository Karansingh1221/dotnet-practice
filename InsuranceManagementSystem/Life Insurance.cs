using System;
using InsuranceClass;
namespace LifeInsuranceClass{
    class LifeInsurance:InsurancePolicy{
        public override int CalculatePremium(){
            return Premium+1000;
        }
        public new void displaypolicy(){
            Console.WriteLine($"Policy Number: {policyNumber}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine("$1000 for Life Insurance");
            Console.WriteLine($"Premium: {Premium}");
        }
    }
}