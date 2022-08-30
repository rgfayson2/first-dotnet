
public class SavingsAcount : BankAccount
{

    public SavingsAcount() : base()
    {
        Balance = 200;

    }

    public SavingsAcount(decimal amount) : base(amount) {
        
    }

}