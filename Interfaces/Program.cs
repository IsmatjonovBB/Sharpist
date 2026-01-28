namespace Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // Application of Interfaces
        
        // Person person = new Person();
        // Car car = new Car();
        // DoAction(person);
        // DoAction(car);
        // void DoAction(IMovable movable) => movable.Move();
        
        
        // Default Interface implementation

        // IMovable tom = new Person();
        // Car tesla = new Car();
        // tom.Move();
        // tesla.Move();
        // Person bob = new Person();
        // bob.Move();      // Error!
        
        
        // Multiple Interface Implementation

        Message hello = new Message("Hello World!");
        hello.Print();
        
        IMessage sayHello = new Message("Hello METANIT.COM!");
        Console.WriteLine(sayHello.Text);

        // Не все объекты IMessage являются объектами Message, необходимо явное приведение
        // Message someMessage = sayHello;     // Error!

        // Интерфейс IMessage не имеет свойства Print, необходимо явное приведение
        // sayHello.Print();   // Error!
        
        // если hello представляет класс Message, выполняем преобразование
        if (sayHello is Message someMessage) someMessage.Print();
        
        
        // Explicit interface implementation
        BaseAction baseAction1 = new BaseAction();

        // baseAction1.Move();  // Error! there is not method Move() in BaseAction
        
        // Unsafe
        ((IAction)baseAction1).Move();
        
        // Safe
        if(baseAction1 is IAction action) action.Move();
        
        // else like this...
        IAction baseAction2 = new BaseAction();
        baseAction2.Move();

        Console.WriteLine("---------------");
        
        // Person person = new Person();
        // ((ISchool)person).Study();
        // ((IUniversity)person).Study();

        Console.WriteLine();
        
        // #1
        HeroAction action1 = new HeroAction();
        action1.Move();
        ((IAction)action1).Move();

        Console.WriteLine();
        
        Person tom = new Person("Tom");
        // подписываемся на событие
        tom.MoveEvent += () => Console.WriteLine($"{tom.Name} is moving");
        tom.Move();
    }
}