using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDetails
{
    #region Overloading

    //internal class Load_Ride_Params_Poly
    //{
    //    static void Main()
    //    {
    //        Calculator calculator = new Calculator();

    //        int resultInt = calculator.Add(5, 10);
    //        double resultDouble = calculator.Add(5.5, 10.5);

    //        Console.WriteLine($"Result (int): {resultInt}");
    //        Console.WriteLine($"Result (double): {resultDouble}");
    //    }
    //}
    //public class Calculator
    //{
    //    public int Add(int a, int b)
    //    {
    //        return a + b;
    //    }

    //    public double Add(double a, double b)
    //    {
    //        return a + b;
    //    }
    //}

    #endregion

    #region Overriding

    //class Load_Ride_Params_Poly
    //{
    //    static void Main(string[] args)
    //    {
    //        //method overriding = provides a new version of a method inherited from a parent class
    //        //                    inherited method must be: abstract, virtual, or already overriden     // abstract -> no body so no overriding, virtual -> body so overriden
    //        //                    Used with ToString(), polymorphism 

    //        Dog dog = new Dog();
    //        Cat cat = new Cat();

    //        dog.Speak();
    //        cat.Speak();

    //        Console.ReadKey();
    //    }
    //}
    //class Animal
    //{
    //    public virtual void Speak()
    //    {
    //        Console.WriteLine("The animal goes *brrr*");
    //    }
    //}
    //class Dog : Animal
    //{
    //    public override void Speak()
    //    {
    //        Console.WriteLine("The dog goes *woof*");
    //    }
    //}
    //class Cat : Animal
    //{

    //}

    #endregion

    #region Polymorphism

    //class Load_Ride_Params_Poly
    //{
    //    static void Main(string[] args)
    //    {
    //        // polymorphism = Greek word that means to "have many forms"
    //        //                Objects can be identified by more than one type
    //        //                Ex. A Dog is also: Canine, Animal, Organism

    //        Car car = new Car();
    //        Bicycle bicycle = new Bicycle();
    //        Boat boat = new Boat();

    //        Vehicle[] vehicles = { car, bicycle, boat };    // In poly, we call the common base for all class, which is vehicle bcs it is common for 3 class, using this we can call all 3 objects of 3 class

    //        foreach (Vehicle vehicle in vehicles)
    //        {
    //            vehicle.Go();       // print 3 class message seperately as poly is used
    //        }

    //        Console.ReadKey();
    //    }
    //}
    //class Vehicle
    //{
    //    public virtual void Go()
    //    {
    //           // empty bcs even if we give any body, it will get override
    //    }
    //}
    //class Car : Vehicle
    //{
    //    public override void Go()
    //    {
    //        Console.WriteLine("The car is moving!");
    //    }
    //}
    //class Bicycle : Vehicle
    //{
    //    public override void Go()
    //    {
    //        Console.WriteLine("The bicycle is moving!");
    //    }
    //}
    //class Boat : Vehicle
    //{
    //    public override void Go()
    //    {
    //        Console.WriteLine("The boat is moving!");
    //    }
    //}

    #endregion

    #region Overrriding and Delegate

    //public class Shape
    //{
    //    public virtual void Draw()
    //    {
    //        Console.WriteLine("Drawing a shape");
    //    }
    //}
    //public class Circle : Shape
    //{
    //    public override void Draw()
    //    {
    //        Console.WriteLine("Drawing a circle");
    //    }
    //}

    //public delegate void MyDelegate(string message);

    //public class Messenger
    //{
    //    public void DisplayMessage(string message)
    //    {
    //        Console.WriteLine($"Message: {message}");
    //    }
    //}


    //internal class Load_Ride_Params_Poly
    //{
    //    static void Main()
    //    {
    //        Shape shape = new Circle();
    //        shape.Draw(); // This will call the overridden method in Circle

    //        Messenger messenger = new Messenger();
    //        MyDelegate myDelegate = new MyDelegate(messenger.DisplayMessage);

    //        myDelegate("Hello, Delegates!");
    //    }
    //}

    #endregion

    #region params keyword

    // class Load_Ride_Params_Poly
    //{
    //    static void Main(string[] args)
    //    {
    //        //params keyword = a method parameter that takes a variable number of arguments.
    //        //                 The parameter type must be a single - dimensional array

    //        double totalprice = CheckOut(3.99, 5.75, 15, 1.00, 10.25);

    //        Console.WriteLine(totalprice);
    //        Console.ReadKey();
    //    }

    //    static double CheckOut(params double[] prices)
    //    {
    //        double total = 0;

    //        foreach (double price in prices)
    //        {
    //            total += price;
    //        }
    //        return total;
    //    }
    //}

    #endregion

}
