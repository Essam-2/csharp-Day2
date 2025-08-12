using System;
using System.Text.RegularExpressions;



class Account
{
    private string name = "Essam";

    //why we use Set 
        //    • a negative body temperature
        //    • a day in March outside the range 1 through 31
        //    • a product code not in the company’s product catalog, etc.
    public void SetName (string accountName)
    {
        name = accountName;
    }

    public string GetName()
    {
        return name;
    }
}


class AccountTest
{
    static void Main()
    {
        // create an Account object and assing iy to myAccount 
        Account myAccount = new Account();

        Console.WriteLine($"Initial name is: {myAccount.GetName()}");
        Console.WriteLine("Enter the name");


        string theName = Console.ReadLine();

        myAccount.SetName(theName);

        Console.WriteLine($"myAccount's name is: {myAccount.GetName()}");






        Console.ReadLine();
    }
}