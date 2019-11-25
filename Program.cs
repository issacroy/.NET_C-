//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assgnmnt_19_11_19
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}



using System;
namespace Assgnmnt_19_11_19
{

   public class Employee
    {
        int id;
        string name;
        double sal;
        static int idl=0;
        public Employee( string ename, double esal)
        {
            id = ++idl;
            ename = name;
            esal = sal;
        }

        public int Id
        {
            get
            { return id; }
        }
        public string ename { get; set; }
        public double esal { get; set; }
    }


   public class PerEmployee : Employee
    {
        public PerEmployee(string ename, double esal)
            : base(ename, esal)
        {
            Console.WriteLine("id= "+Id+" name= " + ename + "  salary= " + esal);
        } 

    public void calculatesal(double sal)
        {
            int canteen = 1000;
            double TDS;
            TDS = 0.1 * sal;
            sal = sal - TDS - canteen;
            Console.WriteLine("Salary After Reduction " + sal);
        }
    }


    class TempEmployee : Employee
    {
        public TempEmployee(string ename, double esal)
            : base(ename, esal)
        {
            Console.WriteLine("id= " + Id + " name= " + ename + "  salary= " + esal);
        }

      public void calculatesal(double sal)
        {
            int canteen = 1000;
            sal = sal - canteen;
            Console.WriteLine("Salary After Reduction " + sal);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            PerEmployee obj1 = new PerEmployee("ABC", 2000);
            obj1.calculatesal(2000);
            TempEmployee obj2 = new TempEmployee("edf", 5000);
            obj2.calculatesal(5000);

            Console.Read();
        }
    }
}
