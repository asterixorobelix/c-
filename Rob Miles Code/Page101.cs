/*
Page 101 of Rob Miles c# book.
Code Sample 33

Create an Account class, with the methods WithdrawFunds, PayInFunds and GetBalance. 
Create a further method, which prevents an account from being created at the bank if the applicant does not have more than R25 000 to invest at account opening and the user is under the age of 21.
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

    private static decimal minIncome;
    private static int minAge;

    public static bool AccountAllowed(decimal income, int age)
    {
        if ((income >= minIncome) && (age >= minAge))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}

class Bank
{
    public static void Main()
    {
        if (Account.AccountAllowed(25000, 21))
        {
            Console.WriteLine("Allowed Account");
        }
    }
}
