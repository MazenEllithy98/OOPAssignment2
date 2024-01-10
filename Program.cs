using OOPAssignment2.Polymorphism_overriding;
using System.Diagnostics.CodeAnalysis;
using OOPAssignment2.Polymorphism_overriding;
using OOPAssignment2.Interfaces;
using System.Security.Cryptography.X509Certificates;


namespace OOPAssignment2

{
    #region Employee
    class Employee
    {
        public int ID { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }

        public void MyFun1()
        {
            Console.WriteLine("I am Employee");
        }
        public virtual void MyFun2()
        {
            Console.WriteLine($"ID : {ID} Age : {Age} Name : {Name} ");
        }


    }
    class FullTimeEmployee : Employee
    {
        public decimal Salary { get; set; }

        public new void MyFun1()
        {
            Console.WriteLine(" I am FullTime Employee");
        }

        public override void MyFun2()
        {
            Console.WriteLine($"ID : {ID} Age : {Age} Name : {Name}  Salary : {Salary}");
        }

    }
    class PartTimeEmployee : Employee
    {
        public decimal HourRate { get; set; }
        public int CountOfHours { get; set; }
        public new void MyFun1 ()
        {
            Console.WriteLine("I am Part Time Employee");
        }
        public override void MyFun2()
        {
            Console.WriteLine($"ID : {ID} Age : {Age} Name : {Name}  Count Of Hours : {CountOfHours} Hour Rate : {HourRate}");
        }
    }
#endregion
    internal class Program
    {
        #region Function Overloading


        public static int sum(int x, int y)
        {
            return x + y;
        }
        public static int sum(int x, int y, int z)
        {
            return x + y + z;
        }

        public static double sum(double x, double y)
        {
            return x + y;
        }

        public static double sum(double x, int y)
        {
            return x + y;
        }

        #endregion

        #region   Process Employee
        public static void ProcessEmployee(Employee employee)             // This is Binding
        {
            if (employee is not null)
            {
                employee.MyFun1();
                employee.MyFun2();
            }
        }

        //public static void ProcessEmployee(FullTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.MyFun1();
        //        employee.MyFun2();
        //    }
        //}

        //public static void ProcessEmployee(PartTimeEmployee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.MyFun1();
        //        employee.MyFun2();
        //    }
        //}
        #endregion

        #region Print10Numbers
        public static void Print10NumbersFromSeries(ISeries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"{series.Current}");
                    series.GetNext();

                }
                series.Reset();
            }
        }


        ////public static void Print10NumbersFromSeries(SeriesByTwo series)
        ////{
        ////    if (series is not null)
        ////    {
        ////        for (int i = 0; i < 10; i++)
        ////        {
        ////            Console.WriteLine($"{series.Current}");
        ////            series.GetNext();

        ////        }
        ////        series.Reset();
        ////    }
        ////}


        ////public static void Print10NumbersFromSeries(SeriesByThree series)
        ////{
        ////    if (series is not null)
        ////    {
        ////        for (int i = 0; i < 10; i++)
        ////        {
        ////            Console.WriteLine($"{series.Current}");
        ////            series.GetNext();

        ////        }
        ////        series.Reset();
        ////    }
        ////}
        #endregion
        static void Main(string[] args)
        {
            #region Function Overloading
            //double result = sum(1.3, 3.4);
            //Console.WriteLine($"sum = {result}");
            //result = sum(1, 2, 3);
            //Console.WriteLine($"sum = {result}");
            #endregion

            #region Polymorphism overriding

            //TypeA typeA = new TypeA(1);
            //typeA.A = 12;
            //typeA.MyFun1();
            //typeA.MyFun2();

            //TypeB typeb = new TypeB(2, 3);
            //typeb.A= 11;
            //typeb.B= 20;
            //typeb.MyFun1();
            //typeb.MyFun2();

            #endregion

            #region Binding

            //// Reference from Parent , Object from Child 

            //TypeA RefBase = new TypeB(1, 2);       
            //RefBase.A= 15;
            //RefBase.MyFun1();  // Perform MyFun1 of Type A [I am Base [Parent]]   
            //RefBase.MyFun2(); // Perform latest override => (a,b)

            //// Reference sees the parent only and as MyFun2 is Virtual , it was overridden and that's why it was performing the latest override
            //// Static Binding => override using NEW keyword - Compiler will call function of reference not object at compilation time (Early Binding)
            //// Dynamic Binding => Override using OVERRIDE keyword - CLR will call function of the object not the reference at run time  (Late Binding)


            #endregion

            #region Not Binding
            ////Car = BMW ----------> Binding

            ////BMW = (BMW) Car ----------> Not Binding (Explicit Casting) 

            ////object 01 = 3;

            ////int x = (int)01;
            //TypeA typeA = new TypeA(1);
            //typeA = new TypeB(1, 2);

            //TypeB RefChild = (TypeB)typeA;
            //RefChild.B = 12;


            #endregion


            #region another Example of Binding
            //FullTimeEmployee fullTimeEmployee = new FullTimeEmployee();

            //ProcessEmployee(fullTimeEmployee);   // NOT BINDING -> will perform only fulltime employee functions

            //PartTimeEmployee partTimeEmployee= new PartTimeEmployee();
            //ProcessEmployee(partTimeEmployee); 
            #endregion
            #region Extended examples on binding
            //TypeC typeC = new TypeC(1, 2, 3);

            //TypeA typeA = new TypeC(1, 2, 3); // TypeA is indirect parent to typeC 
            //typeA.A = 20;

            //TypeB typeB = new TypeC(1, 2, 3);
            //typeB.A = 20;
            //typeB.B = 25;   // typeB can see A and B

            //typeA.MyFun1(); // static binding => I am Base [Parent] 
            //typeA.MyFun2(); // dynamic binding => TypeC's Method but with values : A equals : 20 , B equals : 2 , C equals : 3 as typeA can't access b or c

            //typeB.MyFun1(); // static binding => I am Base [Parent] 
            //typeB.MyFun2(); // A equals : 20 , B equals : 25 , C equals : 3

            //typeC.MyFun1(); // static binding => I am Base [Parent] 
            //typeC.MyFun2(); // A equals : 1 , B equals : 2 , C equals : 3 as typeC was given these values and I didn't change any but it can access a , b , c
            #endregion

            #region Interface 1 
            //IMyType myType = new IMyType();
            //myType.MyFun();


            //MyType myType= new MyType();
            //myType.Salary= 2500;
            //myType.MyFun();



            //IMyType referenceFromInterface = new MyType();
            //referenceFromInterface.Print();
            //referenceFromInterface.MyFun();
            //referenceFromInterface.Salary = 1000;

            #endregion

            #region Interface 2
            //SeriesByTwo seriesbytwo = new SeriesByTwo();
            //Print10NumbersFromSeries(seriesbytwo);

            //SeriesByThree seriesbythree = new SeriesByThree();
            //Print10NumbersFromSeries(seriesbythree);


            //SeriesByFour seriesbyfour = new SeriesByFour();
            //Print10NumbersFromSeries(seriesbyfour);


            //int[] Numbers = { 3, 5, 4, 2, 1, 0, 8, 9 };
            //Array.Sort(Numbers);



            #endregion

        }
    }
}