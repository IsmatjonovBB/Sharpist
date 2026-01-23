using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using Delegates.Messages;

namespace Delegates;

class Program
{
    // delegate void Message();
    delegate int Operation(int x, int y);
    // delegate void DomeDel(int a, double b);
    // delegate T Operation<T, K>(K val);

    static void Main(string[] args)
    {
        // Message mes;
        // mes = Hello;
        // mes();
        // void Hello() => Console.WriteLine("Hello METANIT.COM!");

        // Message message1 = Welcome.Print;
        // Message message2 = new Hello().Display;
        //
        // message1();
        // message2();

        // Operation operation = Add;
        // int result = operation(10, 20);
        // Console.WriteLine(result);
        //
        // operation = Multiply;
        // result = operation(10, 20);
        // Console.WriteLine(result);
        //
        // int Add(int x, int y) => x + y;
        // int Subtract(int x, int y) => x - y;
        // int Multiply(int x, int y) => x * y;

        // Operation operation = Add;
        // Operation operation2 = new Operation(Add); Another option
        
        // void SomeMethod1(int g, double n) { } Only 'll accept this method!

        // double SomeMethod2(int g, double n) => g + n;
        // void SomeMethod3(int n, double g) { }
        // void SomeMethod4(ref int g, double n) { }
        // void SomeMethod5(out int g, double n) { g = 6; } Don't accept cause' of parameters

        
        // Message? message = Hello;
        // message += HowAreYou;
        // message();
        // message -= HowAreYou;
        // if (message != null) message();
        
        
        // Message mes1 = Hello;
        // Message mes2 = HowAreYou;
        // Message mes3 = mes1 + mes2;  IMPORTATNT PART!!!
        // mes3();
        
        
        // Message mes = Hello;
        // mes();  Calling like Methods
        //
        // Operation op = Add;
        // int n = op(10, 20);  Also...
        // Console.WriteLine(n);

        
        // Message mes = Hello;
        // mes.Invoke();  Using Method 'Invoke()' to call a delegate instead of '()'
        //
        // Operation op = Add;
        // int n = op.Invoke(1, 2);
        // Console.WriteLine(n);

        
        // Message? mes = null;
        // mes?.Invoke();
        //
        // Operation? op = Add;
        // op -= Add;
        // int? n = op.Invoke(1, 2);  If delegate don't have an  instance, than won't return anything

        // Operation op = Subtract;
        // op += Multiply;
        // op += Add;
        // Console.WriteLine(op.Invoke(1, 2));  Return only the last reference!

        
        // Operation<decimal, int> squareOperation = Square;
        // decimal result1 = squareOperation(5);
        // Console.WriteLine(result1);
        //
        // Operation<int, int> doubleOperation = Double;
        // int result2 = doubleOperation(5);
        // Console.WriteLine(result2);
        //
        // decimal Square(int x) => x * x;
        // int Double(int x) => x + x;      IMPORTANT PART WITH GENERICS!!!

        
        // DoOperation(5, 4, Add);
        // DoOperation(5, 4, Subtract);
        // DoOperation(5, 4, Multiply);
        //
        // void DoOperation(int a, int b, Operation op)
        // {
        //     Console.WriteLine(op(a,b));
        // }        Using delegate as parameter of Method!
        
        
        // Operation operation = SelectOperation(OperationType.Add);
        // Console.WriteLine(operation(10, 20));
        //
        // operation = SelectOperation(OperationType.Subtract);
        // Console.WriteLine(operation(10, 20));
        //
        // operation = SelectOperation(OperationType.Multiply);
        // Console.WriteLine(operation(10, 20));
        //
        // Operation SelectOperation(OperationType opType)
        // {
        //     switch (opType)
        //     {
        //         case OperationType.Add: return Add;
        //         case OperationType.Subtract: return Subtract;
        //         default: return Multiply;
        //     }
        // }
        //
        //
        // void Hello() => Console.WriteLine("Hello, Metanit.com");
        // void HowAreYou() => Console.WriteLine("How are you?");
        // void HowOldAreYou() => Console.WriteLine("How old are you?");
        
        
        /* USING DELEGATES */

        // Account account = new(100);
        // account.AccountRegister(Print);
        // account.AccountRegister(ColorPrint);
        // account.Take(50);
        // account.UnRegisterAccount(ColorPrint);
        // account.Take(100);
        // void Print(string message) => Console.WriteLine(message);
        //
        // void ColorPrint(string message)
        // {
        //     Console.ForegroundColor = ConsoleColor.Green;
        //     Console.WriteLine(message);
        //     Console.ResetColor();
        // }
        
        
        /* ANONYMOUS METHODS */

        // MessageHandler handler = delegate(string mes)
        // {
        //     Console.WriteLine(mes);
        // };
        // handler("Hello World!");
        
        // static void ShowMessage(string message, MessageHandler handler)
        // {
        //     handler.Invoke(message);
        // }
        //
        // ShowMessage("Hello", delegate(string mes)
        // {
        //     Console.WriteLine(mes);
        // });

        // MessageHandler handler = delegate
        // {
        //     Console.WriteLine("Annonymous Method!");
        // };
        // handler("hello World!");

        // int z = 7;
        // Operation operation = delegate(int x, int y)
        // {
        //     return x + y + z;
        // };
        // int result = operation(1, 2);
        // Console.WriteLine(result);
        
        
        /* LYAMBDA EXPRESSION*/

        // Message hello = () =>
        // {
        //     Console.Write("Hello ");
        //     Console.WriteLine("World!");
        // };
        // hello();
        // hello();
        // hello();
        
        // var hello = () => Console.WriteLine("Hello World!");
        // hello();
        // hello();
        // hello();
        
        // MathOperation sum = (x, y) => Console.WriteLine($"{x} + {y} = {x + y}");
        // sum(10, 20);
        // sum(220, 440);

        // var sum = (x, y) => Console.WriteLine($"{x} + {y} = {x + y}");  ERROR!
        // var sum = (int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
        // sum(1, 2);
        // sum(30, 40);
        
        // PrintHandler print = message => Console.WriteLine(message);  //We may not use '()' if we have only one parameter
        // print("Hello!");
        // print("Welcome!");  

        // var welcome = (string message = "Hello") => Console.WriteLine(message);  //We can use default value in our parameters
        // welcome("Hello World!");
        // welcome();
        
        // var sum = (int x, int y) => x + y;
        // int sumResult = sum(4, 5);
        // Console.WriteLine(sumResult);
        //
        // Operation multiply = (x, y) => x * y;
        // int multiplyResult = multiply(4, 5);
        // Console.WriteLine(multiplyResult);

        // var substact = (int x, int y) =>
        // {
        //     if (x > y) return x - y;
        //     else return y - x;
        // };
        // int result1 = substact(10, 6);
        // Console.WriteLine(result1);
        //
        // int result2 = substact(-10, 6);
        // Console.WriteLine(result2);
        
        
        
        // Add & Remove actions in Lambda Expressions
        
        // var hello = () => Console.WriteLine("METANIT.COM");
        //
        // var message = () => Console.Write("Hello ");
        // message += () => Console.WriteLine("World");
        // message += hello;
        // message += Print;
        //
        // message();
        // Console.WriteLine("----------------------");
        //
        // message -= Print;
        // message -= hello;
        //
        // message?.Invoke();
        //
        // void Print() => Console.WriteLine("Welcome to C#!");

        
        
        // Lambda-Expression as argument for method
        
        // int[] integers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        //
        // int result1 = Sum(integers, x => x > 5);
        // Console.WriteLine(result1);
        //
        // int result2 = Sum(integers, x => x % 2 == 0);
        // Console.WriteLine(result2);
        //
        // int Sum(int[] numbers, IsEqual func)
        // {
        //     int result = 0;
        //     foreach (var i in numbers)
        //     {
        //         if (func(i)) 
        //             result += i;
        //     }
        //     return result;
        // }
        
        
        
        // Lambda-Expression as a result of method

        // Operation operation = SelectOperation(OperationType.Add);
        // Console.WriteLine(operation(10, 20));
        //
        // operation = SelectOperation(OperationType.Subtract);
        // Console.WriteLine(operation(50, 40));
        //
        // operation = SelectOperation(OperationType.Multiply);
        // Console.WriteLine(operation(10, 50));
        //
        // Operation SelectOperation(OperationType operationType)
        // {
        //     switch (operationType)
        //     {
        //         case OperationType.Add: return (x, y) => x + y;  //We can use Lambda-Expression here
        //         case OperationType.Subtract: return (x, y) => x - y;
        //         default: return (x, y) => x * y;
        //     }
        // }
        
        
        /* EVENTS */

        // Account account = new(100);
        // account.Notify += DisplayMessage;
        // account.Notify += DisplayRedMessage;
        // account.Put(20);
        // // Console.WriteLine($"Сумма на счете: {account.Sum}");
        // account.Take(70);
        // // account.Notify -= DisplayRedMessage;
        // Console.WriteLine($"Сумма на счете: {account.Sum}");
        // account.Take(180);
        // // Console.WriteLine($"Сумма на счете: {account.Sum}");

        // Account acc = new Account(100);
        // acc.Notify += new Account.AccountHandler(DisplayMessage);
        // acc.Notify += DisplayMessage;
        // acc.Put(20);

        // Unit with Annonymous method
        // Account account = new(100);
        // account.Notify += delegate (string message)
        // {
        //     Console.WriteLine(message);
        // };
        // account.Put(20);
        
        // Unit with Lambda-expression
        // Account account = new Account(100);
        // account.Notify += message => Console.WriteLine(message);
        // account.Put(20);
        
        
        // Controlling editors
        // Account account = new Account(100);
        // account.Notify += DisplayMessage;
        // account.Put(20);
        // account.Notify -= DisplayMessage;
        // account.Take(60);
        
        
        // Event data transfer | IMPORTANT MOMENT!!!
        // Account account = new(100);
        // account.Notify += DisplayMessage;
        // // account.Notify += DisplayColorMessage;
        // account.Put(20);
        // account.Put(70);
        // account.Put(150);
        //
        // void DisplayMessage(Account sender, AccountEventArgs e)
        // {
        //     Console.WriteLine($"Сумма транзакции: {e.Sum}");
        //     Console.WriteLine(e.Message);
        //     Console.WriteLine($"Текущая сумма на счете: {sender.Sum}");
        // }

        // void DisplayColorMessage(Account sender, AccountEventArgs e)
        // {
        //     Console.ForegroundColor = ConsoleColor.Red;
        //     Console.WriteLine($"TEST!");
        //     Console.ResetColor();
        // }
        // void DisplayRedMessage(string message)
        // {
        //     Console.ForegroundColor = ConsoleColor.Red;
        //     Console.WriteLine(message);
        //     Console.ResetColor();
        // }
        
        
        
        // Covariance
        // MessageBuilder messageBuilder = WriteSmsMessage; // ковариантность
        // Message message = messageBuilder("Hello");
        // message.Print();    // Email: Hello
        // SmsMessage WriteSmsMessage(string message) => new SmsMessage(message);

        // Console.WriteLine("\n----------------\n");
        //
        // EmailReciever emailBox = Reciever;
        // emailBox(new ("Welcome"));
        // void Reciever(Message message) => message.Print();
        //
        // Console.WriteLine("\n----------------\n");

        // GENERIC COVARIANCE
        // MessageBuilder<EmailMessage> EmailMessageWriter = text => new EmailMessage(text);
        // MessageBuilder<Message> messageBuilder = EmailMessageWriter;
        // Message message = messageBuilder("Hello, Tom");
        // message.Print();

        // GENERIC CONTRAVARIANCE
        // MessageReceiver<Message> messageReceiver = (Message message) => message.Print();
        // MessageReceiver<EmailMessage> emailReceiver = messageReceiver;
        // messageReceiver(new Message("Hello World!"));
        // messageReceiver(new EmailMessage("Hello World!"));
        
        
        // COMBINING COVARIANCE AND CONTRAVARIANCE
        // MessageConverter<Message, EmailMessage> toEmailConverter = message => new EmailMessage(message.Text);
        // MessageConverter<SmsMessage, Message> converter = toEmailConverter;
        // Message message = converter(new SmsMessage("Hello Work!"));
        // message.Print();
        
        
        // DELEGATES ACTION, PREDICATE AND FUNC

        // Action
        // DoOperation(10, 6, Add);
        // DoOperation(10, 6, Multiply);
        // void DoOperation(int a, int b, Action<int, int> op) => op(a, b);
        
        void Add(int a, int b) => Console.WriteLine($"{a} + {b} = {a + b}");
        void Multiply(int a, int b) => Console.WriteLine($"{a} * {b} = {a * b}");
        
        // Predicate
        // Predicate<int> isPositive = x => x >= 0;
        // Console.WriteLine(isPositive(20));
        // Console.WriteLine(isPositive(-20));
        
        // Func
        // int result1 = DoOperation(6, DoubleNumber);
        // Console.WriteLine(result1);
        //
        // int result2 = DoOperation(6, SquareNumber);
        // Console.WriteLine(result2);
        //
        // int DoOperation(int a, Func<int, int> operation) => operation(a);
        // int DoubleNumber(int a) => a * 2;
        // int SquareNumber(int a) => a * a;

        // Func<int, double, double> summa = (x, y) => x + y;
        // Console.WriteLine(summa(2, 3.32));

        // Func<int, int, string> createString = (x, y) => $"{x}{y}";
        // Console.WriteLine(createString(07, 71));
        // Console.WriteLine(createString(14, 88));
    }
}
// DELEGATES
delegate void MessageHandler(string message);
// delegate void Message();
delegate void MathOperation(int x, int y);
delegate void PrintHandler(string message);
delegate bool IsEqual(int x);
// delegate Message MessageBuilder(string message);
delegate void EmailReciever(EmailMessage message);
delegate T MessageBuilder<out T>(string message);
delegate void MessageReceiver<in T>(T message);
delegate E MessageConverter<in M, out E>(M message);

delegate void Action<in T>(T obj);