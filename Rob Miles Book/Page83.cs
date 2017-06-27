/*
Page 83 of Rob Miles c# book.
Code Sample 23

Create a simple BankProgram, using a struct. The BankProgram contains various accounts, which contain the following information for each customer:
customer name - string
customer address - string
account balance - integer value
Bank Accounts can also be "Frozen", "New", "Active", "Closed" and "Under Audit".

Create an Account called RobsAccount, set the account state to Active and give it a balance of a million Rand.

Sample Output:
Robs balance is: 1000000 Rand
*/

using System;

enum State{
	Frozen,New,Active,Closed,UnderAudit
};

struct Account{
	public string Name;
	public string Address;
	public int Balance;
	public State AccountState;
};

class BankProgram{
	static void Main(){
		Console.WriteLine("Enter your details in order to create an account");
		Account Account1;
		Account1.AccountState=State.New;
		Console.WriteLine("Enter your name:");
		Account1.Name=Console.ReadLine();
		Console.WriteLine("Enter your address: ");
		Account1.Address=Console.ReadLine();
		Console.WriteLine("What is your opening balance?");
		Account1.Balance=int.Parse(Console.ReadLine());
		
		Console.WriteLine("\nYour account details");
		Console.WriteLine("Name: "+Account1.Name);
		Console.WriteLine("Balance: "+Account1.Balance);		
	}
}