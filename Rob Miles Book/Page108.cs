/*
Page 108 of Rob Miles c# book.
Code Sample 36

Create an Account class and provide a custom constructor to set the initial values for robsAccount, which are name, address and balance.
Give robsAccount an opening balance of 1000000.
Create some overloaded constructors, so that not all the parameters need to be provided when an object is created.
Add input validation to the constructors, so that blank names and addresses are rejected and an object is not created. 
Also, prevent initial balances above positive or negative 10000000. 
*/

using System;

class Account
{
    // private member data
    private string name;
    private string address;
    private decimal balance;

    public bool SetName(string inName)
    {
        if (inName == "")
            return false;

        name = inName;

        return true;
    }

    public bool SetAddress(string inAddress)
    {
        if (inAddress == "")
            return false;

        address = inAddress;

        return true;
    }

    const decimal MAX_BALANCE = 10000000;
    const decimal MIN_BALANCE = -10000000;

    public bool SetBalance( decimal inBalance)
    {
        if (inBalance < MIN_BALANCE ||
            inBalance > MAX_BALANCE)
            return false;

        balance = inBalance;
        return true;
    }

    // constructors
    public Account(string inName, string inAddress,
      decimal inBalance)
    {
        string errorMessage = "";

        if (SetBalance(inBalance)==false)
            errorMessage = errorMessage + "Bad Balance: " + inBalance;

        if (SetName(inName) == false)
        {
            errorMessage = errorMessage + "Bad name: " + inName;
        }

        if (SetAddress(inAddress) == false)
        {
            errorMessage = errorMessage + " Bad addr: " + inAddress;
        }

        if (errorMessage != "")
        {
            throw new Exception("Account construction failed " 
                + errorMessage);
        }
    }

    public Account(string inName) :
        this(inName, "Not Supplied", 0)
    {
    }
}
/*Constructors can also have logic built into them to prevent objects being created with non-sensical values, which is what has been done in the code above. 
*/

class Bank
{
    public static void Main()
    {
        const int MAX_CUST = 100;
        Account[] Accounts = new Account[MAX_CUST];
        Accounts[0] = new Account("Rob", "", 1000000);
    }
}
