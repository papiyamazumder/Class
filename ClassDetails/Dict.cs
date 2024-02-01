using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDetails
{
    #region Create, Access, Print, Contains

    class Create_Add_Access_Check
    {
        static void Main()
        {
            //Creating a Dictionary with Key and value both are string type
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>();

            //Adding Elements to the Dictionary using Add Method of Dictionary class
            dictionaryCountries.Add("UK", "London, Manchester, Birmingham");
            dictionaryCountries.Add("USA", "Chicago, New York, Washington");
            dictionaryCountries.Add("IND", "Mumbai, Delhi, Bhubaneswar");

            //Accessing Dictionary Elements using For Each Loop
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> KVP in dictionaryCountries)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }

            //Accessing Dictionary Elements using For Loop
            Console.WriteLine("\nAccessing Dictionary Elements using For Loop");
            for (int i = 0; i < dictionaryCountries.Count; i++)
            {
                string key = dictionaryCountries.Keys.ElementAt(i);
                string value = dictionaryCountries[key];
                Console.WriteLine($"Key: {key}, Value: {value}");
            }

            //Accessing Dictionary Elements using Keys
            Console.WriteLine("\nAccessing Dictionary Elements using Keys");
            Console.WriteLine($"Key: UK, Value: {dictionaryCountries["UK"]}");
            Console.WriteLine($"Key: USA, Value: {dictionaryCountries["USA"]}");
            Console.WriteLine($"Key: IND, Value: {dictionaryCountries["IND"]}");
            Console.ReadKey();

            //Creating a Dictionary with Key and value both are string type using Collection Initializer instead of add method
            Dictionary<string, string> dictionaryCountries1 = new Dictionary<string, string>
            {
                { "UK", "London, Manchester, Birmingham" },
                { "USA", "Chicago, New York, Washington" },
                { "IND", "Mumbai, Delhi, India" }
            };

            //Accessing Dictionary Elements using For Each Loop
            Console.WriteLine("Accessing Dictionary Elements using For Each Loop");
            foreach (KeyValuePair<string, string> KVP in dictionaryCountries1)
            {
                Console.WriteLine($"Key:{KVP.Key}, Value: {KVP.Value}");
            }

            //Checking the key using the ContainsKey method:
            Console.WriteLine("Is USA Key Exists : " + dictionaryCountries.ContainsKey("USA"));
            Console.WriteLine("Is PAK Key Exists : " + dictionaryCountries.ContainsKey("PAK"));

            //Checking the value using the ContainsValue method
            Console.WriteLine("\nIs India value Exists : " + dictionaryCountries.ContainsValue("India"));
            Console.WriteLine("Is Srilanka value Exists : " + dictionaryCountries.ContainsValue("Srilanka"));

            // ParallelEnumerable.ForAll() Method to Iterate a Dictionary Collection:
            Console.WriteLine($"Iterating Dictionary Using AsParallel().ForAll Method");
            dictionaryCountries.AsParallel().ForAll(entry => Console.WriteLine(entry.Key + " : " + entry.Value));

            #region Sort Dictionary Values if 1 value

            // Sort the dictionary by values
            Dictionary<string, int> myDictionary = new Dictionary<string, int>();

            // Add key-value pairs to the dictionary
            myDictionary.Add("John", 25);
            myDictionary.Add("Alice", 30);
            myDictionary.Add("Bob", 20);

            // Sort the dictionary by values
            var sortedList = new List<KeyValuePair<string, int>>(myDictionary);
            sortedList.Sort((pair1, pair2) => pair1.Value.CompareTo(pair2.Value));

            // Reconstruct the dictionary from the sorted list
            var sortedDictionary = new Dictionary<string, int>();
            foreach (var pair in sortedList)
            {
                sortedDictionary.Add(pair.Key, pair.Value);
            }

            // Print the sorted dictionary
            Console.WriteLine("Sorted Dictionary by values:");
            foreach (var pair in sortedDictionary)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

            #endregion

            #region Sort Dict Values if there are objects of values

            // Create a dictionary with string keys and Person objects as values
            Dictionary<string, Person> myDictionary = new Dictionary<string, Person>();

            // Add key-value pairs to the dictionary
            myDictionary.Add("John", new Person("John", 25));
            myDictionary.Add("Alice", new Person("Alice", 30));
            myDictionary.Add("Bob", new Person("Bob", 20));

            // Sort the dictionary by the Age property of the Person objects
            var sortedList = new List<KeyValuePair<string, Person>>(myDictionary);
            sortedList.Sort((pair1, pair2) => pair1.Value.Age.CompareTo(pair2.Value.Age));

            // Reconstruct the dictionary from the sorted list
            var sortedDictionary = new Dictionary<string, Person>();
            foreach (var pair in sortedList)
            {
                sortedDictionary.Add(pair.Key, pair.Value);
            }

            // Print the sorted dictionary
            Console.WriteLine("Sorted Dictionary by values (Age):");
            foreach (var pair in sortedDictionary)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value.Name} (Age: {pair.Value.Age})");
            }

            #endregion

            Console.ReadKey();
        }
    }

    #endregion

    #region Remove

    class Remove
    {
        static void Main()
        {
            //Creating a Dictionary with Key and value both are string type using Collection Initializer
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>
            {
                { "UK", "United Kingdom" },
                { "USA", "United State of America" },
                { "IND", "India" },
                { "PAK", "Pakistan" },
                { "SL", "Srilanka" }
            };
            Console.WriteLine($"Dictionary Elements Count Before Removing: {dictionaryCountries.Count}");
            foreach (var item in dictionaryCountries)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }

            // Remove element PAK from Dictionary Using Remove() method
            if (dictionaryCountries.ContainsKey("PAK"))
            {
                dictionaryCountries.Remove("PAK");
                Console.WriteLine($"\nDictionary Elements Count After Removing PAK: {dictionaryCountries.Count}");
                foreach (var item in dictionaryCountries)
                {
                    Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
                }
            }

            // Remove all Elements from Dictionary Using Clear method
            dictionaryCountries.Clear();
            Console.WriteLine($"\nDictionary Elements Count After Clear: {dictionaryCountries.Count}");
            Console.ReadKey();
        }
    }
    #endregion

    #region  Index //dictionary[key] = value; , Update

    class Index_Update
    {
        static void Main()
        {
            //Creating a Dictionary with Key and value both are string type using Collection Initializer
            Dictionary<string, string> dictionaryCountries = new Dictionary<string, string>
            {
                { "UK", "United Kingdom" },
                { "USA", "United State of America" }
            };

            //Assign Values to a Dictionary with Indexer 
            dictionaryCountries["IND"] = "India";
            dictionaryCountries["PAK"] = "Pakistan";
            dictionaryCountries["SL"] = "Srilanka";

            //Accessing the Dictionary using For Each Loop
            foreach (var item in dictionaryCountries)
            {
                Console.WriteLine($"Key:{item.Key}, Value:{item.Value}");
            }

            //Updating the key UK and USA using Indexer
            dictionaryCountries["UK"] = "United Kingdom Updated";
            dictionaryCountries["IND"] = "India Updated";

            Console.WriteLine("\nAfter Updating the Key UK and IND");
            Console.WriteLine($"USA: {dictionaryCountries["UK"]}");
            Console.WriteLine($"IND: {dictionaryCountries["IND"]}");

            Console.ReadKey();
        }
    }

    #endregion

    #region Complex Type, TryGet Value, Get all Key and values
    class Complex_TryGetValue_GetAllKeyValues
    {
        static void Main()
        {
            Dictionary<int, Student> dictionaryStudents = new Dictionary<int, Student>
            {
                { 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"} },
                { 102, new Student(){ ID = 102, Name ="Mohanty", Branch="CSE"} },
                { 103, new Student(){ ID = 103, Name ="Sambit", Branch="ETC"}},

                //The following Statement will give runtime error
                //System.ArgumentException: 'An item with the same key has already been added. Key: 101'
                //{ 101, new Student(){ ID = 101, Name ="Anurag", Branch="CSE"}}
            };

            foreach (KeyValuePair<int, Student> item in dictionaryStudents)
            {
                Console.WriteLine($"Key: {item.Key}, ID: {item.Value.ID}, Name: {item.Value.Name}, Branch: {item.Value.Branch}");
            }

            // TryGetValue() method: 
            Student std102;
            if (dictionaryStudents.TryGetValue(102, out std102))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {std102.ID}, Name: {std102.Name}, Branch: {std102.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 102 is not found in the dictionary");
            }

            Student std105;
            if (dictionaryStudents.TryGetValue(105, out std105))
            {
                Console.WriteLine("\nStudent with Key = 102 is found in the dictionary");
                Console.WriteLine($"ID: {std105.ID}, Name: {std105.Name}, Branch: {std105.Branch}");
            }
            else
            {
                Console.WriteLine("\nStudent with Key = 105 is not found in the dictionary");
            }

            // Get All Key and Value:   To get all the keys in the dictionary use the keys properties of dictionary
            Console.WriteLine("All Keys in Student Dictionary");
            foreach (int key in dictionaryStudents.Keys)
            {
                Console.WriteLine(key + " ");
            }

            // Once you get the keys, then get the values using the keys
            Console.WriteLine("\nAll Keys and values in Student Dictionary");
            foreach (int key in dictionaryStudents.Keys)
            {
                var student = dictionaryStudents[key];
                Console.WriteLine($"Key: {key}, ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
            }

            //To get all the values in the dictionary use Values property
            Console.WriteLine("\nAll Student objects in Student Dictionary");
            foreach (Student student in dictionaryStudents.Values)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Branch: {student.Branch}");
            }

            Console.ReadKey();
        }
    }
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
    }

    #endregion

    #region Sorted Dict
    public class SortedDict
    {
        public static void Main()
        {
            //Creating Generic SortedDictionary Collection with key as integer and value as string
            SortedDictionary<int, string> genericSortedDictionary = new SortedDictionary<int, string>();

            //Adding Elements to SortedDictionary Collection using Add Method in Random Order
            genericSortedDictionary.Add(1, "One");
            genericSortedDictionary.Add(3, "Three");
            genericSortedDictionary.Add(2, "Two");
            genericSortedDictionary.Add(5, "Five");
            genericSortedDictionary.Add(4, "Four");

            //Duplicate Key not allowed, Runtime Exception -> System.ArgumentException: 'An entry with the same key already exists.'
            //genericSortedDictionary.Add(2, "Any Value"); -> Key Cannot be null: Compile Time Error
            //genericSortedDictionary.Add(null, "Any Value");

            //Accessing Generic SortedDictionary Collection using For Each loop
            Console.WriteLine("Accessing SortedDictionary Collection using For Each loop");
            foreach (var item in genericSortedDictionary)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }

            //Accessing Generic SortedDictionary Collection using For loop
            Console.WriteLine("\nAccessing SortedDictionary Collection using For loop");
            for (int i = 0; i < genericSortedDictionary.Count; i++)
            {
                KeyValuePair<int, string> element = genericSortedDictionary.ElementAt(i);
                Console.WriteLine($"Key: {element.Key}, Value: {element.Value}");
            }

            //Accessing SortedDictionary Collection Individual Elements using Key as Indexer
            Console.WriteLine("\nAccessing SortedList Individual Elements using Key as Indexer");
            Console.WriteLine($"Key: 1, Value: {genericSortedDictionary[1]}");
            Console.WriteLine($"Key: 2, Value: {genericSortedDictionary[2]}");
            Console.WriteLine($"Key: 5, Value: {genericSortedDictionary[5]}");

            Console.ReadKey();
        }
    }
    #endregion

    #region Dict class struct

    //class Dict<T>
    //{
    //    private Dictionary<string, int> pairs;  // prop

    //    public Dict()   // Const
    //    {
    //        pairs = new Dictionary<string, int>();
    //    }

    //    public void Add(string key, int value)  //Method
    //    {
    //        pairs.Add(key, value);
    //    }

    //    public void CreateNewDictionary()
    //    {
    //        pairs = new Dictionary<string, int>();
    //    }

    //    public void ShowAll()
    //    {
    //        foreach (var pair in pairs)
    //        {
    //            Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
    //        }
    //    }

    //    public void Remove(string key)
    //    {
    //        pairs.Remove(key);
    //    }

    //    public int Get(string key)
    //    {
    //        if (pairs.ContainsKey(key))
    //        {
    //            return pairs[key];
    //        }
    //        else
    //        {
    //            throw new KeyNotFoundException($"Key '{key}' not found.");
    //        }
    //    }
    //}

    //class ProgramDict
    //{
    //    static void Main(string[] args)
    //    {
    //        Dict dict = new Dict();

    //        dict.Add("One", 1);
    //        dict.Add("Two", 2);
    //        dict.Add("Three", 3);

    //        Console.WriteLine("All Key-Value Pairs:");
    //        dict.ShowAll();

    //        dict.Remove("Two");

    //        Console.WriteLine("\nKey-Value Pairs after Removal:");
    //        dict.ShowAll();

    //        try
    //        {
    //            int value = dict.Get("Three");
    //            Console.WriteLine($"\nValue for key 'Three': {value}");
    //        }
    //        catch (KeyNotFoundException ex)
    //        {
    //            Console.WriteLine(ex.Message);
    //        }
    //    }
    //}

    #endregion


}
