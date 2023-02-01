namespace Bank_System;
class Program
{
    static void Main(string[] args)
    {
        //test program
        Account a = new Account(1122, 20000);
        a.InterestRate = 4.5;

        a.Withdraw(2500);
        a.Deposit(3000);
        Console.WriteLine($"Balance: {a.Balance}");
    }
}
