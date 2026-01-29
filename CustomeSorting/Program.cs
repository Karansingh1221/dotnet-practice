using System;
using System.Collections.Generic;
using System.Linq;
class Student{
    public string Name{get;set;}
    public int Marks{get;set;}
    public int Age{get;set;}
    public Student(string n,int m,int a){
        this.Name=n;
        this.Marks=m;
        this.Age=a;
    }
    public override string ToString(){
        return $"name: {Name},marks: {Marks},age: {Age}";
    }
}
class StudentComparer:IComparer<Student>{
    public int Compare(Student x,Student y){
        int mcomp=y.Marks.CompareTo(x.Marks);
        if(mcomp!=0) return mcomp;
        return x.Age.CompareTo(y.Age);
    }
}
class Program{
    public static void Main(string[] args){
        List<Student>  repo=new List<Student>{new Student("Sparsh",84,20),new Student("Karan",95,21)
        ,new Student("Jagriti",94,20),new Student("Anushka",94,22)};
        // repo = repo.OrderByDescending(std => std.Marks).ThenBy(std => std.Age).ToList();
        // foreach(var i in repo){
        //     Console.WriteLine(i);
        // }

        repo.Sort(new StudentComparer());
        foreach(var i in repo){
            Console.WriteLine(i);
        }
    }
}
