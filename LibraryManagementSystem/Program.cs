using System;
using LibraryClass;
using BookClass;
class MainClass{
    class Person
{
    public string Name;

    public Person(string name)
    {
        Name = name;
    }
}

class Student : Person
{
    public int RollNo;

    public Student(string name, int roll) : base(name)
    {
        RollNo = roll;
    }
}
    
    public static void Main(string[] args){
        Library l=new Library();
        l[1]="Karan";
        l[2]="Jagriti";
        l[3]="Manish";
        Console.WriteLine(l[1]);
        Console.WriteLine(l["Jagriti"]);
        Student s=new Student("Jagriti",34);
    }
}