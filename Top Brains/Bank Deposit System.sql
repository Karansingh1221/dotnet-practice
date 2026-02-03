CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    CustomerName VARCHAR(100),
    PhoneNumber VARCHAR(15),
    City VARCHAR(50),
    CreatedDate DATE
);

CREATE TABLE Accounts
(
    AccountID INT PRIMARY KEY,
    CustomerID INT,
    AccountNumber VARCHAR(20),
    AccountType VARCHAR(20), -- Savings / Current
    OpeningBalance DECIMAL(12,2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);


CREATE TABLE Transactions
(
    TransactionID INT PRIMARY KEY,
    AccountID INT,
    TransactionDate DATE,
    TransactionType VARCHAR(10), -- Deposit / Withdraw
    Amount DECIMAL(12,2),
    FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);


CREATE TABLE Bonus
(
    BonusID INT PRIMARY KEY,
    AccountID INT,
    BonusMonth INT,
    BonusYear INT,
    BonusAmount DECIMAL(10,2),
    CreatedDate DATE,
    FOREIGN KEY (AccountID) REFERENCES Accounts(AccountID)
);

INSERT INTO Customers VALUES
(1, 'Ravi Kumar', '9876543210', 'Chennai', '2023-01-10'),
(2, 'Priya Sharma', '9123456789', 'Bangalore', '2023-03-15'),
(3, 'John Peter', '9988776655', 'Hyderabad', '2023-06-20');


INSERT INTO Accounts VALUES
(101, 1, 'SB1001', 'Savings', 20000),
(102, 2, 'SB1002', 'Savings', 15000),
(103, 3, 'SB1003', 'Savings', 30000);


INSERT INTO Transactions VALUES
(1, 101, '2024-01-05', 'Deposit', 30000),
(2, 101, '2024-01-18', 'Withdraw', 5000),
(3, 101, '2024-02-10', 'Deposit', 25000),

(4, 102, '2024-01-07', 'Deposit', 20000),
(5, 102, '2024-01-25', 'Deposit', 35000),
(6, 102, '2024-02-05', 'Withdraw', 10000),

(7, 103, '2024-01-10', 'Deposit', 15000),
(8, 103, '2024-01-20', 'Withdraw', 5000);



--Que 1
alter proc usp_DepositAndWithdrawAmount @StartDate Date,@EndDate Date,@AccountId int as
begin
    select t.accountid,t.transactiontype,sum(T.Amount) as Total from [dbo].[Transactions] as t where t.AccountID=@accountid and  @StartDate<=t.TransactionDate and @EndDate>=t.transactiondate group by t.TransactionType,t.accountid
end
exec [dbo].[usp_DepositAndWithdrawAmount] @startdate='2024-01-05' ,@enddate='2024-02-10',@AccountId=101

--Que 2
CREATE PROC usp_BonusEligibility AS
BEGIN
    INSERT INTO Bonus (BonusID, AccountID, BonusMonth, BonusYear, BonusAmount, CreatedDate)
    SELECT 
        ROW_NUMBER() OVER (ORDER BY t.AccountID) + ISNULL((SELECT MAX(BonusID) FROM Bonus),0),
        t.AccountID,
        MONTH(t.TransactionDate),
        YEAR(t.TransactionDate),
        1000,
        GETDATE()
    FROM Transactions t
    WHERE t.TransactionType = 'Deposit'
    GROUP BY t.AccountID, YEAR(t.TransactionDate), MONTH(t.TransactionDate)
    HAVING SUM(t.Amount) > 50000
       AND NOT EXISTS (
            SELECT 1 FROM Bonus b
            WHERE b.AccountID = t.AccountID
              AND b.BonusMonth = MONTH(t.TransactionDate)
              AND b.BonusYear  = YEAR(t.TransactionDate)
        );
END
exec usp_BonusEligibility
select * from [dbo].[Bonus]






--Que3
create proc usp_getCurrentBalance as
begin
    select c.customername,a.accountnumber,
    isnull(sum(case when t.transactiontype='deposit' then t.amount end),0)-
    isnull(sum(case when t.transactiontype='withdraw' then t.amount end),0)+
    isnull(b.bonusamount,0)as CurrentBalance from [dbo].[Accounts] as a join [dbo].[Customers] as c on a.CustomerID=c.CustomerID
    left join [dbo].[Transactions] as t on a.AccountID=t.AccountID left join [dbo].[Bonus] as b on a.AccountID=b.AccountID 
    group  by c.CustomerName,a.AccountNumber,b.BonusAmount
end
exec usp_getCurrentBalance
