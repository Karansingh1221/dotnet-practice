using System;
using Entity;
class MainClass{
    public static void Main(string[] args){
        SaleTrasaction obj=new SaleTrasaction();
        int option=0;
        do{
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your option: ");
            option=Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                    obj.getInfo();
                    break;
                case 2:
                    obj.displayInfo();
                    break;
                case 3:
                    obj.displayInfo();
                    break;
                case 4:
                    Console.WriteLine("Thank you. Application closed normally.");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }while(option!=4);
    }
}