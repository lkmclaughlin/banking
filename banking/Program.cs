
using banking;


var s1 = new SavingsComp();

s1.AccountId = "Lynn";
s1.Description = "My Savings Account";
s1.Balance = 1000;


/*
var s1 = new Savings();
s1.Deposit(100);
s1.Withdraw(50);
s1.Deposit(50);
var interest = s1.PayInterest(3);

Console.WriteLine($"S1 paid interest of {interest:C}");
Console.WriteLine($"S1 balance is {s1.Balance:C}");
*/

/*
var a1 = new Account();
a1.Deposit(5);
a1.Deposit(25);
a1.Withdraw(-100);

var a2 = new Account();
a2.Deposit(100);
a2.Transfer(50, a1);

Console.WriteLine($"A1 balance is {a1.Balance:C}");
Console.WriteLine($"A2 balance is {a2.Balance:C}");
*/