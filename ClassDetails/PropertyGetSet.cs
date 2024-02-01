using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDetails
{
    //getters & setters = add security to fields by encapsulation
    //                    They're accessors found within properties

    // properties = combine aspects of both fields and methods (share name with a field)
    // get accessor = used to return the property value
    // set accessor = used to assign a new value
    // value keyword = defines the value being assigned by the set (parameter)

    #region Diff ways to set property:

    //internal class PropertyGetSet
    //{
    //    // Method 1: Using Property Initializers:    MyProperty is initialized to a default value of 10.
    //    public int MyProperty { get; set; } = 10;

    //    // Method 2: Using Constructors:    You can set the property value when creating an instance of the class.
    //    public PropertyGetSet(int value)
    //    {
    //        MyProperty = value;
    //    }

    //    // Method 3: Using Methods:     Setters methods allow setting properties with custom logic.
    //    private int myProperty;
    //    public void SetMyProperty(int value)
    //    {
    //        myProperty = value;
    //    }

    //    // Method 4: Using Indexers:    This allows setting properties using array-like syntax.
    //    private int[] array = new int[10];
    //    public int this[int index]
    //    {
    //        get { return array[index]; }
    //        set { array[index] = value; }
    //    }

    //    static void Main(string[] args)
    //    {
    //        // Method 5: Using Object Initializers:     Object initializers provide a concise syntax to set properties during object creation.
    //        PropertyGetSet obj = new PropertyGetSet { MyProperty = 20 };

    //        // Method 6: Using Reflection:  Reflection allows setting properties dynamically at runtime.
    //        var propertyInfo = typeof(PropertyGetSet).GetProperty("MyProperty");
    //        propertyInfo.SetValue(obj, 30);

    //        // Method 3: Using Methods
    //        obj.SetMyProperty(40);

    //        // Method 4: Using Indexers
    //        obj[0] = 50;
    //    }
    //}

    #endregion

    #region Eg

    //internal class PropertyGetSet
    //{
    //    static void Main(string[] args)
    //    {
    //        Car car = new Car(400);

    //        car.Speed = 1000000000;

    //        Console.WriteLine(car.Speed);

    //        Console.ReadKey();
    //    }
    //}
    //class Car
    //{
    //    private int speed;

    //    public Car(int speed)
    //    {
    //        Speed = speed;
    //    }

    //    public int Speed
    //    {
    //        get { return speed; }
    //        set
    //        {
    //            if (value > 500)
    //            {
    //                speed = 500;
    //            }
    //            else
    //            {
    //                speed = value;
    //            }
    //        }
    //    }

    //}

    #endregion
}
