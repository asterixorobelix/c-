/*
Page 97 of Rob Miles c# book.
Code Sample 32

Create an Account class, with the methods WithdrawFunds, PayInFunds and GetBalance. Create some tests for the Account class which you made
*/

using System;

public class Account
{
    private decimal balance = 0;

    public bool WithdrawFunds(decimal amount)
    {
        if (balance < amount)
        {
            return false;
        }
        balance = balance - amount;
        return true;
    }

    public void PayInFunds(decimal amount)
    {
        balance = balance + amount;
    }

    public decimal GetBalance()
    {
        return balance;
    }
}

class Bank
{
    public static void Main()
    {
        Account test = new Account();
        test.PayInFunds(50);
        if (test.GetBalance() != 50)
        {
            Console.WriteLine("Pay In test failed");
        }
        else
        {
            Console.WriteLine("Pay In test succeeded");
        }
    }
}
