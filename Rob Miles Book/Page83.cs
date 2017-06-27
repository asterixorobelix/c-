/*
Page 83 of Rob Miles c# book.
Code Sample 23

Create a simple BankProgram, using a struct. The BankProgram allows the user enter their details for opening accounts, the bank requires the following information from each new customer:
customer name - string
customer address - string
account balance - integer value
Bank Accounts can also be "Frozen", "New", "Active", "Closed". New accounts are obviously in a state of New.
The program should prompt the user to enter their name, address and opening balance.

Enter your details in order to create an account
Enter your name:
Bob
Enter your address:
8 Dale Avenue
What is your opening balance?
1000

Your account details
Name: Bob
Balance: 1000
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