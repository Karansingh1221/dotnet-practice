using System;
class Employee{
    public virtual double Payroll(){
        return 0;
    }
}
class HourlyEmployee:Employee{
    public int Hours{get;set;}
    public int Rate{get;set;}
    public HourlyEmployee(int h,int r){
        Hours=h;
        Rate=r;
    }
    public override double Payroll(){
        return (double)Hours*Rate;
    }
}
class SalariedEmployee:Employee{
    public double Salary{get;set;}
    public SalariedEmployee(double s){
        Salary=s;
    }
    public override double Payroll(){
        return Salary;
    }
}
class ComissionEmployee:Employee{
    public double BaseSalary{get;set;}
    public double Comission{get;set;}
    public ComissionEmployee(double b,double c){
        BaseSalary=b;
        Comission=c;
    }
    public override double Payroll(){
        return BaseSalary+Comission;
    }
}
public class Program{
    public static void Main(string[] args){
        string[] arr={"he","he","se","ce","se","ce"};
        double total_payroll=0;
        foreach(string s in arr){
            Console.WriteLine("Enter the information of the employee");
            objectCreate(s,ref total_payroll);
        }
        Console.WriteLine($"Total Payroll of all the employees is {total_payroll:F1}");
    }
    public static void objectCreate(string s,ref double total_payroll){
        if(s=="he"){
            Console.WriteLine("Enter Hours Worked:");
            int h=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Rate: ");
            int r=int.Parse(Console.ReadLine());
            HourlyEmployee he=new HourlyEmployee(h,r);
            total_payroll+=he.Payroll();
        }else if(s=="ce"){
            Console.WriteLine("Enter Base Salary:");
            double sa=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Comission: ");
            double c=double.Parse(Console.ReadLine());
            ComissionEmployee e=new ComissionEmployee(sa,c);
            total_payroll+=e.Payroll();
        }else if(s=="se"){
            Console.WriteLine("Enter Monthly Salary:");
            double ms=double.Parse(Console.ReadLine());
            SalariedEmployee e=new SalariedEmployee(ms);
            total_payroll+=e.Payroll();
        }
    }
}