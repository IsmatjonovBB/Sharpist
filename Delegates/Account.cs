namespace Delegates;

// OLD DELEGATES CLASS
// public class Account
// {
//     private int sum;
//     AccountHendler hendler;
//     
//     public Account(int sum) => this.sum = sum;
//
//     public void AccountRegister(AccountHendler del)
//     {
//         hendler += del;
//     }
//
//     public void UnRegisterAccount(AccountHendler del)
//     {
//         hendler -= del;
//     }
//     public void Add(int amount) => sum += amount;
//
//     public void Take(int amount)
//     {
//         if (amount <= sum)
//         {
//             sum -= amount;
//             hendler.Invoke($"From your account was withdrawed {amount}$");
//         }   
//         else
//         {
//             hendler.Invoke($"Insufficient funds. Your balance is {sum}$");
//         }
//     }
// }    // OLD CLASS FOR DELEGATES

// OLD EVENT CLASS
// public class Account
// {
//     public delegate void AccountHandler(string message);
//
//     private AccountHandler? notify;
//     public event AccountHandler Notify
//     {
//         add
//         {
//             notify += value;
//             Console.WriteLine($"{value.Method.Name} добавлен");
//         }
//         remove
//         {
//             notify -= value;
//             Console.WriteLine($"{value.Method.Name} удален");
//         }
//     }
//     public int Sum { get; private set; }
//
//     public Account(int sum) => Sum = sum;
//
//     public void Put(int sum)
//     {
//         Sum += sum;
//         notify?.Invoke($"На счет поступило: {sum}");
//     }
//
//     public void Take(int sum)
//     {
//         if (Sum >= sum)
//         {
//             Sum -= sum;
//             notify?.Invoke($"Со счета снято: {sum}");
//         }
//         else
//         {
//             notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}");
//         }
//     }
// }

public class Account
{
    public delegate void AccountHandler(Account sender, AccountEventArgs e);
    public event AccountHandler? Notify;
    public int Sum { get; private set; }
    public Account(int sum) => Sum = sum;

    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke(this, new AccountEventArgs($"На счет поступило {sum}", sum));
    }

    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke(this, new AccountEventArgs($"Сумма {sum} снята со счета", sum));
        }
        else
        {
            Notify?.Invoke(this, new AccountEventArgs("Недостаточно денег на счете", sum));
        }
    }
}