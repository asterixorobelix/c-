CodeWars Tasks

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

/*
Create a method called ReadValue, which will continue to prompt a user to enter a value between a min and a max, with a configurable message.
Sample Output:
Enter your age  between 0 and 100
120
Enter your age  between 0 and 100
Twelve
Invalid input
Enter your age  between 0 and 100
55
*/

/*Write a program which asks the user to enter a radius. The program then calculates the area of the circle and prints it out.
Make sure that the area which is printed out only has two decimal places.
Don't worry about error handling.

Sample Output:
Enter a circle radius:
13
The area is 530.93 units squared
*/

/*
The objective of 'Duck, duck, goose' is to walk in a circle, tapping on each player's head until one is finally chosen. 

Task: Given an array of players and an index (1-based), return the name of the chosen player. 

Sample Output:
Enter the player to be the goose:
3
Goose is player number: 3
The players are:
Nathan James Fred Sarah
The goose is: Fred

Enter the player to be the goose:
6
Goose is player number: 6
Going around the circle more than once
The players are:
Nathan James Fred Sarah
The goose is: James

Enter the player to be the goose:
9
Goose is player number: 9
Going around the circle more than once
The players are:
Nathan James Fred Sarah Francois
The goose is: Sarah
*/

/*
Philip's just turned four and he wants to know how old he will be in various years in the future such as 2090 or 3044. 
His parents can't keep up calculating this so they've begged you to help them out by writing a programme that can answer Philip's endless questions.
Your task is to write a function which takes two parameters: the year of birth and the year to count years in relation to. 
Since Philip is getting more courious every day he may soon want to know how many years it was until he would be born, so your function needs to work with both dates in the future and in the past.
Provide output in this format: For dates in the future: "You are ... year(s) old." For dates in the past: "You will be born in ... year(s)." 
If the year of birth equals the year requested return: "You were born this very year!"
"..." are to be replaced by the number, followed and proceeded by a single space.
Make sure that you need to account for both "year" and "years", depending on the result.

Sample Output:
Enter your year of birth:
1986
Enter year to calculate to:
2017
You are 31 years old

Enter your year of birth:
1986
Enter year to calculate to:
1922
You will be born in 64 years

Enter your year of birth:
1986
Enter year to calculate to:
1987
You are 1 years old

Enter your year of birth:
1956
Enter year to calculate to:
a
That input is not recognized
*/

/*
Write function makeUpperCase.

Sample Output:
Enter a word to convert:
nathan
Converting to upper case
NATHAN

Enter a word to convert:
12
Converting to upper case
12

Enter a word to convert:
h@t
Converting to upper case
H@T
*/ 

/*
For a pole vaulter, it is very important to begin the approach run at the best possible starting mark. 
There is a guideline that will help a beginning vaulter start at approximately the right location, based on the vaulter's body height.
You are given the following two guidelines to begin with: (1) A vaulter with a height of 1.52 meters should start at 9.45 meters on the runway. 
(2) A vaulter with a height of 1.83 meters should start at 10.67 meters on the runway.

You will receive a vaulter's height in meters. Your job is to return the best starting mark in meters, rounded to two decimal places.

Sample Output:
Enter your height:
1.23
Your ideal StartingMark is 8.31 m from the vault

Enter your height:
a
That input was not recognized
*/

/*
Create a program which allows the user to enter a user-determined number of scores into an array, with a max of 5 scores. 
The program should check that the numbers are positive and less than 300. 
If not, do not add them to the array.
Display the valid entries after the user has entered their scores. Your solution should include input validation.

Sample Output:
Enter the number of scores to store:
3
Enter score:
t
Invalid Input
Enter score:
14578
Number outside of range
Enter score:
23
Enter score:
56
Enter score:
145
You entered:
23
56
145
*/

/*
Write a function called repeatStr which repeats the given string string exactly n times.
eg:
repeatStr(6, "I") // "IIIIII"
repeatStr(5, "Hello") // "HelloHelloHelloHelloHello"

SampleOutput:
Enter a word:
Hello
Enter the number of times to repeat the word:
4
HelloHelloHelloHello
*/

/*
Write a 'welcome' function that takes a parameter 'language' (always a string), and returns a greeting - if you have it in your database. 
Store the languages as a database (eg an object). 
It should default to English if the language is not in the database, or in the event of an invalid input.

The database:
{"english", "Welcome"},
{"czech", "Vitejte"},
{"danish", "Velkomst"},
{"dutch", "Welkom"},
{"estonian", "Tere tulemast"},
{"finnish", "Tervetuloa"},
{"flemish", "Welgekomen"},
{"french", "Bienvenue"},
{"german", "Willkommen"},
{"irish", "Failte"},
{"italian", "Benvenuto"},
{"latvian", "Gaidits"},
{"lithuanian", "Laukiamas"},
{"polish", "Witamy"},
{"spanish", "Bienvenido"},
{"swedish", "Valkommen"},
{"welsh", "Croeso"}

Sample Output:
Enter a language to select a greeting:
spanish
Bienvenido

Enter a language to select a greeting:
afrikaans
That language was not found in the database
Welcome
*/

/*
Write a program which reads in the width and height (as doubles) of a hole in the wall for a window.
The program should then print out the amount of wood required for the frame (in metres) and glass required to double glaze a window of that size.
Include input validation in your solution.
Use passing parameters as output for a function called Calculating which does the actual calculations.

Sample Output:
Enter the width of the window in meters:
a
Invalid Input
Enter the width of the window in meters:
2.1
Enter the height of the window in meters:
1
The length of wood required for a window that size is 6.2 m
The area of glass required for a window that size is 4.2 m
*/