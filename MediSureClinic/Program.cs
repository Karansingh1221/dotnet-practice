using System;
using Entity;
class MainClass{
    public static void Main(string[] args){
        Console.WriteLine("================== MediSure Clinic Billing ==================");
        Patient p=new Patient();
        int option=0;
        do{
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Enter your option: ");
            option=Convert.ToInt32(Console.ReadLine());
            switch(option){
                case 1:
                    p.getDetails();
                    break;
                case 2:
                    if(p.checklastbill()){
                        p.display();
                    }else{
                        Console.WriteLine("No bill available. Please create a new bill first");
                    }
                    break;
                case 3:
                    p.Clear();
                    Console.WriteLine("Last Bill Cleared");
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