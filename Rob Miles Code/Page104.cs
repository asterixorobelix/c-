/*
Page 104 of Rob Miles c# book.
Code Sample 34

Create an Account class and provide a custom constructor to set the initial values for robsAccount, which are name, address and balance.
Give robsAccount an opening balance of 1000000.
*/

using System;

class Account
{
    // private member data
    private string name;
    private string address;
    private decimal balance;

    // constructor
    public Account(string inName, string inAddress, decimal inBalance)
    {
        name = inName;
        address = inAddress;
        balance = inBalance;
    }
}

/*
When an object is created (an instance of a class, created by using the new keyword), the default constructor is always called. 
If one is not supplied by the programmer, the compiler creates and calls its own default constructor.
A default constructor is a constructor which takes no arguments. Once the user has created a constructor. The compiler no longer calls its own default constructor. 
Therefore, if we wish to create objects without supplying any parameters, we must define our own default constructor.
*/

class Bank
{
    public static void Main()
    {
        Account robsAccount;
        robsAccount = new Account("Rob", "Robs House", 1000000);
    }
}
