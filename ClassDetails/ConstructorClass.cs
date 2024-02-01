//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClassDetails
//{
//    public class ConstructorClass
//    {
//        // Default Constructor
//        public ConstructorClass()
//        {
//            Console.WriteLine("Default constructor called.");
//        }

//        // Parameterized Constructor
//        public ConstructorClass(int value)
//        {
//            Console.WriteLine($"Parameterized constructor called with value: {value}");
//        }

//        // Constructor Overloading
//        public ConstructorClass(string name)
//        {
//            Console.WriteLine($"Constructor with string parameter called with name: {name}");
//        }

//        // Chaining Constructors (Constructor chaining)
//        public ConstructorClass(bool flag) : this()
//        {
//            Console.WriteLine("Constructor chaining called.");
//        }

//        // Static Constructor
//        static ConstructorClass()
//        {
//            Console.WriteLine("Static constructor called.");
//        }
//    }

//    class Program1
//    {
//        static void Main(string[] args)
//        {
//            // Example usage
//            ConstructorClass obj1 = new ConstructorClass();           // Default constructor
//            ConstructorClass obj2 = new ConstructorClass(10);         // Parameterized constructor
//            ConstructorClass obj3 = new ConstructorClass("John");     // Constructor with string parameter
//            ConstructorClass obj4 = new ConstructorClass(true);      // Constructor chaining
//        }
//    }
//}
