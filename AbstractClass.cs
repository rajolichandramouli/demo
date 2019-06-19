using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewPractice
{
    class AbstractClass:A1
    {
        public static void Main()
        {
            AbstractClass obj = new AbstractClass();
            obj.Add();
            obj.AbstractMethode();
            Console.ReadLine();
            //Can not create the instance for Abstract class and Interfaces.
            //A1 obj = new A1();
            
        }
        internal override void AbstractMethode()
        {
            Console.WriteLine("Abstract Methode");
        }
    }
    abstract class A1
    {
        static A1()
        {
        }
        public void Add()
        {
            Console.WriteLine("Non-Abstract Methodes");
        }
        internal abstract void AbstractMethode();
        //{
           // Console.WriteLine("Abstract Methode");
        //}
    }
    abstract class A2
    {
        public void Add()
        {
            Console.WriteLine("Non-Abstract Methodes");
        }
        public abstract void AbstractMethode();
        //{
        // Console.WriteLine("Abstract Methode");
        //}
    }
}
