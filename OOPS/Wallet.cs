using System;
namespace WalletClass{
    class Wallet{
        public double balance;
        public void PutMoney(double amt){
            this.balance=amt;
        }
        public void AddMoney(double amt){
            balance+=amt;
            Console.WriteLine("Amount is Added");
        }
        public void GetBalance(){
            Console.WriteLine($"Account Balance: {balance}");
        }

    }
}