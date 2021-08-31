using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the class name:");
        string cls_name = Console.ReadLine();
        switch(cls_name)
        {
            case "Event":
                Type t1 = typeof(Event);
                Console.WriteLine("Class Full Name: {0}",t1.FullName);
                Console.WriteLine("Base Type: {0}",t1.BaseType);
                Console.WriteLine("Is Class: {0}",t1.IsClass);
                Console.WriteLine("Is Interface: {0}",t1.IsInterface);
                break;
            case "StageEvent":
                Type t2 = typeof(StageEvent);
                Console.WriteLine("Class Full Name: {0}", t2.FullName);
                Console.WriteLine("Base Type: {0}", t2.BaseType);
                Console.WriteLine("Is Class: {0}", t2.IsClass);
                Console.WriteLine("Is Interface: {0}", t2.IsInterface);
                break;
            case "Exhibition":
                Type t3 = typeof(Exhibition);
                Console.WriteLine("Class Full Name: {0}", t3.FullName);
                Console.WriteLine("Base Type: {0}", t3.BaseType);
                Console.WriteLine("Is Class: {0}", t3.IsClass);
                Console.WriteLine("Is Interface: {0}", t3.IsInterface);
                break;
        }
        
    }
}
