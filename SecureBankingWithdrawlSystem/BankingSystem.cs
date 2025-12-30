using System;
namespace BankingSystem
{
    class BankOperationException:Exception{
        public BankOperationException(string message,Exception innerException):base(message,innerException){}
    }
    class InsufficientBalanceException:Exception{
        public InsufficientBalanceException(string message):base(message){}
    }
    class BankAccount{
        public string AccountNumber{get;private set;}
        public decimal balance{get;private set;}
        
        public BankAccount(string an,decimal bal){
            if(string.IsNullOrWhiteSpace(an)){
                throw new FormatException("Invalid Input");
            }
            if(bal<0){
                throw new FormatException("Balance Cannot be negative.");
            }
            this.AccountNumber=an;
            this.balance=bal;
        }
        public void withdraw(decimal amt){
            try{
                if(amt<0){
                    throw new FormatException("Withdraw Amount should not be zero");
                }
                if(amt>balance){
                    throw new InsufficientBalanceException("Insufficient Balance");
                }
                balance-=amt;
                Console.WriteLine($"Amount Deducted Successfully. Balance Remaining={balance:C}");
            }
            catch(Exception ex){
                throw new BankOperationException("Something Went Wrong.",ex);
            }
        }
    }
}