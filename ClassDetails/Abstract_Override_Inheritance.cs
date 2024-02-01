using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDetails
{
    #region Car eg

    //internal class Abstract_Override_Inheritance
    //{
    //    static void Main(string[] args)
    //    {
    //        // abstract classes = It can be applied to class, prop, method of parent/base class only. An abstract class is often used to define a common base class that multiple derived classes can extend and implement.
    //        // To access/inherit abstract parent class/prop/method -> use override in child class
    //        // modifier that indicates missing components or incomplete implementation

    //        Car car = new Car();
    //        Bicycle bicycle = new Bicycle();
    //        Boat boat = new Boat();
    //        //Vehicle vehicle = new Vehicle(); //can't create a vehicle object as this class is abstract -> it doesnt have all the definitions for user to create an obj of it, so made it abstract

    //        Console.WriteLine(car.speed);       // abstract class prop
    //        Console.WriteLine(car.wheels);      // non abstract
    //        Console.WriteLine(car.maxSpeed);    // abstract but override

    //        Console.ReadKey();
    //    }
    //}
    //abstract class Vehicle
    //{
    //    public int speed = 0;
    //    public void go()
    //    {
    //        Console.WriteLine("This vehicle is moving!");
    //    }
    //    public abstract int maxSpeed { get; }
    //    public abstract void Start();
    //}

    //class Car : Vehicle
    //{
    //    public int wheels = 4;
    //    public override int maxSpeed
    //    {
    //        get { return 500; }
    //    }
    //    //int maxSpeed = 500; // cant directly assign prop like this as this is abstract in parent class, so use overrride

    //    public override void Start()
    //    {
    //        Console.WriteLine("Car starting...");
    //    }
    //}

    //class Bicycle : Vehicle
    //{
    //    public int wheels = 2;
    //    public override int maxSpeed
    //    {
    //        get { return 50; }
    //    }
    //    public override void Start()
    //    {
    //        Console.WriteLine("Bicycle starting...");
    //    }
    //}

    //class Boat : Vehicle
    //{
    //    public int wheels = 0;
    //    public override int maxSpeed
    //    {
    //        get { return 100; }
    //    }
    //    public override void Start()
    //    {
    //        Console.WriteLine("Boat starting...");
    //    }
    //}

    #endregion

    // OR

    #region shape eg

//    internal class Abstract_Override_Inheritance
//    {
//        private static void Main(string[] args)
//        {
//            Circle circle = new Circle(5);
//            Square square = new Square(4);

//            // Access overridden properties
//            Console.WriteLine($"Area of Circle: {circle.Area}");
//            Console.WriteLine($"Area of Square: {square.Area}");

//            // Call overridden methods
//            circle.DisplayInfo();
//            square.DisplayInfo();

//            Console.ReadKey();
//        }
//    }      
//}

//abstract class Shape
//{
//    public abstract double Area { get; }  // Abstract property

//    public abstract void DisplayInfo();   // Abstract method
//}

//class Circle : Shape
//{
//    private double radius;

//    public Circle(double radius)
//    {
//        this.radius = radius;
//    }

//    public override double Area
//    {
//        get { return Math.PI * radius * radius; }
//    }

//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"This is a circle with radius {radius}");
//    }
//}

//class Square : Shape
//{
//    private double side;

//    public Square(double side)
//    {
//        this.side = side;
//    }

//    public override double Area
//    {
//        get { return side * side; }
//    }

//    public override void DisplayInfo()
//    {
//        Console.WriteLine($"This is a square with side {side}");
//    }

    #endregion

}

