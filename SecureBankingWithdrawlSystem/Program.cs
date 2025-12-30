using System;
using System.IO;
using BankingSystem;
class MainClass{
    public static void Main(string[] args){
        try
        {
            BankAccount accnt=new BankAccount("1001",5000);
            int amt=-20000;
            accnt.withdraw(amt);
        }
        catch(InsufficientBalanceException ex)
        {
            LogException(ex);
            Console.WriteLine(ex.Message);
        }
        catch(BankOperationException ex){
            LogException(ex);
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.InnerException.Message);
        }
        catch(FormatException ex){
            LogException(ex);
            Console.WriteLine("Invalid Format: Wrong Input");
        }
        catch(Exception ex){
            LogException(ex);
            Console.WriteLine("Exception Occured");
        }
    }
    private static void LogException(Exception ex){
        File.AppendAllText("error.Log",DateTime.Now+" | "+
        ex.GetType().Name+" | "+ex.Message+Environment.NewLine);
    }
}