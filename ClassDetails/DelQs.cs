using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDetails
{
    //public class DelQs
    //{
    //    static void Main(string[] args)
    //    {
    //        EnterName ename = new EnterName();
    //        ename.ev_BannedUser += WarningAlarm;
    //        ename.User();
    //        Console.Read();
    //    }
    //    static void WarningAlarm(object sender, BannedUserEventArgs e)
    //    {
    //        Console.WriteLine("{0} Banned User found. Sending Email to Administration.", e.Name);
    //        Console.WriteLine("Email Sent.");
    //        Console.WriteLine("Warning Alarm Started.");
    //        Console.WriteLine("Press Ctrl + c to stop the alarm");
    //        for (; ; )       // creating an infinite loop
    //        {
    //            Console.Beep();
    //            Thread.Sleep(100);
    //        }
    //    }
    //}

    //public class EnterName
    //{
    //    public event EventHandler<BannedUserEventArgs> ev_BannedUser;
    //    public void User() 
    //    {
    //        Console.Write("Enter You Name : ");
    //        string user = Console.ReadLine();

    //    if ((   user.Equals("Jack", StringComparison.OrdinalIgnoreCase) ||
    //            user.Equals("Steven", StringComparison.OrdinalIgnoreCase) ||
    //            user.Equals("Mathew", StringComparison.OrdinalIgnoreCase)) 
    //            && (ev_BannedUser!=null))
    //    {
    //        ev_BannedUser(this, new BannedUserEventArgs(user));
    //    }
    //    else
    //    {
    //       Console.WriteLine("Welcome, " + user);
    //    }   
    //    }  
    //}

    //public class BannedUserEventArgs : EventArgs
    //{
    //    public string Name { get; set; }
    //    public BannedUserEventArgs(string name)
    //    {
    //        Name = name;
    //    }
    //}

    // OR

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter You Name : ");
            string Name = Console.ReadLine();

            OnlineAttendance oa = new OnlineAttendance();
            oa.WelcomeMessage(Name);
        }
    }
    public class OnlineAttendance
    {
        public delegate void MyDelegate(string name);
        public event MyDelegate SendMessage;

        public void WelcomeMessage(string Name)     // Event class
        {
            SendMessage += Message;
            SendMessage(Name);      // Invoke Event class
        }
        public void Message(string Name)
        {
            if (Name != "Jack" && Name != "Steven" && Name != "Mathew")
            {
                Console.WriteLine("Welcome " + Name);
            }
            else
            {
                Console.WriteLine("Banned User found. Sending Email to Administration.");
                Console.WriteLine("Email Sent.");
                Console.WriteLine("Warning Alarm Started.");
                Console.WriteLine("Press Ctrl + c to stop the alarm");
                for (; ; )       // creating an infinite loop
                {
                    Console.Beep();
                    Thread.Sleep(100);
                }
            }
        }
    }
}
