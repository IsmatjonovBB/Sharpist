namespace Delegates;
public delegate void AccountHendler(string message);
public class Account
{
    private int sum;
    AccountHendler hendler;
    
    public Account(int sum) => this.sum = sum;

    public void AccountRegister(AccountHendler del)
    {
        hendler += del;
    }

    public void UnRegisterAccount(AccountHendler del)
    {
        hendler -= del;
    }
    public void Add(int amount) => sum += amount;

    public void Take(int amount)
    {
        if (amount <= sum)
        {
            sum -= amount;
            hendler.Invoke($"From your account was withdrawed {amount}$");
        }   
        else
        {
            hendler.Invoke($"Insufficient funds. Your balance is {sum}$");
        }
    }
        
}