using System;

public class Account
{
    public int _balance;
    public void Desposit(int amount)
    {
        _balance = _balance + amount;
    }
}

Account savings = new Account();

savings._balance = 50;

// above makes the class open. The _balance can be accessed easily.




// below wont work
// Below in an example of encapsulation, where _balance can only be accessed privately.

public class Account
{
    private int _balance;

    public void Desposit(int amount)
    {
        _balance = _balance + amount;
    }
    //...
}

Account savings = new Accounts();

savings._balance = 50; // this now wouldnt be able to access balance because it is private, this no longer will work





// this will work
// below is getters and setter

public class Accounts{
    private int _balance;

    public void Desposit(int amount)
    {
        _balance = _balance + amount;
    }
    //...
}


Accounts savings = new Accounts();

// setter
// this is how you set the balance, put it in the ()
savings.SetBalance(50);


public class Accounts{
    private int _balance;

    public void Desposit(int amount)
    {
        _balance = _balance + amount;
    }
    //...
}


Accounts savings = new Accounts();


//getter
int money = savings.GetBalance();




// this is a list of transactions being made.

public class Accounts{
    privite List<int> _transaction = new List<int>();

    public void Desposit(int amount)
    {
        //_balance = _balance + amount; we can now change it to..
        _transaction.Add(amount);
    }
    //...
}

Accounts savings = new Accounts();
// int money = savings.GetBalance(); no you can
savings.Desposit(50);




// now...

public class Accounts{
    privite List<int> _transaction = new List<int>();

    public void Desposit(int amount)
    {
        //_balance = _balance + amount; we can now change it to..
        _transaction.Add(amount);
    }

    public int GetBalance()
    {

    }
    //...
}

Accounts savings = new Accounts();
// int money = savings.GetBalance(); no you can
savings.Desposit(50);