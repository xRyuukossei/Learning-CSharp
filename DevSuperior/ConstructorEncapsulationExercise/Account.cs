using System;
using System.Globalization;

namespace ConstructorEncapsulationExercise;
internal class Account
{
    private string _name;
    public int AccountNumber { get; private set; }
    public double Balance { get; private set; }

    public Account() {}
    public Account(string name, int accountNumber) : this()
    {
        _name = name;
        AccountNumber = accountNumber;
    }

    public Account(string name, int accountNumber, double balance) : this(name, accountNumber)
    {
        Balance = balance;
    }

    public string Name
    {
        get { return _name; }
        set { if (value != null && value.Length >= 3)
            {
                _name = value;
            }
        }
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdrawal(double amount)
    {
        Balance -= amount + 5;
    }

    public override string ToString()
    {
        return "Account " 
            + AccountNumber 
            + ", Holder: " 
            + _name 
            + ", Balance: $ " 
            + Balance.ToString("F2", CultureInfo.InvariantCulture);
    }
}
