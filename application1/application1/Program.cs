//using System.Runtime.Intrinsics.Arm;

//namespace application1
//{
//    class MyArray
//    {
//        struct student
//        {
//            public string name;
//            public int rollno;
//        }

//        class car
//        {
//            public void horn()
//            {
//                Console.WriteLine("Pee pee");
//            }
//            public void type()
//            {
//                Console.WriteLine("it is 2 stock ");
//            }

//        }
//        interface inte
//        {
//           public abstract void clas();
//        }
//        class volvo : car ,inte
//        {
//            void clas()
//            {
//                Console.WriteLine("hello vivek bolra");
//            }
//            //public void clas()
//            //{
//            //    throw new NotImplementedException();
//            //}

//            public void vol()
//            { 
//                Console.WriteLine("it is volvo"); 
//            }


//        }

//        public static void Main(string[] args)
//        {
//            student s1;
//            s1.name = "vivek";
//            s1.rollno = 1;

//            Console.WriteLine(s1.name);
//            Console.WriteLine(s1.rollno);
//            car:volvo c1 = new volvo();
//            inte:volvo c2 = new volvo();
//           c1.horn();
//            c1.type();
//            c2.vol();
//            c1.clas();

//            Console.ReadLine();
//        }
//    }
//}

using System;
using System.Security.Cryptography.X509Certificates;

//// Abstract class
//abstract class Abstract_Class
//{

//    // Method declaration in abstract class
//    public abstract void abstract_method();
//}

//// Interface
//interface Interface
//{

//    // Method declaration in interface
//    void interface_method();
//}

//// Here, GFg class inherit abstract class and interface
//class GFG : Abstract_Class, Interface
//{

//    // Method definition for abstract method
//    public override void abstract_method()
//    {
//        Console.WriteLine("I am the method of abstract class");
//    }

//    // Method definition for interface
//    public void interface_method()
//    {
//        Console.WriteLine("I am the method of interface");
//    }
//}

//class ths
//{
//    public void horn()
//    {
//        Console.WriteLine("this is class method");
//    }
//}
//interface th
//{
//    void massage();
//}
//class secound : ths, th
//{
//    public void massage()
//    {
//        Console.WriteLine("this is from inerface");
//    }
//}
using System.IO;
class Geeks
{

    // Driver code
    public static void Main(String[] args)
    {
        FileStream f = new FileStream("sample.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
        for(int i=1; i<=10; i++)
        {
            f.WriteByte((byte)i);
        }
        f.Position = 0;
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(f.ReadByte() + " ");
        }
        f.Close();
        Console.ReadKey();






        //ths t = new secound();
        //        th t1 = new secound();
        //        t.horn();
        //        t1.massage();

    }
}