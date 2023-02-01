class Account
{
    //class members
    private int id;
    private double balance;
    private double interestRate;
    private DateTime dateCreated;
    //constructors
    public Account()
    {
        id = 0;
        balance = 0;
        interestRate = 0;
    }

    public Account(int id, double balance)
    {
        this.id = id;
        this.balance = balance;
    }

    //getters and setters
    public int Id
    {
        get{return id;}
        set{id = value;}
    }
    public double Balance
    {
        get{return balance;}
        set{balance = value;}
    }
    public double InterestRate
    {
        get{return interestRate;}
        set{interestRate = value;}
    }

    public DateTime DateCreated
    {
        get{return dateCreated;}
        set{dateCreated = value;}
    }

    public double GetMonthlyInterestRate()
    {
        double monthlyInterest = interestRate/12;

        return balance * monthlyInterest;
    }

    public double Withdraw(double amount)
    {
        if(balance >= amount)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("Insufficient account balance");
        }

        return balance;
    }

    public double Deposit(double amount)
    {
        balance += amount;
        return balance;
    }
}