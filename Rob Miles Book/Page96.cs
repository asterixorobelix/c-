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

Sample Output:
Balance: 1000
Withdrawal: 22
Balance: 978

C:\Users\nathan.stasin\Desktop\practice>new1.exe
Insufficient funds. Your balance: 1000 and you wish to withdraw: 220000
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
				Console.WriteLine("Balance: "+Balance);
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
		
		RobsAccount.WithdrawFunds(220000);
	}
}