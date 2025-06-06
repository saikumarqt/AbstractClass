﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
 abstract class myclass
    {
        public void Method()
        {
            Console.WriteLine("Method is calling");
        }
        public abstract void AbstractMethod();
    }
    class derivedclass:myclass
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Abstract method is calling");
        }
    }
   
    /*
     * AbstractClass: While Defining a class if we have used Abstract
     * keyword
     * which is called as AbstractClass
     * AbstractClass is a collection of Abstract members 
     * and non Abstract members
     * 
     * what is Abstract members?
     * while defining a class members if we have used abstract keyword 
     * which is called as abstract members.
     * Abstract members are empty members which  will have only 
     * declartion
     *  with in the abstract class ,we have to define or we have to 
     *  implement
     *  these abstract members with in the derived class by using override
     *  keyword
     *  
     *  What do you mean declaration and definition?
     *  ex:internal void show()//declartion
     *  {
     *  Console.WriteLine("method is calling");//definition
     *  }
     *  a field cannot be abstract
     *  we can have abstract method
     *  example to abstract method.
     *  ex:internal abstract void show();
     *  we cannot have abstract constructor
     *  Abstract class can contain constructor which is non abstract.
     *  Abstract class members access modifiers should be not private
     *  because we should implement these abstract members in derived
     *  class by using override keyword
     *  static members cannot be abstract.
     *  by default abstract member is a virtual member.
     *  A class which contains normal members or non abstract members
     *  or concerete memebrs is called as normal class or non
     *  abstact class or concrete class and it is fully implemented class.
     *  A class which contains abstract members and non abstact members is 
     called abstract class which is partially implemented class.
    Abstract class cannot be instanciated but we can create reference 
    varibale,

    I have added new line.
     */
    abstract class vehicle
    {
        internal void start()
        {
            Console.WriteLine("Vehicle has started");
        }
        internal void drive()
        {
            Console.WriteLine("vehicle has been driving");
            Console.WriteLine("Hello All");
        }
        internal abstract void park();
        internal abstract void stop();
    }

        class dc : vehicle
        {
        //implementing abstract members in derived class by using override keyword
        internal override void park()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Vehicle has been parked");
        }
        internal override void stop()
        {
            Console.WriteLine("vehicle has stopped");
        }

    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            myclass mc=new derivedclass();
            mc.Method();    
            mc.AbstractMethod();
            
            vehicle obj=new dc();
            obj.start();
            obj.drive();
            obj.park();
            obj.stop();
        }
    }
}
