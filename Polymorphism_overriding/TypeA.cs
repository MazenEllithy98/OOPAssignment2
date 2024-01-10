using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment2.Polymorphism_overriding
{
    #region Polymorphism overriding
    internal class TypeA
    {
        public int A { get; set; }
        public TypeA(int a)
        {
            A = a;
        }
        public void MyFun1()
        {
            Console.WriteLine("I am Base [Parent]");
        }
        public virtual void MyFun2()
        {

            Console.WriteLine($"TypeA : {A}");
        }



    }

    class TypeB : TypeA
    {
        public int B { get; set; }

        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        public new void MyFun1()   // Masking => Masking old function with a new function using new keyword
        {
            Console.WriteLine("I am Child");
        }
        public override void MyFun2 ()    //// overriding using override keyword
        {
            Console.WriteLine($"A equals : {A} , B equals : {B}");
        }

    }
    #endregion

   class TypeC : TypeB
    {
        public int C { get; set; }
        public TypeC(int a , int b , int c) : base (a, b)
        {
            C = c;
        }
        public new void MyFun1()
        {
            Console.WriteLine(" I am Grand Child");
        }
        public override void MyFun2()
        {
            Console.WriteLine($"A equals : {A} , B equals : {B} , C equals : {C}");
        }
    }



}
