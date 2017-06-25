/*
Create a simple BankProgram. The BankProgram contains various accounts, which contain the following information for each customer:
customer name - string
customer address - string
account number - integer value
account balance - integer value
overdraft limit - integer value
Bank Accounts can also be "Frozen", "New", "Active", "Closed" and "Under Audit".

Create an Account called RobsAccount, set the account state to Active and give it a balance of a million Rand.

Sample Output:
Robs balance is: 1000000 Rand
*/
using System;

class BankProgram{

	enum AccountState{
		Frozen,New,Active,Closed,UnderAudit
	};

	//The struct variables are private by default
	struct Account{//The struct type is suitable for representing lightweight objects
		public string Name;
		public string Address;
		public int AccountNumber;
		public int AccountBalance;
		public int OverdraftLimit;
		public AccountState State;
	}

	static void Main(){
		Account NathanStasin;

		NathanStasin.Name="Nathan";
		NathanStasin.AccountNumber=1;
		NathanStasin.AccountBalance=10000;
		NathanStasin.OverdraftLimit=100;

		NathanStasin.State=AccountState.Active;

		Console.WriteLine(NathanStasin.Name);
		Console.WriteLine("AccountBalance: R{0}",NathanStasin.AccountBalance);
	}
}