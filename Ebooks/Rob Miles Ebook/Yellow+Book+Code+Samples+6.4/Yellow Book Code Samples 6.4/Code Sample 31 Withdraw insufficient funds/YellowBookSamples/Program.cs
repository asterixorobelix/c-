/*
Page 96 of Rob Miles c# book.
Code Sample 31


Create an Account class, which has a method WithdrawFunds, which allows for an amount to be withdrawn from the account balance.
Create an account called RobsAccount and withdraw an amount from the account.
*/

using System;

class Account
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
} ;

class Bank
{
    public static void Main()
    {
        Account RobsAccount;
        RobsAccount = new Account();
        if (RobsAccount.WithdrawFunds(5))
        {
            Console.WriteLine("Cash Withdrawn");
        }
        else
        {
            Console.WriteLine("Insufficient Funds");
        }
    }
}
