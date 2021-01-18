using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Singleton fromEmployee = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");

            Singleton fromStudent = Singleton.GetInstance;
            fromEmployee.PrintDetails("From Student");

            Console.WriteLine("-------------------------------");

            //Singleton.DerivedSingleton derivedObj = new Singleton.DerivedSingleton();
            //derivedObj.PrintDetails("From Derived");

            Console.ReadLine();
        }
    }
}
