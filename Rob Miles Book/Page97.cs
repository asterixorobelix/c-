/*
Page 97 of Rob Miles c# book.
Code Sample 32
Create a simple BankProgram. The BankProgram contains various accounts, which contain the following information for each customer:
customer name - string
customer address - string
account balance - integer value
Bank Accounts can also be "Frozen", "New", "Active", "Closed".
Create an Account class, with the methods WithdrawFunds, PayInFunds and GetBalance. Create an account called RobsAccount, give it an initial value of R1000 and make a withdrawal.

Sample Output:
Enter the amount which you wish to withdraw
22
Balance: R1000
Balance: R978
RobsAccount balance: R978
*/

using System;

public enum State{Frozen,New,Active,Closed};

public class Account{
	
	public string Name{get;set;}
	public string Address {get;set;}
	public int Balance {get;set;}
	public State AccountState {get;set;}
	
	public int WithdrawFunds(int Amount){
		Console.WriteLine("Balance: R"+Balance);

		if(Balance>Amount&&Balance>0){
			Balance-=Amount;
			Console.WriteLine("Balance: R"+Balance);
		}
			
		else{
			Console.WriteLine("Your request to withdraw R{0} exceeds your balance of R{1}",Amount,Balance);
		}
		return Balance;
	}
	
	public int GetBalance(){
		return Balance;
	}
}

class Bank{
	static void Main(){
		Account RobsAccount = new Account();
		RobsAccount.Balance=1000;
		
		Console.WriteLine("Enter the amount which you wish to withdraw");
		int WithDrawal;
		
		try{
			WithDrawal=int.Parse(Console.ReadLine());
			RobsAccount.Balance=RobsAccount.WithdrawFunds (WithDrawal);
		}
		catch{
			Console.WriteLine("Invalid input");
		}
		Console.WriteLine("RobsAccount balance: R"+RobsAccount.GetBalance());
	}
}