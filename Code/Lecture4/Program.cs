using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lecture3.ExampleClasses;
using Lecture4.ExampleClasses;

namespace Lecture4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Discuss enum

            EuropeanOptionParams pars = new EuropeanOptionParams(OptionPayoff.Call, 1, 1);
            Date nullDate = null;

            Console.WriteLine("Force pass by reference demo:");
            RunForcePassByRef();
            Console.Read();
            Console.WriteLine("Force pass by value demo:");
            RunForceTestPassByValue();
            Console.Read();
            Console.WriteLine("Copy constructor demo:");
            DateDemoCopyConstructor();
            Console.Read();
        }

        static void TestForcePassByValue(int[] a)
        {
            int[] myCopy = new int[a.Length];
            a.CopyTo(myCopy, 0);
            myCopy[0] = 0;
        }
        static void RunForceTestPassByValue()
        {
            int[] a = new int[2] { 1, 2 };
            Console.WriteLine("{0}", a[0]);
            TestForcePassByValue(a);
            Console.WriteLine("{0}", a[0]);
        }

        static void ForcePassByRef(ref int a)
        {
            a = 0;
        }
        static void RunForcePassByRef()
        {
            int a = 1;
            Console.WriteLine("{0}", a);
            ForcePassByRef(ref a);
            Console.WriteLine("{0}", a);
        }

        static void TestPassByReference(int[] a)
        {
            a[0] = 0;
        }
        static void RunTestPassByReference()
        {
            int[] a = new int[2] { 1, 2 };
            Console.WriteLine("{0}", a[0]);
            TestPassByReference(a);
            Console.WriteLine("{0}", a[0]);
        }

        static void TestPassByValue(int a)
        {
            a = 0;
        }
        static void RunTestPassByValue()
        {
            int a = 1;
            Console.WriteLine("{0}", a);
            TestPassByValue(a);
            Console.WriteLine("{0}", a);
        }

        static void DateDemoReferenceType()
        {
            Date d1 = Date.CreateDate(1, 1, 2016); // this is a valid date
                                                   //and 'new' keyword is used
            Date d2 = d1;
            d1.SetDayOfMonth(2); // still a valid date
            Console.WriteLine("Day of month in d1: {0}", d1.GetDayOfMonth());
            Console.Read();
            Console.WriteLine("Day of month in d2: {0}", d2.GetDayOfMonth());
        }

        static void DateDemoCopyConstructor()
        {
            Date d1 = Date.CreateDate(1, 1, 2016); // this is a valid date
                                                   //and 'new' keyword is used
            Date d2 = new Date(d1);
            d1.SetDayOfMonth(2); // still a valid date
            Console.WriteLine("Day of month in d1: {0}", d1.GetDayOfMonth());
            Console.Read();
            Console.WriteLine("Day of month in d2: {0}", d2.GetDayOfMonth());
        }
    }
}
