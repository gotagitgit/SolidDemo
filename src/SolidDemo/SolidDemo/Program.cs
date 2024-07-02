namespace SolidDemo;

internal class Program
{
    static void Main(string[] args)
    {
        var bankAccount = new BankAccount(1, "Juan Dela Cruz", 100m);

        bankAccount.Withdraw(50m);
        var balance = bankAccount.GetBalance();

        Console.WriteLine($"Your remaining Balance is {balance:f2}");

        bankAccount.Withdraw(100m);

        Console.ReadLine();
    }
}
