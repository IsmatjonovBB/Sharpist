namespace Interfaces;

delegate void MoveHandler();
// interface IMovable
// {
    // void Move() => Console.WriteLine("Walking");
    // public const int minSpeed = 0;
    // private static int maxSpeed = 60;
    // static double GetTime(double distance, double speed) => distance / speed;
    //
    // static int MaxSpeed
    // {
    //     get
    //     {
    //         return maxSpeed;
    //     }
    //     set
    //     {
    //         if (value > 0) maxSpeed = value;
    //     }
    // }
// }


// class Person : IMovable { }
// struct Car : IMovable
// {
//     public void Move()
//     {
//         Console.WriteLine("Driving");
//     }
// }


// public abstract interface IAction    // We cannot use modificator abstract for interfaces!
// {
//     void Move();
// }
// internal interface IRunAction : IAction
// {
//     void Run();
// }


// class RunAction : IRunAction
// {
//     internal void Move()     // Don't use any access mod beside public!
//     {
//         Console.WriteLine("I am running!");
//     }
// }
// interface IAction
// {
//     void Move();
// }
// interface IRunAction : IAction
// {
//     new void Move();
// }


// interface IFoo
// {
//     void Execute();
// }
// interface IBar
// {
//     void Execute();
// }
// class Tester : IFoo, IBar
// {
//     void IFoo.Execute()
//     {
//         Console.WriteLine("Tester Executes!");
//     }
//     void IBar.Execute()
//     {
//         Console.WriteLine("Tester Executes!");
//     }
// }

interface IMessage
{
    string Text { get; set; }
}

interface IPrintble
{
    void Print();
}

class Message : IMessage, IPrintble
{
    public string Text { get; set; }
    public Message(string text) => Text = text;
    public void Print() => Console.WriteLine(Text);
}

// #1
interface IAction
{
    void Move();
}
class BaseAction : IAction
{
    public void Move() => Console.WriteLine("Move in BaseAction");
}

class HeroAction : BaseAction, IAction
{
    void IAction.Move() => Console.WriteLine("Move in HeroAction");
}

// #2
// class Person : ISchool, IUniversity
// {
//     // public void Study() => Console.WriteLine("Study in school or in university");
//     void IUniversity.Study() => Console.WriteLine("Study at University");
//     void ISchool.Study() => Console.WriteLine("Study at School");
// }
// interface ISchool
// {
//     void Study();
// }
// interface IUniversity
// {
//     void Study();
// }


// #3
interface IMovable
{
    protected internal void Move();
    protected internal string Name { get;}
    protected internal event MoveHandler MoveEvent;
}
class Person : IMovable
{
    string name;
    // явная реализация события - дополнительно создается переменная
    MoveHandler? moveEvent;
    // неявная реализация события с модификатором public
    public event MoveHandler MoveEvent
    {
        add => moveEvent += value;
        remove => moveEvent -= value;
    }
    // неявная реализация свойства - в виде автосвойства, но с модификатором public
    public string Name { get => name; }
    public Person(string name) => this.name = name;
    // неявная реализация метода, но с модификатором public 
    public void Move()
    {
        Console.WriteLine($"{name} is walking");
        moveEvent?.Invoke();
    }
}