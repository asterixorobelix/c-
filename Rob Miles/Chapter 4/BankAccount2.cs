/*
The program we are making is for a bank, the "United Friendly and Really Nice Bank of Lovely People ™", otherwise known as the Friendly Bank.
At the moment we are simply concerned with managing the account information in the bank. The bank manager has told us that the bank stores information about each customer. This information includes their name, address, account number, balance and overdraft value. Other data items might be added later.
There are many thousands of customers and the manager has also told us that there are also a number of different types of accounts (and that new types of account are invented from time to time).
The system must also generate warning letters and statements as required.

Every account will contain a variable of type AccountState which represents the state of that account.
The possible states for a bank account are: "Frozen", "New", "Active", "Closed" and "Under Audit".

From your specification you know that the program must hold the following:
 customer name - string
 customer address - string
 account number - integer value
 account balance - integer value
 overdraft limit - integer value
To help us with our bank database we could create a structure which could hold all the information about a customer.

To start off The Friendly Bank have told you to create an account called RobsAccount, for the Customer Rob Miles, set the account state to Active and then gives it a million Rand.
The account has an overdraft of R135 000. Rob's Address is: 8 Dale Avenue, Constantia, 7806 and it is account number 1.

Set up an entire array of customers, called Bank which can hold all the customers.
The maximum number of customers that our bank can hold is 100.

Copy the information from the RobsAccount structure into the element at the start of the Bank array.

Create a second entry in the Bank array, for an account owned by Jim, which has been frozen because the balance of this account is 0.

Then, create a method called PrintAccount, which takes a parameter of the Account Structure and prints the given
Name:
Address:
Balance:

*/

using System;

enum AccountState 
{ 
    New, Active, UnderAudit, Frozen, Closed 
};

struct Account 
{ 
    public AccountState State; 
    public string Name; 
    public string Address; 
    public int AccountNumber; 
    public int Balance; 
    public int Overdraft; 
};

//Note how the structure and enum are declared outside the BankProgram class.

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
        Account [] Bank = new Account [MAX_CUST];
        Account RobsAccount; 
        RobsAccount.State = AccountState.Active; 
        Console.WriteLine("State: {0}",RobsAccount.State);
        RobsAccount.Balance = 1000000;
        Console.WriteLine("Balance: R{0}\n",RobsAccount.Balance);
        RobsAccount.Name ="Rob Miles Account";
        RobsAccount.Overdraft = 135000;
        RobsAccount.Address = "8 Dale Avenue, Constantia, 7806";
        RobsAccount.AccountNumber=1;
        
        Bank[0] = RobsAccount;
        
        Bank[1].Name = "Jim"; 
        Bank[1].Address = "Jim's House";
        Bank[1].State = AccountState.Frozen; 
        Bank[1].Balance = 0;
        
        PrintAccount(Bank[1]);
    } 
}