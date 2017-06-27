/*
Page 96 of Rob Miles c# book.
Code Sample 31
Create a simple BankProgram. The BankProgram contains various accounts, which contain the following information for each customer:
customer name - string
customer address - string
account balance - integer value
Bank Accounts can also be "Frozen", "New", "Active", "Closed".

Create an Account class, which has a method WithdrawFunds, which allows for an amount to be withdrawn from the account balance.
Create an account called RobsAccount and withdraw an amount from the account.

Balance: 1000
How much do you want to withdraw?
691
Withdrawal: 691
Balance: 309

C:\Users\nathan.stasin\Desktop\cSharp\Rob Miles Book>Page96.exe
Balance: 1000
How much do you want to withdraw?
2500
Insufficient funds. Your balance: R1000 and you wish to withdraw: R2500
*/

using System;

enum State{ Frozen, New, Active, Closed};

class BankProgram{
	
	class Account{
		
		public string Name;
		public string Address;
		public int Balance;
		public State AccountState;
		
		public void WithdrawFunds(int Withdrawal){
			if(Withdrawal<Balance&&Balance>0){
				
				Console.WriteLine("Withdrawal: "+Withdrawal);
				Balance-=Withdrawal;
				Console.WriteLine("Balance: "+Balance);				
			}
			else{
				Console.WriteLine("Insufficient funds. Your balance: R{0} and you wish to withdraw: R{1}",Balance,Withdrawal);
			}
		}
	}
	
	static void Main(){
		Account RobsAccount=new Account();
		RobsAccount.Name="Rob";
		RobsAccount.Address="Robs House";
		RobsAccount.Balance=1000;
		RobsAccount.AccountState=State.Active;
		
		Console.WriteLine("Balance: "+RobsAccount.Balance);
		int WithdrawalRequest;
		Console.WriteLine("How much do you want to withdraw?");
		
		try{
			WithdrawalRequest=int.Parse(Console.ReadLine());
			RobsAccount.WithdrawFunds(WithdrawalRequest);
		}
		
		catch{
			Console.WriteLine("Invalid input");
		}		
	}
}