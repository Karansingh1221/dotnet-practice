using System;
namespace InsuranceClass{
    abstract class InsurancePolicy{
        public int policyNumber {get;init;}
        public int premium;
        public int Premium{
            get {return premium;}
            set{
                if(value<=0){
                    throw new ArgumentException("Premium must be greater than zero");
                }
                premium=value;
            }
        }

        public string name {get;set;}
        public virtual int CalculatePremium(){
            return premium;
        }
        public void displaypolicy(){
            Console.WriteLine($"Policy Number: {policyNumber}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Premium: {Premium}");
        }
    }
}