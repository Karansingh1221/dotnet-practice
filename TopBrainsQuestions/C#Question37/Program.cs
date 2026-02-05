using System;
using Library_ns;
public class Program{
    public static void Admin_Menu(){
        int option=-1;
        do{
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Update Book");
            Console.WriteLine("3. Delete Book");
            Console.WriteLine("4. View All Book");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice: ");
            option=int.Parse(Console.ReadLine());
            switch(option){
                case 1:
                    Library.AddBook();
                    break;
                case 2:
                    Library.UpdateBook();
                    break;
                case 3:
                    Library.DeleteBook();
                    break;
                case 4:
                    Library.ViewAllBooks();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }while(option!=5);
    }
    public static void Main(string[] args){
        int option=-1;
        do{
            Console.WriteLine("1. Admin");
            Console.WriteLine("2. User");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice: ");
            option=int.Parse(Console.ReadLine());
            if(option==1){
                Admin_Menu();
            }
            else if(option==2){
                User_Menu();
            }
            else if(option==3){
                Console.WriteLine("Exiting...");
            }
            else{
                Console.WriteLine("Invalid option");
            }
        }while(option!=3);
    }
    public static void User_Menu(){
        int option=-1;
        do{
            Console.WriteLine("1. Search book by name");
            Console.WriteLine("2. Search book by publisher");
            Console.WriteLine("3. View highest price book");
            Console.WriteLine("4. View lowest price book");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Enter your choice: ");
            option=int.Parse(Console.ReadLine());
            switch(option){
                case 1:
                    Library.SearchBookByName();
                    break;
                case 2:
                    Library.SearchBookByPublisher();
                    break;
                case 3:
                    Library.HighestPriceBook();
                    break;
                case 4:
                    Library.LowestPriceBook();
                    break;
                case 5:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        }while(option!=5);
    }
}