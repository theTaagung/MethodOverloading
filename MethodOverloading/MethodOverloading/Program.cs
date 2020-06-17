using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass dc = new DerivedClass();
            dc.MethodOverloading("ATUL");
            dc.MethodOverloading2("ATUL");

            BaseClass bc = new BaseClass();
            bc.MethodOverloading("ATUL");
            bc.MethodOverloading2("ATUL");

            BaseClass bcdc = new DerivedClass();
            bcdc.MethodOverloading("Atul");
            bcdc.MethodOverloading2("Atul");




            //MethodOverloading_Conv(10);
            //MethodOverloading_Conv(5, 15);

            //MethodOverloading_Optional("AKS");
            //MethodOverloading_Optional(true);

            //MethodOverloadingReturn("AKS");

            //MethodOverloading_Obj("Atul", true);
            //MethodOverloading_Obj(true, true);

            //MethodOverloading_named(dFirst: 10, dThird: 13, dSecond: 15);
            //MethodOverloading_named(10, 15, 14);

            Console.ReadLine();
        }

        #region #1 Different Parameters

        static void MethodOverloading_Diff()
        {
            Console.WriteLine("MethodOverloading with No Parameters");
        }

        static void MethodOverloading_Diff(string str)
        {
            Console.WriteLine("MethodOverloading with String Parameters");
        }



        #endregion

        #region #2 Parameters Order
        static void MethodOverloading_Order(int i, string str)
        {
            Console.WriteLine("MethodOverloading with String Parameters");
        }

        static void MethodOverloading_Order(string str, int i)
        {
            Console.WriteLine("MethodOverloading with String Parameters");
        }
        #endregion

        #region #3 Object type

        static void MethodOverloading_Obj(string str, object obj)
        {
            Console.WriteLine("MethodOverloading with string, Object Parameters");
        }

        static void MethodOverloading_Obj(object obj1, object obj2)
        {
            Console.WriteLine("MethodOverloading with Object,Object Parameters");
        }


        #endregion

        #region #4 Return type

        static void MethodOverloadingReturn(int s)
        {
            Console.WriteLine("MethodOverloading with No Parameters");

        }

        static int MethodOverloadingReturn(string str)
        {
            Console.WriteLine("MethodOverloading with Object Parameters");
            return 0;

        }

        #endregion

        #region #5 Conversion Between data types

        static void MethodOverloading_Conv(int i)
        {
            Console.WriteLine("MethodOverloading with int Parameters");
        }

        static void MethodOverloading_Conv(double d)
        {
            Console.WriteLine("MethodOverloading with double Parameters");
        }

        static void MethodOverloading_Conv(double d, int i)
        {
            Console.WriteLine("MethodOverloading with double, int Parameters");
        }

        static void MethodOverloading_Conv(int i, double d)
        {
            Console.WriteLine("MethodOverloading with int,double Parameters");
        }

        static void MethodOverloading_Conv(int i1, int i2)
        {
            Console.WriteLine("MethodOverloading with int,int Parameters");
        }

        static void MethodOverloading_Conv(int i1, int i2, double dbl)
        {
            Console.WriteLine("MethodOverloading with int,int, double Parameters");
        }
        static void MethodOverloading_Conv(int i1, double i2, double dbl)
        {
            Console.WriteLine("MethodOverloading with int,double, double Parameters");
        }




        #endregion

        #region #6 Named Parameters
        static void MethodOverloading_named(int first, int second, int third)
        {
            Console.WriteLine("MethodOverloading with int,int,int Parameters");
        }

        static void MethodOverloading_named(double dFirst, double dSecond, double dThird)
        {
            Console.WriteLine("MethodOverloading with double,double,double Parameters");
        }


        #endregion

        #region #7 Optional Parameters
        static void MethodOverloading_Optional(object str)
        {
            Console.WriteLine("MethodOverloading with object Parameters");
        }

        static void MethodOverloading_Optional(string str, int x = 5)
        {
            Console.WriteLine("MethodOverloading with str, int Parameters");
        }
        #endregion

        #region #8 Out and Ref

        static void MethodOverloadingRef(decimal d, int a)
        {

            Console.WriteLine("MethodOverloading with decimal,int Parameters");
        }
        static void MethodOverloadingRef(decimal d, out int a)
        {
            a = 10;
            Console.WriteLine("MethodOverloading with decimal,out-int Parameters");
        }

        static void MethodOverloadingOut(decimal d, ref int a)
        {
            a = 10;
            Console.WriteLine("MethodOverloading with decimal,ref-int Parameters");
        }

        #endregion

        #region #9 Delegate as a Parameter
        public int MethodforFunc(string input)
        {
            return input.Length;
        }

        public string MethodforFuncDelegate()
        {
            return "Nothing passed";
        }

        public void MethodforAction(string s, int i)
        {

        }

        public bool MethodforPredicate(string s)
        {
            return true;
        }

        static void MethodOverloading(Func<string, string, int> methodName)
        {
            Console.WriteLine("SmapleMethod with Func<string, string, int> Parameters");
        }

        static void MethodOverloading(Func<string> methodName)
        {
            Console.WriteLine("SmapleMethod with Func<int>Parameters");
        }

        static void MethodOverloading(Predicate<string> methodName)
        {
            Console.WriteLine("SmapleMethod Predicate<string> Parameters");
        }

        static void MethodOverloading(Func<string, bool> methodName)
        {
            Console.WriteLine("SmapleMethod Func<string,bool> Parameters");
        }

        static void MethodOverloading(Action<string, int> methodName)
        {
            Console.WriteLine("SmapleMethod Action<string, int> Parameters");
        }
        #endregion

        #region #10 Inheritance

        #endregion

    }

    public class BaseClass
    {
        public void MethodOverloading(string str)
        {
            Console.WriteLine("From Base Class.");
        }
        public void MethodOverloading2(Object str)
        {
            Console.WriteLine("From Base Class.");
        }

        public virtual void MethodOverride(string s)
        {
            Console.WriteLine("From Base class");
        }
    }

    class DerivedClass : BaseClass
    {
        public void MethodOverloading(object obj)
        {
            Console.WriteLine("From Derived Class.");
        }
        public void MethodOverloading2(string str)
        {
            Console.WriteLine("From Derived Class.");
        }
        public override void MethodOverride(string str)
        {
            Console.WriteLine("From Derived class -- Overridden Method");
        }
    }


}


