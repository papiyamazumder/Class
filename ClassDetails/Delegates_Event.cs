using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDetails
{
    // Delegates -> Access Modifier, Return Type, and Number, Type, and Order of Parameters of both del and func has to be same, only name can be different
    // Declare, Instant create as object, Invoke

    public delegate void MyDelegate(int x, int y);  // Syntax custom delegates

    public delegate void EventHandler(object sender, EventArgs e);      // Built in delegates events
    public delegate void EventHandler<TEventArgs>(object sender, TEventArgs e);

    #region Passing Methods as Method Parameters : When to use
    //internal class Delegates_Event
    //{
    //    public delegate void WorkPerformedHandler(int hours, WorkType workType);
    //    static void Main(string[] args)
    //    {
    //        WorkPerformedHandler del1 = new WorkPerformedHandler(Manager_WorkPerformed);
    //        del1(10, WorkType.Golf);
    //        //del1.Invoke(50, WorkType.GotoMeetings);
    //        Console.ReadKey();
    //    }
    //    public static void Manager_WorkPerformed(int workHours, WorkType wType)
    //    {
    //        Console.WriteLine("Work Performed by Event Handler");
    //        Console.WriteLine($"Work Hours: {workHours}, Work Type: {wType}");
    //    }
    //}
    //public enum WorkType
    //{
    //    Golf,
    //    GotoMeetings,
    //    GenerateReports
    //}

    #endregion

    #region Callbacks: When to use

    //public delegate void CallbackMethodHandler(string message);
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Program obj = new Program();
    //        CallbackMethodHandler del1 = new CallbackMethodHandler(obj.CallbackMethod);
    //        //Here, I am calling the DoSomework function and I want the 
    //        //DoSomework function to call the delegate at some point of time
    //        //which will invoke the CallbackMethod method
    //        DoSomework(del1);
    //        Console.ReadKey();
    //    }
    //    public static void DoSomework(CallbackMethodHandler del)
    //    {
    //        Console.WriteLine("Processing some Task");
    //        del("Pranaya");
    //    }
    //    public void CallbackMethod(string message)
    //    {
    //        Console.WriteLine("CallbackMethod Executed");
    //        Console.WriteLine($"Hello: {message}, Good Morning");
    //    }
    //}

    #endregion

    #region Multicast delegates

    //public delegate void RectangleDelegate(double Width, double Height);
    //public class Rectangle
    //{
    //    public void GetArea(double Width, double Height)
    //    {
    //        Console.WriteLine($"Area is {Width * Height}");
    //    }
    //    public void GetPerimeter(double Width, double Height)
    //    {
    //        Console.WriteLine($"Perimeter is {2 * (Width + Height)}");
    //    }
    //    static void Main(string[] args)
    //    {
    //        Rectangle rect = new Rectangle();
    //        RectangleDelegate rectDelegate = new RectangleDelegate(rect.GetArea);
    //        rectDelegate += rect.GetPerimeter;      // You use += operator to chain delegates together. instead of RectangleDelegate rectDelegate = rect.GetArea; 

    //        Delegate[] InvocationList = rectDelegate.GetInvocationList();
    //        Console.WriteLine("InvocationList:");
    //        foreach (var item in InvocationList)
    //        {
    //            Console.WriteLine($"  {item}");
    //        }
    //        Console.WriteLine();

    //        Console.WriteLine("Invoking Multicast Delegate:");
    //        rectDelegate(23.45, 67.89);
    //        // OR
    //        //rectDelegate.Invoke(13.45, 76.89);

    //        Console.WriteLine();
    //        Console.WriteLine("Invoking Multicast Delegate After Removing one Pipeline:");
    //        //Removing a method from delegate object
    //        rectDelegate -= rect.GetPerimeter;      // Remove Perimeter delgate and only return area  // Delisting
    //        rectDelegate.Invoke(13.45, 76.89);
    //        Console.ReadKey();
    //    }
    //}

    #endregion

    #region Multiple multicast delegate

    //public delegate void MathDelegate(int No1, int No2);
    //public class Program1
    //{
    //    //Static Method
    //    public static void Add(int x, int y)
    //    {
    //        Console.WriteLine($"Addition of {x} and {y} is : {x + y}");
    //    }
    //    //Static Method
    //    public static void Sub(int x, int y)
    //    {
    //        Console.WriteLine($"Subtraction of {x} and {y} is : {x - y}");
    //    }
    //    //Non-Static Method
    //    public void Mul(int x, int y)
    //    {
    //        Console.WriteLine($"Multiplication of {x} and {y} is : {x * y}");
    //    }
    //    //Non-Static Method
    //    public void Div(int x, int y)
    //    {
    //        Console.WriteLine($"Division of {x} and {y} is : {x / y}");
    //    }
    //    static void Main(string[] args)
    //    {
    //        Program1 p = new Program1();
    //        MathDelegate del1 = new MathDelegate(Add);      //Static Method within the same class can be access directly
    //        MathDelegate del2 = new MathDelegate(Program1.Sub);      //Static Method can be access using class name
    //        MathDelegate del3 = new MathDelegate(p.Mul);                    //Non-Static Method must be access through object 
    //        MathDelegate del4 = new MathDelegate(p.Div); ;

    //        MathDelegate del5 = del1 + del2 + del3 + del4;                      //In this example del5 is a multicast delegate. We can use +(plus) operator to chain delegates together and -(minus) operator to remove a delegate.
    //        Delegate[] InvocationList = del5.GetInvocationList();
    //        Console.WriteLine("InvocationList:");
    //        foreach (var item in InvocationList)
    //        {
    //            Console.WriteLine($" {item}");
    //        }
    //        Console.WriteLine();

    //        Console.WriteLine("Invoking Multicast Delegate::");
    //        del5.Invoke(20, 5);
    //        Console.WriteLine();

    //        Console.WriteLine("Invoking Multicast Delegate After Removing one Delegate:");
    //        del5 -= del2;
    //        del5(22, 7);

    //        Console.ReadKey();
    //    }
    //}

    #endregion

    #region Multicast Delegates with Return Type in C#

    //// Deletegate's return type is int
    //public delegate int SampleDelegate();
    //public class Program
    //{
    //    static void Main()
    //    {
    //        SampleDelegate del = new SampleDelegate(MethodOne);
    //        del += MethodTwo;

    //        // The Value Returned By Delegate will be 2, returned by the MethodTwo(), as it is the last method in the invocation list.
    //        int ValueReturnedByDelegate = del();
    //        Console.WriteLine($"Returned Value = {ValueReturnedByDelegate}");
    //        Console.ReadKey();
    //    }
    //    // This method returns one
    //    public static int MethodOne()
    //    {
    //        Console.WriteLine("MethodOne is Executed");
    //        return 1;
    //    }
    //    // This method returns two
    //    public static int MethodTwo()
    //    {
    //        Console.WriteLine("MethodTwo is Executed");
    //        return 2;
    //    }
    //}

    #endregion

    #region  Multicast Delegates using out Parameter in C#:

    //// Deletegate has an int output parameter
    //public delegate void SampleDelegate(out int Integer);
    //public class Program
    //{
    //    static void Main()
    //    {
    //        SampleDelegate del = new SampleDelegate(MethodOne);
    //        del += MethodTwo;
    //        // The ValueFromOutPutParameter will be 2, initialized by MethodTwo(),
    //        // as it is the last method in the invocation list.
    //        int ValueFromOutPutParameter = 0;        // This is the initial value before any method is invoked.Once invoked, it will get updated
    //        del(out ValueFromOutPutParameter);
    //        Console.WriteLine($"Returned Value = {ValueFromOutPutParameter}");
    //        Console.ReadKey();
    //    }
    //    // This method sets ouput parameter Number to 1
    //    public static void MethodOne(out int Number)
    //    {
    //        Console.WriteLine("MethodOne is Executed");
    //        Number = 1;
    //    }
    //    // This method sets ouput parameter Number to 2
    //    public static void MethodTwo(out int Number)
    //    {
    //        Console.WriteLine("MethodTwo is Executed");
    //        Number = 2;
    //    }
    //}
    #endregion

    #region Generic Delegates   // Inbuilt delegates -> Func(with return), Action(returns nothing), Predicate(returns bool)

    //public class GenericDelegates
    //{
    //static void Main(string[] args)
    //{
    //    Func<int, float, double, double> obj1 = new Func<int, float, double, double>(AddNumber1);   // OR //Func<int, float, double, double> obj1 = (x, y, z) => { return x + y + z; }
    //    double Result = obj1.Invoke(100, 125.45f, 456.789);
    //    Console.WriteLine(Result);

    //    Action<int, float, double> obj2 = new Action<int, float, double>(AddNumber2);   // OR //Func<int, float, double, double> obj2 = (x, y, z) => { return x + y + z; }
    //    obj2.Invoke(50, 255.45f, 123.456);

    //    Predicate<string> obj3 = new Predicate<string>(CheckLength);
    //    bool Status = obj3.Invoke("Pranaya");
    //    Console.WriteLine(Status);

    //    Console.ReadKey();
    //}
    //public static double AddNumber1(int no1, float no2, double no3)
    //{
    //    return no1 + no2 + no3;
    //}
    //public static void AddNumber2(int no1, float no2, double no3)
    //{
    //    Console.WriteLine(no1 + no2 + no3);
    //}
    //public static bool CheckLength(string name)
    //{
    //    if (name.Length > 5)
    //        return true;
    //    return false;
    //}

    #region Custom delegates // Don't use this creating custom delegates
    //public class GenericDelegates
    //{
    //    public delegate double AddNumber1Delegate(int no1, float no2, double no3);
    //    public delegate void AddNumber2Delegate(int no1, float no2, double no3);
    //    public delegate bool CheckLengthDelegate(string name);
    //    static void Main(string[] args)
    //    {
    //        AddNumber1Delegate obj1 = new AddNumber1Delegate(AddNumber1);
    //        double Result = obj1.Invoke(100, 125.45f, 456.789);
    //        Console.WriteLine(Result);
    //        AddNumber2Delegate obj2 = new AddNumber2Delegate(AddNumber2);
    //        obj2.Invoke(50, 255.45f, 123.456);
    //        CheckLengthDelegate obj3 = new CheckLengthDelegate(CheckLength);
    //        bool Status = obj3.Invoke("Pranaya");
    //        Console.WriteLine(Status);
    //        Console.ReadKey();
    //    }
    //    public static double AddNumber1(int no1, float no2, double no3)
    //    {
    //        return no1 + no2 + no3;
    //    }
    //    public static void AddNumber2(int no1, float no2, double no3)
    //    {
    //        Console.WriteLine(no1 + no2 + no3);
    //    }
    //    public static bool CheckLength(string name)
    //    {
    //        if (name.Length > 5)
    //            return true;
    //        return false;
    //    }
    //}
    #endregion

    //}

    #endregion

    #region Anonymous Delegates

    //class AnonymousMethod
    //{
    //    static void Main(string[] args)
    //    {
    //        //Create a collection of List of Employees
    //        List<Employee> listEmployees = new List<Employee>()
    //        {
    //            new Employee{ ID = 101, Name = "Pranaya", Gender = "Male", Salary = 100000},
    //            new Employee{ ID = 102, Name = "Priyanka", Gender = "Female", Salary = 200000},
    //            new Employee{ ID = 103, Name = "Anurag", Gender = "Male", Salary = 300000},
    //            new Employee{ ID = 104, Name = "Preety", Gender = "Female", Salary = 400000},
    //            new Employee{ ID = 104, Name = "Sambit", Gender = "Male", Salary = 500000},
    //        };
    //        // An anonymous method is being passed as an argument to the Find() method of List Collection. instead of creating Predicate Delegate
    //        Employee employee = listEmployees.Find (delegate (Employee x) { return x.ID == 103; });

    //        Console.WriteLine(@"ID : {0}, Name : {1}, Gender : {2}, Salary : {3}", employee.ID, employee.Name, employee.Gender, employee.Salary);

    //        Console.ReadKey();
    //    }
    //    public class Employee
    //    {
    //        public int ID { get; set; }
    //        public string Name { get; set; }
    //        public string Gender { get; set; }
    //        public double Salary { get; set; }
    //    }
    //}

    #endregion

    #region Event Delegates

    ////Step1: Define one delegate
    //public delegate void WorkPerformedHandler(int hours, WorkType workType);
    //public class Worker
    //{
    //    //Step2: Define one event to notify the work progress using the custom delegate
    //    public event WorkPerformedHandler WorkPerformed;
    //    //Step2: Define another event to notify when the work is completed using buil-in EventHandler delegate
    //    public event EventHandler WorkCompleted;
    //    public void DoWork(int hours, WorkType workType)
    //    {
    //        //Do Work here and notify the consumer that work has been performed
    //        for (int i = 0; i < hours; i++)
    //        {
    //            OnWorkPerformed(i + 1, workType);
    //            Thread.Sleep(3000);
    //        }
    //        //Notify the consumer that work has been completed
    //        OnWorkCompleted();
    //    }
    //    protected virtual void OnWorkPerformed(int hours, WorkType workType)
    //    {
    //        //Raising Events only if Listeners are attached
    //        //Approach1
    //        //if(WorkPerformed != null)
    //        //{
    //        //    WorkPerformed(8, WorkType.GenerateReports);
    //        //}
    //        //Approach2
    //        //WorkPerformed?.Invoke(8, WorkType.GenerateReports);
    //        //Approach3
    //        //WorkPerformedHandler del1 = WorkPerformed as WorkPerformedHandler;
    //        //if(del1 != null)
    //        //{
    //        //    del1(8, WorkType.GenerateReports);
    //        //}
    //        //Approach4
    //        if (WorkPerformed is WorkPerformedHandler del2)
    //        {
    //            del2(8, WorkType.GenerateReports);
    //        }
    //    }
    //    protected virtual void OnWorkCompleted()
    //    {
    //        //Raising the Event
    //        //Approach1
    //        //EventHandler delegate takes two parameters i.e. object sender, EventArgs e
    //        //Sender is the current class i.e. this keyword and we do not need to pass any data
    //        //So, we need to pass Empty EventArgs
    //        //WorkCompleted?.Invoke(this, EventArgs.Empty);
    //        //Approach2
    //        if (WorkCompleted is EventHandler del)
    //        {
    //            del(this, EventArgs.Empty);
    //        }
    //        //Note: You can also use other two Approached
    //    }
    //}
    //public enum WorkType
    //{
    //    Golf,
    //    GotoMeetings,
    //    GenerateReports
    //}
    #endregion

    #region // OR

    //public class TryingEvents
    //{
    //    public delegate void MyDelegate();   // Defining the delegate

    //    public event MyDelegate MyEvent;     // Defining the event of delegate type

    //    public void Print()
    //    {
    //        Console.WriteLine("Correct");
    //    }

    //    public void Next()
    //    {
    //        Console.WriteLine("Correct");
    //    }

    //    public void GetName(string name)
    //    {
    //        if (name == "Dipannita")
    //        {
    //            MyEvent += Print;  // Assigning the Print method to the event
    //            MyEvent += Next;   // Assigning the Next method to the event
    //        }

    //        MyEvent.Invoke();    // Triggering the event // Invoke sud match the function assigned
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        TryingEvents tryingEvents = new TryingEvents(); // Creating an object of the class
    //        tryingEvents.GetName("Dipannita");             // Calling the method with a parameter
    //    }
    //}

    #endregion

    #region Eg Event Delegates

    //This is Subscriber Class
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        AddTwoNumbers a = new AddTwoNumbers();
    //        //Event gets binded with delegates
    //        a.ev_OddNumber += new AddTwoNumbers.dg_OddNumber(EventMessage);
    //        a.Add();
    //        Console.Read();
    //    }
    //    //Delegates calls this method when event raised.  
    //    static void EventMessage()
    //    {
    //        Console.WriteLine("********Event Executed : This is Odd Number**********");
    //    }
    //}
    ////This is Publisher Class
    //class AddTwoNumbers
    //{
    //    public delegate void dg_OddNumber(); //Declared Delegate     
    //    public event dg_OddNumber ev_OddNumber; //Declared Events

    //    public void Add()
    //    {
    //        int result;
    //        result = 5 + 4;
    //        Console.WriteLine(result.ToString());
    //        //Check if result is odd number then raise event
    //        if ((result % 2 != 0) && (ev_OddNumber != null))
    //        {
    //            ev_OddNumber(); //Raised Event
    //        }
    //    }
    //}

    #endregion

    #region Eg Built in Del

    ////This is Subscriber Class
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        AddTwoNumbers a = new AddTwoNumbers();
    //        //Event gets binded with delegates
    //        a.ev_OddNumber += EventMessage;
    //        a.Add();
    //        Console.Read();
    //    }
    //    //Delegates calls this method when event raised.  
    //    static void EventMessage(object sender, EventArgs e)
    //    {
    //        Console.WriteLine("***Event Executed : This is Odd Number***");
    //    }
    //}
    ////This is Publisher Class
    //class AddTwoNumbers
    //{
    //    public event EventHandler<EventArgs> ev_OddNumber;

    //    public void Add()
    //    {
    //        int result;
    //        result = 5 + 4;
    //        Console.WriteLine(result.ToString());
    //        //Check if result is odd number then raise event
    //        if ((result % 2 != 0) && (ev_OddNumber != null))
    //        {
    //            ev_OddNumber(this, EventArgs.Empty); //Raised Event
    //        }
    //    }
    //}

    #endregion

    #region Eg Built in Custom Delegates

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        AddTwoNumbers a = new AddTwoNumbers();
    //        a.ev_OddNumber += EventMessage;
    //        a.Add();
    //        Console.Read();
    //    }

    //    static void EventMessage(object sender, OddNumberEventArgs e)       // Custom argument
    //    {
    //        Console.WriteLine("Event Executed : {0} is an Odd Number", e.sum);
    //    }
    //}

    //public class AddTwoNumbers
    //{
    //    public event EventHandler<OddNumberEventArgs> ev_OddNumber;

    //    public void Add()
    //    {
    //        int result;
    //        result = 5 + 4;
    //        Console.WriteLine(result.ToString());
    //        if ((result % 2 != 0) && (ev_OddNumber != null))
    //        {
    //            ev_OddNumber(this, new OddNumberEventArgs(result)); //Raised Event
    //        }
    //    }
    //}

    ////Creating Custom EventArgs
    //public class OddNumberEventArgs : EventArgs
    //{
    //    public OddNumberEventArgs(int result)
    //    {
    //        sum = result;
    //    }
    //    public int sum { get; set; }
    //}

    #endregion

    #region Generic EventHandler<TEventArgs> delegate:

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        // Define an event publisher class
    //        var eventPublisher = new EventPublisher();

    //        // Subscribe to the event
    //        eventPublisher.EventOccured += HandleEvent;

    //        // Trigger the event
    //        eventPublisher.TriggerEvent();
    //    }

    //    // Event handler method
    //    static void HandleEvent(object sender, MyEventArgs e)
    //    {
    //        Console.WriteLine($"Event handled: {e.Message}");
    //    }
    //}

    //// Custom event argument class
    //class MyEventArgs : EventArgs
    //{
    //    public string Message { get; set; }

    //    public MyEventArgs(string message)
    //    {
    //        Message = message;
    //    }
    //}

    //// Event publisher class
    //class EventPublisher
    //{
    //    // Define an event using the generic EventHandler delegate
    //    public event EventHandler<MyEventArgs> EventOccured;

    //    // Method to trigger the event
    //    public void TriggerEvent()
    //    {
    //        // Raise the event
    //        OnEventOccured(new MyEventArgs("Hello, World!"));
    //    }

    //    // Protected method to raise the event
    //    protected virtual void OnEventOccured(MyEventArgs e)
    //    {
    //        EventOccured?.Invoke(this, e);
    //    }
    //}

    #endregion

}

