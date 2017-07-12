/*
Page 112 of Rob Miles c# book.
Code Sample 37

Create an CustomerAccount class which has some methods, WithdrawFunds, PayInFunds, GetBalance.
Create an interface for CustomerAccount.
Create a new account, deposit R50 into it and display the balance. 
*/

using System;

public interface IAccount
{
    void PayInFunds(decimal amount);
    bool WithdrawFunds(decimal amount);
    decimal GetBalance();
}

public class CustomerAccount : IAccount
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
        IAccount account = new CustomerAccount();
        account.PayInFunds(50);
        Console.WriteLine("Balance: " + account.GetBalance());
    }
}
