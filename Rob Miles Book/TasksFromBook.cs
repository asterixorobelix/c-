Rob Miles book tasks

/*
Code Sample 1.
Page 14 of the Rob Miles c# programming pdf

Write a program which reads in the width and height (as doubles) of a  hole in the wall for a window.
The program should then print out the amount of wood required for the frame (in metres) and glass required to double glaze a window of that size.

Sample Output:
This program asks you for the width and height of a window and calculates the area of glass required to fill the hole
Enter width in metres:
2.3
Enter height in metres:
1.1
The length of the wood for the frame is: 6.8 metres
The area of glass required for double glazing is 5.06 square metres
*/

/*
Code Sample 12.
Page 52 of the Rob Miles c# programming pdf

Create a Method called ReadValue, which can prompt the user to enter a value between a max and a min, with a configurable message.
ReadValue should keep on prompting the user until valid input is entered.

Sample Output:
Enter width of window:  between 0.5 and 5 m
4
Width: 4
Enter your age:  between 0 and 70 years
34
Age: 34
*/

/*
Code Sample 16.
Page 63 of the Rob Miles c# programming pdf

Given a set of player scores from a game, list of those scores in ascending order.
No player can score less than 0 or more than 1000 runs in a game.
*/

/*
Page 64 of Rob Miles pdf. Code Sample 16.

Create a program which allows the user to enter 5 scores into an array. The program should check that the numbers are positive and less than 300. 
If not, do not add them to the array.
Display the valid entries after the user has entered 5 scores.

Sample Output:
You will be able to enter 5 scores
Score : -1
Score : 11
Score : 2
Score : 400
Score : 34
Score : 2
Score : 11
You entered:
Score: 11
Score: 2
Score: 34
Score: 2
Score: 11
*/

/*
Page 83 of Rob Miles c# book.
Code Sample 23

Create a simple BankProgram using a struct. The BankProgram contains various accounts, which contain the following information for each customer:
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

/*
Page 84 of Rob Miles c# book.
Code Sample 24

Create a simple BankProgram. The BankProgram contains various accounts, which contain the following information for each customer:
customer name - string
customer address - string
account number - integer value
account balance - integer value
overdraft limit - integer value
Bank Accounts can also be "Frozen", "New", "Active", "Closed" and "Under Audit".
Create an entire array of customers, called Bank which can hold all the bank's customers. 
The maximum number of customers that our bank can hold is 100.
There are two customers in the database:
Rob, who has an active account and whose balance is R100000 and Jim who has R0 in his bank account so it has been frozen.
*/

/*
Page 84 of Rob Miles c# book.
Code Sample 24

Create a simple BankProgram. The BankProgram contains various accounts, which contain the following information for each customer:
customer name - string
customer address - string
account number - integer value
account balance - integer value
overdraft limit - integer value
Bank Accounts can also be "Frozen", "New", "Active", "Closed" and "Under Audit".
Create an entire array of customers, called Bank which can hold all the bank's customers. 
The maximum number of customers that our bank can hold is 100.
There are two customers in the database:
Rob, who has an active account and whose balance is R100000 and Jim who has R0 in his bank account so it has been frozen.
*/

/*
Page 96 of Rob Miles c# book.
Code Sample 31

Create an Account class, which has a method WithdrawFunds, which allows for an amount to be withdrawn from the account balance.
Create an account called RobsAccount and withdraw an amount from the account.
*/

/*
Page 97 of Rob Miles c# book.
Code Sample 32

Create an Account class, with the methods WithdrawFunds, PayInFunds and GetBalance. Create some tests for the Account class which you made
*/


/*
Page 97 of Rob Miles c# book.
Code Sample 32

Create an Account class, with the methods WithdrawFunds, PayInFunds and GetBalance. Create some tests for the Account class which you made
*/

/*
Page 104 of Rob Miles c# book.
Code Sample 34

Create an Account class and provide a custom constructor to set the initial values for robsAccount, which are name, address and balance.
Give robsAccount an opening balance of 1000000.
*/

/*
Page 107 of Rob Miles c# book.
Code Sample 35

Create an Account class and provide a custom constructor to set the initial values for robsAccount, which are name, address and balance.
Give robsAccount an opening balance of 1000000.
Create some overloaded constructors, so that not all the parameters need to be provided when an object is created.
*/

/*
Page 108 of Rob Miles c# book.
Code Sample 36

Create an Account class and provide a custom constructor to set the initial values for robsAccount, which are name, address and balance.
Give robsAccount an opening balance of 1000000.
Create some overloaded constructors, so that not all the parameters need to be provided when an object is created.
Add input validation to the constructors, so that blank names and addresses are rejected and an object is not created. 
Also, prevent initial balances above positive or negative 10000000. 
*/

/*
Page 112 of Rob Miles c# book.
Code Sample 37

Create an CustomerAccount class which has some methods, WithdrawFunds, PayInFunds, GetBalance.
Create an interface for CustomerAccount.
Create a new account, deposit R50 into it and display the balance. 
*/

