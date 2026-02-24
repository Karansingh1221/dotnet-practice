using System;
using System.Collections.Generic;
using System.Collections;
public class Employee{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Department{get;set;}
    public int Salary{get;set;}
}
public class Program{
    public static void Main(string[] args){
        List<Employee> record=new List<Employee>();
        record.Add(new Employee { Id = 1, Name = "Karan", Department = "IT", Salary = 60000 });
        record.Add(new Employee { Id = 2, Name = "Rahul", Department = "HR", Salary = 45000 });
        record.Add(new Employee { Id = 3, Name = "Priya", Department = "Finance", Salary = 55000 });
        record.Add(new Employee { Id = 4, Name = "Amit", Department = "Marketing", Salary = 50000 });
        record.Add(new Employee { Id = 5, Name = "Neha", Department = "IT", Salary = 72000 });
        record.Add(new Employee { Id = 6, Name = "Suresh", Department = "HR", Salary = 48000 });
        record.Add(new Employee { Id = 7, Name = "Anjali", Department = "Finance", Salary = 62000 });
        record.Add(new Employee { Id = 8, Name = "Vikram", Department = "Marketing", Salary = 53000 });
        record.Add(new Employee { Id = 9, Name = "Rohit", Department = "IT", Salary = 51000 });
        record.Add(new Employee { Id = 10, Name = "Meena", Department = "HR", Salary = 65000 });

        var result=record.GroupBy(e=>e.Department).Select(e=>new{Department=e.Key,Employee=e.Where(g=>g.Salary>50000).ToList()}).
        Where(g=>g.Employee.Any()).
        ToDictionary(e=>e.Department,e=>e.Employee);
        foreach(var i in result){
            Console.WriteLine("Department: "+i.Key);
            foreach(var j in i.Value){
                Console.Write(j.Name+" ");
            }
            Console.WriteLine();
        }


    }
}