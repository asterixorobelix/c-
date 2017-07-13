/*
Page 107 of Rob Miles c# book.
Code Sample 35

Create an Account class and provide a custom constructor to set the initial values for robsAccount, which are name, address and balance.
Give robsAccount an opening balance of 1000000.
Create some overloaded constructors, so that not all the parameters need to be provided when an object is created.
*/

using System;

class Account
{
    // private member data
    private string name;
    private string address;
    private decimal balance;

    // constructors
    public Account(string inName, string inAddress,
      decimal inBalance)
    {
        name = inName;
        address = inAddress;
        balance = inBalance;
    }
    public Account(string inName, string inAddress) :
        this(inName, inAddress, 0)
    {
    }

    public Account(string inName) :
        this(inName, "Not Supplied", 0)
    {
    }
}

/*C# provides a way in which you can call one constructor from another. The keyword this means "another constructor in this class".
*/

class Bank
{
    public static void Main()
    {
        const int MAX_CUST = 100;
        Account[] Accounts = new Account[MAX_CUST];
        Accounts[0] = new Account("Rob", "Robs House", 1000000);
        Accounts[1] = new Account("Jim", "Jims House");
        Accounts[2] = new Account("Fred");
    }
}
