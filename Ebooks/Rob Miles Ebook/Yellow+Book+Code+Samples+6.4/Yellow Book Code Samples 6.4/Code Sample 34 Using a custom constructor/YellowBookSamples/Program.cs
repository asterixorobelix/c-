/*
Page 104 of Rob Miles c# book.
Code Sample 34

Create an Account class and provide a custom constructor to set the initial values for robsAccount.
*/

using System;

class Account
{
    // private member data
    private string name;
    private string address;
    private decimal balance;

    // constructor
    public Account(string inName, string inAddress,
      decimal inBalance)
    {
        name = inName;
        address = inAddress;
        balance = inBalance;
    }
}

class Bank
{
    public static void Main()
    {
        Account robsAccount;
        robsAccount = new Account("Rob", "Robs House", 1000000);
    }
}
