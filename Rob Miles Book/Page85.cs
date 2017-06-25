/*
Page 85 of Rob Miles c# book.
Code Sample 25

Create a simple BankProgram. The BankProgram contains various accounts, which contain the following information for each customer:
customer name - string
customer address - string
account number - integer value
account balance - integer value
overdraft limit - integer value
Bank Accounts can also be "Frozen", "New", "Active", "Closed" and "Under Audit".
Create an entire array of customers, called Bank which can hold all the bank's customers. 
The maximum number of customers that our bank can hold is 100.
There are two customers in the database:
Rob, who has an active account and whose balance is R100000 and Jim who has R0 in his bank account so it has been frozen.

Create a Method called PrintAccount, which prints out the properties of an Account.

Sample Output:
Name: Rob
Address: Robs House
Balance: 1000000
Name: Jim
Address: Jim's House
Balance: 0
*/

using System;

enum AccountState
{
    New,
    Active,
    UnderAudit,
    Frozen,
    Closed
} ;

struct Account
{
    public AccountState State;
    public string Name;
    public string Address;
    public int AccountNumber;
    public int Balance;
    public int Overdraft;
} ;

class BankProgram
{

    public static void PrintAccount(Account a)
    {
        Console.WriteLine("Name: " + a.Name);
        Console.WriteLine("Address: " + a.Address);
        Console.WriteLine("Balance: " + a.Balance);
    }

    public static void Main()
    {
        const int MAX_CUST = 100;
        Account[] Bank = new Account[MAX_CUST];

        Bank[0].Name = "Rob";
        Bank[0].Address = "Robs House";
        Bank[0].State = AccountState.Active;
        Bank[0].Balance = 1000000;
        
        Bank[1].Name = "Jim";
        Bank[1].Address = "Jim's House";
        Bank[1].State = AccountState.Frozen;
        Bank[1].Balance = 0;

        PrintAccount(Bank[0]);
        PrintAccount(Bank[1]);
    }
}
