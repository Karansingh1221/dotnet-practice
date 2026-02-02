using NUnit.Framework;
[TestFixture] 
public class UnitTest
{
    [Test]  
    public void Test_Deposit_ValidAmount()
    {
        BankAccount acc = new BankAccount(1000);
        acc.Deposit(500);
        Assert.AreEqual(1500, acc.balance);   
    }
    [Test]
    public void Test_Deposit_NegativeAmount()
    {
        BankAccount acc = new BankAccount(1000);
        acc.Deposit(-200);
        Assert.AreEqual(1000, acc.balance);   
    }
    [Test]
    public void Test_Withdraw_ValidAmount()
    {
        BankAccount acc = new BankAccount(1000);
        acc.withdraw(300);
        Assert.AreEqual(700, acc.balance);
    }
    [Test]
    public void Test_Withdraw_InsufficientFunds()
    {
        BankAccount acc = new BankAccount(1000);
        acc.withdraw(2000);
        Assert.AreEqual(1000, acc.balance);   
    }
}
