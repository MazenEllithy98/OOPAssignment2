using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment2.Interfaces
{
    //Developer1
    interface IMyType
    {   /// iinterface is a code contract between the developer who wrote it aand the developer who will implement it in the future
        /// Default Access Modifier inside interface is public => unlike class and struct
        /// Private Access Modifier is not allowed to be used inside interface
        /// we can't create objects from interface , we can only do references
        /// What can we write inside interrface? 
        /// 1) Signature for property
        public int Salary { get; set; } // compiler won't generate backing field => Signature Property

        /// 2) Signature for Method
        void MyFun(); // unimplemented method

        /// 3) Default Implemented Method
        //C# 8.0 Feature => .NET CORE 3.1 (2019)
        void Print()
        {
            Console.WriteLine("Hello Default Implemented Method from Interface");
            
        }

      
    }

    //Developer 2
    class MyType : IMyType //=> implements
    {
        public int Salary { get;set;}
        public void MyFun() 
        {
            Console.WriteLine("Hello Route");
        }

    }
}
