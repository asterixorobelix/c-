/*
Page 83 of Rob Miles c# book.
Code Sample 23

Create a simple BankProgram. The BankProgram contains various accounts, which contain the following information for each customer:
customer name - string
customer address - string
account number - integer value
account balance - integer value
overdraft limit - integer value
Bank Accounts can also be "Frozen", "New", "Active", "Closed" and "Under Audit".

Create an Account called RobsAccount, set the account state to Active and give it a balance of a million Rand.

Sample Output:
Robs balance is: 1000000 Rand
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

    public static void Main()
    {
        Account RobsAccount;
        RobsAccount.State = AccountState.Active;
        RobsAccount.Balance = 1000000;

        Console.WriteLine("Robs balance is: {0} Rand",RobsAccount.Balance);
    }
}
