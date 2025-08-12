using System;
using System.Text.RegularExpressions;



class Account
{
    public string Name { get; private set; }
    public decimal balance { get; private set; }


    public Account() { }

    public Account (string accountName, decimal initialBalance)
    {
        Name = accountName;
        Balance = initialBalance;
    }

    public Account(string accountName)
    {
        Name = accountName;
    }

    //why we use Set 
    //    • a negative body temperature
    //    • a day in March outside the range 1 through 31
    //    • a product code not in the company’s product catalog, etc.
    public void SetName (string accountName)
    {
        Name = accountName;
    }

    public string GetName()
    {
        return Name;
    }


    public decimal Balance
    {
        get
        {
            return balance;
        }

        private set 
        { 
            if(value > 0.0m)
            {
                balance = value;
            }
        }
    }

    public void Deposit(decimal despositAmount)
    {
        if(despositAmount > 0.0m)
        {
            Balance = Balance + despositAmount;
        }
    }
}


class AccountTest
{
    static void Main()
    {
        // create an Account object and assing iy to myAccount 
        //Account myAccount = new Account();
        //Account Account1 = new Account("1st Account");

        Account AccountWithBalance = new Account("Essam", 10000);



        Console.WriteLine($"{AccountWithBalance.Name}'s balnce: {AccountWithBalance.balance:C}");


        Console.Write("\nEnter deposit amount for account1: ");

        decimal depositAmount = decimal.Parse(Console.ReadLine());
        Console.WriteLine($"adding to account1 balance\n");
        AccountWithBalance.Deposit(depositAmount);

        Console.WriteLine($"{AccountWithBalance.Name}'s balance: {AccountWithBalance.Balance:C}");





        Console.ReadLine();
    }
}